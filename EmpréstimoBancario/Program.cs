// Empréstimo Bancário 

class Program
{
    static void Main(string[] args)
    {
        
        double valorEmprestimo;
        double taxaJuros;
        int numeroParcelas;

        
        Console.Write("Digite o valor do empréstimo: ");
        valorEmprestimo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros (em decimal, ex: 0.05 para 5%): ");
        taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de parcelas: ");
        numeroParcelas = Convert.ToInt32(Console.ReadLine());

       
        double valorParcela = (valorEmprestimo * (1 + taxaJuros)) / numeroParcelas;

        Console.WriteLine($"\nO valor de cada parcela será: R$ {valorParcela:F2}");
    }
}
