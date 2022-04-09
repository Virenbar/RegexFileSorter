using System.Windows;

namespace RegexFileSorter
{
    /// <summary>
    /// Логика взаимодействия для WInputBox.xaml
    /// </summary>
    public partial class WInputBox : Window
    {
        public WInputBox()
        {
            InitializeComponent();
        }

        public string Input
        {
            get => TB_Input.Text;
            set => TB_Input.Text = value;
        }

        private void B_Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void B_Save_Click(object sender, RoutedEventArgs e)
        {
            if (Input.Length == 0) { return; }
            DialogResult = true;
        }
    }
}