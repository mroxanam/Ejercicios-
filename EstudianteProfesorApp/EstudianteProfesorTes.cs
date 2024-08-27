using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorApp
{
    public class EstudianteProfesorTes
    {
        static void Main()
        { 
          Persona persona = new Persona();
            persona.Saludar();
        
          Estudiante estudiante = new Estudiante(); 
            estudiante.Saludar();
            estudiante.SetEdad(20);
           
            estudiante.VerEdad();
            estudiante.Estudiar();

            Profesor profesor = new Profesor();
            profesor.Saludar();
            profesor.SetEdad(40);
            
            profesor.Explicar();

            while (true)
            {
                Console.WriteLine("¿A quién quieres preguntar?");
                Console.WriteLine("1. Estudiante");
                Console.WriteLine("2. Profesor");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción (1, 2, 3): ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        estudiante.Saludar();
                        estudiante.VerEdad();
                        estudiante.Estudiar();
                        break;

                    case "2":
                        profesor.Saludar();
                        profesor.Explicar();
                        break;

                    case "3":
                        Console.WriteLine("Saliendo...");
                        return; // Sale del programa

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }

                Console.WriteLine(); // Para dar un espacio entre interacciones

                      Console.WriteLine("Presiona Enter para salir...");
                      Console.ReadLine();

            }




           
        
        }
        

    }
}
