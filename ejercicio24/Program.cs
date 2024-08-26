

   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio24
{
  class Program
  {
    static void Main()
    {
       
        Console.Write("Introduce el primer número (dividendo): ");
        int dividendo = Convert.ToInt32(Console.ReadLine());

       
        Console.Write("Introduce el segundo número (divisor): ");
        int divisor = Convert.ToInt32(Console.ReadLine());

            int cociente = dividendo / divisor;
            int resto = dividendo % divisor;

            Console.WriteLine("El cociente de la división es: " + cociente);
           
            Console.WriteLine("El resto de la división es: " + resto);
        
                Console.ReadLine();
        
    }
  }
}
