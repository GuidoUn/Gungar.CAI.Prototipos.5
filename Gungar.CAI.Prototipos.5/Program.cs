namespace Gungar.CAI.Prototipos._5
{
    internal static class Program
    {
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
                VuelosModel.CargaInicial(); //reemplazar por constructor estatico en clase de almacen
                HotelesModel.CargaInicial(); //reemplazar por constructor estatico en clase de almacen
                Application.Run(new MenuPrincipalForm());

            }
            finally
            {
                AppModel.GuardarDatos();
                VuelosModel.GuardarDatos();
                HotelesModel.GuardarDatos();
            }
        }
    }
}