using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EjerciciosTema1
{
    class Utiles
    {
        public static int pedirNum()
        {
            bool valido;
            int num;

            do
            {

                Console.Write("Introduce un número ");
                valido = int.TryParse(Console.ReadLine(), out num);

                if (!valido)
                {

                    Console.WriteLine("Número no valido");

                }


            } while (!valido);


            return num;

        }

        public static void menu()
        {
            int op;
            bool salir = false;

            do
            {

                Console.WriteLine("-----------MENU-----------");
                Console.WriteLine("1.- Restar");
                Console.WriteLine("2.- Cifras");
                Console.WriteLine("3.- Suma Intervalos");
                Console.WriteLine("4.- Fibonacci");
                Console.WriteLine("5.- Salir");

                op = Utiles.pedirNum();

                switch (op)
                {

                    case 1:

                        Console.WriteLine("-----------VAMOS A REALIZAR UNA RESTA-----------");
                        Resta.restar();
                        break;

                    case 2:

                        Console.WriteLine("-----------VAMOS A CONTAR CIFRAS-----------");
                        CifrasNum.calcularCifras();
                        break;

                    case 3:

                        Console.WriteLine("-----------VAMOS SUMAR NÚMEROS-----------");
                        SumaInterv.SumaInter();
                        break;

                    case 4:

                        Console.WriteLine("-----------FIBONACCI RECURSIVO-----------");
                        FibonacciRecurs.fibonacciRecur();
                        break;

                    case 5:

                        Console.WriteLine("-----------SALIENDO DEL PROGRAMA-----------");
                        salir = true;
                        break;

                    default:

                        Console.WriteLine("-----------ELIJE UNA OPCIÓN CORRECTA-----------");
                        break;
                }

                Thread.Sleep(1500);
                Console.Clear();

            } while (!salir);
        }

    }
}
