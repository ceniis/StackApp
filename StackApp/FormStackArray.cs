﻿using System;
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
            StackArray.StackSize = (int)numericUpDown2.Value; 
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            int element = checkBox1.Checked ? new Random().Next(0, 10) : (int)numericUpDown1.Value; 
            StackArray.InsertTopElement(element);
            labelElements.Text = StackArray.NumberOfElements();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            StackArray.DeleteTopElement();
            labelElements.Text = StackArray.NumberOfElements();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            node.btnPeek_Click(sender, e, dataGridView1);
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            StackArray.ClearsStack();
            MessageBox.Show("Stack is empty", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelElements.Text = StackArray.NumberOfElements();
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
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    List<int> numbers = new List<int>();

                    foreach (string line in lines)
                    {
                        if (int.TryParse(line.Trim(), out int number))
                        {
                            numbers.Add(number);
                        }
                        else
                        {
                            MessageBox.Show($"Invalid number skipped: {line}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // Display in DataGridView
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("Elements", "Elements");

                    foreach (int num in numbers)
                    {
                        dataGridView1.Rows.Add(num);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            this.Hide();
            node.Show();
        }
    }
}
