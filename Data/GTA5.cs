using Microsoft.Win32;

namespace MyVMP_Launcher.Data
{
    public static class GTA5
    {
        public static string Base { get; private set; }

		/// <summary>
		/// Initializes the GTA5-System
		/// </summary>
        public static void Init()
        {
            Helper.Logging.Log("Trying to find GTA5 install");
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RAGE-MP");
                Base = (string)registryKey.GetValue("game_v_path") + "\\";
                Helper.Logging.Log(string.Format("Found GTA5 install at \"{0}\"", Base));
            }
            catch (System.Exception ex)
            { 
                Helper.Logging.Log(ex.Message);
            }
        }
    }
}
