using ProyectoPersonal.Servicios;

namespace ProyectoPersonal.Controladores 
{   
    /// <summary>
    /// Clase principal de la aplicacion
    /// 260923 -> irm
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Metodo de entrada en la aplicacion
        /// 260923 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            MenuInterfaz menuInt = new MenuImplementacion();

            menuInt.mensajeBienevenida();
            //Variable que controla el flujo del menu
            bool cerrarMenu = false;
            //guardar la opcion del usuario
            int opcionSeleccionada;
            //iniciamos el bucle
            while (!cerrarMenu) 
            {
                opcionSeleccionada = menuInt.mostrarMenu();
                switch (opcionSeleccionada) 
                {
                    case 0:
                        cerrarMenu = true; 
                        break;
                    case 1:
                        Console.WriteLine("Ha seleccionado la opcion 1");
                        break;
                    case 2:
                        Console.WriteLine("ha selccionado la opcion 2");
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}