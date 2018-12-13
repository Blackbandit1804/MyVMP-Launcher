using Microsoft.Win32;
using System;
using System.IO;

namespace MyVMP_Launcher.Data
{
    class RAGE
    {
        public static string Base { get; private set; }
        public static string ClientResources { get; private set; }
        public static string DLCPacks { get; private set; }

		/// <summary>
		/// Initializes the RAGE:MP-System
		/// </summary>
        public static void Init()
        {
            Helper.Logging.Log("Trying to find RAGE:MP install");
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RAGE-MP");
                Base = (string)registryKey.GetValue("rage_path") + "\\";
                ClientResources = Base + @"client_resources\145.239.149.95_22005\";
                DLCPacks = Base + @"client_resources\145.239.149.95_22005\dlcpacks\";
                Helper.Logging.Log(string.Format("Found RAGE:MP install at \"{0}\"", Base));
                if (!Directory.Exists(ClientResources))
                    Directory.CreateDirectory(ClientResources);
            }
            catch (Exception ex)
            {
                Helper.Logging.Log(ex.Message);
            }
        }

		internal static void SetNewBasePath(string path)
		{
			Helper.Logging.Log("Trying to set RAGE install folder ");
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RAGE-MP", true);
				registryKey.SetValue("rage_path", path, RegistryValueKind.String);
				Base = string.Format("{0}\\", path);
				Helper.Logging.Log(string.Format("Successfully changed RAGE install folder to \"{0}\"", Base));
			}
			catch (Exception ex)
			{
				Helper.Logging.Log(ex.Message, "error");
			}
		}
	}
}
