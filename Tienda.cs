using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    public class Tienda
    {
        public string Nombre { get; set; }

        public Direccion direccion { get; set; }

        public List<Prenda> prendas { get; set; }

    }
}
