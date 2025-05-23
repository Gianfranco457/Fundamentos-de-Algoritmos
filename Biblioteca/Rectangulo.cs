using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Rectangulo
    {
        public void area()
        {
            Console.Write("Ingrese la base: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÁrea: " + (b * h));
        }

        public void perimetro()
        {
            Console.Write("Ingrese lado 1: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lado 2: ");
            int l1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerimetro: " + (l + l + l1+ l1));
        }
    }
}
