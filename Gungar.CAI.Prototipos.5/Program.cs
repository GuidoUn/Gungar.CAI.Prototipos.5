using Gungar.CAI.Prototipos._5.Almacenes;

namespace Gungar.CAI.Prototipos._5
{
    internal static class Program
    {
        private static void GuardarDatos()
        {
            AlmacenVuelos.GuardarVuelos();
            AlmacenItinerarios.GuardarItinerarios();

            // TODO: Arreglar bug que cuadriplica los hoteles
            AlmacenHoteles.GuardarHoteles(); 
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
              
                Application.Run(new MenuPrincipalForm());
            }
            finally
            {
                GuardarDatos();
            }
        }
    }
}