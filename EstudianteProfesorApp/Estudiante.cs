using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorApp
{
    public class Estudiante : Persona
    {
    
        public override void Saludar()
        {
            Console.WriteLine("Hola, soy un estudiante.");
        }
        public void Estudiar() 
        {
            Console.WriteLine("Estoy estudiando.");
        }
        public void VerEdad() 
        {
            Console.WriteLine($"Mi edad es : {GetEdad()} años.");

        }
    }

}
