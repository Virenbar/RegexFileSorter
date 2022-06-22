using System.Collections.Generic;

namespace RegexFileSorter
{
    public class GroupedFiles
    {
        public GroupedFiles(string name)
        {
            Name = name;
        }

        public List<File> Files { get; } = new();
        public bool IsValid { get; set; }
        public string Name { get; set; } = "";
        public string Path { get; set; } = "";
        public string Status { get; set; } = "";
        public record File(string FileName, string InPath, string OutPath);
    }
}