using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    internal class FormatoNombreNoValidoExeprion: ApplicationException
    {
        public FormatoNombreNoValidoExeprion()
        {

        }
        public FormatoNombreNoValidoExeprion(string message)
        {

        }
        public FormatoNombreNoValidoExeprion(string message, Exception inner)
        {

        }

    }
}
