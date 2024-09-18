using System;

namespace Teste
{
    public class program
    {
        static void Main(string[] args)
        {
            Teste2();
        }

        static void Teste()
        {
            Console.WriteLine("Digite um número:");
            var numero = int.Parse(Console.ReadLine());

            if (IsFibonacci(numero))
            {
                Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
            }

            static bool IsFibonacci(int n)
            {
                if (n < 0) return false;

                var a = 0;
                var b = 1;

                while (a < n)
                {
                    var temp = a;
                    a = b;
                    b = temp + b;
                }

                return a == n || n == 0;
            }
        }

        static void Teste2()
        {
            Console.WriteLine("Digite uma frase:");
            var texto = Console.ReadLine();

            var quantidade = EncontrarLetraA(texto);

            if (quantidade > 0)
            {
                Console.WriteLine($"A letra 'a' maiúscula ou minúscula aparece {quantidade} vezes na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' maiúscula ou minúscula não aparece na string.");
            }


            static int EncontrarLetraA(string texto)
            {
                var quantidade = 0;

                foreach (var c in texto)
                {
                    if (c == 'a' || c == 'A')
                    {
                        quantidade++;
                    }
                }

                return quantidade;
            }
        }

        static void Teste3()
        {
            var indice = 12;
            var soma = 0;
            var k = 1;

            while (k < indice)
            {
                soma = soma + k;
                k = k + 1;
            }

            Console.WriteLine(soma);
        }

        static void Teste4()
        {
            // Sequência A
            int[] A = { 1, 3, 5, 7 };
            var numero = A[A.Length - 1] + 2;
            Console.WriteLine("O Proximo numero é: " + numero);

            // Sequência B
            int[] seqB = { 2, 4, 8, 16, 32, 64 };
            var numeroB = seqB[seqB.Length - 1] * 2;
            Console.WriteLine("O Proximo numero é: " + numeroB);

            // Sequência C
            int[] seqC = { 0, 1, 4, 9, 16, 25, 36 };
            var numeroC = (int)Math.Pow(Math.Sqrt(seqC[seqC.Length - 1]) + 1, 2);
            Console.WriteLine("O Proximo numero é: " + numeroC);

            // Sequência D
            int[] D = { 4, 16, 36, 64 };
            var numeroD = (int)Math.Pow(Math.Sqrt(D[D.Length - 1]) + 2, 2);
            Console.WriteLine("O Proximo numero é: " + numeroD);

            // Sequência E
            int[] e = { 1, 1, 2, 3, 5, 8 };
            var numeroE = e[e.Length - 1] + e[e.Length - 2];
            Console.WriteLine("O Proximo numero é: " + numeroE);

            // Sequência F
            int[] f = { 2, 10, 12, 16, 17, 18, 19 };
            var numeroF = f[f.Length - 1] + 1;
            Console.WriteLine("O Proximo numero é: " + numeroF);
        }

    }
}