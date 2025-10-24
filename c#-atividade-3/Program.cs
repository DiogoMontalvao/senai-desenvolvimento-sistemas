using System.Diagnostics;
using System.Reflection.Metadata;

namespace Atividade2 
{
    public class Program 
    {
        public static void Main(String[] args)
        {
            Carro carro = new Carro("Grande", "Preto", 240.0);

            do
            {
                ExibeMenu();

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n" + carro.Ligar());
                        break;

                    case "2":
                        Console.WriteLine("\n" + carro.Acelerar());
                        break;

                    case "3":
                        Console.WriteLine("\n" + carro.PassarMarcha());
                        break;
                        
                    case "4":
                        Console.WriteLine("\n" + carro.toString());
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            } while (true);
        } 
        
        private static void ExibeMenu()
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1. Ligar");
            Console.WriteLine("2. Acelerar");
            Console.WriteLine("3. Passar marcha");
            Console.WriteLine("4. Informações do carro");
            Console.Write("Opção: ");
        }
    }       
}



