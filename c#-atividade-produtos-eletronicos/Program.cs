namespace ProdutosEletronicos
{
    
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Loja loja = new Loja();

            Celular celular1 = new Celular("codigo1", "Nome1", "Marca1", 789.0, 5000, 128);
            Celular celular2 = new Celular("codigo2", "Nome2", "Marca2", 987.0, 5000, 256);

            Notebook notebook1 = new Notebook("codigo3", "Nome3", "Marca1", 1234.0, 15.1, "Rapidão");

            loja.AdicionarProduto(celular1);
            loja.AdicionarProduto(celular2);
            loja.AdicionarProduto(notebook1);

            loja.ListarProdutos();

            Console.WriteLine("\n== Por Código ==");
            loja.BuscarProdutoPorCodigo("codigo2").ExibirDetalhes();

            Console.WriteLine("\n== Por Marca ==");
            foreach (Produto produto in loja.BuscarProdutoPorMarca("Marca1"))
            {                
                produto.ExibirDetalhes();
            }

            loja.AtualizarPreco("codigo1", 12345);
            loja.BuscarProdutoPorCodigo("codigo1").ExibirDetalhes();

            loja.RemoverProduto("codigo2");
            loja.ListarProdutos();
        }
    }
}