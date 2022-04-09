using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace RegexFileSorter.Controls
{
    internal class TextBoxFolder : TextBox
    {
        public TextBoxFolder()
        {
            base.IsReadOnly = true;
        }

        public new bool IsReadOnly { get; } = true;

        public void SelectFolder()
        {
            var F = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                InitialDirectory = Text
            };
            if (F.ShowDialog() == CommonFileDialogResult.Ok) { Text = F.FileName; }
        }

        protected override void OnDragEnter(DragEventArgs e) => ProcessDrag(e);

        protected override void OnDragLeave(DragEventArgs e) => base.OnDragLeave(e);

        protected override void OnDragOver(DragEventArgs e) => ProcessDrag(e);

        protected override void OnDrop(DragEventArgs e)
        {
            var Folder = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            if (Directory.Exists(Folder)) { Text = Folder; }
        }

        private static void ProcessDrag(DragEventArgs e)
        {
            var Effect = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var Folder = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(Folder)) { Effect = DragDropEffects.Link; }
            }
            e.Effects = Effect;
            e.Handled = true;
        }
    }
}