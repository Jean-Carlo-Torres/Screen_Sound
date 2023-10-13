// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
// List<string> listaDasBandas = new List<string> { "Pink Floyd", "Pearl Jam", "Nirvana" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Pink Floyd", new List<int> { 10, 8, 9 });
bandasRegistradas.Add("Pearl Jam", new List<int> { 9, 10, 4, 7 });
bandasRegistradas.Add("Nirvana", new List<int>());


void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░

");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirAMediaDeUmaBanda();
            break;
        case 5:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das banda");
    Console.Write("Insira o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista das bandas registradas");
    // for (int i = 0; i < listaDasBandas.Count; i++){
    //     Console.WriteLine($"Banda: {listaDasBandas[i]}");
    // }
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '=');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliação de uma banda");
    Console.Write("Insira o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"Digite uma nota de 1 a 10 para a banda {nomeDaBanda}!");
        Console.Write("Nota: ");
        int nota = int.Parse(Console.ReadLine()!);
        if (nota > 10 || nota < 1)
        {
            Console.WriteLine("Nota inválida!");
            Thread.Sleep(2000);
            Console.Clear();
            AvaliarUmaBanda();
        }
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"Avaliação da banda {nomeDaBanda} finalizada!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirAMediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibição da média de uma banda");
    Console.Write("Insira o nome da banda que deseja ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        try
        {
            double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
            Console.WriteLine($"A média da banda {nomeDaBanda} é {mediaDaBanda}");
        }
        catch
        {
            Console.WriteLine($"A banda {nomeDaBanda} não tem nenhuma avaliação");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirLogo();
ExibirOpcoesDoMenu();