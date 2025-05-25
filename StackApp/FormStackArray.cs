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

            // Update the label
            labelElements.Text = $"There're {StackArray.NumberOfElements()} element(s).";
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            try
            {
                int element = checkBox1.Checked ? new Random().Next(0, 10) : (int)numericUpDown1.Value;
                StackArray.InsertTopElement(element);
                labelElements.Text = $"There're {StackArray.NumberOfElements()} element(s).";
                UpdateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                StackArray.DeleteTopElement();
                labelElements.Text = $"There're {StackArray.NumberOfElements()} element(s).";
                UpdateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            node.btnPeek_Click(sender, e, dataGridView1);
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            StackArray.ClearsStack();
            MessageBox.Show("Stack is empty", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelElements.Text = $"There're {StackArray.NumberOfElements()} element(s).";
            UpdateGrid();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a text file with integers";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var numbers = FileManager.ReadIntegersFromFile(openFileDialog.FileName, line =>
                        MessageBox.Show($"Invalid number skipped: {line}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning));

                    StackArray.ClearsStack();

                    foreach (var num in numbers)
                        StackArray.InsertTopElement(num);

                    UpdateGrid();
                    labelElements.Text = $"There're {StackArray.NumberOfElements()} element(s).";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Stack to File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileManager.SaveToFile(saveFileDialog.FileName, dataGridView1);
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            node.btnHelp_Click(sender, e);
        }

        private void btnNodeStack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StackArray.GetStackItems();
        }
    }
}
