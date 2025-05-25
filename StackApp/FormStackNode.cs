using StackApp;
using System.Windows.Forms;
namespace StackApp
{
    public partial class FormStackNode : Form
    {
        private Stack myStack = new Stack();

        public FormStackNode()
        {
            InitializeComponent();
        }

        private void FormStack_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Clear();
            DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data", // This must match the property name in StackNode
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
            dataGridView1.DataSource = myStack.Nodes;

            // Update the label
            labelElements.Text = $"There're {myStack.Count} element(s).";
        }

        public void HighlightTopRow(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.ClearSelection();
                var row = dataGridView.Rows[0];
                row.Selected = true;
            }
        }

        public void btnHelp_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {

            int element = checkBox1.Checked ? new Random().Next(0, 10) : (int)numericUpDown1.Value;
            myStack.Push(element);
            labelElements.Text = $"There're {myStack.Count} element(s).";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                myStack.Pop();
                labelElements.Text = $"There're {myStack.Count} element(s).";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnPeek_Click(object sender, EventArgs e, DataGridView dataGridView)
        {
            try
            {
                HighlightTopRow(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            myStack.FreeStack();
            MessageBox.Show("Stack is empty", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labelElements.Text = $"There're {myStack.Count} element(s).";
        }

        public void LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("File not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (int.TryParse(line.Trim(), out int number))
                {
                    myStack.Push(number); // Add to stack
                }
                else
                {
                    MessageBox.Show($"Invalid line in file: \"{line}\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    openFileDialog.Title = "Select a file to load";


                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        myStack.FreeStack();
                        LoadFromFile(openFileDialog.FileName);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = myStack.Nodes;
                        labelElements.Text = $"There're {myStack.Count} element(s).";
                        dataGridView1.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading file: " + ex.Message);
            }
        }

        private void btnArrayStack_Click(object sender, EventArgs e)
        {
            FormStackArray array = new FormStackArray();
            array.Show();
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            HighlightTopRow(dataGridView1);
        }
    }
}