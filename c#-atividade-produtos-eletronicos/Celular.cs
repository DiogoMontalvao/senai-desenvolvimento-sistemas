namespace ProdutosEletronicos
{

    public class Celular : Produto
    {

        public int CapacidadeBateria { get; set; }
        public int MemoriaInterna { get; set; }

        public Celular(string codigo, string nome, string marca, double preco, int capacidadeBateria, int memoriaInterna)
            : base(codigo, nome, marca, preco)
        {
            CapacidadeBateria = capacidadeBateria;
            MemoriaInterna = memoriaInterna;
        }

        override public void ExibirDetalhes()
        {

            Console.WriteLine("\n== Celular ==");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Capacidade da Bateria: {CapacidadeBateria}");
            Console.WriteLine($"Memória Interna: {MemoriaInterna}");
        }
    }
}