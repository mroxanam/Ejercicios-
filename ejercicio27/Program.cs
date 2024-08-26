using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio27
{
    class Program
    {
        static void Main()
        {     //el usuario debe ingresar un numero
            Console.WriteLine("Por favor ,Ingresar un numero");
           
            double num1=Convert.ToDouble(Console.ReadLine());

            //ingresar el segundo numero
            Console.WriteLine("Ingresar el segundo numero");
           
           double num2=Convert.ToDouble(Console.ReadLine());
           double producto= num1 * num2; //es la multiplicacion 
           
            Console.WriteLine("El producto de " + num1 + "*" + num2 +" es = " +  producto);//lo que va a mostrar en consola
            
            Console.ReadLine();
        }
    }
}
