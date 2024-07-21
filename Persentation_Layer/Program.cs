using A_Persentation_Layer;
using A_Persentation_Layer.Frm.Frm_Dialog;

namespace Persentation_Layer
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
            Application.Run(new Main());
            // test 
            //ok
            //1

        }
    }
}