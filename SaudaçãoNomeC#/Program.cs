//Saudação com Nome
class Program
{
    static void Main(string[] args)
    {
       
        string nome = "João";

       
        string saudacaoConcatenacao = "Olá, " + nome + "! Bem-vindo ao nosso site!";
        Console.WriteLine(saudacaoConcatenacao);

        string saudacaoInterpolacao = $"Olá, {nome}! Bem-vindo ao nosso site!";
        Console.WriteLine(saudacaoInterpolacao);
    }
}

