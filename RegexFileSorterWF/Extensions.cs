using RegexFileSorterWF.Properties;
using System.Reflection;

namespace RegexFileSorterWF
{
    internal static class Extensions
    {
        public static void AddStyleDataBindigs(this Form form)
        {
            form.DataBindings.Add("Font", Settings.Default, "Font", true, DataSourceUpdateMode.OnPropertyChanged);
            form.DataBindings.Add("ForeColor", Settings.Default, "ForeColor", true, DataSourceUpdateMode.OnPropertyChanged);
            form.DataBindings.Add("BackColor", Settings.Default, "BackColor", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static DialogResult AskYesNo(this Form form, string text, string caption)
        {
            return MessageBox.Show(form, text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult AskYesNoCancel(this Form form, string text, string caption)
        {
            return MessageBox.Show(form, text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
        }

        public static void DoubleBuferred(this Control control) => DoubleBuferred(control, true);

        public static void DoubleBuferred(this Control control, bool state)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property?.SetValue(control, state, null);
        }
    }
}