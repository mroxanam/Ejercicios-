using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio23
{
    class Program
    {
        static void Main()
        {
           
           Console.WriteLine("Por favor, ingresa el primer numero: " );

            int numero1 = Convert.ToInt32( Console.ReadLine() );
          
            Console.WriteLine("Por favor, ingresa el segundo numero: " ); 
             
            int numero2 = Convert.ToInt32(Console.ReadLine());
            
             int producto = numero1 * numero2;

             Console.WriteLine("El resultado de " + numero1 +  " * "  +  numero2  + " es  " +  producto  );


           Console.ReadLine() ;
            
        }
    }
}
