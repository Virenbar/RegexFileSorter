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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Sort = new System.Windows.Forms.Button();
            this.L_Count = new System.Windows.Forms.Label();
            this.B_Move = new System.Windows.Forms.Button();
            this.LV_Unsorted = new System.Windows.Forms.ListView();
            this.LV_Sorted = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.B_Open = new System.Windows.Forms.Button();
            this.B_Copy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BS_Config = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TB_Source = new RegexFileSorterWF.Controls.TextBoxFolder();
            this.TB_Destination = new RegexFileSorterWF.Controls.TextBoxFolder();
            this.B_SelectS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.B_SelectD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MI_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Load = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Config)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LV_Unsorted, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LV_Sorted, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(969, 326);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.B_Sort);
            this.flowLayoutPanel1.Controls.Add(this.L_Count);
            this.flowLayoutPanel1.Controls.Add(this.B_Move);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(726, 290);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // B_Sort
            // 
            this.B_Sort.AutoSize = true;
            this.B_Sort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Sort.Image = global::RegexFileSorterWF.Icons8.Synchronize16;
            this.B_Sort.Location = new System.Drawing.Point(3, 3);
            this.B_Sort.Name = "B_Sort";
            this.B_Sort.Padding = new System.Windows.Forms.Padding(1);
            this.B_Sort.Size = new System.Drawing.Size(80, 27);
            this.B_Sort.TabIndex = 0;
            this.B_Sort.Text = "Sort files";
            this.B_Sort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Sort.UseVisualStyleBackColor = true;
            this.B_Sort.Click += new System.EventHandler(this.B_Sort_Click);
            // 
            // L_Count
            // 
            this.L_Count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_Count.AutoSize = true;
            this.L_Count.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_Count.Location = new System.Drawing.Point(89, 8);
            this.L_Count.Name = "L_Count";
            this.L_Count.Size = new System.Drawing.Size(51, 17);
            this.L_Count.TabIndex = 3;
            this.L_Count.Text = "Files: 0";
            // 
            // B_Move
            // 
            this.B_Move.AutoSize = true;
            this.B_Move.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Move.Image = global::RegexFileSorterWF.Icons8.Ok16;
            this.B_Move.Location = new System.Drawing.Point(146, 3);
            this.B_Move.Name = "B_Move";
            this.B_Move.Padding = new System.Windows.Forms.Padding(1);
            this.B_Move.Size = new System.Drawing.Size(91, 27);
            this.B_Move.TabIndex = 0;
            this.B_Move.Text = "Move Files";
            this.B_Move.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_Move.UseVisualStyleBackColor = true;
            this.B_Move.Click += new System.EventHandler(this.B_Move_Click);
            // 
            // LV_Unsorted
            // 
            this.LV_Unsorted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Unsorted.GridLines = true;
            this.LV_Unsorted.Location = new System.Drawing.Point(3, 20);
            this.LV_Unsorted.Name = "LV_Unsorted";
            this.LV_Unsorted.Size = new System.Drawing.Size(478, 264);
            this.LV_Unsorted.TabIndex = 2;
            this.LV_Unsorted.UseCompatibleStateImageBehavior = false;
            this.LV_Unsorted.View = System.Windows.Forms.View.Details;
            this.LV_Unsorted.GroupTaskLinkClick += new System.EventHandler<System.Windows.Forms.ListViewGroupEventArgs>(this.LV_Unsorted_GroupTaskLinkClick);
            this.LV_Unsorted.ItemActivate += new System.EventHandler(this.LV_Unsorted_ItemActivate);
            // 
            // LV_Sorted
            // 
            this.LV_Sorted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_Sorted.GridLines = true;
            this.LV_Sorted.Location = new System.Drawing.Point(487, 20);
            this.LV_Sorted.MultiSelect = false;
            this.LV_Sorted.Name = "LV_Sorted";
            this.LV_Sorted.Size = new System.Drawing.Size(479, 264);
            this.LV_Sorted.TabIndex = 2;
            this.LV_Sorted.UseCompatibleStateImageBehavior = false;
            this.LV_Sorted.View = System.Windows.Forms.View.Details;
            this.LV_Sorted.GroupTaskLinkClick += new System.EventHandler<System.Windows.Forms.ListViewGroupEventArgs>(this.LV_Sorted_GroupTaskLinkClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.B_Open);
            this.flowLayoutPanel2.Controls.Add(this.B_Copy);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 290);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(164, 33);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // B_Open
            // 
            this.B_Open.AutoSize = true;
            this.B_Open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Open.Location = new System.Drawing.Point(3, 3);
            this.B_Open.Name = "B_Open";
            this.B_Open.Padding = new System.Windows.Forms.Padding(1);
            this.B_Open.Size = new System.Drawing.Size(69, 27);
            this.B_Open.TabIndex = 0;
            this.B_Open.Text = "Open File";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // B_Copy
            // 
            this.B_Copy.AutoSize = true;
            this.B_Copy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_Copy.Location = new System.Drawing.Point(78, 3);
            this.B_Copy.Name = "B_Copy";
            this.B_Copy.Padding = new System.Windows.Forms.Padding(1);
            this.B_Copy.Size = new System.Drawing.Size(83, 27);
            this.B_Copy.TabIndex = 0;
            this.B_Copy.Text = "Copy Group";
            this.B_Copy.UseVisualStyleBackColor = true;
            this.B_Copy.Click += new System.EventHandler(this.B_Copy_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(195, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unsorted files";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(687, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sorted files";
            // 
            // BS_Config
            // 
            this.BS_Config.DataSource = typeof(RegexFileSorter.Profile);
            this.BS_Config.CurrentItemChanged += new System.EventHandler(this.BS_Config_CurrentItemChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 21);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.TB_Source, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TB_Destination, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.B_SelectS, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.B_SelectD, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(969, 126);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.checkBox2);
            this.flowLayoutPanel3.Controls.Add(this.checkBox3);
            this.flowLayoutPanel3.Controls.Add(this.checkBox1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(86, 98);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(369, 25);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BS_Config, "InPlace", true));
            this.checkBox2.Location = new System.Drawing.Point(3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sort in source folder";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BS_Config, "CreateNew", true));
            this.checkBox3.Location = new System.Drawing.Point(141, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(124, 19);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Create new folders";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.BS_Config, "SearchFolder", true));
            this.checkBox1.Location = new System.Drawing.Point(271, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Search folder";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Config, "Regex", true));
            this.textBox1.Location = new System.Drawing.Point(86, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(774, 23);
            this.textBox1.TabIndex = 5;
            // 
            // TB_Source
            // 
            this.TB_Source.AllowDrop = true;
            this.TB_Source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Source.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Config, "SFolder", true));
            this.TB_Source.Location = new System.Drawing.Point(86, 5);
            this.TB_Source.Name = "TB_Source";
            this.TB_Source.Size = new System.Drawing.Size(774, 23);
            this.TB_Source.TabIndex = 1;
            // 
            // TB_Destination
            // 
            this.TB_Destination.AllowDrop = true;
            this.TB_Destination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Destination.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BS_Config, "DFolder", true));
            this.TB_Destination.Location = new System.Drawing.Point(86, 38);
            this.TB_Destination.Name = "TB_Destination";
            this.TB_Destination.Size = new System.Drawing.Size(774, 23);
            this.TB_Destination.TabIndex = 1;
            // 
            // B_SelectS
            // 
            this.B_SelectS.AutoSize = true;
            this.B_SelectS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_SelectS.Image = global::RegexFileSorterWF.Icons8.OpenedFolder16;
            this.B_SelectS.Location = new System.Drawing.Point(866, 3);
            this.B_SelectS.Name = "B_SelectS";
            this.B_SelectS.Padding = new System.Windows.Forms.Padding(1);
            this.B_SelectS.Size = new System.Drawing.Size(100, 27);
            this.B_SelectS.TabIndex = 2;
            this.B_SelectS.Text = "Select folder";
            this.B_SelectS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_SelectS.UseVisualStyleBackColor = true;
            this.B_SelectS.Click += new System.EventHandler(this.B_SelectS_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source folder";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // B_SelectD
            // 
            this.B_SelectD.AutoSize = true;
            this.B_SelectD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.B_SelectD.Image = global::RegexFileSorterWF.Icons8.OpenedFolder16;
            this.B_SelectD.Location = new System.Drawing.Point(866, 36);
            this.B_SelectD.Name = "B_SelectD";
            this.B_SelectD.Padding = new System.Windows.Forms.Padding(1);
            this.B_SelectD.Size = new System.Drawing.Size(100, 27);
            this.B_SelectD.TabIndex = 2;
            this.B_SelectD.Text = "Select folder";
            this.B_SelectD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.B_SelectD.UseVisualStyleBackColor = true;
            this.B_SelectD.Click += new System.EventHandler(this.B_SelectD_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "RegEx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(969, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Save,
            this.MI_Load,
            this.MI_Delete});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton1.Text = "Profiles";
            // 
            // MI_Save
            // 
            this.MI_Save.Name = "MI_Save";
            this.MI_Save.Size = new System.Drawing.Size(107, 22);
            this.MI_Save.Text = "Save";
            this.MI_Save.Click += new System.EventHandler(this.MI_Save_Click);
            // 
            // MI_Load
            // 
            this.MI_Load.Name = "MI_Load";
            this.MI_Load.Size = new System.Drawing.Size(107, 22);
            this.MI_Load.Text = "Load";
            // 
            // MI_Delete
            // 
            this.MI_Delete.Name = "MI_Delete";
            this.MI_Delete.Size = new System.Drawing.Size(107, 22);
            this.MI_Delete.Text = "Delete";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(969, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "Тут могла быть ваша реклама";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BS_Config)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView LV_Unsorted;
        private ListView LV_Sorted;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button B_Open;
        private Button B_Copy;
        private Button B_Move;
        private BindingSource BS_Config;
        private Panel panel1;
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
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox textBox1;
        private Label label5;
        private Button B_Sort;
        private Label L_Count;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
    }
}