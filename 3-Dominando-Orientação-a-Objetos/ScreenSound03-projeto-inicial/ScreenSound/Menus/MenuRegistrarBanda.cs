using OpenAI_API;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI_API;

namespace ScreenSound.Menus
{
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new Banda(nomeDaBanda);

            var client = new OpenAIAPI("ChaveDAAPI"); //chave API
            var chat = client.Chat.CreateConversation(); //cria uma nova conversa
            chat.AppendSystemMessage($"Resuma a banda {banda.Nome} em 1 parágrafo. Adote um modelo  informal"); //manda  o comando
            string resposta =  chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult(); //captura a reposta do ChatGPT
            Console.WriteLine(resposta); //Armazena a reposta em uma variável
            banda.Resumo = resposta;
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
