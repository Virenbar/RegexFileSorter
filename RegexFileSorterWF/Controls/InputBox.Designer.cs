namespace RegexFileSorterWF.Controls
{
    partial class InputBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_Value = new TextBox();
            B_OK = new Button();
            B_Cancel = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            L_Header = new Label();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TB_Value
            // 
            TB_Value.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Value.Location = new Point(6, 21);
            TB_Value.Name = "TB_Value";
            TB_Value.Size = new Size(332, 23);
            TB_Value.TabIndex = 0;
            // 
            // B_OK
            // 
            B_OK.AutoSize = true;
            B_OK.Location = new Point(3, 3);
            B_OK.Name = "B_OK";
            B_OK.Size = new Size(75, 25);
            B_OK.TabIndex = 1;
            B_OK.Text = "OK";
            B_OK.UseVisualStyleBackColor = true;
            B_OK.Click += B_OK_Click;
            // 
            // B_Cancel
            // 
            B_Cancel.AutoSize = true;
            B_Cancel.Location = new Point(84, 3);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new Size(75, 25);
            B_Cancel.TabIndex = 1;
            B_Cancel.Text = "Cancel";
            B_Cancel.UseVisualStyleBackColor = true;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(B_OK);
            flowLayoutPanel1.Controls.Add(B_Cancel);
            flowLayoutPanel1.Location = new Point(176, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(162, 31);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(L_Header, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Controls.Add(TB_Value, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(344, 111);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // L_Header
            // 
            L_Header.Anchor = AnchorStyles.Top;
            L_Header.AutoSize = true;
            L_Header.Location = new Point(154, 3);
            L_Header.Name = "L_Header";
            L_Header.Size = new Size(35, 15);
            L_Header.TabIndex = 0;
            L_Header.Text = "Input";
            // 
            // InputBox
            // 
            AcceptButton = B_OK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = B_Cancel;
            ClientSize = new Size(344, 111);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(360, 150);
            Name = "InputBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Text input";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TB_Value;
        private Button B_OK;
        private Button B_Cancel;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label L_Header;
    }
}