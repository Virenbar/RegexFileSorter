using System.Windows;

namespace RegexFileSorter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnExit(ExitEventArgs e)
        {
            Configuration.SaveJSON();
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            Configuration.LoadJSON();
            base.OnStartup(e);
        }
    }
}