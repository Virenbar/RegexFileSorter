namespace RegexFileSorter
{
    public class Profile : ObservableObject

    {
        private string sourceFolder = "";
        private string targetFolder = "";

        public Profile()
        {
            SourceFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TargetFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Pattern = @"^([\w]+?)_.*";//^\d+\.([\w-]+?)_
            Replacement = "$1";
            InPlace = false;
            CreateNew = false;
            SearchFolder = true;
        }

        protected Profile(Profile config)
        {
            SourceFolder = config.SourceFolder;
            TargetFolder = config.TargetFolder;
            Pattern = config.Pattern;
            Replacement = config.Replacement;
            InPlace = config.InPlace;
            CreateNew = config.CreateNew;
            SearchFolder = config.SearchFolder;
        }

        public Profile Clone() => new(this);

        #region Properties
        public bool CreateNew { get; set; }

        public bool InPlace { get; set; }

        public string OutFolder => InPlace ? SourceFolder : TargetFolder;

        public string Pattern { get; set; }

        public string Replacement { get; set; }

        public bool SearchFolder { get; set; }

        public string SourceFolder
        {
            get => sourceFolder;
            set
            {
                if (sourceFolder == value) { return; }
                sourceFolder = value;
                OnPropertyChanged();
            }
        }

        public string TargetFolder
        {
            get => targetFolder;
            set
            {
                if (targetFolder == value) { return; }
                targetFolder = value;
                OnPropertyChanged();
            }
        }

        #endregion Properties
    }
}