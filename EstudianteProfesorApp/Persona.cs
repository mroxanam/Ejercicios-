using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudianteProfesorApp
{
    public class Persona
    {
        public int edad;
        public virtual void Saludar() 
        {
            Console.WriteLine("Hola, soy una persona.");
        
        }
       public void SetEdad(int edad)
       {
         
           this.edad = edad;


       }
        public int GetEdad() 
        {

            return edad;
        }

    }
 }    