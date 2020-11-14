using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Cotizacion> cotizaciones { get; set; }

        public Tienda tienda { get; set; }

        public Vendedor(int id, string nombre, string apellido) {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
