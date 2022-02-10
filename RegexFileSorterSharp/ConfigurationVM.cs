using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace RegexFileSorter
{
    internal class ConfigurationVM : ObservableObject
    {
        public ConfigurationVM()
        {
            UpdateMenu();
        }

        public Config Current
        {
            get => Configuration.Current;
            set
            {
                Configuration.Current = value;
                OnPropertyChanged();
            }
        }

        public void SaveAs(string name)
        {
            Configuration.SaveAs(name);
            UpdateMenu();
        }

        public ObservableCollection<MenuItem> LoadMenu { get; } = new();
        public ObservableCollection<MenuItem> DeleteMenu { get; } = new();

        private void UpdateMenu()
        {
            LoadMenu.Clear();
            DeleteMenu.Clear();
            foreach (var Config in Configuration.Configs)
            {
                var Name = Config.Key;
                var LMI = new MenuItem { Header = Name };
                LMI.Click += (sender, e) =>
                {
                    Configuration.SetConfig(Name);
                    OnPropertyChanged(nameof(Current));
                };
                LoadMenu.Add(LMI);

                var DMI = new MenuItem { Header = Name };
                DMI.Click += (sender, e) =>
                {
                    Configuration.Delete(Name);
                    UpdateMenu();
                };
                DeleteMenu.Add(DMI);
            }
        }
    }
}