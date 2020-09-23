using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosTema1
{
    class CifrasNum        
    {

        /**
         * 
         * pedir numero entero de max 5 cifras y calcular cifras
         * 
         */


        public static void calcularCifras()
        {

            int n, cont = 1, resto = 10;

            do
            {

                n = Utiles.pedirNum();

            } while (n < 0 || n > 99999);

            while(resto <= n)
            {

                resto *= 10;
                cont++;

            }

            Console.WriteLine("El numero " + n + " tiene " + cont + " cifras");

        }
        

    }
}
