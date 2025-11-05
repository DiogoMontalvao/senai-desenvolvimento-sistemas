namespace AtividadeConcessionaria
{
    
    public class Acessorio
    {
        public TipoAcessorio Tipo { get; set; }
        public string Marca { get; set; }
        public string Material { get; set; }
        private double _preco;
        public double Preco
        {
            get
            {
                return _preco;
            }

            set
            {
                if (value < 0)
                    throw new Exception("Preço inválido.");

                _preco = value;
            }
        }

        public Acessorio() {}

        public Acessorio(TipoAcessorio tipo, string marca, string material, double preco)
        {
            Tipo = tipo;
            Marca = marca;
            Material = material;
            Preco = preco;
        }

        public void ToString()
        {
            Console.WriteLine("\n== Acessório ==");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}