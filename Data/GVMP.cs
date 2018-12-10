using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace MyVMP_Launcher.Data
{
    public static class GVMP
    {
        const string PatchURL = "http://server1.gvmp.de:5000/api/patching";
        const string LiveURL = "http://launcher.gvmp.de/live/";
		public static string UserName { get; private set; } = string.Empty;
        static WebClient Client = new WebClient();

		/// <summary>
		/// Downloads the given DLC
		/// </summary>
		/// <param name="FileName">Name of the DLC</param>
        static void Download(string FileName, string type)
        {
			switch(type)
			{
				case "dlc":
					try
					{
						Helper.Logging.Log(string.Format("Downloading DLC: {0}", FileName));
						Client.DownloadFile(string.Format("{0}{1}/dlc.rpf", LiveURL, FileName), string.Format("{0}{1}/dlc.rpf", RAGE.DLCPacks, FileName));
						Helper.Logging.Log(string.Format("Downloading of DLC: {0} finished", FileName));
					}
					catch (Exception ex)
					{
						if (Convert.ToInt32(FileName) == 0)
						{
							Helper.Logging.Log(string.Format("Fehler beim Download der Datei: {0}{1}/dlc.rpf", LiveURL, FileName), "error");
							Helper.Logging.Log(string.Format("Fehler: {0}", ex.Message), "error");
						}
						else
						{
							Helper.Logging.Log(string.Format("Could not download DLC {0}. It looks like the Updater and can be ignored... maybe...", FileName), "warning");
							try
							{
								Directory.Delete(string.Format("{0}{1}", RAGE.DLCPacks, FileName));
							}
							catch (Exception e)
							{
								Helper.Logging.Log(string.Format("Fehler: {0}", e.Message), "error");
							}
						}
					}
					break;
			}
		}

		/// <summary>
		/// Checks the MD5 hast of a file
		/// </summary>
		/// <param name="FileName">DLC Name</param>
		/// <param name="Hash">Hash to check against</param>
		/// <returns></returns>
		static bool IsLatest(string FileName, string Hash)
		{
			try
			{
				if (File.Exists(string.Format("{0}{1}/dlc.rpf", RAGE.DLCPacks, FileName)))
				{
					MD5 md5 = MD5.Create();
					FileStream stream = File.OpenRead(string.Format("{0}{1}/dlc.rpf", RAGE.DLCPacks, FileName));
					stream.Position = 0L;
					string fileHash = BitConverter.ToString(md5.ComputeHash((Stream)stream)).Replace("-", "").ToLowerInvariant();
					stream.Close();
					return fileHash == Hash;
				}
				return false;
			}
			catch (Exception ex)
			{
				Helper.Logging.Log(string.Format("Fehler beim Abgleich: {0}", ex.Message), "error");
				return false;
			}
		}

		/// <summary>
		/// Initializes GVMP resources
		/// </summary>
        public static void Init()
        {
			Helper.Logging.Log("Getting PlayerName");
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\RAGE-MP");
				UserName = (string)registryKey.GetValue("player_name");
			}
			catch (Exception ex)
			{
				Helper.Logging.Log(ex.Message);
			}
			Helper.Logging.Log("Checking DLC's");
            string json = Client.DownloadString(PatchURL);
            JObject results = JObject.Parse(json);
            foreach (var item in results)
            {
				if (!int.TryParse(item.Key, out int n))
				{
					string currentFolder = RAGE.DLCPacks + item.Key;
					Helper.Logging.Log(string.Format("Checking: {0}", item.Key));
					if (!Directory.Exists(currentFolder))
					{
						Helper.Logging.Log(string.Format("Creating: {0}", item.Key));
						Directory.CreateDirectory(currentFolder);
						Download(item.Key, "dlc");
					}
					else
					{
						if (!IsLatest(item.Key, item.Value.ToString()))
						{
							Helper.Logging.Log(string.Format("Updating: {0}", item.Key));
							Download(item.Key, "dlc");
						}
					}
				}
            }
        }
    }
}
