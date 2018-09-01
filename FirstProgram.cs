using System;

namespace OlaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo");
            Console.ReadKey(true);

            // Declarando variaveis
            String nome = "";
            Char caractere = ' ';
            int numerointeiro = 0;
            bool logica = true;
            float realsimples = 0.0f;
            Double real = 0.0;
            Decimal valormonetario = 0.0M;

            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Seu nome é {0}", nome);
            Console.WriteLine("Seu nome é " + nome);

            Console.WriteLine("Digite um número  inteiro: ");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número  inteiro: ");
            int valor2 = Int32.Parse(Console.ReadLine());
            int soma = valor1 + valor2;

            Console.ReadKey(true);
        }
    }
}
