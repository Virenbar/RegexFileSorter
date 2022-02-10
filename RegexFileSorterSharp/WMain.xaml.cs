using Microsoft.WindowsAPICodePack.Dialogs;
using RegexFileSorter.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using static RegexFileSorter.Configuration;

namespace RegexFileSorter
{
    /// <summary>
    /// Логика взаимодействия для WMain.xaml
    /// </summary>
    public partial class WMain : Window
    {
        private readonly CommonOpenFileDialog COFD = new() { IsFolderPicker = true };
        private readonly ObservableCollection<SortedFolder> SFInvalid = new();
        private readonly ObservableCollection<SortedFolder> SFValid = new();

        public WMain()
        {
            InitializeComponent();

            SortValid.ItemsSource = SFValid;
            SortValid.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            SortInvalid.ItemsSource = SFInvalid;
            SortInvalid.Items.SortDescriptions.Add(new SortDescription("Files.Count", ListSortDirection.Descending));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void B_Preview_Click(object sender, RoutedEventArgs e)
        {
            if (!Current.Regex.Contains("?<S>"))
            {
                MessageBoxWPF.ShowWarning("Regex missing ?<S> capture group");
                return;
            }
            SFValid.Clear();
            SFInvalid.Clear();
            var L = Sorter.ScanFiles();
            foreach (var G in L)
            {
                var SF = Sorter.PrepareFiles(G);
                if (SF.IsValid)
                {
                    SFValid.Add(SF);
                }
                else
                {
                    SFInvalid.Add(SF);
                }
            }
            B_Sort.IsEnabled = SFValid.Count > 0;
        }

        private void B_SelectD_Click(object sender, RoutedEventArgs e)
        {
            COFD.InitialDirectory = Current.DFolder;
            if (COFD.ShowDialog() == CommonFileDialogResult.Ok) { Current.DFolder = COFD.FileName; }
        }

        private void B_SelectS_Click(object sender, RoutedEventArgs e)
        {
            COFD.InitialDirectory = Current.SFolder;
            if (COFD.ShowDialog() == CommonFileDialogResult.Ok) { Current.SFolder = COFD.FileName; }
        }

        private void B_Sort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Sorter.MoveFiles(SFValid);
                SFValid.Clear();
            }
            catch (Exception) { }
            finally
            {
                B_Sort.IsEnabled = false;
            }
        }

        private void MI_Save_Click(object sender, RoutedEventArgs e)
        {
            var F = new WInputBox();
            if (F.ShowDialog() ?? false)
            {
                var VM = (ConfigurationVM)DataContext;
                VM.SaveAs(F.Input);
            }
        }
    }
}