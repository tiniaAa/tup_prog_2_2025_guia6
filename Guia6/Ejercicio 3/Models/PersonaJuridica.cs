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
            if (VerificarCUIT() == false)
            {
                throw new FormatoCUITNoValidoExeption();
            }
            this.cuit = cuit;
            

        }
        public override string Describir()
        {
            return $"Nombre {nombre}-CUIT:{cuit}";
        }
        public bool VerificarCUIT()
        {
            //Validar que todos los digitos sean numericos 
            //que la cantidad de digitos sea 11 
            //ser validado por el verificador (un re mambo )
            
            
            bool valido = cuit.Length == 11;//que sea 11 
            int n = 0;

            while (n<11 && valido )//que sean todos numericos 
            {
                if (char.IsNumber(cuit[n])==false)
                {
                    valido = false;
                }
                n++;
            }
            int[] pesos = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int dv = 0;
            if (valido==true)
            {
                int sum = 0;
                for (int e=0 ; e<pesos.Length;e++)
                {
                    sum += (int)char.GetNumericValue(cuit[e]) *pesos[e];
                }
                int resto = sum % 11;

                //verificando el dv
                switch (resto) 
                 {
                        case 0:
                            dv = 0;
                            break;
                        case 1:
                            dv = 9;
                        break;
                        default:
                            dv =11-resto;
                        break;
                }

                valido &= dv == (int)char.GetNumericValue(cuit[10]);


            }



            return valido;


        }

    }
}
