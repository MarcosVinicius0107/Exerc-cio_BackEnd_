namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome = "";
        public double N1, N2, N3;

        //Construtor com parâmetros
        public MediaAluno(double param1, double param2, double param3)
        {
            //Define os valores iniciais para as minhas propriedades
            N1 = param1;
            N2 = param2;
            N3 = param3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0;//Atribuindo um valor fixo para as 3 propriedades de uma vez
        }

        public void Media()
        {
            double media = (N1 + N2 + N3) / 3;
            Console.WriteLine($"A média do (a) {Nome} foi: {media} 👀");
        }
    }
}