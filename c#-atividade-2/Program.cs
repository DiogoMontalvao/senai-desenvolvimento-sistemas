using System.Diagnostics;
using System.Reflection.Metadata;

namespace Projeto 
{
    public class Program 
    {
        public static void Main(String[] args)
        {
            Televisao tv = new Televisao("Topzera");
            Controle controle = new Controle(tv);

            do
            {
                ExibeMenu();

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\n" + controle.Ligar());
                        break;

                    case "2":
                        Console.WriteLine("\n" + controle.AumentarVolume());
                        break;

                    case "3":
                        Console.WriteLine("\n" + controle.DiminuirVolume());
                        break;

                    case "4":
                        Console.WriteLine("\n" + controle.AumentarCanal());
                        break;
                        
                    case "5":
                        Console.WriteLine("\n" + controle.DiminuirCanal());
                        break;

                    case "6":
                        Console.WriteLine("\n" + controle.TrocarCanal());
                        break;
                        
                    case "7":
                        Console.WriteLine("\n" + controle.InformacoesTv());
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
            Console.WriteLine("1. Ligar e Desligar");
            Console.WriteLine("2. Aumentar volume");
            Console.WriteLine("3. Diminuir volume");
            Console.WriteLine("4. Aumentar canal");
            Console.WriteLine("5. Diminuir canal");
            Console.WriteLine("6. Trocar canal");
            Console.WriteLine("7. Informações TV");
            Console.Write("Opção: ");
        }
    }       
}



