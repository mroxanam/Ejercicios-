using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saludo
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Por favor, ingresa tu nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola, " + nombre + "!");
            Console.ReadLine();

        }
    }
}
