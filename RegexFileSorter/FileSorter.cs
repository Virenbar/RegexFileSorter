using System.Text.RegularExpressions;

namespace RegexFileSorter
{
    public class FileSorter
    {
        private readonly List<GroupedFiles> groups = new();
        private readonly Dictionary<string, string> outDirectories = new();
        private readonly Profile profile = ProfileManager.Current;

        public FileSorter(Profile profile) => this.profile = profile;

        public int SortedCount => SortedGroups.Sum(F => F.Files.Count);
        public IReadOnlyList<GroupedFiles> SortedGroups => groups.Where(F => F.IsSorted).ToList();
        public int UnsortedCount => UnsortedGroups.Sum(F => F.Files.Count);
        public IReadOnlyList<GroupedFiles> UnsortedGroups => groups.Where(F => !F.IsSorted).ToList();

        public void MoveValidFiles()
        {
            foreach (var SF in SortedGroups)
            {
                if (!SF.IsSorted) { continue; }
                foreach (var F in SF.Files)
                {
                    var OutPath = Path.Combine(SF.Path, F.FileName);
                    if (File.Exists(OutPath)) { File.Delete(OutPath); }
                    File.Move(F.InPath, OutPath);
                }
            }
        }

        public void SortFiles()
        {
            RefreshOutDirectories();
            groups.Clear();

            var Matches = new List<(string Path, string Match)>();
            var S = Directory.GetFiles(profile.SourceFolder);
            var R = new Regex(profile.Pattern);
            foreach (var File in S)
            {
                var name = Path.GetFileName(File);
                if (R.IsMatch(name))
                {
                    var T = Regex.Replace(name, profile.Pattern, profile.Replacement);
                    Matches.Add((File, T));
                }
            }

            var Lookup = Matches.ToLookup(X => X.Match, X => X.Path);
            foreach (var Group in Lookup)
            {
                var SF = new GroupedFiles(Group.Key);
                foreach (var File in Group)
                {
                    var FileName = Path.GetFileName(File);
                    SF.Files.Add(new GroupedFiles.File(FileName, File));
                }
                ValidateGroup(SF);
                groups.Add(SF);
            }
        }

        private void RefreshOutDirectories()
        {
            outDirectories.Clear();
            foreach (var Folder in Directory.GetDirectories(profile.OutFolder))
            {
                var FolderName = Path.GetFileName(Folder);
                outDirectories.Add(FolderName, Folder);
            }
        }

        private void ValidateGroup(GroupedFiles group)
        {
            var OutPath = Path.Combine(profile.OutFolder, group.Name);
            if (Directory.Exists(OutPath))
            {
                group.Path = OutPath;
                group.IsSorted = true;
                group.Status = $@"Folder: ""{group.Name}""";
            }
            else if (!profile.StrictMode)
            {
                foreach (var (FolderName, Folder) in outDirectories)
                {
                    var folder = FolderName.ToLowerInvariant();
                    var name = group.Name.ToLowerInvariant();
                    if (folder.Contains(name))
                    {
                        group.Path = Folder;
                        group.IsSorted = true;
                        group.Status = $@"Folder: ""{FolderName}""";
                    }
                }
            }

            if (!group.IsSorted)
            {
                if (profile.CreateNew)
                {
                    group.Path = OutPath;
                    group.IsSorted = true;
                    group.Status = $@"New folder: ""{group.Name}""";
                }
                else
                {
                    group.Status = "";
                }
            }
        }
    }
}