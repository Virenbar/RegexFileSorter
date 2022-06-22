using RegexFileSorterWF.Controls;
using System.Diagnostics;
using System.Reflection;
using RegexFileSorter;

namespace RegexFileSorterWF
{
    public partial class FormMain : Form
    {
        private FileSorter Sorter = new();

        public FormMain()
        {
            InitializeComponent();
            Icon = Properties.Resources.RFS_Icon;
        }

        private void RefreshUI()
        {
            BS_Config.DataSource = ProfileManager.Current;
            MI_Load.DropDownItems.Clear();
            MI_Delete.DropDownItems.Clear();
            foreach (var profile in ProfileManager.Profiles)
            {
                var Load = new ToolStripMenuItem(profile.Key);
                Load.Click += (object? sender, EventArgs e) =>
                {
                    ProfileManager.SetCurrent(profile.Key);
                    RefreshUI();
                };
                MI_Load.DropDownItems.Add(Load);

                var Delete = new ToolStripMenuItem(profile.Key);
                Delete.Click += (object? sender, EventArgs e) =>
                {
                    if (this.AskYesNo($"Delete profile \"{profile.Key}\"?", "Delete profile") == DialogResult.No) { return; }
                    ProfileManager.Remove(profile.Key);
                    RefreshUI();
                }; ;
                MI_Delete.DropDownItems.Add(Delete);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            RefreshUI();

            LV_Sorted.View = View.Details;
            //EnableDoubleBuferring(this);
            EnableDoubleBuferring(tableLayoutPanel1);
            EnableDoubleBuferring(LV_Sorted);
            //LV_Sorted.DoubleBuffered = true;
            //LV_Sorted.LabelWrap = false;
            LV_Sorted.BeginUpdate();
            LV_Sorted.Columns.Add("Name");
            LV_Sorted.HeaderStyle = ColumnHeaderStyle.None;
            var GroupNames = Enumerable
                .Range(1, 100)
                .Select(I => $"Group {I}")
                .ToList();

            var Groups = GroupNames
                .Select(group => new ListViewGroup(group)
                {
                    Subtitle = $"Subtitle {group}",
                    CollapsedState = ListViewGroupCollapsedState.Collapsed,
                    Footer = $"Footer {group}",
                    TaskLink = $"Task {group}"
                });

            foreach (var group in Groups)
            {
                LV_Sorted.Groups.Add(group);
                var ItemNames = Enumerable
                    .Range(1, 10)
                    .Select(I => $"Item {I} ({group})")
                    .ToList();

                var Items = ItemNames
                    .Select(item =>
                    {
                        var LVI = new ListViewItem(item)
                        {
                            Group = group
                        };
                        return LVI;
                    });
                LV_Sorted.Items.AddRange(Items.ToArray());
                LV_Sorted.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                LV_Sorted.EndUpdate();
            }
        }

        public static void EnableDoubleBuferring(Control control)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property?.SetValue(control, true, null);
        }

        #region UI Events

        private void B_Open_Click(object sender, EventArgs e)
        {
        }

        private void B_Copy_Click(object sender, EventArgs e)
        {
        }

        private void B_Move_Click(object sender, EventArgs e)
        {
        }

        private void LV_Sorted_GroupTaskLinkClick(object sender, ListViewGroupEventArgs e)
        {
            var S = (GroupedFiles?)LV_Sorted.Groups[e.GroupIndex].Tag;
            if (S is null) { return; }
            Process.Start(new ProcessStartInfo(S.Path) { UseShellExecute = true });
        }

        private void LV_Unsorted_GroupTaskLinkClick(object sender, ListViewGroupEventArgs e)
        {
        }

        private void LV_Unsorted_ItemActivate(object sender, EventArgs e)
        {
        }

        private void B_SelectS_Click(object sender, EventArgs e) => TB_Source.SelectFolder();

        private void B_SelectD_Click(object sender, EventArgs e) => TB_Destination.SelectFolder();

        private void B_Sort_Click(object sender, EventArgs e)
        {
        }

        private void MI_Save_Click(object sender, EventArgs e)
        {
            var Name = "";
            var Done = false;
            while (!Done)
            {
                var F = new InputBox() { Header = "Input name for profile", Value = Name };
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
                        break;
                }
            }
            ProfileManager.Add(Name);
            RefreshUI();
        }

        #endregion UI Events
    }
}