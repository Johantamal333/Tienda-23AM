using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea02.Clases
{
    public class Cliente
    {
        string Nombre { get; set; }
        string Correo { get; set; }
        string Numero { get; set; }

        public void Imprimirdatos()
        {

            Console.WriteLine("ingresa tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu correo");
            Correo = Console.ReadLine();
            Console.WriteLine("ingresa tu numero");
            Numero = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("Bienvenido " + Nombre);
            Console.WriteLine("                                     ");
            Console.WriteLine("correo : " + Correo);
            Console.WriteLine("                                     ");
            Console.WriteLine("Numero : " + Numero);
            Console.WriteLine("*****************************************************************************************************");

            Articulos articulo = new Articulos();
            articulo.precioart();






        }
    }
}