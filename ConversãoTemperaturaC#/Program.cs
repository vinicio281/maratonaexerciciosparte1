//Conversão de Temperatura (Celsius para Fahrenheit) 

class Program
{
    static void Main(string[] args)
    {
        
        const double fatorConversao = 9.0 / 5.0;

        
        Console.Write("Digite a temperatura em Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        
        double fahrenheit = (celsius * fatorConversao) + 32;

        
        Console.WriteLine($"{celsius}°C equivale a {fahrenheit:F2}°F");
    }
}

