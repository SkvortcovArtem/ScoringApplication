using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;

namespace CreditScoringApp
{
    internal class SupportClass
    {
        public string GetPythonPath(string filename)
        {
            string path1 = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path2 = "PythonApplication1";
            string directory = Path.Combine(path1, path2, filename);
            directory = directory.Replace(@"\", @"\\");
            return directory;
        }

        public void SaveDataToCSV(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                bool fileError = false;
                try
                {
                    File.Delete(GetPythonPath("bankdata.csv"));
                }
                catch (IOException ex)
                {
                    fileError = true;
                    MessageBox.Show("Невозможно обратиться к файлам." + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            if (i != columnCount - 1)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ";";
                            }
                            else
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString();
                            }

                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                if (j != columnCount - 1)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                                else
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString();
                                }
                            }
                        }

                        File.WriteAllLines(GetPythonPath("bankdata.csv"), outputCsv, Encoding.UTF8);
                        MessageBox.Show("Обучение модели начато, не закрывайте форму до его окончания.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка :" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет данных для записи!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SaveFileToExcel(DataGridView dataGridView1, EventArgs e)
        {
            //Creating DataTable.
            DataTable dt = new DataTable();

            //Adding the Columns.
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.Filter = "Excel file|*.xlsx";
            saveFile1.Title = "save results as Excel spreadsheet";
            saveFile1.FileName = "SavedTable" + " -" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";
            if (saveFile1.ShowDialog() == DialogResult.OK)
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add(dt, "SavedTable");
                wb.SaveAs(saveFile1.FileName);
            }
        }

        public void SaveClientsToCSV(DataGridView dataGridView1)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                bool fileError = false;
                try
                {
                    File.Delete(GetPythonPath("newclients.csv"));
                }
                catch (IOException ex)
                {
                    fileError = true;
                    MessageBox.Show("Невозможно обратиться к файлам." + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            if (i != columnCount - 1)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ";";
                            }
                            else
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString();
                            }

                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                if (j != columnCount - 1)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                                else
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString();
                                }
                            }
                        }

                        File.WriteAllLines(GetPythonPath("newclients.csv"), outputCsv, Encoding.UTF8);
                        MessageBox.Show("Проверка клиентов начата, не закрывайте форму до её окончания.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка :" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет данных для записи!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
