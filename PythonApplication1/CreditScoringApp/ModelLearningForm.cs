using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;

namespace CreditScoringApp
{
    public partial class ModelLearningForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(StartForm.server);
        DataTable BankTable = new DataTable();
        SqlDataAdapter WorkersAdapt;
        public ModelLearningForm()
        {
            InitializeComponent();
        }        

        private void btClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsDataForm clientsDataForm = new ClientsDataForm();
            clientsDataForm.Show();
        }

        private void btAddClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }

        private void btCheckClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckClientForm checkClientForm = new CheckClientForm();
            checkClientForm.Show();
        }

        private void btReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportForm = new ReportsForm();
            reportForm.Show();
        }

        private void ModelLearningForm_Shown(object sender, EventArgs e)
        {
            btSaveModel.Enabled = false;
            try
            {
                sqlcon.Open();
                string query = "SELECT Models.Id_Model, Models.Name_Model, Operations_Logs.Id_Model, Operations_Logs.Date FROM Models, Operations_Logs WHERE Models.Id_Model=Operations_Logs.Id_Model";
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdapt = new SqlDataAdapter(command);
                WorkersAdapt.Fill(BankTable);
                DGDatabase.DataSource = BankTable.DefaultView;
                DGDatabase.Columns[0].HeaderText = "ID";
                DGDatabase.Columns[1].HeaderText = "Название";
                DGDatabase.Columns[2].Visible = false;
                DGDatabase.Columns[3].HeaderText = "Дата";
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            if (StartForm.adminFlag)
            {
                btModel.Visible = true;
            }
            else
            {
                btModel.Visible = false;
            }
        }

        private void btLearnModel_Click(object sender, EventArgs e)
        {
            DataTable BankTableL = new DataTable();
            SqlDataAdapter WorkersAdaptL;
            string query = "SELECT * FROM bankdata WHERE TARGET is not NULL";
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdaptL = new SqlDataAdapter(command);
                WorkersAdaptL.Fill(BankTableL);
                dataGridView1.DataSource = BankTableL.DefaultView;
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            SupportClass sc = new SupportClass();
            sc.SaveDataToCSV(dataGridView1);
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = sc.GetPythonPath("BankModel.py");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            Thread.Sleep(10000);
            btSaveModel.Enabled = true;            
        }

        private void btSaveModel_Click(object sender, EventArgs e)
        {            
            SqlDataAdapter WorkersAdapt1;            
            DateTime today = DateTime.Today;
            int modelID = 0;
            
            try
            {
                SupportClass sc = new SupportClass();
                string modelPath = sc.GetPythonPath("model_file_ada.pkl");
                sqlcon.Open();
                string query1 = "INSERT INTO Models(Name_Model, [File]) " +
                "SELECT 'model_file_ada.pkl' AS Name_File, " +
                "* FROM OPENROWSET(BULK N'" + modelPath.Replace(@"\\", @"\") + "', SINGLE_BLOB) AS [File]";
                SqlCommand command1 = new SqlCommand(query1, sqlcon);
                WorkersAdapt1 = new SqlDataAdapter(command1);
                command1.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение или загрузить данные");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            
            try
            {
                DataTable BankTable2 = new DataTable();
                SqlDataAdapter WorkersAdapt2;
                sqlcon.Open();
                string query2 = "SELECT TOP 1 * FROM Models ORDER BY Id_Model DESC";
                SqlCommand command2 = new SqlCommand(query2, sqlcon);
                WorkersAdapt2 = new SqlDataAdapter(command2);
                dataGridView1.DataSource = BankTable2.DefaultView;
                BankTable2.Clear();
                WorkersAdapt2.Fill(BankTable2);
                modelID = Convert.ToInt32(dataGridView1[0, 0].Value);
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение или загрузить данные");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            
            try
            {                
                SqlDataAdapter WorkersAdapt3;
                sqlcon.Open();
                string query3 = "INSERT INTO Operations_Logs(Id_Worker, Id_Model, Operation_Type, Date) VALUES(" + StartForm.Id_Worker + ", " + modelID.ToString() + ", 'LearnModel', '" + today.ToShortDateString() + "')";
                SqlCommand command3 = new SqlCommand(query3, sqlcon);
                WorkersAdapt3 = new SqlDataAdapter(command3);
                command3.ExecuteNonQuery();
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение или загрузить данные");
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            
            try
            {
                DataTable BankTableM = new DataTable();
                SqlDataAdapter WorkersAdaptM;
                sqlcon.Open();
                string queryN = "SELECT Models.Id_Model, Models.Name_Model, Operations_Logs.Id_Model, Operations_Logs.Date FROM Models, Operations_Logs WHERE Models.Id_Model=Operations_Logs.Id_Model";
                SqlCommand commandM = new SqlCommand(queryN, sqlcon);
                WorkersAdaptM = new SqlDataAdapter(commandM);
                WorkersAdaptM.Fill(BankTableM);
                DGDatabase.DataSource = BankTableM.DefaultView;
                DGDatabase.Columns[0].HeaderText = "ID";
                DGDatabase.Columns[1].HeaderText = "Название";
                DGDatabase.Columns[2].Visible = false;
                DGDatabase.Columns[3].HeaderText = "Дата";
                Thread.Sleep(1000);
                DGDatabase.Refresh();
                sqlcon.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось установить соединение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void ModelLearningForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupportClass sc = new SupportClass();
            sc.SaveFileToExcel(DGDatabase, e);
        }
    }
}
