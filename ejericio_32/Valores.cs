using System;
using System.Collections.Generic;

namespace ejericio_32
{
    public class Valores
    {
        //PROPIEDADES
        const int ValorCredito = 125000;
        double total = 0, extra = 0, descuento = 0, descuento_ttl = 0;
        int subsidio = 0;
        public double descuentos(Estudiantes estudiantes)
        {
            switch (estudiantes.Estrato)
            {
                case 1:
                    descuento = 0.80;
                    break;
                case 2:
                    descuento = 0.50;
                    break;
                case 3:
                    descuento = 0.30;
                    break;
                default:
                    descuento = 0.0;
                    break;
            }
            descuento_ttl = descuento;
            return descuento_ttl;
        }
        //CREDITOS
        public double creditos(Estudiantes estudiantes)
        { 
            if (estudiantes.Creditos <= 20)
            {
                total = (estudiantes.Creditos * ValorCredito) - descuento_ttl;
            }
            else
            {
                extra = estudiantes.Creditos - 20;
                total = (ValorCredito * 20) + (extra * ValorCredito * 2) - descuento_ttl;
            }
            total -= total * descuento_ttl;
            return   total;
        }
        //SUBSIDIO
        public int subsidios(Estudiantes estudiantes) 
        {
            if (estudiantes.Estrato == 1)
            {
                subsidio = 200000;       
            }
            else if (estudiantes.Estrato == 2)
            {
                subsidio = 100000;
            }
            else { subsidio = 0; }
            return subsidio;
        }
        
    }

}
