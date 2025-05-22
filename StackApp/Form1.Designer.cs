namespace StackApp
{
    partial class StakForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StakForm));
            dataGridView1 = new DataGridView();
            elements = new Label();
            groupBox1 = new GroupBox();
            btnPop = new Button();
            btnPush = new Button();
            btnPeek = new Button();
            btnFree = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 46);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(185, 167);
            dataGridView1.TabIndex = 0;
            // 
            // elements
            // 
            elements.AutoSize = true;
            elements.ForeColor = SystemColors.ControlLight;
            elements.Location = new Point(13, 19);
            elements.Margin = new Padding(4, 0, 4, 0);
            elements.Name = "elements";
            elements.Size = new Size(201, 21);
            elements.TabIndex = 1;
            elements.Text = "0 elements in the stack";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFree);
            groupBox1.Controls.Add(btnPeek);
            groupBox1.Controls.Add(btnPush);
            groupBox1.Controls.Add(btnPop);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(236, 19);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(284, 134);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Controls:";
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
            btnHelp.Location = new Point(236, 174);
            btnHelp.Margin = new Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(284, 39);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // StakForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 42, 42);
            ClientSize = new Size(538, 226);
            Controls.Add(btnHelp);
            Controls.Add(groupBox1);
            Controls.Add(elements);
            Controls.Add(dataGridView1);
            Font = new Font("Century Gothic", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StakForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stack";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label elements;
        private GroupBox groupBox1;
        private Button btnFree;
        private Button btnPeek;
        private Button btnPush;
        private Button btnPop;
        private Button btnHelp;
    }
}
