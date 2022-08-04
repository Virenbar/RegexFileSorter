using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RegexFileSorter
{
    public class Profile : INotifyPropertyChanged

    {
        private string m_DFolder = "";
        private string m_SFolder = "";

        public Profile()
        {
            SFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Regex = @"(?<S>[\w]+?)_";//^\d+\.(?<S>[\w-]+?)_
            InPlace = false;
            CreateNew = false;
            SearchFolder = true;
        }

        protected Profile(Profile config)
        {
            SFolder = config.SFolder;
            DFolder = config.DFolder;
            Regex = config.Regex;
            InPlace = config.InPlace;
            CreateNew = config.CreateNew;
            SearchFolder = config.SearchFolder;
        }

        public Profile Clone() => new(this);

        #region Properties
        public bool CreateNew { get; set; }

        public string DFolder
        {
            get => m_DFolder;
            set
            {
                m_DFolder = value;
                OnPropertyChanged();
            }
        }

        public bool InPlace { get; set; }
        public string OutFolder => InPlace ? SFolder : DFolder;
        public string Regex { get; set; }
        public bool SearchFolder { get; set; }

        public string SFolder
        {
            get => m_SFolder;
            set
            {
                m_SFolder = value;
                OnPropertyChanged();
            }
        }

        #endregion Properties

        #region INotify

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion INotify
    }
}