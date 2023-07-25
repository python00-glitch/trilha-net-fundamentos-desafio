using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Clear();

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new();

// Removi todas linhas que mostrava mensagens para pegar informações do 'precoInicial' e 'precoPorHora', e fiz um método na classe
es.Apresentar();

bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
    Console.Write("Digite a sua opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            es.AdicionarVeiculo();
            Console.ResetColor();
            break;

        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            es.RemoverVeiculo();
            Console.ResetColor();
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.Green;
            es.ListarVeiculos();
            Console.ResetColor();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Opção inválida");
            Console.ResetColor();
            break;
    }

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ResetColor();
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
