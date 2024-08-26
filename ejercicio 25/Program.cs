using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int numero1=Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Ingrese el segundo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Ingrese el tercer numero");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            
            int suma =numero1 + numero2 + numero3;
            
            Console.WriteLine("El Resultado de sumar  " + numero1 + "+" + numero2 + "+" + numero3 + "  es  : "  + suma);
            Console.ReadLine();
        }
    }
}
