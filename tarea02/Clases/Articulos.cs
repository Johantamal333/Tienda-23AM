using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace tarea02.Clases
{
    public class Articulos
    {
        public void precioart()

        {
            int art1, art2, art3, art4, art5;
            int artotal = 0;
            double desc = 10;
            int opcion;

            Console.WriteLine("ingresa precio del primer articulo");
            art1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del segundo articulo");
            art2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del tercer articulo");
            art3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del cuarto articulo");
            art4 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa precio del quinto articulo");
            art5 = int.Parse(Console.ReadLine());
            artotal = art1 + art2 + art3 + art4 + art5;
            Console.WriteLine("Pagarás un total de: " + artotal);
            if (artotal >= 5000 && artotal < 8000)
            {
                Console.WriteLine("felicidades tendrás un 10% de descuento :) ");
                Console.WriteLine("con el descuento Pagarás un total de: " + artotal / desc);

            }
            if (artotal >= 8000 && artotal < 10000)
            {
                Console.WriteLine("felicidades tienes el pago a 3 meses sin intereses ");
            }
            if (artotal >= 10000)
            {
                Console.WriteLine("puedes escoger entre 1-. 6 meses sin intereses" );
                Console.WriteLine("2 -. 12 meses sin intereses");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1: Console.WriteLine(" Excelente decición tu pago será a 6 meses sin intereses... ");
                        break;
                        case 2: Console.WriteLine(" Excelente decición tu pago será a 12 meses sin intereses... ");
                        break;
                }


            }
        }
    }
}