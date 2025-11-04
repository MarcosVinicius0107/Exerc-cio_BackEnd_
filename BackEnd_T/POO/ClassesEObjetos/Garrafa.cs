namespace ClassesEObjetos
{
    public class Garrafa
    {
        //propridades
        public double capacidade;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //métodos
        public void Abrir()
        {
            Console.WriteLine($"clack (garrafa abrindo)");
        }

        public void Fechar()
        {
            Console.WriteLine($"Click (garrafa fechando)");
        }

        public void Encher()
        {
            Console.WriteLine($"Glu glu glu (garrafa enchendo)");
        }
        public void Esvaziar()
        {
            Console.WriteLine($"gluglu (garrafa esvaziando)");
        }
    }
}