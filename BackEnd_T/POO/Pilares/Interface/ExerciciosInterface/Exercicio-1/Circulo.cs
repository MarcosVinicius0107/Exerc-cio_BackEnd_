namespace Exercicio_1
{
    public class Circulo : IForma
    {
    public float Raio;
    private float PI = 3.14f;

    public void Calculadora()
    {
        Console.WriteLine($"Área do Círculo: {PI * Raio * Raio}");
    }
    }
}