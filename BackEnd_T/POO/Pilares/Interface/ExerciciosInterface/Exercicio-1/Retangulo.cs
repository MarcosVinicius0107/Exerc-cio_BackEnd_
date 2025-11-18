namespace Exercicio_1
{
    public class Retangulo : IForma
    {
    public float Largura;
    public float Altura;

    public void Calculadora()
    {
        Console.WriteLine($"Área do Retângulo: {Largura * Altura}");
    }
    }
}