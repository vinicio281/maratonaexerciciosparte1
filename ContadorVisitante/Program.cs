using System;

class Program
{
    static void Main(string[] args)
    {
        int capacidadeMaxima = 50;
        int visitantes = 0;

        Console.WriteLine("Simulação de entrada de visitantes no museu:");
        Console.WriteLine($"Capacidade máxima: {capacidadeMaxima} pessoas\n");

        
        while (visitantes < capacidadeMaxima)
        {
            visitantes++; 
            Console.WriteLine($"Visitante {visitantes} entrou. Total no museu: {visitantes}");
        }

        Console.WriteLine("\nCapacidade máxima atingida! Não é possível adicionar mais visitantes.");
    }
}
