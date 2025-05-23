using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Trapecio
    {
        public void area()
        {
            Console.Write("Ingrese la base1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la base2: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÁrea: " + ((b1 + b2) / 2)*h);
        }

        public void perimetro()
        {
            Console.Write("Ingrese la base1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la base2: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese lado 1: ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int l2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerimetro: " + (b1 + b2 +l1 +l2));
        }
    }
}
