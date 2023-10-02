using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra un mensaje de bienvenida
        /// 260923 -> irm
        /// </summary>
        public void mensajeBienevenida();

        /// <summary>
        /// Metodo que te muestra las firerentes opciones del menu
        /// 260923 -> irm
        /// </summary>
        public int mostrarMenu();
    }
}
