namespace AtividadeConcessionaria
{
    
    public class Concessionaria
    {

        List<Veiculo> Veiculos = new List<Veiculo>();

        public static void Main(string[] args)
        {
            Concessionaria concessionaria = new Concessionaria();

            Acessorio acessorio1 = new Acessorio(TipoAcessorio.TAPETE_FOFO, "Fofudo", "Fofura", 320.0);
            Acessorio acessorio2 = new Acessorio(TipoAcessorio.BANCO_COURO, "Courudo", "Couro Preto", 100.0);
            Acessorio acessorio3 = new Acessorio(TipoAcessorio.FAROL_XENON, "Luminudo", "Brilhante", 3000.0);

            Veiculo veiculo1 = new Veiculo("Jeep Compass", "Jeep", 2023, 150000.0, [acessorio1, acessorio3]);
            Veiculo veiculo2 = new Veiculo("Carrudo", "Correiro", 2001, 30000.0, [acessorio2, acessorio1]);

            concessionaria.AdicionarVeiculo(veiculo1);
            concessionaria.AdicionarVeiculo(veiculo2);

            foreach (Veiculo veiculo in concessionaria.Veiculos) 
            {
                veiculo.ToString();
                veiculo.CalcularValorTotalPrint();
                veiculo.AplicarDesconto(20.0);
                veiculo.ListarAcessorios();
            }

            concessionaria.BuscarCarroPorMarca("Vazia");
            concessionaria.BuscarCarroPorMarca("Carrudo");
            
            concessionaria.BuscarCarroPorValor(10000.0);
            concessionaria.BuscarCarroPorValor(76000.0);
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Veiculos.Add(veiculo);

            Console.WriteLine("Veículo adicionado.");
        }

        public void BuscarCarroPorMarca(string marca)
        {
            Console.WriteLine("\n== Carros por Marca ==");

            List<Veiculo> veiculosPorMarca = new List<Veiculo>();

            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.Marca.ToUpper().Equals(marca.ToUpper()))
                    veiculosPorMarca.Add(veiculo);
            }

            foreach (Veiculo veiculo in veiculosPorMarca)
            {
                veiculo.ToString();
            }

            if (veiculosPorMarca.Count() == 0) 
                Console.WriteLine("Nenhum carro encontrado.");
        }

        public void BuscarCarroPorValor(double valor)
        {
        Console.WriteLine($"\n== Carros por valor menor ou igual a R$ {valor} ==");

            List<Veiculo> veiculosPorValor = new List<Veiculo>();

            foreach (Veiculo veiculo in Veiculos)
            {
                if (veiculo.ValorBase <= valor)
                    veiculosPorValor.Add(veiculo);
            }

            foreach (Veiculo veiculo in veiculosPorValor)
            {
                veiculo.ToString();
            }

            if (veiculosPorValor.Count() == 0) 
                Console.WriteLine("Nenhum carro encontrado.");
        }

        public void ToString()
        {
            Console.WriteLine("\n== Carros Concessionária ==");
            
            foreach (Veiculo veiculo in Veiculos) 
            {
                veiculo.ToString();
            }
        }
    }
}