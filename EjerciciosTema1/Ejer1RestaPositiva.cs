using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosTema1
{
    class Resta
    {
        /**
         * Pedir dos numeros enteros y calcular la resta de forma que siempre
         * devuelva valor positivo
         */

        public static void restar()
        {

            int n = Utiles.pedirNum();
            int n1 = Utiles.pedirNum();

            if (n > n1)
            {

                Console.WriteLine(n + " - " + n1 + " = " + (n - n1));

            }
            else
            {
                Console.WriteLine(n1 + " - " + n + " = " + (n1 - n));

            }

        }
        

    }

    
}
