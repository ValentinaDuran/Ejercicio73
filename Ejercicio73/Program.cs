using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;

            Queue<string> colaStr = new Queue<string>();

            Console.WriteLine("ingrese una cadena de texto");
            cadena = Console.ReadLine();

            while (cadena != "")
            {
                colaStr.Enqueue(cadena);
                Console.WriteLine("ingrese una cadena de texto");
                cadena = Console.ReadLine();

            }
            while (colaStr.Count > 0)
            {
                Console.WriteLine(colaStr.Dequeue());
            }
            Console.ReadKey();

        }
    }
}
