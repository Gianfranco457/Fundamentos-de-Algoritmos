using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio5();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n" + nombre + ", Bienvenido al curso de Fundamentos de Algoritmo");
        }

        static void ejercicio2()
        {
            Console.WriteLine("Gianfranco\n19\nIng. Sistemas");
        }

        static void ejercicio3()
        {
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\"" + nombre + "\"");
        }
        static void ejercicio4()
        {
            int num1, num2;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1-num2));
            Console.WriteLine("La multiplicación es: " + (num1 * num2));
            Console.WriteLine("La división es: " + (num1 / num2));
            Console.WriteLine("El módulo es: " + (num1 % num2));
        }

        static void ejercicio5()
        {

        }
    }
}
