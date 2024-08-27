using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario tres números
        Console.Write("Introduce el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Introduce el tercer número: ");
        int numero3 = int.Parse(Console.ReadLine());

        // Comparar los tres números para encontrar el mayor
        int mayor;

        if (numero1 >= numero2 && numero1 >= numero3)
        {
            mayor = numero1;
        }
        else if (numero2 >= numero1 && numero2 >= numero3)
        {
            mayor = numero2;
        }
        else
        {
            mayor = numero3;
        }

        // Mostrar el mayor de los tres números
        Console.WriteLine("El mayor de los tres números es: " + mayor);
        Console.ReadLine();
    } 
}

