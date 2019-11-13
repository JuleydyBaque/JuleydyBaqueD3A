using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea03.Clases
{
    public class Cliente
    {
        private string apellidos;

        public string Apellidos
        {
            get {
                try
                {
                    var completo = apellidos.Split(' ');
                    string apellido1 = completo[0];
                    string apellido2 = completo[1];
                    return apellidos;
                }
                catch (Exception e)
                {
                    apellidos = ("Ingrese los apellidos del cliente:");
                }
                return apellidos;

            }

            set { apellidos = value; }
        }

        private string nombres;

        public string Nombres
        {
            get {
                try
                {
                    var completo = nombres.Split(' ');
                    string nombre1 = completo[0];
                    string nombre2 = completo[1];
                    return nombres;
                }
                catch (Exception e)
                {
                    nombres =("Ingrese los nombres del cliente:") ;
                }
                return nombres;
            }

            set { nombres = value; }
        }

        private int numeroCedula;

        public int NumeroCedula
        {
            get { return numeroCedula; }
            set { numeroCedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
