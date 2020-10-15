using System;

namespace Exercicios1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region RESULTADO DE A + B = 40

            int a = 10, b = 30;
            int soma = a + b;

            Console.WriteLine("A soma de a + b é igual a: " + soma);

            #endregion

            Console.WriteLine(" ");

            #region RESULTADO DE A + B = -20

            int c = -30;
            int d = 10;
            int subtracao = c + d;

            Console.WriteLine("O resultado final de -30 + 10 é igual a: " + subtracao);

            #endregion

            Console.WriteLine(" ");

            #region RESULTADO DE E + F = 0

            int e = 0, f = 0;
            int resultado = e + f;

            Console.WriteLine("O resultado entre E e F é igual a: " + resultado);

            #endregion
        }
    }
}
