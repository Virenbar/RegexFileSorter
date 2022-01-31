using System.Collections.Generic;

namespace RegexFileSorter
{
    internal class SortedFolder
    {
        public SortedFolder()
        {
            Name = "No Name";
            Path = "None";
            Status = "None";
        }

        public SortedFolder(string name)
        {
            Name = name;
            IsValid = false;
        }

        public List<SortedFile> Files { get; }
        public bool IsValid { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public record SortedFile(string Filename, string InPath, string OutPath);
    }
}