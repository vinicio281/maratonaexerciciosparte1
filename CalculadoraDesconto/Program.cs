// CalculadoraDesconto


class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite o preço original do produto: R$ ");
        double precoOriginal = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Digite a porcentagem de desconto (ex.: 10 para 10%): ");
        double descontoPercentual = Convert.ToDouble(Console.ReadLine());
        
        double valorFinal = precoOriginal - (precoOriginal * descontoPercentual / 100);

        
        Console.WriteLine($"\nPreço original: R$ {precoOriginal:F2}");
        Console.WriteLine($"Desconto: {descontoPercentual}%");
        Console.WriteLine($"Preço com desconto: R$ {valorFinal:F2}");
    }
}
