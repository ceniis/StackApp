namespace StackApp
{
    partial class FormStackNode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStackNode));
            dataGridView1 = new DataGridView();
            labelElements = new Label();
            groupBox1 = new GroupBox();
            btnFree = new Button();
            btnPeek = new Button();
            btnPush = new Button();
            btnPop = new Button();
            btnHelp = new Button();
            btnRead = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            checkBox1 = new CheckBox();
            btnSave = new Button();
            btnArrayStack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 43);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(201, 288);
            dataGridView1.TabIndex = 0;
            // 
            // labelElements
            // 
            labelElements.AutoSize = true;
            labelElements.ForeColor = SystemColors.ControlLight;
            labelElements.Location = new Point(13, 16);
            labelElements.Margin = new Padding(4, 0, 4, 0);
            labelElements.Name = "labelElements";
            labelElements.Size = new Size(201, 21);
            labelElements.TabIndex = 1;
            labelElements.Text = "0 elements in the stack";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFree);
            groupBox1.Controls.Add(btnPeek);
            groupBox1.Controls.Add(btnPush);
            groupBox1.Controls.Add(btnPop);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(234, 78);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(284, 134);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls:";
            // 
            // btnFree
            // 
            btnFree.BackColor = Color.FromArgb(65, 65, 65);
            btnFree.Cursor = Cursors.Hand;
            btnFree.FlatAppearance.BorderColor = Color.LightGray;
            btnFree.FlatAppearance.BorderSize = 2;
            btnFree.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnFree.FlatStyle = FlatStyle.Flat;
            btnFree.Location = new Point(145, 72);
            btnFree.Margin = new Padding(4, 3, 4, 3);
            btnFree.Name = "btnFree";
            btnFree.Size = new Size(118, 39);
            btnFree.TabIndex = 3;
            btnFree.Text = "Free";
            btnFree.UseVisualStyleBackColor = false;
            btnFree.Click += btnFree_Click;
            // 
            // btnPeek
            // 
            btnPeek.BackColor = Color.FromArgb(65, 65, 65);
            btnPeek.Cursor = Cursors.Hand;
            btnPeek.FlatAppearance.BorderColor = Color.LightGray;
            btnPeek.FlatAppearance.BorderSize = 2;
            btnPeek.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnPeek.FlatStyle = FlatStyle.Flat;
            btnPeek.Location = new Point(20, 72);
            btnPeek.Margin = new Padding(4, 3, 4, 3);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(118, 39);
            btnPeek.TabIndex = 2;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = false;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPush
            // 
            btnPush.BackColor = Color.FromArgb(65, 65, 65);
            btnPush.Cursor = Cursors.Hand;
            btnPush.FlatAppearance.BorderColor = Color.LightGray;
            btnPush.FlatAppearance.BorderSize = 2;
            btnPush.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnPush.FlatStyle = FlatStyle.Flat;
            btnPush.Location = new Point(20, 27);
            btnPush.Margin = new Padding(4, 3, 4, 3);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(118, 39);
            btnPush.TabIndex = 1;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = false;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.BackColor = Color.FromArgb(65, 65, 65);
            btnPop.Cursor = Cursors.Hand;
            btnPop.FlatAppearance.BorderColor = Color.LightGray;
            btnPop.FlatAppearance.BorderSize = 2;
            btnPop.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnPop.FlatStyle = FlatStyle.Flat;
            btnPop.Location = new Point(145, 27);
            btnPop.Margin = new Padding(4, 3, 4, 3);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(118, 39);
            btnPop.TabIndex = 0;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = false;
            btnPop.Click += btnPop_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.FromArgb(85, 85, 85);
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.FlatAppearance.BorderColor = Color.LightGray;
            btnHelp.FlatAppearance.BorderSize = 2;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = SystemColors.ControlLight;
            btnHelp.Location = new Point(379, 292);
            btnHelp.Margin = new Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(138, 39);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.FromArgb(85, 85, 85);
            btnRead.Cursor = Cursors.Hand;
            btnRead.FlatAppearance.BorderColor = Color.LightGray;
            btnRead.FlatAppearance.BorderSize = 2;
            btnRead.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnRead.FlatStyle = FlatStyle.Flat;
            btnRead.ForeColor = SystemColors.ControlLight;
            btnRead.Location = new Point(234, 233);
            btnRead.Margin = new Padding(4, 3, 4, 3);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(138, 39);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read from file";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(42, 42, 42);
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.ForeColor = SystemColors.ControlLight;
            numericUpDown1.Location = new Point(398, 9);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(119, 28);
            numericUpDown1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(234, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 7;
            label1.Text = "Enter an element:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.ForeColor = SystemColors.ControlLight;
            checkBox1.Location = new Point(234, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(296, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Generate an element randomly ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(85, 85, 85);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.LightGray;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = SystemColors.ControlLight;
            btnSave.Location = new Point(381, 233);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 39);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save in file";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnArrayStack
            // 
            btnArrayStack.BackColor = SystemColors.ControlLight;
            btnArrayStack.Cursor = Cursors.Hand;
            btnArrayStack.FlatAppearance.BorderColor = Color.White;
            btnArrayStack.FlatAppearance.BorderSize = 2;
            btnArrayStack.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnArrayStack.FlatStyle = FlatStyle.Flat;
            btnArrayStack.ForeColor = Color.FromArgb(65, 65, 65);
            btnArrayStack.Location = new Point(234, 292);
            btnArrayStack.Margin = new Padding(4, 3, 4, 3);
            btnArrayStack.Name = "btnArrayStack";
            btnArrayStack.Size = new Size(138, 39);
            btnArrayStack.TabIndex = 10;
            btnArrayStack.Text = "Array stack";
            btnArrayStack.UseVisualStyleBackColor = false;
            btnArrayStack.Click += btnArrayStack_Click;
            // 
            // FormStackNode
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(532, 343);
            Controls.Add(btnArrayStack);
            Controls.Add(btnSave);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnHelp);
            Controls.Add(btnRead);
            Controls.Add(groupBox1);
            Controls.Add(labelElements);
            Controls.Add(dataGridView1);
            Font = new Font("Century Gothic", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormStackNode";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stack Node";
            Load += FormStack_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label labelElements;
        private GroupBox groupBox1;
        private Button btnFree;
        private Button btnPeek;
        private Button btnPush;
        private Button btnPop;
        private Button btnHelp;
        private Button btnRead;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private CheckBox checkBox1;
        private Button btnSave;
        private Button btnArrayStack;
    }
}
