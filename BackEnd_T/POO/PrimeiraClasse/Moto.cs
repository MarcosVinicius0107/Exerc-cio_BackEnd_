namespace PrimeiraClasse
{
    public class Moto
    {
        //propridades
        public int qtdRodas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //métodos
        public void Acelerar()
        {
            Console.WriteLine($"vrumm vrum tu tu tu tu tu tu");
        }

        public void Frear()
        {
            Console.WriteLine($"Moto Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Vrum Vrum ...");
        }
        public void Desligar()
        {
            Console.WriteLine($"Moto Desligando");
        }

    }
}