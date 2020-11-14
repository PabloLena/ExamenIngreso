using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    public class Pantalon : Prenda
    {
        public bool Chupin { get; set; }

        public Pantalon(bool esChupin, double precio, bool premium) {
            Chupin = esChupin;
            Precio = precio;
            Premium = premium;
        }

        public override double ModificaPrecio()
        {
            double precioFinal = this.Precio;
            double rebaja = 0;
            double aumenta = 0;
            if (Chupin)
            {
                rebaja = precioFinal * 0.12;
                precioFinal = precioFinal - rebaja;
            }
            if (Premium)
            {
                aumenta = this.Precio * 0.3;
                precioFinal = precioFinal + aumenta;
            }
            this.Precio = precioFinal;
            return precioFinal;
        }
    }
}
