﻿using System;
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

        public Numero(string elNumero, int laBase)
        {
            // instancie una validacion del numero
            Numero elResultado;
            var validacionBase = new Dominio.Validaciones.ValidarBase();
            var validacionNumero = new Dominio.Validaciones.ValidarNumero();
            if (validacionBase.LaBaseEstaEnElIntervaloCorrecto(laBase) &
                validacionNumero.ElNumeroEsValidoEnLaBase(elNumero, laBase))
            {
                
                this.laBase = laBase;
                this.elNumero = elNumero;

            }
            else
            {                
            }                
        }

        public Numero()
        {
        }
    }
}
