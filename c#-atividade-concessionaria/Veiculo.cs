namespace AtividadeConcessionaria
{
    
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        private double _valorBase;
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
        public List<Acessorio> Acessorios = new List<Acessorio>();

        public Veiculo() { }

        public Veiculo(string marca, string modelo, int ano, double valorBase, List<Acessorio> acessorios)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            ValorBase = valorBase;
            Acessorios = acessorios;
        }

        public double CalcularValorTotal()
        {
            double valorTotal = ValorBase;

            foreach (Acessorio acessorio in Acessorios)
            {
                valorTotal += acessorio.Preco;
            }

            return valorTotal;
        }

        public void CalcularValorTotalPrint()
        {
            Console.WriteLine($"\nValor total: R$ {CalcularValorTotal()}");
        }

        public void AplicarDesconto(double percentual)
        {
            double valorTotal = CalcularValorTotal();
            double desconto = valorTotal * (percentual / 100);
            double totalDesconto = valorTotal - desconto;

            Console.WriteLine($"Valor com desconto de {percentual}%: R$ {totalDesconto}");
        }
        
        public void ListarAcessorios()
        {
            foreach (Acessorio acessorio in Acessorios)
            {
                acessorio.ToString();
            }
        }

        public void ToString()
        {
            Console.WriteLine("\n== Veículo ==");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"ValorBase: {ValorBase}");

            ListarAcessorios();
        }
    }
}