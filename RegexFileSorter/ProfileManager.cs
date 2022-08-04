using Newtonsoft.Json;

namespace RegexFileSorter
{
    public static class ProfileManager
    {
        private const string CurrentFile = "Current.json", ProfilesFile = "Profiles.json";

        static ProfileManager()
        {
            Current = new();
            Profiles = new() { { "Default", new() } };
        }

        public static Profile Current { get; set; }
        public static IReadOnlyDictionary<string, Profile> p => Profiles;
        public static Dictionary<string, Profile> Profiles { get; set; }

        public static void Add(string name) => Add(name, Current);

        public static void Add(string name, Profile profile) => Profiles[name] = profile.Clone();

        public static bool Contains(string name) => Profiles.ContainsKey(name);

        public static void Load()
        {
            if (File.Exists(CurrentFile))
            {
                Current = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(CurrentFile)) ?? Current;
            }
            if (File.Exists(ProfilesFile))
            {
                Profiles = JsonConvert.DeserializeObject<Dictionary<string, Profile>>(File.ReadAllText(ProfilesFile)) ?? Profiles;
            }
        }

        public static void Remove(string name) => Profiles.Remove(name);

        public static void Save()
        {
            File.WriteAllText(CurrentFile, JsonConvert.SerializeObject(Current));
            File.WriteAllText(ProfilesFile, JsonConvert.SerializeObject(Profiles));
        }

        public static void SetCurrent(string name) => Current = Profiles[name].Clone();
    }
}