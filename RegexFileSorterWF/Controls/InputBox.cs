namespace RegexFileSorterWF.Controls
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
            BackColor = Constants.BackColor;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string Value { get => TB_Value.Text; set => TB_Value.Text = value; }
        public string Header { get => L_Header.Text; set => L_Header.Text = value; }
    }
}