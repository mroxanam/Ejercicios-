using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje31
{
     class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un numero: ");
            int numero= int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.Write (numero) ;
                Console.Write("x");
                Console.Write(i);
                Console.Write("=");
                Console.Write(numero * i);
                Console.ReadLine(); 
            }
            
        }
    }
}
