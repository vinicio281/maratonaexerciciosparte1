// Conversor de Moeda 

class Program
{
    static void Main(string[] args)
    {
      
        Console.Write("Digite a quantia em reais (R$): ");
        double valorReais = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de câmbio (ex.: 5.20): ");
        double taxaCambio = Convert.ToDouble(Console.ReadLine());

       
        double valorDolares = valorReais / taxaCambio;

        valorDolares = Math.Round(valorDolares, 2);

        Console.WriteLine($"\nR$ {valorReais:F2} equivale a US$ {valorDolares:F2} com taxa de câmbio {taxaCambio:F2}");
    }
}
