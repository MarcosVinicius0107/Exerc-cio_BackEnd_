namespace TheBasics
{
    public class Avião : Veiculo
    {
        public string Compainha;
        public int QtdTurbinas;
        public int QtdAssentos;
        public void Decolar()
        {
            Console.WriteLine($"vrooooom");
        }
        public void Pousar()
        {
            Console.WriteLine($"Vônnn-vônnn-vônnn... shhhhh... toc!");
        }

    }
}