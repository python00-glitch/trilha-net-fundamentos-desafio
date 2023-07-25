namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        // Retirei todos os private e esclui a variavel 'horas', para usar direto no método 'Remover', junto com o cálculo
        /*private*/ decimal precoInicial = 0;
        /*private*/ decimal precoPorHora = 0;

        private Dictionary<string, DateTime> veiculos = new();
             // ^ Cria um método de lista
                  // ^ Lista do tipo 'string'
                          // ^ A lista se cama 'veiculos'

        // Removi todas linhas que mostrava mensagens para pegar informações do 'precoInicial' e 'precoPorHora'
        public void Apresentar()
        {
            Console.Write("Seja bem vindo ao sistema de estacionamento!\n" + "\nDigite o preço inicial: ");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Agora digite o preço por hora: ");
            precoPorHora = Convert.ToDecimal(Console.ReadLine());
        }
        public void AdicionarVeiculo()
        {
            DateTime horaEntrada = DateTime.Now;
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("");
            Console.Write("Digite a placa do veículo para estacionar: ");
            string cliente = Console.ReadLine().ToUpper();
            veiculos.Add(cliente, horaEntrada);
            // IMPLEMENTADO!!!!
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine("PLACA:");
                Console.WriteLine(veiculo);
            }
            Console.Write("\nDigite a placa do veículo para remover: ");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine().ToUpper();
            // IMPLEMENTADO!!!!

            // Verifica se o veículo existe
            if (veiculos.ContainsKey(placa))
            {
                Console.Write($"\nDigite a quantidade de horas que o veículo permaneceu estacionado: ");
                decimal horas = 0;
                horas = Convert.ToDecimal(Console.ReadLine());
        
                decimal valorTotal = 0;
                valorTotal = precoInicial + (precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                Console.ResetColor();
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são: ");
                Console.WriteLine("");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"PLACA: ");
                    Console.WriteLine($"{veiculo}");
                }
            }
            else
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há veículos estacionados.");
                Console.ResetColor();
            }
        }
    }
}
