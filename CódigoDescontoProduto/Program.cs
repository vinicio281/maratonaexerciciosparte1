using System;

//Solicita o preço do produto
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite o preço do produto: R$ ");
        double preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o código de desconto (1, 2 ou 3): ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        double desconto = 0;

        switch (codigo)
        {
            case 1:
                desconto = 0.10;
                break;
            case 2:
                desconto = 0.20;
                break;
            case 3:
                desconto = 0.30;
                break;
            default:
                Console.WriteLine("Código inválido! Nenhum desconto aplicado.");
                return;
        }

        double precoFinal = preco - (preco * desconto);

        Console.WriteLine($"\nCódigo {codigo}: Desconto de {desconto * 100}% aplicado!");
        Console.WriteLine($"Preço original: R$ {preco:F2}");
        Console.WriteLine($"Preço com desconto: R$ {precoFinal:F2}");
    }
}
