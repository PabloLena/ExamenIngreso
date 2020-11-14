using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public DateTime FechaHora { get; set; }
        public Prenda prenda { get; set; }
        public int Cantidad { get; set; }

        public double ResultadoCotiazacion { get; set; }

        public Cotizacion(int id, int vendedorId, DateTime fechaHora, Prenda prenda, int cantidad) {
            Id = id;
            VendedorId = vendedorId;
            FechaHora = fechaHora;
            this.prenda = prenda;
            Cantidad = cantidad;
            //Resultado = realizaCotizacion();
        }

        public void realizaCotizacion() {        

            this.prenda.Precio = this.prenda.Precio * this.Cantidad;

            ArrayList arrayList = new ArrayList();
            arrayList.Add(this.prenda);

            foreach (var p in arrayList)
            {
                Type type = p.GetType();
                switch (type.Name)
                {
                    case "Camisa":

                        Camisa camisa1 = (Camisa)p;

                        if (camisa1.CuelloMao && camisa1.MangaCorta)
                        {
                            if (Cantidad > Prenda.MangaCortaCuelloMao)
                            {
                                Console.WriteLine($"La cantidad ingresada no puede ser mayor al stock: {Prenda.MangaCortaCuelloMao}");
                                return;
                            }
                            else
                            {
                                Prenda.MangaCortaCuelloMao = Prenda.MangaCortaCuelloMao - Cantidad;
                            }
                        }

                        if (camisa1.CuelloMao && !camisa1.MangaCorta )
                        {
                            if (Cantidad > Prenda.MangaLargaCuelloMao)
                            {
                                Console.WriteLine($"la cantidad ingresada no puede ser mayor al stock{ Prenda.MangaLargaCuelloMao }");
                                return;
                            }
                            else
                            {
                                Prenda.MangaLargaCuelloMao = Prenda.MangaLargaCuelloMao - Cantidad;
                            }
                        }

                        if (!camisa1.CuelloMao && !camisa1.MangaCorta)
                        {
                            if (Cantidad > Prenda.MangaLargaCuelloNormal)
                            {
                                Console.WriteLine($"la cantidad ingresada no puede ser mayor al stock: {Prenda.MangaLargaCuelloNormal}");
                                return;
                            }
                            else
                            {
                                Prenda.MangaLargaCuelloNormal = Prenda.MangaLargaCuelloMao - Cantidad;
                            }
                        }

                        if (!camisa1.CuelloMao && camisa1.MangaCorta)
                        {
                            if (Cantidad > Prenda.MangaCortaCuelloNormal)
                            {
                                Console.WriteLine($"la cantidad ingresada no puede ser mayor al stock: {Prenda.MangaCortaCuelloNormal}");
                                return;
                            }
                            else
                            {
                                Prenda.MangaCortaCuelloNormal = Prenda.MangaCortaCuelloNormal - Cantidad;
                            }
                        }
                        this.ResultadoCotiazacion= camisa1.ModificaPrecio();
                        break;

                    case "Pantalon":
                        Pantalon pantalon1 = (Pantalon)p;


                        if (pantalon1.Chupin)
                        {
                            if (Cantidad > Prenda.PantalonChupin)
                            {
                                Console.WriteLine($"la cantidad ingresada no puede ser mayor al stock: {Prenda.PantalonChupin}");
                                return;
                            }
                            else
                            {
                                Prenda.PantalonChupin = Prenda.PantalonChupin - Cantidad;
                            }
                        }

                        if (!pantalon1.Chupin)
                        {
                            if (Cantidad > Prenda.PantalonNormal)
                            {
                                Console.WriteLine($"la cantidad ingresada no puede ser mayor al stock: {Prenda.PantalonNormal}");
                                return;
                            }
                            else
                            {
                                Prenda.PantalonNormal = Prenda.PantalonNormal - Cantidad;
                            }
                        }

                        ResultadoCotiazacion = pantalon1.ModificaPrecio();
                        break;

                    default:
                        break;
                }
            }         
        }

    }
}
