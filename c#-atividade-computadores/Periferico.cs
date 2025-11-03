namespace AtividadeComputadores
{

    public class Periferico
    {

        public TipoPeriferico Tipo { get; set; }
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

        public Periferico() { }

        public Periferico(TipoPeriferico tipo, string marca, string material, double preco)
        {
            Tipo = tipo;
            Marca = marca;
            Material = material;
            Preco = preco;
        }



        public void ToString()
        {
            Console.WriteLine("\n== Periférico ==");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Material: {Material}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}