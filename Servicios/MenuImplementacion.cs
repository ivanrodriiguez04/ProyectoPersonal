using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// 260923 -> irm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienevenida()
        {
            string mensaje = "Bienvenido a mi proyecto personal";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenu()
        {
            int opcionIntroducida;

            Console.WriteLine("0.Cerrar app");
            Console.WriteLine("1.Seleccione el dia que desea coger cita y el tipo de corte:");
            Console.WriteLine("2.Modificar la cita:");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
