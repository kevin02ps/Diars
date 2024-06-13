using InversionesHermanos;

namespace ProyectoDiars
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
            //Metodo para abrir formularios
            Login form = new Login();
            form.Show();
            Application.Run();

        }
    }
}