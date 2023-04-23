using RegexFileSorter;
using RegexFileSorterWF.Controls;
using RegexFileSorterWF.Models;
using RegexFileSorterWF.Properties;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RegexFileSorterWF
{
    public partial class FormMain : Form
    {
        private GroupedFiles? Group;
        private FileSorter? Sorter;

        public FormMain()
        {
            InitializeComponent();
            this.AddStyleDataBindigs();
            this.DoubleBuferred();
            Icon = Resources.RFS_Icon;
        }

        private static void RefreshTree(TreeView tree, IEnumerable<GroupedFiles> groups)
        {
            tree.BeginUpdate();
            tree.Nodes.Clear();
            var nodes = groups.Select(g => new GroupTreeNode(g)).ToArray();
            tree.Nodes.AddRange(nodes);
            tree.EndUpdate();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshMenu();
            RefreshUI();
        }

        private void RefreshMenu()
        {
            MI_Load.DropDownItems.Clear();
            MI_Delete.DropDownItems.Clear();
            foreach (var profile in ProfileManager.Profiles)
            {
                var Load = new ToolStripMenuItem(profile.Key);
                Load.Click += (object? _, EventArgs _) =>
                {
                    ProfileManager.SetCurrent(profile.Key);
                    BS_Config.DataSource = ProfileManager.Current;
                    RefreshUI();
                };
                MI_Load.DropDownItems.Add(Load);

                var Delete = new ToolStripMenuItem(profile.Key);
                Delete.Click += (object? _, EventArgs _) =>
                {
                    if (this.AskYesNo($"Delete profile \"{profile.Key}\"?", "Delete profile") == DialogResult.No) { return; }
                    ProfileManager.Remove(profile.Key);
                    RefreshMenu();
                };
                MI_Delete.DropDownItems.Add(Delete);
            }
            BS_Config.DataSource = ProfileManager.Current;
        }

        private void RefreshUI()
        {
            if (Sorter is null) { return; }

            L_CountSorted.Text = Regex.Replace(L_CountSorted.Text, @"\d+", $"{Sorter.SortedCount}");
            L_CountUnsorted.Text = Regex.Replace(L_CountUnsorted.Text, @"\d+", $"{Sorter.UnsortedCount}");
            MI_CopyName.Enabled = Group is not null;
            MI_OpenFolder.Enabled = Group?.IsSorted ?? false;

            B_Move.Enabled = Sorter.SortedGroups.Count > 0;
        }

        private void SortFiles()
        {
            var Profile = ProfileManager.Current;
            if (string.IsNullOrWhiteSpace(Profile.Pattern))
            {
                this.ShowWarning("Regex pattern is empty", "Empty Pattern");
                return;
            }

            try
            {
                Sorter = new(Profile);
                Sorter.SortFiles();
                RefreshTree(TV_Sorted, Sorter.SortedGroups);
                RefreshTree(TV_Unsorted, Sorter.UnsortedGroups);
                RefreshUI();
            }
            catch (RegexParseException E)
            {
                this.ShowError(E.Message, "Invalid regex expression");
            }
        }

        #region UI Events

        private void B_About_Click(object sender, EventArgs e)
        {
            var F = new FormAbout();
            F.ShowDialog(this);
        }

        private void B_Move_Click(object sender, EventArgs e)
        {
            Sorter?.MoveValidFiles();
            SortFiles();
        }

        private void B_SelectD_Click(object sender, EventArgs e) => TB_Destination.SelectFolder();

        private void B_SelectS_Click(object sender, EventArgs e) => TB_Source.SelectFolder();

        private void B_Sort_Click(object sender, EventArgs e) => SortFiles();

        private void MI_CopyName_Click(object sender, EventArgs e)
        {
            if (Group is null) { return; }
            Clipboard.SetText(Group.Name);
        }

        private void MI_OpenFolder_Click(object sender, EventArgs e)
        {
            if (Group is null) { return; }
            if (!Directory.Exists(Group.Path))
            {
                if (this.AskYesNo($"Create folder \"{Path.GetFileName(Group.Path)}\"?", "Warning") == DialogResult.No) { return; }
                Directory.CreateDirectory(Group.Path);
            }
            Process.Start(new ProcessStartInfo(Group.Path) { UseShellExecute = true });
        }

        private void MI_Save_Click(object sender, EventArgs e)
        {
            var Name = "";
            var Done = false;
            while (!Done)
            {
                using var F = new InputBox { Text = "Profile name", Header = "Input name for profile", Value = Name };
                if (F.ShowDialog(this) == DialogResult.Cancel) { return; }
                Name = F.Value;
                if (!ProfileManager.Contains(Name)) { break; }
                // Ask for overwrite
                var Result = this.AskYesNoCancel($"Profile \"{Name}\" already exists.\nOverwrite it?", "Warning");
                if (Result == DialogResult.Cancel) { return; }
                Done = Result == DialogResult.Yes;
            }
            ProfileManager.Add(Name);
            RefreshUI();
            RefreshMenu();
        }

        private void TV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if ((e.Node?.Parent ?? e.Node) is GroupTreeNode GTN)
            {
                Group = GTN.Group;
            }
            RefreshUI();
        }

        private void TV_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is TreeView TV && e.Button == MouseButtons.Right)
            {
                TV.SelectedNode = TV.GetNodeAt(e.X, e.Y);
            }
        }

        #endregion UI Events
    }
}