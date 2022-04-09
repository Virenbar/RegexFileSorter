using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace RegexFileSorter.Controls
{
    /// <summary>
    /// Логика взаимодействия для MessageBoxWPF.xaml
    /// </summary>
    public partial class MessageBoxWPF : Window
    {
        private static readonly string T;

        static MessageBoxWPF()
        {
            T = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        }

        private MessageBoxWPF()
        {
            InitializeComponent();
        }

        private MessageBoxWPF(string text, string title, MessageBoxButton buttons, MessageBoxImage image)
        {
            InitializeComponent();

            Title = title;
            Text.Text = text;

            Yes.Visibility = No.Visibility = (buttons is MessageBoxButton.YesNo or MessageBoxButton.YesNoCancel) ? Visibility.Visible : Visibility.Collapsed;
            OK.Visibility = (buttons is MessageBoxButton.OK or MessageBoxButton.OKCancel) ? Visibility.Visible : Visibility.Collapsed;
            Cancel.Visibility = (buttons is MessageBoxButton.OKCancel or MessageBoxButton.YesNoCancel) ? Visibility.Visible : Visibility.Collapsed;

            Image.Source = MBItoBS(image);

            Result = MessageBoxResult.None;
        }

        public MessageBoxResult Result { get; private set; }

        public static MessageBoxResult Show(string text, string title, MessageBoxButton buttons, MessageBoxImage image)
        {
            var W = new MessageBoxWPF(text, title, buttons, image);
            W.ShowDialog();
            return W.Result;
        }

        public static MessageBoxResult Show(string text) => Show(text, T, MessageBoxButton.OK, MessageBoxImage.None);

        public static MessageBoxResult Show(string text, string title) => Show(text, title, MessageBoxButton.OK, MessageBoxImage.None);

        public static MessageBoxResult Show(string text, string title, MessageBoxButton buttons) => Show(text, title, buttons, MessageBoxImage.None);

        public static MessageBoxResult AskYesNo(string text) => Show(text, T, MessageBoxButton.YesNo, MessageBoxImage.Warning);

        public static MessageBoxResult ShowError(string text) => Show(text, T, MessageBoxButton.OK, MessageBoxImage.Error);

        public static MessageBoxResult ShowWarning(string text) => Show(text, T, MessageBoxButton.OK, MessageBoxImage.Warning);

        private static BitmapSource MBItoBS(MessageBoxImage image)
        {
            Icon icon = image switch
            {
                MessageBoxImage.Error => SystemIcons.Error,
                MessageBoxImage.Question => SystemIcons.Question,
                MessageBoxImage.Warning => SystemIcons.Warning,
                MessageBoxImage.Information => SystemIcons.Information,
                _ => null,
            };
            if (icon == null) { return null; }
            return Imaging.CreateBitmapSourceFromHIcon(icon.Handle, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Cancel;
            Close();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.No;
            Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.OK;
            Close();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            Result = MessageBoxResult.Yes;
            Close();
        }
    }
}