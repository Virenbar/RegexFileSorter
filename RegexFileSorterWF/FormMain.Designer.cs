namespace RegexFileSorterWF
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            B_Move = new Button();
            TV_Unsorted = new TreeView();
            CMS_Tree = new ContextMenuStrip(components);
            MI_CopyName = new ToolStripMenuItem();
            MI_OpenFolder = new ToolStripMenuItem();
            TV_Sorted = new TreeView();
            L_CountUnsorted = new Label();
            L_CountSorted = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            B_Sort = new Button();
            BS_Config = new BindingSource(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            TB_Source = new Controls.TextBoxFolder();
            TB_Destination = new Controls.TextBoxFolder();
            B_SelectS = new Button();
            label1 = new Label();
            label2 = new Label();
            B_SelectD = new Button();
            label7 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            MI_Save = new ToolStripMenuItem();
            MI_Load = new ToolStripMenuItem();
            MI_Delete = new ToolStripMenuItem();
            B_About = new ToolStripButton();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            CMS_Tree.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BS_Config).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 2);
            tableLayoutPanel1.Controls.Add(TV_Unsorted, 0, 1);
            tableLayoutPanel1.Controls.Add(TV_Sorted, 1, 1);
            tableLayoutPanel1.Controls.Add(L_CountUnsorted, 0, 0);
            tableLayoutPanel1.Controls.Add(L_CountSorted, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 151);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(997, 472);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(B_Move);
            flowLayoutPanel1.Location = new Point(699, 436);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(97, 33);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // B_Move
            // 
            B_Move.AutoSize = true;
            B_Move.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_Move.Enabled = false;
            B_Move.Image = Icons8.Ok16;
            B_Move.Location = new Point(3, 3);
            B_Move.Name = "B_Move";
            B_Move.Padding = new Padding(1);
            B_Move.Size = new Size(91, 27);
            B_Move.TabIndex = 0;
            B_Move.Text = "Move Files";
            B_Move.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Move.UseVisualStyleBackColor = true;
            B_Move.Click += B_Move_Click;
            // 
            // TV_Unsorted
            // 
            TV_Unsorted.ContextMenuStrip = CMS_Tree;
            TV_Unsorted.Dock = DockStyle.Fill;
            TV_Unsorted.Location = new Point(3, 20);
            TV_Unsorted.Name = "TV_Unsorted";
            TV_Unsorted.Size = new Size(492, 410);
            TV_Unsorted.TabIndex = 5;
            TV_Unsorted.AfterSelect += TV_Unsorted_AfterSelect;
            TV_Unsorted.MouseDown += TV_MouseDown;
            // 
            // CMS_Tree
            // 
            CMS_Tree.Items.AddRange(new ToolStripItem[] { MI_CopyName, MI_OpenFolder });
            CMS_Tree.Name = "contextMenuStrip1";
            CMS_Tree.Size = new Size(171, 48);
            // 
            // MI_CopyName
            // 
            MI_CopyName.Image = Icons8.CopyToClipboard16;
            MI_CopyName.Name = "MI_CopyName";
            MI_CopyName.Size = new Size(170, 22);
            MI_CopyName.Text = "Copy group name";
            MI_CopyName.Click += MI_CopyName_Click;
            // 
            // MI_OpenFolder
            // 
            MI_OpenFolder.Image = Icons8.OpenedFolder16;
            MI_OpenFolder.Name = "MI_OpenFolder";
            MI_OpenFolder.Size = new Size(170, 22);
            MI_OpenFolder.Text = "Open folder";
            MI_OpenFolder.Click += MI_OpenFolder_Click;
            // 
            // TV_Sorted
            // 
            TV_Sorted.ContextMenuStrip = CMS_Tree;
            TV_Sorted.Dock = DockStyle.Fill;
            TV_Sorted.Location = new Point(501, 20);
            TV_Sorted.Name = "TV_Sorted";
            TV_Sorted.Size = new Size(493, 410);
            TV_Sorted.TabIndex = 5;
            TV_Sorted.AfterSelect += TV_Sorted_AfterSelect;
            TV_Sorted.MouseDown += TV_MouseDown;
            // 
            // L_CountUnsorted
            // 
            L_CountUnsorted.Anchor = AnchorStyles.None;
            L_CountUnsorted.AutoSize = true;
            L_CountUnsorted.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            L_CountUnsorted.Location = new Point(192, 0);
            L_CountUnsorted.Name = "L_CountUnsorted";
            L_CountUnsorted.Size = new Size(114, 17);
            L_CountUnsorted.TabIndex = 3;
            L_CountUnsorted.Text = "Unsorted files - 0";
            // 
            // L_CountSorted
            // 
            L_CountSorted.Anchor = AnchorStyles.None;
            L_CountSorted.AutoSize = true;
            L_CountSorted.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            L_CountSorted.Location = new Point(698, 0);
            L_CountSorted.Name = "L_CountSorted";
            L_CountSorted.Size = new Size(98, 17);
            L_CountSorted.TabIndex = 3;
            L_CountSorted.Text = "Sorted files - 0";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(B_Sort);
            flowLayoutPanel2.Location = new Point(206, 436);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(86, 33);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // B_Sort
            // 
            B_Sort.AutoSize = true;
            B_Sort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_Sort.Image = Icons8.Synchronize16;
            B_Sort.Location = new Point(3, 3);
            B_Sort.Name = "B_Sort";
            B_Sort.Padding = new Padding(1);
            B_Sort.Size = new Size(80, 27);
            B_Sort.TabIndex = 0;
            B_Sort.Text = "Sort files";
            B_Sort.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_Sort.UseVisualStyleBackColor = true;
            B_Sort.Click += B_Sort_Click;
            // 
            // BS_Config
            // 
            BS_Config.DataSource = typeof(RegexFileSorter.Profile);
            BS_Config.CurrentItemChanged += BS_Config_CurrentItemChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel2.Controls.Add(TB_Source, 1, 0);
            tableLayoutPanel2.Controls.Add(TB_Destination, 1, 1);
            tableLayoutPanel2.Controls.Add(B_SelectS, 2, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(B_SelectD, 2, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel3, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(997, 126);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel4.Controls.Add(textBox3, 2, 0);
            tableLayoutPanel4.Controls.Add(label6, 1, 0);
            tableLayoutPanel4.Location = new Point(83, 66);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(808, 29);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", BS_Config, "Pattern", true));
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(357, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", BS_Config, "Replacement", true));
            textBox3.Location = new Point(448, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(357, 23);
            textBox3.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(366, 7);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 3;
            label6.Text = "Replacement";
            // 
            // TB_Source
            // 
            TB_Source.AllowDrop = true;
            TB_Source.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_Source.DataBindings.Add(new Binding("Text", BS_Config, "SourceFolder", true, DataSourceUpdateMode.OnPropertyChanged));
            TB_Source.Location = new Point(86, 5);
            TB_Source.Name = "TB_Source";
            TB_Source.Size = new Size(802, 23);
            TB_Source.TabIndex = 1;
            // 
            // TB_Destination
            // 
            TB_Destination.AllowDrop = true;
            TB_Destination.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_Destination.DataBindings.Add(new Binding("Text", BS_Config, "TargetFolder", true, DataSourceUpdateMode.OnPropertyChanged));
            TB_Destination.Location = new Point(86, 38);
            TB_Destination.Name = "TB_Destination";
            TB_Destination.Size = new Size(802, 23);
            TB_Destination.TabIndex = 1;
            // 
            // B_SelectS
            // 
            B_SelectS.AutoSize = true;
            B_SelectS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_SelectS.Image = Icons8.OpenedFolder16;
            B_SelectS.Location = new Point(894, 3);
            B_SelectS.Name = "B_SelectS";
            B_SelectS.Padding = new Padding(1);
            B_SelectS.Size = new Size(100, 27);
            B_SelectS.TabIndex = 2;
            B_SelectS.Text = "Select folder";
            B_SelectS.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_SelectS.UseVisualStyleBackColor = true;
            B_SelectS.Click += B_SelectS_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Source folder";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(7, 42);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Target folder";
            // 
            // B_SelectD
            // 
            B_SelectD.AutoSize = true;
            B_SelectD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            B_SelectD.Image = Icons8.OpenedFolder16;
            B_SelectD.Location = new Point(894, 36);
            B_SelectD.Name = "B_SelectD";
            B_SelectD.Padding = new Padding(1);
            B_SelectD.Size = new Size(100, 27);
            B_SelectD.TabIndex = 2;
            B_SelectD.Text = "Select folder";
            B_SelectD.TextImageRelation = TextImageRelation.ImageBeforeText;
            B_SelectD.UseVisualStyleBackColor = true;
            B_SelectD.Click += B_SelectD_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(35, 73);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 3;
            label7.Text = "Pattern";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(checkBox2);
            flowLayoutPanel3.Controls.Add(checkBox3);
            flowLayoutPanel3.Controls.Add(checkBox1);
            flowLayoutPanel3.Location = new Point(86, 98);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(369, 25);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.DataBindings.Add(new Binding("Checked", BS_Config, "InPlace", true));
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(132, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Sort in source folder";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.DataBindings.Add(new Binding("Checked", BS_Config, "CreateNew", true));
            checkBox3.Location = new Point(141, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(124, 19);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "Create new folders";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Checked", BS_Config, "SearchFolder", true));
            checkBox1.Location = new Point(271, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Search folder";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, B_About });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(997, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "l";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { MI_Save, MI_Load, MI_Delete });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(59, 22);
            toolStripDropDownButton1.Text = "Profiles";
            // 
            // MI_Save
            // 
            MI_Save.Image = Icons8.Save16;
            MI_Save.Name = "MI_Save";
            MI_Save.Size = new Size(107, 22);
            MI_Save.Text = "Save";
            MI_Save.Click += MI_Save_Click;
            // 
            // MI_Load
            // 
            MI_Load.Name = "MI_Load";
            MI_Load.Size = new Size(107, 22);
            MI_Load.Text = "Load";
            // 
            // MI_Delete
            // 
            MI_Delete.Name = "MI_Delete";
            MI_Delete.Size = new Size(107, 22);
            MI_Delete.Text = "Delete";
            // 
            // B_About
            // 
            B_About.Alignment = ToolStripItemAlignment.Right;
            B_About.Image = Icons8.Info16;
            B_About.ImageTransparentColor = Color.Magenta;
            B_About.Name = "B_About";
            B_About.Size = new Size(60, 22);
            B_About.Text = "About";
            B_About.Click += B_About_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 623);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(500, 500);
            Name = "FormMain";
            Text = "RegexFileSorter";
            Load += FormMain_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            CMS_Tree.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BS_Config).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button B_Move;
        private BindingSource BS_Config;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem MI_Load;
        private ToolStripMenuItem MI_Save;
        private ToolStripMenuItem MI_Delete;
        private TableLayoutPanel tableLayoutPanel2;
        private Controls.TextBoxFolder TB_Source;
        private Controls.TextBoxFolder TB_Destination;
        private Button B_SelectS;
        private Label label1;
        private Label label2;
        private Button B_SelectD;
        private Label L_CountUnsorted;
        private Label L_CountSorted;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button B_Sort;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private ToolStripButton B_About;
        private TreeView TV_Sorted;
        private TreeView TV_Unsorted;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox3;
        private Label label6;
        private Label label7;
        private ContextMenuStrip CMS_Tree;
        private ToolStripMenuItem MI_CopyName;
        private ToolStripMenuItem MI_OpenFolder;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}