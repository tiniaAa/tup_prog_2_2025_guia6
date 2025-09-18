using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class PersonaJuridica:Persona
    {
        string cuit;

        public PersonaJuridica(string nombre, string cuit):base (nombre)
        {
            this.cuit = cuit;

            if (FormatoCUITNoValidoExeption(cuit)==false) 
            { 
            
            }

        }
        public override string Describir()
        {
            return $"Nombre {nombre}-CUIT:{cuit}";
        }

    }
}
