using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Número {i}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            soma += numero; // acumula na soma
        }

        
        double media = soma / 10.0;

        Console.WriteLine($"\nA média dos números digitados é: {media:F2}");
    }
}

