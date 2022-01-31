using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexFileSorter
{
    internal static class Configuration
    {
        private const string CurrentF = "Current.json", ConfigsF = "Configs.json";

        static Configuration()
        {
            Current = new();
            Configs = new() { { "C1", new() }, { "C2", new() }, { "C3", new() } };
        }

        public static Config Current { get; set; }
        public static Dictionary<string, Config> Configs { get; set; }

        public static void LoadJSON()
        {
            if (File.Exists(CurrentF)) { Current = JsonConvert.DeserializeObject<Config>(File.ReadAllText(CurrentF)); }
            if (File.Exists(ConfigsF)) { Configs = JsonConvert.DeserializeObject<Dictionary<string, Config>>(File.ReadAllText(ConfigsF)); }
        }

        public static void SaveJSON()
        {
            File.WriteAllText(CurrentF, JsonConvert.SerializeObject(Current));
            File.WriteAllText(ConfigsF, JsonConvert.SerializeObject(Configs));
        }

        public static void Delete(string name) => Configs.Remove(name);

        public static void SaveAs(string name) => Configs.Add(name, new Config(Current));

        public static void SetConfig(string name) => Current = new Config(Configs[name]);
    }
}