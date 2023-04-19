using Newtonsoft.Json;

namespace RegexFileSorter
{
    public static class ProfileManager
    {
        private const string CurrentFile = "Current.json", ProfilesFile = "Profiles.json";
        private static Dictionary<string, Profile> profiles;

        static ProfileManager()
        {
            Current = new();
            profiles = new() { { "Default", new() } };
        }

        public static Profile Current { get; set; }
        public static IReadOnlyDictionary<string, Profile> Profiles => profiles;

        public static void Add(string name) => Add(name, Current);

        public static void Add(string name, Profile profile) => profiles[name] = profile.Clone();

        public static bool Contains(string name) => Profiles.ContainsKey(name);

        public static void Load()
        {
            if (File.Exists(CurrentFile))
            {
                Current = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(CurrentFile)) ?? Current;
            }
            if (File.Exists(ProfilesFile))
            {
                profiles = JsonConvert.DeserializeObject<Dictionary<string, Profile>>(File.ReadAllText(ProfilesFile)) ?? profiles;
            }
        }

        public static void Remove(string name) => profiles.Remove(name);

        public static void Save()
        {
            File.WriteAllText(CurrentFile, JsonConvert.SerializeObject(Current, Formatting.Indented));
            File.WriteAllText(ProfilesFile, JsonConvert.SerializeObject(Profiles, Formatting.Indented));
        }

        public static void SetCurrent(string name) => Current = Profiles[name].Clone();
    }
}