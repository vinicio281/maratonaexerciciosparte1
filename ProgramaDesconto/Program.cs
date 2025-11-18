using System;
//Programa de desconto
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Digite o valor total da compra: R$ ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());


        if (valorCompra > 200)
        {
            double valorComDesconto = valorCompra - (valorCompra * 0.10);
            Console.WriteLine("\nDesconto de 10% aplicado!");
            Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
            Console.WriteLine($"Valor com desconto: R$ {valorComDesconto:F2}");
        }
        else
        {
            Console.WriteLine("\nAdicione mais itens ao carrinho para ganhar um desconto de 10%.");
            Console.WriteLine($"Valor atual: R$ {valorCompra:F2}");
        }
    }
}
