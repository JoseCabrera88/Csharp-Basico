using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class EntradaSalida
    {
        public static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("");
            Console.Write(" Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine(" Hola " + nombre);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
