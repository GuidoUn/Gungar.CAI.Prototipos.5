namespace Gungar.CAI.Prototipos._5
{
    internal static class Program
    {
        private static void GuardarDatos()
        {
            AppModel.GuardarDatos();
            AlmacenVuelos.GuardarVuelos();

            // TODO: Arreglar bug que cuadriplica los hoteles
            //HotelesModel.GuardarDatos(); 
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                AppModel.CargaInicial(); //reemplazar por constructor estatico en clase de almacen
                                         //VuelosModel.CargaInicial(); //reemplazar por constructor estatico en clase de almacen
                HotelesModel.CargaInicial(); //reemplazar por constructor estatico en clase de almacen
                                             //AlmacenVuelos.LeerVuelos();
                Application.Run(new MenuPrincipalForm());
            }
            finally
            {
                GuardarDatos();
            }
        }
    }
}