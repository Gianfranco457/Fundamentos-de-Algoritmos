using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static string[,] productos = new string[100, 3]; // 0: Nombre, 1: Precio, 2: Stock
        static int contador = 0;
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n====== MENÚ DE PRODUCTOS ======");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Mostrar productos");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Registrar();
                        break;
                    case 2:
                        Mostrar();
                        break;
                    case 3:
                        Modificar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intenta de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }

        static void Registrar()
        {
            if (contador < 100)
            {
                string[] campos = { "nombre", "precio", "stock" };
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Ingrese el {campos[i]} del producto: ");
                    productos[contador, i] = Console.ReadLine();
                }

                contador++;
                Console.WriteLine("Producto registrado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pueden registrar más productos.");
            }
        }

        static void Mostrar()
        {
            Console.WriteLine("\n==== LISTA DE PRODUCTOS ====");

            if (contador == 0)
            {
                Console.WriteLine("No hay productos registrados.");
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.Write($"[{i}] ");
                    for (int j = 0; j < 3; j++)
                    {
                        string etiqueta = j == 0 ? "Nombre" : j == 1 ? "Precio" : "Stock";
                        Console.Write($"{etiqueta}: {productos[i, j]}  ");
                    }
                    Console.WriteLine(); // Salto de línea al final de cada producto
                }
            }
        }

        static void Modificar()
        {
            Console.Write("Ingrese el índice del producto que desea modificar: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < contador)
            {
                string[] campos = { "nombre", "precio", "stock" };
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Nuevo {campos[i]}: ");
                    productos[indice, i] = Console.ReadLine();
                }

                Console.WriteLine("Producto modificado correctamente.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
    }
}
