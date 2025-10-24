using System.Reflection.PortableExecutable;

namespace Atividade2
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public double VelocidadeMaxima { get; set; }
        public double VelocidadeAtual { get; set; }

        public Carro(string modelo, string cor, double velocidadeMaxima)
        {
            Modelo = modelo;
            Cor = cor;
            VelocidadeMaxima = velocidadeMaxima;

            VelocidadeAtual = 0;
        }

        public string Ligar()
        {
            return "Carro ligado";
        }

        public string Acelerar()
        {
            Console.Write("\nAcelerar: ");
            double velocidade;

            if (!Double.TryParse(Console.ReadLine(), out velocidade))
                return "Velocidade inválida";


            if (velocidade <= 0.0 || (velocidade + VelocidadeAtual) > VelocidadeMaxima)
                return "Velocidade inválida";

            VelocidadeAtual += velocidade;
            return $"Velocidade atual: {VelocidadeAtual}";
        }

        public string PassarMarcha()
        {
            if (VelocidadeAtual >= 0.0 && VelocidadeAtual <= 20.0)
                return "Marcha 1";

            if (VelocidadeAtual >= 21.0 && VelocidadeAtual <= 40.0)
                return "Marcha 2";

            if (VelocidadeAtual >= 41.0 && VelocidadeAtual <= 60.0)
                return "Marcha 3";

            if (VelocidadeAtual >= 61.0 && VelocidadeAtual <= 100.0)
                return "Marcha 4";

            if (VelocidadeAtual > 100.0)
                return "Marcha 5";

            return "";
        }

        public string toString()
        {
            return $"Modelo: {Modelo}\nCor: {Cor}\nVelocidade Máxima: {VelocidadeMaxima}\nVelocidade Atual: {VelocidadeAtual}";
        }
    }
}