using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public  class Persona:IComparable
    {
        protected string nombre;
        public string Nombre;

        public Persona (string nombre)
        {
            this.nombre = nombre;
        }
        public virtual string Describir()
        {
            return $"{nombre}";
        }
        
        public int CompareTo(Object obj)
        {
            Persona persona = obj as Persona; 
            if (persona != null)
            {
                return persona.nombre.CompareTo(nombre);
            }
            return -1;

        }

    }
}
