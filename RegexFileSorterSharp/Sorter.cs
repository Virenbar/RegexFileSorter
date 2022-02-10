using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static RegexFileSorter.Configuration;

namespace RegexFileSorter
{
    internal static class Sorter
    {
        public static void MoveFiles(IEnumerable<SortedFolder> folders)
        {
            foreach (var SF in folders)
            {
                if (!SF.IsValid) { continue; }
                foreach (var F in SF.Files)
                {
                    if (File.Exists(F.OutPath)) { File.Delete(F.OutPath); }
                    File.Move(F.InPath, F.OutPath);
                }
            }
        }

        public static SortedFolder PrepareFiles(IGrouping<string, string> group)
        {
            var SF = new SortedFolder(group.Key);
            SF.Path = Path.Combine(Current.OutFolder, SF.Name);
            if (Directory.Exists(SF.Path))
            {
                SF.IsValid = true;
                SF.Status = "Found";
            }
            else if (Current.SearchFolder)
            {
                foreach (var Folder in Directory.GetDirectories(Current.OutFolder))
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
                if (Current.CreateNew)
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

        public static ILookup<string, string> ScanFiles()
        {
            var Result = new List<(string Path, string Match)>();
            var S = Directory.GetFiles(Current.SFolder);
            var R = new Regex(Current.Regex);
            foreach (var File in S)
            {
                var M = R.Match(Path.GetFileName(File));
                if (M.Success) { Result.Add((File, M.Groups["S"].Value)); }
            }
            return Result.ToLookup(X => X.Match, X => X.Path);
        }
    }
}