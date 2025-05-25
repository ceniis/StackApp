using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
   public static class FileManager
    {
        public static List<int> ReadIntegersFromFile(string fileName, Action<string>? warningCallback = null)
        {
            List<int> numbers = new List<int>();

            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("File not found!", fileName);
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                if (int.TryParse(line.Trim(), out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    warningCallback?.Invoke(line);
                }
            }

            return numbers;
        }

        public static void SaveToFile(string fileName, DataGridView dataGridView)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the blank row at the end
                        if (row.Cells["colElement"].Value is int value)
                        {
                            writer.WriteLine(value);
                        }
                    }
                }

                MessageBox.Show("Stack saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
