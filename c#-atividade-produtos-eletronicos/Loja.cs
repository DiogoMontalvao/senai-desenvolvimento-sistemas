namespace ProdutosEletronicos
{
    
    public class Loja : IOperacoesProduto
    {

        public List<Produto> Produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);

            Console.WriteLine("\nProduto adicionado.");
        }

        public List<Produto> BuscarProdutoPorMarca(string marca)
        {
            List<Produto> produtosPorMarca = new List<Produto>();

            foreach (Produto produto in Produtos)
            {
                if (marca.ToUpper().Equals(produto.Marca.ToUpper()))
                    produtosPorMarca.Add(produto);
            }

            return produtosPorMarca;
        }

        public Produto BuscarProdutoPorCodigo(string codigo)
        {
            foreach (Produto produto in Produtos)
            {
                if (codigo.ToUpper().Equals(produto.Codigo.ToUpper()))
                    return produto;
            }

            throw new Exception("Produto não encontrado.");
        }

        public void RemoverProduto(string codigo)
        {
            Produto produto = BuscarProdutoPorCodigo(codigo);
            Produtos.Remove(produto);

            Console.WriteLine("\nProduto removido.");
        }

        public void AtualizarPreco(string codigo, double novoPreco)
        {
            Produto produto = BuscarProdutoPorCodigo(codigo);

            produto.Preco = novoPreco;

            Console.WriteLine($"\nPreço do produto {produto.Nome} atualizado: R$ {produto.Preco}.");
        }
        
        public void ListarProdutos()
        {
            Console.WriteLine("\n== Lista de Produtos ==");
            
            foreach (Produto produto in Produtos)
            {
                produto.ExibirDetalhes();
            }
        }
    }
}