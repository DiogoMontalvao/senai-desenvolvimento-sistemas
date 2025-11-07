namespace ProdutosEletronicos
{
    
    public class Notebook : Produto
    {

        public double TamanhoTela { get; set; }
        public string Processador { get; set; }

        public Notebook(string codigo, string nome, string marca, double preco, double tamanhoTela, string processador)
            : base(codigo, nome, marca, preco)
        {
            TamanhoTela = tamanhoTela;
            Processador = processador;
        }

        override public void ExibirDetalhes()
        {
            Console.WriteLine("\n== Notebook ==");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Tamanho da Tela: {TamanhoTela}");
            Console.WriteLine($"Processador: {Processador}");
        }
    }
}