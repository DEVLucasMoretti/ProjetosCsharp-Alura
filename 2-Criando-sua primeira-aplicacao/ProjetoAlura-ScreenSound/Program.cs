//Screen Sound


using System.Diagnostics;

//List<string> bandList = new List<string>() { "Neffex", "Imagine Dragons" , "Coldplay"};

Dictionary<string,List<int>> registerBands = new Dictionary<string, List<int>>();
registerBands.Add("Linkin Park", new List<int> { 10,9,9});
registerBands.Add("The Beatles", new List<int>());
void WelcomeMessage()
{                            
    string welcomeMessage = @"

    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ";
    Console.WriteLine(welcomeMessage);
}

void MenuOptions()
{
    WelcomeMessage();
    Console.WriteLine(
        "Digite 1 para registrar uma banda.\n" +
        "Digite 2 para mostrar todas as bandas.\n" +
        "Digite 3 para avaliar uma banda.\n" +
        "Digite 4 para exibir a média de uma banda.\n" +
        "Digite 0 para sair.\n");
    int choose = int.Parse(Console.ReadLine());

    switch (choose)
    {
        case 0: Console.WriteLine("Volte sempre ^-^ "); break;
        case 1: BandRegister(); break;
        case 2: ShowBands(); break;
        case 3: RateBand(); break;
        case 4: ShowAverage(); break;
        default: Console.WriteLine("Opção escolhida Inválida"); break;
    }

}
void BandRegister()
{
        Console.Clear();
        ShowOptionsTilte("Registro de Bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string bandName = Console.ReadLine();
        //bandList.Add(bandName);
        registerBands.Add(bandName, new List<int>());
        Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
        Thread.Sleep(1000); // Tipo time.sleep, espera 2s, no caso 2.000 milisegundos
        Console.Clear();
        MenuOptions();

}

void ShowBands()
{
        Console.Clear();
        ShowOptionsTilte("Exibindo todas as bandas resgistradas: ");
    //foreach (string band in bandList)
        foreach (string band in registerBands.Keys)
        {
            Console.WriteLine($" -Banda: {band}");
        }
        Thread.Sleep(2000);
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear() ;
        MenuOptions();
}

void ShowOptionsTilte(string title)
{
    int quantLetters = title.Length;
    string decorations = string.Empty.PadLeft(quantLetters, '*');
    Console.WriteLine($"{decorations}\n{title}\n{decorations}\n");
}

void RateBand()
{
    //digitar a banda que deseja avaliar
    //se a banda existe no dicionário >> atribuir nota
    //voltar ao menu principal
    Console.Clear();
    ShowOptionsTilte("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: "); 
    string nameBand = Console.ReadLine();
    if (registerBands.ContainsKey(nameBand))
    {
        Console.Write($"Qual a sua avaliação para a banda {nameBand} (0-10): ");
        int rating = int.Parse(Console.ReadLine());
        registerBands[nameBand].Add(rating);
        Console.WriteLine($"\nA nota {rating} foi registrada com sucesso para a a banda {nameBand}");
        Thread.Sleep(4000);
        Console.Clear();
        MenuOptions();
    }
    else
    {
        Console.WriteLine($"A banda {nameBand} não foi encontrada");
        Thread.Sleep(2000);
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();
    }


}

void ShowAverage()
{
    Console.Clear();
    ShowOptionsTilte("Exibir a média da banda: ");
    Console.Write("Digite o nome da banda que você deseja exibir a média: ");
    string nameBand = Console.ReadLine();

    if(registerBands.ContainsKey(nameBand))
    {
        List<int> bandsRates = registerBands[nameBand];
        Console.WriteLine($"A média da banda {nameBand} é {bandsRates.Average()}.");
        Thread.Sleep(3000);
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();
    }
    else
    {
        Console.WriteLine($"A banda {nameBand} não foi encontrada");
        Thread.Sleep(2000);
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        MenuOptions();
    }

}



MenuOptions();