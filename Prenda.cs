using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    public abstract class Prenda
    {
        public static int MangaCortaCuelloNormal = 300;
        public static int MangaCortaCuelloMao = 200;
        public static int MangaLargaCuelloNormal = 350;
        public static int MangaLargaCuelloMao = 150;

        public static int PantalonChupin = 1500;
        public static int PantalonNormal = 500;

        public bool Premium { get; set; }
        public double Precio { get; set; }

        public abstract double ModificaPrecio();     

    }
}
