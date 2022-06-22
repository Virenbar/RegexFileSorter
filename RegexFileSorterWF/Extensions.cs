namespace RegexFileSorterWF
{
    internal static class Extensions
    {
        public static DialogResult AskYesNo(this Form form, string text, string header)
        {
            return MessageBox.Show(form, text, header, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}