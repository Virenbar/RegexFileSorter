using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace RegexFileSorter
{
    internal static class Configuration
    {
        private const string CurrentF = "Current.json", ConfigsF = "Configs.json";

        static Configuration()
        {
            Current = new();
            Configs = new() { { "Default", new() } };
        }

        public static Dictionary<string, Config> Configs { get; set; }
        public static Config Current { get; set; }

        public static bool Contains(string name) => Configs.ContainsKey(name);

        public static void Delete(string name) => Configs.Remove(name);

        public static void LoadJSON()
        {
            if (File.Exists(CurrentF)) { Current = JsonConvert.DeserializeObject<Config>(File.ReadAllText(CurrentF)); }
            if (File.Exists(ConfigsF)) { Configs = JsonConvert.DeserializeObject<Dictionary<string, Config>>(File.ReadAllText(ConfigsF)); }
        }

        public static void SaveAs(string name) => Configs[name] = new Config(Current);

        public static void SaveJSON()
        {
            File.WriteAllText(CurrentF, JsonConvert.SerializeObject(Current));
            File.WriteAllText(ConfigsF, JsonConvert.SerializeObject(Configs));
        }

        public static void SetConfig(string name) => Current = new Config(Configs[name]);
    }
}