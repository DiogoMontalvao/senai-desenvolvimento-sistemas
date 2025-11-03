using System.Runtime.InteropServices;

namespace AtividadeComputadores
{

    public class Computador
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Processador { get; set; }
        public double _valorBase;
        public double ValorBase
        {
            get
            {
                return _valorBase;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Valor inválido.");

                _valorBase = value;
            }
        }
        public List<Periferico> Perifericos = new List<Periferico>();

        public Computador() { }

        public Computador(string marca, string modelo, string processador, double valorBase, List<Periferico> perifericos)
        {
            Marca = marca;
            Modelo = modelo;
            Processador = processador;
            ValorBase = valorBase;
            Perifericos = perifericos;
        }

        public void CalcularValorTotalPrint()
        {
            Console.WriteLine($"\nValor total: R$ {CalcularValorTotal()}");
        }

        public Double CalcularValorTotal()
        {
            double total = ValorBase;

            foreach (Periferico periferico in Perifericos)
            {
                total += periferico.Preco;
            }

            return total;
        }

        public void AplicarDesconto(double percentual)
        {
            double valorTotal = CalcularValorTotal();
            double desconto = valorTotal * (percentual / 100);
            double totalDesconto = valorTotal - desconto;

            Console.WriteLine($"Valor com desconto de {percentual}%: R$ {totalDesconto}");
        }

        public void ListarPerifericos()
        {
            foreach (Periferico periferico in Perifericos)
            {
                periferico.ToString();
            }
        }

        public void ToString()
        {
            Console.WriteLine("\n== Computador ==");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Processador: {Processador}");
            Console.WriteLine($"ValorBase: {ValorBase}");

            foreach (Periferico periferico in Perifericos)
            {
                periferico.ToString();
            }
        }
    }
}