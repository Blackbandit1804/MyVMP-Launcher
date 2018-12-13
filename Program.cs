using System;
using System.Windows.Forms;

namespace MyVMP_Launcher
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Title = "MyVMP-Debug (Nicht schließen)";
            Helper.Logging.Log("Application start initiated");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Helper.Logging.Log("Application start finished");
            Application.Run(new MainWindow());
        }
    }
}
