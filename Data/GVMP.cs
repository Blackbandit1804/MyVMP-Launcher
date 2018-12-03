using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;

namespace MyVMP_Launcher.Data
{
    public static class GVMP
    {
        const string PatchURL = "http://server1.gvmp.de:5000/api/patching";
        const string LiveURL = "http://launcher.gvmp.de/live/";
        static WebClient Client = new WebClient();

		/// <summary>
		/// Downloads the given DLC
		/// </summary>
		/// <param name="FileName">Name of the DLC</param>
        static void Download(string FileName)
        {
            Helper.Logging.Log(string.Format("Downloading DLC: {0}", FileName));
            Client.DownloadFile(string.Format("{0}{1}/dlc.rpf", LiveURL, FileName), string.Format("{0}{1}/dlc.rpf", RAGE.DLCPacks, FileName));
            Helper.Logging.Log(string.Format("Downloading of DLC: {0} finished", FileName));
        }

		/// <summary>
		/// Checks the MD5 hast of a file
		/// </summary>
		/// <param name="FileName">DLC Name</param>
		/// <param name="Hash">Hash to check against</param>
		/// <returns></returns>
		static bool IsLatest(string FileName, string Hash)
		{
			MD5 md5 = MD5.Create();
			FileStream stream = File.OpenRead(string.Format("{0}{1}/dlc.rpf", RAGE.DLCPacks, FileName));
			stream.Position = 0L;
			string fileHash = BitConverter.ToString(md5.ComputeHash((Stream)stream)).Replace("-", "").ToLowerInvariant();
			stream.Close();
			return fileHash == Hash;
		}

		/// <summary>
		/// Initializes GVMP resources
		/// </summary>
        public static void Init()
        {
            Helper.Logging.Log("Checking DLC's");
            string json = Client.DownloadString(PatchURL);
            JObject results = JObject.Parse(json);
            foreach (var item in results)
            {
                string currentFolder = RAGE.DLCPacks + item.Key;
                Helper.Logging.Log(string.Format("Checking: {0}", item.Key));
                if (!Directory.Exists(currentFolder))
                {
                    Helper.Logging.Log(string.Format("Creating: {0}", item.Key));
                    Directory.CreateDirectory(currentFolder);
                    Download(item.Key);
                }
				else
				{
					if(!IsLatest(item.Key, item.Value.ToString()))
					{
						Helper.Logging.Log(string.Format("Updating: {0}", item.Key));
						Download(item.Key);
					}
				}
            }
        }
    }
}
