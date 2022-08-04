using System.Reflection;

namespace RegexFileSorterWF
{
    internal static class Extensions
    {
        public static DialogResult AskYesNo(this Form form, string text, string header)
        {
            return MessageBox.Show(form, text, header, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static void DoubleBuferred(this Control control) => DoubleBuferred(control, true);

        public static void DoubleBuferred(this Control control, bool state)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property?.SetValue(control, state, null);
        }
    }
}