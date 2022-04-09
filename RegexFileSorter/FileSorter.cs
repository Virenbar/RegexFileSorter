using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexFileSorter
{
    internal class FileSorter
    {
        private readonly Config Config;

        public FileSorter(Config config) => Config = config;

        public IReadOnlyList<SortedFolder> Folders { get; private set; }
        public IReadOnlyList<SortedFolder> InvalidFolders => Folders.Where(F => !F.IsValid).ToList();
        public IReadOnlyList<SortedFolder> ValidFolders => Folders.Where(F => F.IsValid).ToList();

        public SortedFolder PrepareFiles(IGrouping<string, string> group)
        {
            var SF = new SortedFolder(group.Key);
            SF.Path = Path.Combine(Config.OutFolder, SF.Name);
            if (Directory.Exists(SF.Path))
            {
                SF.IsValid = true;
                SF.Status = "Found";
            }
            else if (Config.SearchFolder)
            {
                foreach (var Folder in Directory.GetDirectories(Config.OutFolder))
                {
                    var FolderName = Path.GetFileName(Folder);
                    if (FolderName.ToLower().Contains(SF.Name.ToLower()))
                    {
                        SF.Path = Folder;
                        SF.IsValid = true;
                        SF.Status = $"Found \"{FolderName}\"";
                    }
                }
            }

            if (!SF.IsValid)
            {
                if (Config.CreateNew)
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
                SF.Files.Add(new SortedFolder.SortedFile(FileName, File, OutFile));
            }

            return SF;
        }

        public void SortFiles()
        {
            var Result = new List<(string Path, string Match)>();
            var S = Directory.GetFiles(Config.SFolder);
            var R = new Regex(Config.Regex);
            foreach (var File in S)
            {
                var M = R.Match(Path.GetFileName(File));
                if (M.Success) { Result.Add((File, M.Groups["S"].Value)); }
            }
            var RRR = Result.ToLookup(X => X.Match, X => X.Path);
            Folders = RRR.Select(G => PrepareFiles(G)).ToList();
        }
    }
}