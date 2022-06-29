using System.Text.RegularExpressions;

namespace RegexFileSorter
{
    public class FileSorter
    {
        private readonly Profile _profile = ProfileManager.Current;
        private readonly Dictionary<string, string> OutDirectories = new();
        private readonly List<GroupedFiles> _groups = new();

        public FileSorter(Profile profile) => _profile = profile;

        public IReadOnlyList<GroupedFiles> Groups => _groups;
        public IReadOnlyList<GroupedFiles> InvalidFolders => Groups.Where(F => !F.IsValid).ToList();
        public IReadOnlyList<GroupedFiles> ValidFolders => Groups.Where(F => F.IsValid).ToList();

        private void RefreshOutDirectories()
        {
            OutDirectories.Clear();
            foreach (var Folder in Directory.GetDirectories(_profile.OutFolder))
            {
                var FolderName = Path.GetFileName(Folder);
                OutDirectories.Add(FolderName.ToLowerInvariant(), Folder);
            }
        }

        public GroupedFiles PrepareFiles(IGrouping<string, string> group)
        {
            var SF = new GroupedFiles(group.Key);
            SF.Path = Path.Combine(_profile.OutFolder, SF.Name);
            if (Directory.Exists(SF.Path))
            {
                SF.IsValid = true;
                SF.Status = "Found";
            }
            else if (_profile.SearchFolder)
            {
                foreach (var Folder in Directory.GetDirectories(_profile.OutFolder))
                {
                    var FolderName = Path.GetFileName(Folder);
                    if (FolderName.ToLowerInvariant().Contains(SF.Name.ToLowerInvariant()))
                    {
                        SF.Path = Folder;
                        SF.IsValid = true;
                        SF.Status = $"Found \"{FolderName}\"";
                    }
                }
            }

            if (!SF.IsValid)
            {
                if (_profile.CreateNew)
                {
                    SF.IsValid = true;
                    SF.Status = $"Create folder \"{SF.Name}\"";
                }
                else { SF.Status = "Not Found"; }
            }

            foreach (var File in group)
            {
                var FileName = Path.GetFileName(File);
                var OutFile = Path.Combine(SF.Path, FileName);
                SF.Files.Add(new GroupedFiles.File(FileName, File, OutFile));
            }

            return SF;
        }

        private void ValidateGroup(GroupedFiles group)
        {
        }

        public void SortFiles()
        {
            RefreshOutDirectories();

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
            }

            //Groups = RRR.Select(G => PrepareFiles(G)).ToList();
        }

        public void MoveValidFiles()
        {
            foreach (var SF in ValidFolders)
            {
                if (!SF.IsValid) { continue; }
                foreach (var F in SF.Files)
                {
                    if (File.Exists(F.OutPath)) { File.Delete(F.OutPath); }
                    if (!Directory.Exists(F.OutPath)) { Directory.CreateDirectory(F.OutPath); };
                    File.Move(F.InPath, F.OutPath);
                }
            }
        }
    }
}