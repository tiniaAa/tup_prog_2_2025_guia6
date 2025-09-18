using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    internal class FormatoCUITNoValidoExeption: ApplicationException
    {
       public FormatoCUITNoValidoExeption():base ("CUIT no valido ")
        {

        }
        public FormatoCUITNoValidoExeption(string message) 
        {
        
        }
        public FormatoCUITNoValidoExeption(string message, Exception inner)
        {

        }
    }
}
