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

namespace CreditScoringApp
{
    public partial class MenuForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(StartForm.server);
        DataTable BankTable = new DataTable();
        SqlDataAdapter WorkersAdapt;

        public MenuForm()
        {
            InitializeComponent();
        }
        private void Menu_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM Workers WHERE Id_Worker=" + StartForm.Id_Worker.ToString();
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdapt = new SqlDataAdapter(command);
                WorkersAdapt.Fill(BankTable);
                DGWorker.DataSource = BankTable.DefaultView;
                txtFIO.Text = DGWorker[1, 0].Value.ToString();
                txtPost.Text = DGWorker[3, 0].Value.ToString();
                txtAddress.Text = DGWorker[2, 0].Value.ToString();
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

        private void btModel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelLearningForm modelLearningForm = new ModelLearningForm();
            modelLearningForm.Show();
        }

        private void закрытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
