namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 99;
        public int VolumeMaximo = 100;

        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
            NivelVolume++;
            Console.WriteLine($"Nível atual do volume: {NivelVolume}");
            }
            else
            {
                Console.WriteLine($"O volume já atingiu o nível máximo: {NivelVolume}");
            }
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando atv...");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                Console.WriteLine($"O volume já está no mínimo {NivelVolume}");
            }
            else
            {
                NivelVolume--;
                Console.WriteLine($"Volume atual: {NivelVolume}");
            }
        }

        public void Ligar()
        {
                Console.WriteLine($"Ligando a tv... ");
        }
    }
}