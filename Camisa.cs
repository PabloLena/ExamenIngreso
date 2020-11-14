using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    public class Camisa : Prenda
    {
        public bool MangaCorta { get; set; }
        public bool CuelloMao { get; set; }

        public Camisa(bool esMangaCorta, bool esCuelloMao, double precio, bool premium)
        {
            MangaCorta = esMangaCorta;
            CuelloMao = esCuelloMao;
            Precio = precio;
            Premium = premium;
        }

        public override double ModificaPrecio()
        {
            double precioFinal = this.Precio;
            double rebaja = 0;
            double aumenta = 0;
            if (MangaCorta)
            {
                rebaja = this.Precio * 0.1;
                precioFinal = precioFinal - rebaja;
            }

            if (CuelloMao)
            {
                aumenta = this.Precio * 0.03;
                precioFinal = precioFinal + aumenta;
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
