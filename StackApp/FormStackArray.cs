using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackApp
{
    public partial class FormStackArray : Form
    {
        public FormStackArray()
        {
            InitializeComponent();
        }
        
        FormStackNode node = new FormStackNode();

        private void FormStackArray_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data",
                HeaderText = "Element",
                Name = "colElement",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = Color.Black,
                    BackColor = Color.White
                },
                HeaderCell = {
                    Style = new DataGridViewCellStyle
                    {
                        Font = new Font("Century Gothic", 12F, FontStyle.Regular),
                        ForeColor = Color.Black,
                        BackColor = Color.LightGray
                    }
                }
            };

            dataGridView1.Columns.Add(dataColumn);

            // Bind your data source
            // dataGridView1.DataSource = myStack.Nodes;

            // Update the label
            labelElements.Text = StackArray.NumberOfElements();
            StackArray.StackSize = 10; 
        }

        private void btnPush_Click(object sender, EventArgs e)
        {

        }

        private void btnPop_Click(object sender, EventArgs e)
        {

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {

        }

        private void btnFree_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            node.btnFile_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            node.btnHelp_Click(sender, e);
        }

        private void btnNodeStack_Click(object sender, EventArgs e)
        {
            node.Show();
            this.Hide();
        }
    }
}
