using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombres = "Gianfranco Peña"; 
            //Obtenemos la longitud de la cadena
            int longitud =nombres.Length;
            Console.WriteLine($"Longitud:{longitud}");

            int pos = nombres.IndexOf("A");
            Console.WriteLine($"Posición:{pos}");

            String nombreMayus=nombres.ToUpper();
            Console.WriteLine($"Mayusculas:{nombreMayus}");
            
            String nombreMinus=nombres.ToLower();
            Console.WriteLine($"Minisculas:{nombreMinus}");

            string nombre1 = nombres.Substring(11);
            Console.WriteLine($"Nombres:{nombre1}");

            //Extrae una subcadena (6 caracter) desde la posicion 0
            string nombre2=nombres.Substring(0,10);
            Console.WriteLine($"Nombres:{nombre2}");

            int pos1 = nombres.IndexOf("C", 1);
            Console.WriteLine($"Posicion 2:{pos1}");

            //

            //Extraemos 1 caracter esfecificado su posicion
            Console.WriteLine($"Caracter:{nombres[6]}");

            //Obtenemos un
            //
            string estudiante = "Rosa Maria Cueva Merino";//Resultado-RMCM
            String letra1, letra2, letra3, letra4;
            letra1 = estudiante[0].ToString();
            letra2= estudiante[estudiante.IndexOf(" ")+1].ToString();
            letra3 = estudiante[estudiante.IndexOf(" ", estudiante.IndexOf(" ") + 1) + 1].ToString();
            letra4 = estudiante[estudiante.LastIndexOf(" ") + 1].ToString();

            Console.WriteLine($"Resultado:{letra1}{letra2}{letra3}");
        }
    }
}
