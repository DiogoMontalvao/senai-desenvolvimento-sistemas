namespace AtividadeComputadores
{

    public class LojaInformatica
    {
        
        public static void Main(string[] args)
        {
            Periferico periferico1 = new Periferico(TipoPeriferico.Mouse, "Topzera", "Metal", 20.0);
            Periferico periferico2 = new Periferico(TipoPeriferico.Teclado, "Topzera", "Metal", 60.0);
            Periferico periferico3 = new Periferico(TipoPeriferico.Monitor, "Topzera", "Plástico", 600.0);

            Computador computador1 = new Computador("Topzera", "123", "Intudo", 2000.0, [periferico1, periferico3]);
            Computador computador2 = new Computador("Topzudo", "1234", "Amudo", 1800.0, [periferico2]);

            computador1.ToString();
            computador1.CalcularValorTotalPrint();
            computador1.AplicarDesconto(20.0);
            computador1.ListarPerifericos();

            Console.WriteLine("\n------------------------------");

            computador2.ToString();
            computador2.CalcularValorTotalPrint();
            computador2.AplicarDesconto(30.0);
            computador2.ListarPerifericos();
        }
    }
}