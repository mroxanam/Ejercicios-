using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otros_ejercicios_de_c_
{

    class Program
    {
        static void Main()
        {
            Console.Write("Introduce un número: ");

            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
               Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);

            }    Console.ReadLine();
        }
    }    
    

}
