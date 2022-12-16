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
using System.IO;
using System.Threading;

namespace CreditScoringApp
{
    public partial class CheckClientForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(StartForm.server);
        DataTable BankTable = new DataTable();
        SqlDataAdapter WorkersAdapt;
        List<int> listIdClients = new List<int>();
        List<int> listDescisions = new List<int>();
        public CheckClientForm()
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

        private void btReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm reportForm = new ReportsForm();
            reportForm.Show();
        }

        private void btModel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelLearningForm modelLearningForm = new ModelLearningForm();
            modelLearningForm.Show();
        }

        private void CheckClientForm_Shown(object sender, EventArgs e)
        {
            btSaveResult.Enabled = false;

            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM bankdata WHERE TARGET is null";
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdapt = new SqlDataAdapter(command);
                WorkersAdapt.Fill(BankTable);
                DGDatabase.DataSource = BankTable.DefaultView;
                DGDatabase.Columns[0].Visible = false;
                DGDatabase.Columns[3].Visible = false;
                DGDatabase.Columns[4].Visible = false;
                DGDatabase.Columns[1].HeaderText = "Решение о кредите";
                DGDatabase.Columns[2].HeaderText = "Возраст";
                DGDatabase.Columns[5].HeaderText = "Образование";
                DGDatabase.Columns[6].HeaderText = "Рейтинг региона";
                DGDatabase.Columns[7].HeaderText = "Тип дохода";
                DGDatabase.Columns[8].HeaderText = "Пол";
                DGDatabase.Columns[9].HeaderText = "Дней с последнего изменения телефона";
                DGDatabase.Columns[10].HeaderText = "Дней с последнего изменения паспорта";
                DGDatabase.Columns[11].HeaderText = "Место работы совпадает с местом проживания";
                DGDatabase.Columns[1].ReadOnly = false;
                sqlcon.Close();
                for (int i = 0; i < DGDatabase.Rows.Count; i++)
                {
                    listIdClients.Add(Convert.ToInt32(DGDatabase[0, i].Value));
                }
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

        private void btCheck_Click(object sender, EventArgs e)
        {
            SupportClass sc = new SupportClass();
            sc.SaveClientsToCSV(DGDatabase);
            if (DGDatabase.Rows.Count != 0)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = sc.GetPythonPath("ImportModel.py");
                Process p = new Process();
                p.StartInfo = psi;
                p.Start();
                Thread.Sleep(3000);
                btSaveResult.Enabled = true;
            }                       
        }

        private void btSaveResult_Click(object sender, EventArgs e)
        {
            SupportClass sc = new SupportClass();
            DataTable dt = new DataTable();
            // Creating the columns
            foreach (var headerLine in File.ReadLines(sc.GetPythonPath("descision.csv")).Take(1))
            {
                foreach (var headerItem in headerLine.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    dt.Columns.Add(headerItem.Trim());
                }
            }
            foreach (var line in File.ReadLines(sc.GetPythonPath("descision.csv")))
            {
                dt.Rows.Add(line.Split(';'));
            }
            if (dt.Rows.Count > 0)
            {
                DGWorker.DataSource = dt;
            }
            for (int i = 0; i < DGWorker.Rows.Count; i++)
            {
                DGDatabase[1, i].Value = DGWorker[0, i].Value;
                listDescisions.Add(Convert.ToInt32(DGDatabase[1, i].Value));
            }
            for (int i = 0; i < DGDatabase.Rows.Count; i++)
            {
                string id = listIdClients[i].ToString();
                string descision = listDescisions[i].ToString();
                try
                {
                    DataTable BankTableU = new DataTable();
                    SqlDataAdapter WorkersAdaptU;
                    sqlcon.Open();
                    string queryU = "UPDATE bankdata SET TARGET=" + descision + " WHERE Id_Client=" + id;
                    SqlCommand commandU = new SqlCommand(queryU, sqlcon);
                    WorkersAdaptU = new SqlDataAdapter(commandU);
                    commandU.ExecuteNonQuery();
                    BankTableU.Clear();
                    WorkersAdaptU.Fill(BankTableU);
                    sqlcon.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось установить соединение или обновить данные");
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

        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void CheckClientForm_FormClosed(object sender, FormClosedEventArgs e)
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
