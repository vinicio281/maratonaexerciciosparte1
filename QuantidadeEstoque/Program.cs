using System;

//Verificação de estoque
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Digite a quantidade do produto em estoque: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        if (quantidade < 5)
        {
            Console.WriteLine("Alerta: Baixo estoque. Por favor, reabasteça este produto.");
        }
        else
        {
            Console.WriteLine("Estoque suficiente.");
        }
    }
}