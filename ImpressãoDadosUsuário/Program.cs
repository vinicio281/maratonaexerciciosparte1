//Impressão de Dados do Usuário 

class Program
{
    static void Main(string[] args)
    {
        // Solicita os dados ao usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite sua cidade: ");
        string cidade = Console.ReadLine();

       
        string mensagemConcatenacao = "Meu nome é " + nome + ", tenho " + idade + " anos e moro em " + cidade + ".";
        Console.WriteLine("\nUsando concatenação:");
        Console.WriteLine(mensagemConcatenacao);

      
        string mensagemInterpolacao = $"Meu nome é {nome}, tenho {idade} anos e moro em {cidade}.";
        Console.WriteLine("\nUsando interpolação:");
        Console.WriteLine(mensagemInterpolacao);
    }
}
