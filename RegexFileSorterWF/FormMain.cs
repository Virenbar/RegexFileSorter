using RegexFileSorter;
using RegexFileSorterWF.Controls;
using System.Diagnostics;

namespace RegexFileSorterWF
{
    public partial class FormMain : Form
    {
        private FileSorter? Sorter;

        public FormMain()
        {
            InitializeComponent();
            Icon = Properties.Resources.RFS_Icon;
            DoubleBuffered = true;
        }

        private static void RefreshList(IEnumerable<GroupedFiles> groups, ListView list)
        {
            var Groups = groups
                .OrderBy(g => g.Name)
                .OrderByDescending(g => g.Files.Count)
                .Select(group => new ListViewGroup($"{group.Name} - {group.Files.Count}")
                {
                    TaskLink = group.Status,
                    CollapsedState = ListViewGroupCollapsedState.Collapsed,
                    Tag = group
                });

            list.BeginUpdate();
            list.Items.Clear();
            foreach (var group in Groups)
            {
                var Items = ((GroupedFiles)group.Tag!).Files.Select(file =>
                    {
                        var LVI = new ListViewItem(file.FileName) { Group = group };
                        return LVI;
                    });
                list.Groups.Add(group);
                list.Items.AddRange(Items.ToArray());
            }
            list.EndUpdate();
        }

        private void FixWidth()
        {
            LV_Unsorted.Columns[0].Width = LV_Unsorted.Width - 25;
            LV_Sorted.Columns[0].Width = LV_Sorted.Width - 25;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshMenu();
            RefreshUI();

            LV_Sorted.DoubleBuferred();
            LV_Sorted.View = View.Details;
            LV_Sorted.HeaderStyle = ColumnHeaderStyle.None;

            LV_Unsorted.DoubleBuferred();
            LV_Unsorted.View = View.Details;
            LV_Unsorted.HeaderStyle = ColumnHeaderStyle.None;
            FixWidth();
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
                    RefreshMenu();
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
        }

        private void RefreshUI()
        {
            BS_Config.DataSource = ProfileManager.Current;
        }

        private void SortFiles()
        {
            Sorter = new(ProfileManager.Current);
            Sorter.SortFiles();
            RefreshList(Sorter.SortedGroups, LV_Sorted);
            RefreshList(Sorter.UnsortedGroups, LV_Unsorted);
            L_Count.Text = $"Files: {Sorter.SortedFiles}";
            B_Move.Enabled = Sorter.SortedGroups.Count > 0;
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

        private void BS_Config_CurrentItemChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void FormMain_Resize(object sender, EventArgs e) => FixWidth();

        private void LV_Sorted_GroupTaskLinkClick(object sender, ListViewGroupEventArgs e)
        {
            var S = (GroupedFiles)LV_Sorted.Groups[e.GroupIndex].Tag!;
            if (!Directory.Exists(S.Path))
            {
                if (MessageBox.Show(this, $"Create folder \"{Path.GetFileName(S.Path)}\"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { Directory.CreateDirectory(S.Path); }
                else { return; }
            }
            Process.Start(new ProcessStartInfo(S.Path) { UseShellExecute = true });
        }

        private void LV_Unsorted_GroupTaskLinkClick(object sender, ListViewGroupEventArgs e)
        {
            var S = (GroupedFiles)LV_Unsorted.Groups[e.GroupIndex].Tag!;
            Clipboard.SetText(S.Name);
        }

        private void LV_Unsorted_ItemActivate(object sender, EventArgs e)
        {
            //TODO
        }

        private void MI_Save_Click(object sender, EventArgs e)
        {
            var Name = "";
            var Done = false;
            while (!Done)
            {
                var F = new InputBox { Header = "Input name for profile", Value = Name };
                if (F.ShowDialog(this) == DialogResult.Cancel) { return; }
                Name = F.Value;
                if (!ProfileManager.Contains(Name)) { break; }
                switch (MessageBox.Show(this, $"Profile \"{Name}\" alredy exists.\nOverwrite it?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        Done = true;
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        return;

                    default:
                        return;
                }
            }
            ProfileManager.Add(Name);
            RefreshUI();
            RefreshMenu();
        }

        #endregion UI Events
    }
}