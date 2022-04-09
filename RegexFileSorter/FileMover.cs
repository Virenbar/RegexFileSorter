using System.Collections.Generic;
using System.IO;

namespace RegexFileSorter
{
    internal static class FileMover
    {
        /// <summary>
        /// Moves all valid files from <see cref="SortedFolder.SortedFile.InPath"/> to <see cref="SortedFolder.SortedFile.OutPath"/>
        /// </summary>
        /// <param name="folders"></param>
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
    }
}