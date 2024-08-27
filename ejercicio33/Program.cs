using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce un número entero: ");
        int numero;

        // Verificar si la entrada es un número válido
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número {0} es par.", numero);
            }
        
            else
            {
               
             Console.WriteLine("El número {0} es impar.", numero);

            }
        }    
        else      

        {

             Console.WriteLine("Entrada no válida. Por favor, introduce un número entero.");      
        }

             
        Console.ReadLine();
    } 

}
    
