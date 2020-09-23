using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosTema1
{
    class SumaInterv
    {

        /**
         * Calcula sua de los numeros entre X e Y, dados por user
         * 
         */
        public static void SumaInter()
        {

            int n, n1, suma = 0;

            do
            {

                n = Utiles.pedirNum();
                n1 = Utiles.pedirNum();

            } while (n < 0 || n1 < 0);

            if (n < n1)
            {

                for (int i = n; i <= n1; i++)
                {

                    suma += i;

                }

                Console.WriteLine("La suma de los números entre " + n + " y " + n1 + " es " + suma);

            }
            else {

                for (int i = n1; i <= n; i++)
                {

                    suma += i;

                }

                Console.WriteLine("La suma de los números entre " + n1 + " y " + n + " es " + suma);

            }

            

        }
       
    }
}
