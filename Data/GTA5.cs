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
                Helper.Logging.Log(ex.Message, "error");
            }
        }

		public static void SetNewBasePath(string path)
		{
			Helper.Logging.Log("Trying to set GTA5 install folder ");
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RAGE-MP", true);
				registryKey.SetValue("game_v_path", path, RegistryValueKind.String);
				Base = string.Format("{0}\\", path);
				Helper.Logging.Log(string.Format("Successfully changed GTA5 install folder to \"{0}\"", Base));
			}
			catch (System.Exception ex)
			{
				Helper.Logging.Log(ex.Message, "error");
			}
		}
    }
}
