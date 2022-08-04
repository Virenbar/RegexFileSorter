namespace RegexFileSorter
{
    public class GroupedFiles
    {
        public GroupedFiles(string name)
        {
            Name = name;
        }

        public List<File> Files { get; } = new();
        public bool IsSorted { get; set; }
        public string Name { get; set; } = "No Name";
        public string Path { get; set; } = "";
        public string Status { get; set; } = "None";
        public record File(string FileName, string InPath);
    }
}