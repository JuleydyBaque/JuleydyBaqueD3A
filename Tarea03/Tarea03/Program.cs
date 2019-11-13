using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea03.Clases;

namespace Tarea03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Ingrese los Apellidos del cliente");
            cliente.Apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese los Nombres del cliente");
            cliente.Nombres = Console.ReadLine();
            Console.WriteLine("Ingrese el número de cédula del cliente");
            cliente.NumeroCedula = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la dirección del cliente  ");
            cliente.Direccion = Console.ReadLine();


            Gasolina gasolina = new Gasolina();


            Program.Gasolina();
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    gasolina.Tipo = "Extra";
                    gasolina.PrecioVenta = 1.50;
                    break;
                case 2:
                    gasolina.Tipo = "Super";
                    gasolina.PrecioVenta = 2.00;
                    break;
                default:
                    Console.WriteLine("Disculpa las molestias pero no contamos con ese tipo :(");
                    break;
            }

          //  Console.WriteLine("Ingrese el tipo de gasolina que solicita");
          // gasolina.Tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de galones que solicita");
            gasolina.CantidadGalones = int.Parse(Console.ReadLine());

           
            Console.WriteLine("-------------------------------B I E N V E N I D O--------------------------------------");
            Console.WriteLine("***********************************FACTURA***********************************************");
            Console.Write("Nombres: {0}", cliente.Nombres);
            Console.Write("\t\t\t Apellidos: {0}", cliente.Apellidos);
            Console.WriteLine();
            Console.WriteLine("N° Cédula: {0}", cliente.NumeroCedula);
            Console.WriteLine("Dirección: {0}", cliente.Direccion);
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Tipo \t\t\t Cantidad De Galones \t\t\t Precio De Venta");
            Console.Write(gasolina.Tipo + "\t\t\t\t");
            Console.Write(gasolina.CantidadGalones + "\t\t\t\t\t");
            Console.WriteLine(gasolina.PrecioVenta);
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("\t\t\t\t\t\t\t Subtotal: {0}", gasolina.CantidadGalones * gasolina.PrecioVenta);
            Console.WriteLine("\t\t\t\t\t\t\t IVA: {0}", gasolina.IVA);
            Console.WriteLine("\t\t\t\t\t\t\t Total: {0}", gasolina.TotalPagar);

            Console.ReadKey();
        }

        static void Gasolina()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Elegir el tipo de gasolina que desea comprar");
            Console.WriteLine("1.- Extra __________________________ $1.50");
            Console.WriteLine("2.- Super __________________________ $2.00");
            Console.WriteLine("*******************************************************");

            


        }
    }
}
