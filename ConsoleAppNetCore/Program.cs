using System;
using System.Diagnostics;

namespace ConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            
            int numero = 0, quantidadeDePrimosEncontrados = 0, quantidadeDePrimos;

            Console.WriteLine("Digite a quantidade de primos que o sistema deve buscar: ");
            quantidadeDePrimos = Convert.ToInt32(Console.ReadLine());
            stopwatch.Start();
            while (quantidadeDePrimosEncontrados != quantidadeDePrimos)
            {
                if (EhPrimo(numero))
                    quantidadeDePrimosEncontrados++;
                numero++;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine("FIM");
            Console.ReadKey();
        }
        static bool EhPrimo(int numero)
        {
            int divisor;
            bool ehPrimo;

            if (ehPar(numero))
                ehPrimo = false;
            else
                ehPrimo = true;

            divisor = 3;
            while (ehPrimo && divisor <= numero / 2)
            {
                if (numero % divisor == 0)
                    ehPrimo = false;
                divisor = divisor + 2;
            }

            if (ehPrimo)
                return true;
            else
                return false;
        }

        static bool ehPar(int numero) => (numero <= 1 || (numero != 2 && numero % 2 == 0));
    }
}
