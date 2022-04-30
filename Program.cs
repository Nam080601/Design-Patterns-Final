using System;
using System.Windows.Forms;


namespace Design_Patterns_Final
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
            Application.Run(new FormMain());

        }
    }
}
