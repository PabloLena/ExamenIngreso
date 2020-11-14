using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngreso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Cotizador Expres--");
            String linea;
            int contador = 1;
            bool salida = true;

            Direccion direccion = new Direccion();
            direccion.Calle = "Aristides";
            direccion.Numeracion = 123;
            Tienda tienda = new Tienda();
            tienda.Nombre = "Nike";
            tienda.direccion = direccion;
            Vendedor vendedor = new Vendedor(1, "Carla", "Bruno");
            vendedor.cotizaciones = new List<Cotizacion>();

            Console.WriteLine($"Nombre tienda: {tienda.Nombre}" );
            Console.WriteLine($"Direccion tienda, Calle: {tienda.direccion.Calle} - Numeracion: {tienda.direccion.Calle}");


            while (salida)
            {
                bool premium = true;
                Console.WriteLine("Para prenda premium ingrese true, si no ingrese false ");
                linea = Console.ReadLine();
                try
                {
                    premium = Convert.ToBoolean(linea);

                }
                catch (Exception)
                {
                    Console.WriteLine(" Dato mal ingresado ");
                    continue;
                }

                Prenda prenda1;
                Console.WriteLine("Para camisa ingrese 0, para pantalon ingrese 1");
                linea = Console.ReadLine();

                if (linea == "0" )
                {
                    
                    Console.WriteLine("Para manga corta ingrese true, Para manga larga ingrese false ");
                    linea = Console.ReadLine();
                    bool mangaCorta = true;
                    try
                    {
                        mangaCorta = Convert.ToBoolean(linea);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" Dato mal ingresado ");
                        continue;
                    }

                    Console.WriteLine("Para cuello Mao ingrese true, Para cuelloMao normal ingrese false ");
                    linea = Console.ReadLine();
                    bool cuelloMao = true;
                    try
                    {
                        cuelloMao = Convert.ToBoolean(linea);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" Dato mal ingresado ");
                        continue;
                    }

                    Console.WriteLine($"Precio de camisa: {50} ");
                    prenda1 = new Camisa(mangaCorta, cuelloMao, 50, premium);                    
                }
                else if (linea == "1")
                {

                    Console.WriteLine("Para chupin ingrese true, si no ingrese false ");
                    linea = Console.ReadLine();
                    bool chupin = true;
                    try
                    {
                        chupin = Convert.ToBoolean(linea);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" Dato mal ingresado ");
                        continue;
                    }
                    Console.WriteLine($"Precio de pantalon: {100} ");
                    prenda1 = new Pantalon(chupin, 100, premium);               
                }
                else
                {
                    Console.WriteLine(" Dato mal ingresado ");
                    continue;
                }

                Console.WriteLine("Ingrese cantidad");
                linea = Console.ReadLine();
                int cant = Convert.ToInt32(linea);
                Cotizacion cotizacion1 = new Cotizacion(contador, vendedor.Id, DateTime.Now, prenda1, cant);

                cotizacion1.realizaCotizacion();

                if (cotizacion1.ResultadoCotiazacion != 0)
                {
                    Console.WriteLine($"Cotizacion: {cotizacion1.ResultadoCotiazacion} \n Prenda: {prenda1.GetType().Name}  "); 
                    vendedor.cotizaciones.Add(cotizacion1);
                    contador++;
                }
                else
                {
                    Console.WriteLine("La cotizacion no se pudo realizar.");
                }

                Console.WriteLine(" Continuar y/n ");
                linea = Console.ReadLine();
                if (linea == "n")
                {
                    salida = false;
                }
            }

            Console.WriteLine($"-- Historial cotizaciones vendedor {vendedor.Nombre} -- ");
            foreach (var cotizacionesVendedor in vendedor.cotizaciones)
            {
                Console.WriteLine($"Id: {cotizacionesVendedor.Id}");
                Console.WriteLine($"Fecha: {cotizacionesVendedor.FechaHora }");
                Console.WriteLine($"Prenda: {cotizacionesVendedor.prenda.GetType().Name }");
                Console.WriteLine($"Cantidad: { cotizacionesVendedor.Cantidad }");
                Console.WriteLine($"Cotizacion:  { cotizacionesVendedor.ResultadoCotiazacion }");        

            }

            Console.ReadLine();
        }
    }
}
