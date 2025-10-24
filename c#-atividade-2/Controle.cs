namespace Projeto
{
    public class Controle
    {
        private Televisao Televisao;

        public Controle(Televisao televisao)
        {
            Televisao = televisao;
        }

        public string Ligar()
        {
            if (Televisao.Ligada)
            {
                Televisao.Ligada = false;
                return "TV Desligada";
            }

            Televisao.Ligada = true;
            return "TV Ligada";
        }

        public string AumentarVolume()
        {
            if (Televisao.Volume == 100)
                return "Volume máximo";

            Televisao.Volume += 10;
            return $"Volume: {Televisao.Volume}";
        }

        public string DiminuirVolume()
        {
            if (Televisao.Volume == 0)
                return "Mudo";

            Televisao.Volume -= 10;
            return $"Volume: {Televisao.Volume}";
        }

        public string AumentarCanal()
        {
            Televisao.Canal++;
            return $"Canal: {Televisao.Canal}";
        }

        public string DiminuirCanal()
        {
            if (Televisao.Canal == 1)
                return $"Canal: {Televisao.Canal}";


            Televisao.Canal--;
            return $"Canal: {Televisao.Canal}";
        }

        public string TrocarCanal()
        {
            Console.Write("\nDigite o canal: ");
            int canal;

            if (!Int32.TryParse(Console.ReadLine(), out canal))
                return "Canal inválido";


            if (canal <= 0)
                return "Canal inválido.";

            Televisao.Canal = canal;
            return $"Canal: {Televisao.Canal}";
        }
        
        public string InformacoesTv()
        {
            return Televisao.toString();
        }
    }
}
