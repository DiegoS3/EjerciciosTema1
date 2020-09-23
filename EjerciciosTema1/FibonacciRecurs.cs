using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosTema1
{
    class FibonacciRecurs
    {

        private static int serieFRecur(int n)
        {
            if (n == 1 || n == 0)
            {

                return n;

            }
            else
            {

                return serieFRecur(n - 1) + serieFRecur(n - 2);

            }

        }

        public static void fibonacciRecur()
        {
            int n;

            do
            {

                n = Utiles.pedirNum();

            } while (n < 0);

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Fibonnaci de " + (i+1) + " es " + serieFRecur(i));

            }

        }

    }
}
