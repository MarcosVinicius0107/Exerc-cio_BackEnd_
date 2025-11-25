namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        // Operações Matemáticas Simples
        // Vsibilidade tipoDeRetorno Nome(parâmetro){corpo}
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        // Criar as outras 3 operações
        //não se esqueça que não existe divisão 
        //por zero. então na divisão faça a
        //validação.

        public static float Subtracao(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicacao(float a, float b)
        {
            return a * b;
        }

        public static float Divisao(float a, float b)
        {
            if (b == 0)
            {
                Console.WriteLine($"Não é permitido fazer divisão por zero!");
                return 0;
            }
            return a / b;
        }

    }
}