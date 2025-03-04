namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
           
            string adicionarVeiculos = Console.ReadLine();
           
             
             if (veiculos.Contains(adicionarVeiculos))
             {
                Console.WriteLine($"A placa do veículo {adicionarVeiculos.ToUpper()} já existe. Cadastre outra placa!\n");
             }

             else
             {
                veiculos.Add(adicionarVeiculos.ToUpper());
                Console.WriteLine("Véículo cadastrado!\n");
             }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para ser retirado:");

           
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                 
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
    
                int horas = int.Parse(Console.ReadLine());
                
                decimal valorTotal = precoInicial + precoPorHora * horas; 
                Console.WriteLine($"O valor total a pagar é: {valorTotal:C}.");
                // TODO: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);
                
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo de placa {placa.ToUpper()} foi retirado e o preço total foi de: R$ {valorTotal:C}.");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item.ToUpper() + " E está estacionandos há: " + DateTime.Now);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
