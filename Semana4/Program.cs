using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio3();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            int n1;

            Console.Write("Ingrese un numero enetero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("\nEl numero es par");
            }
            else
            {
                Console.WriteLine("\nEl numero es impar");
            }
        }

        static void ejercicio2()
        {
            int edad;

            Console.Write("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad <0)
            {
                Console.WriteLine("\nEdad invalida");
            }
            else if (edad < 18)
            {
                Console.WriteLine("\nEs menor de edad");
            }
            else
            {
                Console.WriteLine("'nEs mayor de edad");
            }
        }

        static void ejercicio3()
        {

        }
    }
}
