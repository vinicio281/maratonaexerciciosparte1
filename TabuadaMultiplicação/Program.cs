using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tabuada do número 7:\n");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = 7 * i;
            Console.WriteLine($"7 x {i} = {resultado}");
        }
    }
}

