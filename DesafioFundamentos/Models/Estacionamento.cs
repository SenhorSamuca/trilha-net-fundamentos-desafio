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
            // I M P L E M E N T A D O ! ! !
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // I M P L E M E N T A D O ! ! !
            string placa = Console.ReadLine();
                        
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // I M P L E M E N T A D O ! ! !
                int horas = 0;
                decimal valorTotal = 0;

                horas += Convert.ToInt32(Console.ReadLine());
                valorTotal = (precoInicial + precoPorHora) * horas;
                
                // TODO: Remover a placa digitada da lista de veículos
                // I M P L E M E N T A D O ! ! !
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                // I M P L E M E N T A D O ! ! !
                for(int contadorVeiculos = 0; contadorVeiculos < veiculos.Count; contadorVeiculos++){
                    Console.WriteLine($"Veículo: {contadorVeiculos + 1} | Placa: {veiculos[contadorVeiculos]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
