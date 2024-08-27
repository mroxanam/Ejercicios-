using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorApp
{
    public class Profesor:Persona
    {
        public override void Saludar()
        {
            Console.WriteLine("Hola, soy un profesor.");
        }
        public void Explicar()
        {
            Console.WriteLine("Estoy explicando.");
        }
    }
}
