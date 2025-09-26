using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public  class Persona:IComparable
    {
        protected string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                Match match = Regex.Match(value, @"^\s*(?<apellido>[\p{L}\s]{2,}?),\s*(?<nombres>[\p{L}\s]{2,})\s*$");
                if (match.Success == false)
                {
                    throw new FormatoNombreNoValidoExeprion();
                }
                nombre = value;
            }
        }

        public Persona (string nombre)
        {
            

            this.Nombre = nombre;

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
