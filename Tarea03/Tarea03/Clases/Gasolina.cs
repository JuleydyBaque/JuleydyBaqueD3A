using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03.Clases
{
    public class Gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cantidadGalones;

        public int CantidadGalones
        {
            get { return cantidadGalones; }
            set { cantidadGalones = value; }
        }

        private double precioVenta;

        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        private double subtotal;

        public double Subtotal
        {
            get {
                subtotal = CantidadGalones * PrecioVenta;
                return subtotal; }
         //   set { subtotal = value; }
        }

        private double iva;

        public double IVA
        {
            get {
                iva = (Subtotal * 12) / 100;
                return iva; }
           // set { iva = value; }
        }

        private double totalPagar;

        public double TotalPagar
        {
            get {
                totalPagar = Subtotal + IVA;
                return totalPagar; }
           // set { totalPagar = value; }
        }



    }
}

