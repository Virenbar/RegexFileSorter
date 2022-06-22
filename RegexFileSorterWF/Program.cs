using RegexFileSorter;

namespace RegexFileSorterWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ApplicationExit += Application_ApplicationExit;
            ProfileManager.Load();

            Application.Run(new FormMain());
        }

        private static void Application_ApplicationExit(object? sender, EventArgs e)
        {
            ProfileManager.Save();
        }
    }
}