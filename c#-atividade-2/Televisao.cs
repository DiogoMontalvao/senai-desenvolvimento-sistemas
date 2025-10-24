namespace Projeto
{
    public class Televisao
    {
        public string Marca { get; set; }

        public int Volume { get; set; }
        public int Canal { get; set; }

        public bool Ligada { get; set; }

        public Televisao(string marca)
        {
            Marca = marca;

            Volume = 20;
            Canal = 1;

            Ligada = false;
        }

        public string toString()
        {
            if (!Ligada)
                return "TV desligada";

            return $"Marca: {Marca}\nVolume: {Volume}\nCanal: {Canal}";
        }
    }
}

