namespace ProdutosEletronicos
{

    public abstract class Produto
    {

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
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

        public Produto(string codigo, string nome, string marca, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Marca = marca;
            Preco = preco;
        }

        public abstract void ExibirDetalhes();

        override public string ToString()
        {
            return $"\nCódigo: {Codigo}\nNome: {Nome}\nMarca: {Marca}\nPreço: {Preco}";
        }
    }
}