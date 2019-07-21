using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmaServerSelector
{
    class SaveData
    {
        public string ModDir { get; set; }
        public string BinPath { get; set; }
        public string ProfileDir { get; set; }
        public string ConfPath { get; set; }
        public string Args { get; set; }
        public int[] Enabled { get; set; }

        public SaveData(string modDir, string binPath, string profileDir, string confPath, string args, int[] enabled)
        {
            ModDir = modDir;
            BinPath = binPath;
            ProfileDir = profileDir;
            ConfPath = confPath;
            Args = args;
            Enabled = enabled;
        }
    }
    static class Saving
    {
        public static void SaveToFile(SaveData save, string path)
        {
            File.WriteAllText(@path, JsonConvert.SerializeObject(save));
        }

        public static SaveData ReadFromFile(string path)
        {
            return JsonConvert.DeserializeObject<SaveData>(File.ReadAllText(@path));
        }
    }
}
