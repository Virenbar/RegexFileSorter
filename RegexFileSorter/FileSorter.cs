using System.Text.RegularExpressions;

namespace RegexFileSorter
{
    public class FileSorter
    {
        private readonly List<GroupedFiles> _groups = new();
        private readonly Profile _profile = ProfileManager.Current;
        private readonly Dictionary<string, string> OutDirectories = new();

        public FileSorter(Profile profile) => _profile = profile;

        public IReadOnlyList<GroupedFiles> Groups => _groups;
        public IReadOnlyList<GroupedFiles> SortedFolders => Groups.Where(F => F.IsSorted).ToList();
        public IReadOnlyList<GroupedFiles> UnsortedFolders => Groups.Where(F => !F.IsSorted).ToList();

        public void MoveValidFiles()
        {
            foreach (var SF in SortedFolders)
            {
                if (!SF.IsSorted) { continue; }
                foreach (var F in SF.Files)
                {
                    if (File.Exists(F.OutPath)) { File.Delete(F.OutPath); }
                    if (!Directory.Exists(F.OutPath)) { Directory.CreateDirectory(F.OutPath); };
                    File.Move(F.InPath, F.OutPath);
                }
            }
        }

        public void SortFiles()
        {
            RefreshOutDirectories();
            _groups.Clear();

            var Result = new List<(string Path, string Match)>();
            var S = Directory.GetFiles(_profile.SFolder);
            var R = new Regex(_profile.Regex);
            foreach (var File in S)
            {
                var M = R.Match(Path.GetFileName(File));
                if (M.Success) { Result.Add((File, M.Groups["S"].Value)); }
            }

            var Groups = Result.ToLookup(X => X.Match, X => X.Path);
            foreach (var Group in Groups)
            {
                var SF = new GroupedFiles(Group.Key);
                foreach (var File in Group)
                {
                    var FileName = Path.GetFileName(File);
                    var OutFile = Path.Combine(SF.Path, FileName);
                    SF.Files.Add(new GroupedFiles.File(FileName, File, OutFile));
                }
                ValidateGroup(SF);
                _groups.Add(SF);
            }
        }

        private void RefreshOutDirectories()
        {
            OutDirectories.Clear();
            foreach (var Folder in Directory.GetDirectories(_profile.OutFolder))
            {
                var FolderName = Path.GetFileName(Folder);
                OutDirectories.Add(FolderName.ToLowerInvariant(), Folder);
            }
        }

        private void ValidateGroup(GroupedFiles group)
        {
            var OutPath = Path.Combine(_profile.OutFolder, group.Name);
            if (Directory.Exists(OutPath))
            {
                group.Path = OutPath;
                group.IsSorted = true;
                group.Status = "Found";
            }
            else if (_profile.SearchFolder)
            {
                foreach (var (FolderName, Folder) in OutDirectories)
                {
                    if (FolderName.ToLowerInvariant().Contains(group.Name.ToLowerInvariant()))
                    {
                        group.Path = Folder;
                        group.IsSorted = true;
                        group.Status = $"Found \"{FolderName}\"";
                    }
                }
            }

            if (!group.IsSorted)
            {
                if (_profile.CreateNew)
                {
                    group.IsSorted = true;
                    group.Status = $"Create folder \"{group.Name}\"";
                }
                else { group.Status = "Not Found"; }
            }
        }
    }
}