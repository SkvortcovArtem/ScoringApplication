using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace CreditScoringApp
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public string GetPythonPath(string filename)
        {
            string path1 = System.IO.Directory.GetParent(System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString()).ToString();
            string path2 = "PythonApplication1";
            string directory = Path.Combine(path1, path2, filename);
            directory = directory.Replace(@"\", @"\\");
            return directory;
        }

        /*public void LearnModel()
        {
            string myPythonApp = GetPythonPath("BankModel.py");
            string fileName = "D:\\Programs\\Visual Studio\\SDK\\Python39_64\\python.exe";
            using (CommandLineProcess cmd = new CommandLineProcess(fileName, myPythonApp))
            {
                // Call Python:
                int exitCode = cmd.Run(out string processOutput, out string processError);

                // Check result:
                listBox1.Items.Add(processOutput);
                if (exitCode == 0)
                {
                    listBox1.Items.Add("Build completed successfully!");
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(processError))
                        listBox1.Items.Add($"PYTHON PROCESS ERROR: {processError}");
                    listBox1.Items.Add("Build failed!");
                }
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            /*string myPythonApp = GetPythonPath("Test.py");
            
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "D:\\Programs\\Visual Studio\\SDK\\Python39_64\\python.exe";
            //start.WorkingDirectory = @"D:\script";
            start.Arguments = myPythonApp;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = GetPythonPath("BankModel.py");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            /*var progressDialog = new ProgressDialog();
            progressDialog.Progressbar.Value = 0;
            progressDialog.Progressbar.Maximum = 5;

            progressDialog.RunAsync(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    progressDialog.Progressbar.BeginInvoke((MethodInvoker)(() => {
                        progressDialog.Progressbar.Value += 1;
                    }));
                }                
            });
            
            progressDialog.ShowDialog();            
            progressDialog.Progressbar.Value = 5;
            Thread.Sleep(1000);
            progressDialog.Close();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(StartForm.server);
            DataTable BankTable = new DataTable();
            SqlDataAdapter WorkersAdapt;

            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM Workers";
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdapt = new SqlDataAdapter(command);
                WorkersAdapt.Fill(BankTable);
                DGLogin.DataSource = BankTable.DefaultView;
                
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }
    }
}
