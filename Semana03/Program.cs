using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Semana03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio7();
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
            double bas, alt, area;

            Console.Write("Ingrese la base: ");
            bas = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura: ");
            alt = double.Parse(Console.ReadLine());

            area = (bas * alt)/2;

            Console.WriteLine($"El Área es : {area}");
            Console.ReadKey();  
        }

        static void ejercicio6()
        {
            double n1, n2, n3, promedio;
            
            Console.Write("Escriba el primer numero decimal: ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Escriba el segundo numero decimal: ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Escriba el tercer numero decimal: ");
            n3 = double.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("Promedio: " + promedio.ToString("F2"));
            Console.ReadKey();
        }

        static void ejercicio7()
        {
            double radio, area;

            Console.Write("Ingrese el radio del circulo: ");
            radio = double.Parse(Console.ReadLine());

            area = 3.14 * (radio * radio);

            Console.WriteLine("El área del cículo es: " + area + " m2 ");
        }
    }
}
