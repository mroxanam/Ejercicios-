using System;

namespace ejercicio57
{
    class Program
    {
        static void Main()
        {
            // Pedir al usuario un número del 1 al 5
            Console.Write("Introduce un número del 1 al 5: ");

            // Verificar si la entrada es un número válido
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                // Usar switch para escribir el nombre del número
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("uno");
                        break;
                    case 2:
                        Console.WriteLine("dos");
                        break;
                    case 3:
                        Console.WriteLine("tres");
                        break;
                    case 4:
                        Console.WriteLine("cuatro");
                        break;
                    case 5:
                        Console.WriteLine("cinco");
                        break;
                    default:
                        Console.WriteLine("Número fuera de rango. Por favor, introduce un número del 1 al 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, introduce un número del 1 al 5.");
            }

            // Pausa para evitar que la consola se cierre inmediatamente
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
