using Microsoft.WindowsAPICodePack.Dialogs;
using RegexFileSorter.Controls;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace RegexFileSorter
{
    /// <summary>
    /// Логика взаимодействия для WMain.xaml
    /// </summary>
    public partial class WMain : Window
    {
        private readonly CommonOpenFileDialog COFD = new() { IsFolderPicker = true };
        private readonly ConfigurationVM Configuration;
        private readonly ObservableCollection<SortedFolder> SFInvalid = new();
        private readonly ObservableCollection<SortedFolder> SFValid = new();
        private FileSorter Sorter;

        public WMain()
        {
            InitializeComponent();

            SortValid.ItemsSource = SFValid;
            SortValid.Items.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
            SortInvalid.ItemsSource = SFInvalid;
            SortInvalid.Items.SortDescriptions.Add(new SortDescription("Files.Count", ListSortDirection.Descending));

            Configuration = (ConfigurationVM)DataContext;
        }

        private Config Current => ((ConfigurationVM)DataContext).Current;

        private void B_Preview_Click(object sender, RoutedEventArgs e)
        {
            if (!Current.Regex.Contains("?<S>"))
            {
                MessageBoxWPF.ShowWarning("Regex missing ?<S> capture group");
                return;
            }
            try
            {
                Sorter = new(Current);
                Sorter.SortFiles();

                SFValid.Clear();
                SFInvalid.Clear();
                foreach (var SF in Sorter.Folders)
                {
                    if (SF.IsValid) { SFValid.Add(SF); } else { SFInvalid.Add(SF); }
                }
            }
            catch (Exception E)
            {
                MessageBoxWPF.ShowWarning(E.Message);
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
                FileMover.MoveFiles(SFValid);
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
            var F = new WInputBox() { Owner = this };
            while (F.ShowDialog() ?? false)
            {
                Name = F.Input;
                if (Configuration.Contains(Name))
                {
                    if (MessageBoxWPF.AskYesNo($"Profile \"{Name}\" already exsists. Replace it?") == MessageBoxResult.No)
                    {
                        F = new WInputBox() { Owner = this, Input = Name };
                        continue;
                    }
                }

                Configuration.SaveAs(Name);
                return;
            }
        }
    }
}