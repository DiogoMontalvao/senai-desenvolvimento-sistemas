namespace ProdutosEletronicos
{

    public interface IOperacoesProduto
    {
        
        void AdicionarProduto(Produto produto);
        void RemoverProduto(string codigo);
        Produto BuscarProdutoPorCodigo(string codigo);
        List<Produto> BuscarProdutoPorMarca(string marca);
        void AtualizarPreco(string codigo, double novoPreco);
        void ListarProdutos();
    }
}