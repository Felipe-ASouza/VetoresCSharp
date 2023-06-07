using System;
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            double media = soma / n;
            Console.WriteLine("A média da altura é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}