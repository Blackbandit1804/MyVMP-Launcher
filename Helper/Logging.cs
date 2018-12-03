using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyVMP_Launcher.Helper
{
    public static class Logging
    {
        public static void Log(string message, string type = "info")
        {
            DateTime now = DateTime.Now;
            string timestamp = now.ToString("HH:mm:ss");
            Console.ResetColor();
            switch(type)
            {
                case "info":
                    Console.WriteLine(string.Format("[INFO] [{0}] {1}", timestamp, message));
                    break;

                case "error":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(string.Format("[INFO] [{0}] {1}", timestamp, message));
                    break;

                default:
                    Console.WriteLine(string.Format("[INFO] [{0}] {1}", timestamp, message));
                    break;
            }
        }
    }
}
