using System.ComponentModel;

namespace RegexFileSorterWF.Controls
{
    public partial class TextBoxFolder : TextBox
    {
        public TextBoxFolder()
        {
            base.ReadOnly = true;
            AllowDrop = true;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [DefaultValue(true)]
        public new bool ReadOnly { get; } = true;

        public void SelectFolder()
        {
            var F = new FolderBrowserDialog { InitialDirectory = Text };
            if (F.ShowDialog() == DialogResult.OK) { Text = F.SelectedPath; }
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            if (e.Data is null) { return; }
            var Folder = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (Directory.Exists(Folder)) { Text = Folder; }
        }

        protected override void OnDragEnter(DragEventArgs e) => ProcessDrag(e);

        //protected override void OnDragLeave(EventArgs e) => base.OnDragLeave(e);

        protected override void OnDragOver(DragEventArgs e) => ProcessDrag(e);

        private static void ProcessDrag(DragEventArgs e)
        {
            var Effect = DragDropEffects.None;
            if (e.Data is null) { return; }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var Folder = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(Folder)) { Effect = DragDropEffects.Link; }
            }
            e.Effect = Effect;
        }
    }
}