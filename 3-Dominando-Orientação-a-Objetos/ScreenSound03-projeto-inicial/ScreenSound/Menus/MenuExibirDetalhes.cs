﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;

internal class MenuExibirDetalhes : Menu
{


    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        //base é para chamar o método, no caso o executar que está lá  na Classe Menu, e sobreescrever esse método
        base.Executar(bandasRegistradas);
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[(nomeDaBanda)];
            Console.WriteLine(banda.Resumo);
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia:");
            foreach(Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
    
        }
    }
}
