using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero
{
    public class Numero
    {
        public String elNumero { get; set; } //  una propiedad para el numero y una propiedad para la base 
        public int laBase { get; set; }

        public bool esBaseDiez { get {
                return laBase == 10 ; }
        }

        public double elNumeroEnDecimal { get {
                return double.Parse(elNumero); } }

    }
}
