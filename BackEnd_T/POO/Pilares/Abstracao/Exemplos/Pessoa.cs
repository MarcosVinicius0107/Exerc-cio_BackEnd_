namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"Olá Marcos");
        }

        public override void Mover()
        {
            Console.WriteLine($"walk walk walk");
        }
    }
}