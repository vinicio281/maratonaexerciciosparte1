using System;

class Program
{
    static void Main(string[] args)
    {
        string senhaCorreta = "senha123";
        int tentativas = 0;
        int maxTentativas = 3;
        bool loginSucesso = false;

        Console.WriteLine("=== Sistema de Login ===");

        while (tentativas < maxTentativas && !loginSucesso)
        {
            Console.Write("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();
            tentativas++;

            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("\nLogin bem-sucedido!");
                loginSucesso = true;
            }
            else
            {
                Console.WriteLine($"Senha incorreta! Tentativa {tentativas} de {maxTentativas}.");
            }
        }

        if (!loginSucesso)
        {
            Console.WriteLine("\nConta bloqueada por excesso de tentativas.");
        }
    }
}
