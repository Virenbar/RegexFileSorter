using RegexFileSorter;

namespace RegexFileSorterWF.Models
{
    internal class GroupTreeNode : TreeNode
    {
        public GroupTreeNode(GroupedFiles group)
        {
            Group = group ?? throw new ArgumentNullException(nameof(group));
            Text = $"{Group.Name} - {Group.Files.Count}{(Group.Status.Length > 0 ? $" - {Group.Status}" : "")}";
            var nodes = Group.Files.Select(f => new TreeNode { Text = f.FileName }).ToArray();
            Nodes.AddRange(nodes);
        }

        public GroupedFiles Group { get; }
    }
}