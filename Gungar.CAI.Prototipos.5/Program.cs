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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AppModel.CargaInicial();
            VuelosModel.CargaInicial();
            Application.Run(new MenuPrincipalForm());
            AppModel.GuardarDatos();
            VuelosModel.GuardarDatos();
        }
    }
}