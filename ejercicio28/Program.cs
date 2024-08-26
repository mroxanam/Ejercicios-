using System;
// roxana
//26/08/2024

namespace ejercicio28
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingresar el numero = dividendo");
            double dividendo = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("ingresar el segundo numero divisor");
            
            double divisor =Convert.ToDouble(Console.ReadLine());
            double cociente = dividendo / divisor;
            double resto = dividendo % divisor;
           
            Console.WriteLine("El cociente de la división es: " + cociente);

            Console.WriteLine("El resto de la división es: " + resto);

            Console.ReadLine();
        }
    }
}
