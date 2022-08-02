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
        }

        private static void RefreshList(IEnumerable<GroupedFiles> groups, ListView list)
        {
            var Groups = groups
                .Select(group => new ListViewGroup($"{group.Name} - {group.Files.Count}")
                {
                    TaskLink = group.Status,
                    CollapsedState = ListViewGroupCollapsedState.Collapsed,
                    Tag = group
                });

            list.BeginUpdate();
            foreach (var group in Groups)
            {
                var Items = ((GroupedFiles)group.Tag!).Files.Select(file =>
                    {
                        var LVI = new ListViewItem(file.FileName) { Group = group };
                        return LVI;
                    });
                list.Items.AddRange(Items.ToArray());
                list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            list.EndUpdate();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshMenu();
            RefreshUI();

            LV_Sorted.View = View.Details;
            tableLayoutPanel1.DoubleBuferred();
            LV_Sorted.DoubleBuferred();
            LV_Sorted.Columns.Add("Name");
            LV_Sorted.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void RefreshMenu()
        {
            MI_Load.DropDownItems.Clear();
            MI_Delete.DropDownItems.Clear();
            foreach (var profile in ProfileManager.Profiles)
            {
                var Load = new ToolStripMenuItem(profile.Key);
                Load.Click += (object? _, EventArgs e) =>
                {
                    ProfileManager.SetCurrent(profile.Key);
                    RefreshMenu();
                    RefreshUI();
                };
                MI_Load.DropDownItems.Add(Load);

                var Delete = new ToolStripMenuItem(profile.Key);
                Delete.Click += (object? _, EventArgs e) =>
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

        #region UI Events

        private void B_Copy_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void B_Move_Click(object sender, EventArgs e)
        {
            Sorter?.MoveValidFiles();
        }

        private void B_Open_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void B_SelectD_Click(object sender, EventArgs e) => TB_Destination.SelectFolder();

        private void B_SelectS_Click(object sender, EventArgs e) => TB_Source.SelectFolder();

        private void B_Sort_Click(object sender, EventArgs e)
        {
            Sorter = new(ProfileManager.Current);
            Sorter.SortFiles();
            RefreshList(Sorter.SortedFolders, LV_Sorted);
            RefreshList(Sorter.UnsortedFolders, LV_Unsorted);
            B_Move.Enabled = Sorter.SortedFolders.Count > 0;
        }

        private void BS_Config_CurrentItemChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void LV_Sorted_GroupTaskLinkClick(object sender, ListViewGroupEventArgs e)
        {
            var S = (GroupedFiles)LV_Sorted.Groups[e.GroupIndex].Tag!;
            //if (S is null) { return; }
            Process.Start(new ProcessStartInfo(S.Path) { UseShellExecute = true });
        }

        private void LV_Unsorted_GroupTaskLinkClick(object sender, ListViewGroupEventArgs e)
        {
            //TODO
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
        }

        #endregion UI Events
    }
}