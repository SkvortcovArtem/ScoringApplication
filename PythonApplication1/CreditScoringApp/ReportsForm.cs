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
    public partial class ReportsForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(StartForm.server);        
        List<string> researchList = new List<string>();        
        List<string> groupList = new List<string>();

        public ReportsForm()
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

        private void btModel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelLearningForm modelLearningForm = new ModelLearningForm();
            modelLearningForm.Show();
        }

        private void ReportsForm_Shown(object sender, EventArgs e)
        {
            cbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbResearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportType.Items.Add("Разброс значений");
            cbReportType.Items.Add("Проценты");
            cbReportType.SelectedItem = "Разброс значений";
            cbResearch.Items.Add("Возраст");
            cbResearch.Items.Add("Время с последнего изменения телефона");
            cbResearch.Items.Add("Время с последнего изменения паспорта");
            cbResearch.SelectedItem = "Возраст";
            cbGroup.Items.Add("Выдан ли кредит");
            cbGroup.Items.Add("Образование");
            cbGroup.Items.Add("Тип дохода");
            cbGroup.Items.Add("Пол");
            cbGroup.Items.Add("Совпадение места жительства и работы");
            cbGroup.SelectedItem = "Выдан ли кредит";
            researchList.Add("DAYS_BIRTH");
            researchList.Add("DAYS_LAST_PHONE_CHANGE");
            researchList.Add("[DAYS_ID_PUBLISH]");
            groupList.Add("TARGET");
            groupList.Add("NAME_EDUCATION_TYPE");
            groupList.Add("NAME_INCOME_TYPE");
            groupList.Add("CODE_GENDER");
            groupList.Add("REG_CITY_NOT_WORK_CITY");
            if (StartForm.adminFlag)
            {
                btModel.Visible = true;
            }
            else
            {
                btModel.Visible = false;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DataTable BankTable = new DataTable();
            SqlDataAdapter WorkersAdapt;
            string query = "";
            if (cbReportType.SelectedItem.ToString() == "Разброс значений")
            {
                query = "SELECT " + groupList[cbGroup.SelectedIndex] + ", MIN(CAST(" + researchList[cbResearch.SelectedIndex] + " as bigint)) AS Minimum, MAX(CAST(" + researchList[cbResearch.SelectedIndex] + " as bigint)) AS Maximum," +
                "AVG(CAST(" + researchList[cbResearch.SelectedIndex] + " as bigint)) AS Average, VAR(CAST(" + researchList[cbResearch.SelectedIndex] + " as bigint)) AS Variance " +
                "FROM bankdata " +
                "GROUP BY " + groupList[cbGroup.SelectedIndex] + " " +
                "ORDER BY Maximum DESC";
            }
            else if (cbReportType.SelectedItem.ToString() == "Проценты")
            {
                query = "select " + groupList[cbGroup.SelectedIndex] + ", " +
                "count(*) as clients, " +
                "count(*) * 100.0 / sum(count(*)) over() as perscentage " +
                "from bankdata " +
                "group by " + groupList[cbGroup.SelectedIndex];
            }            
            try
            {
                sqlcon.Open();
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdapt = new SqlDataAdapter(command);
                WorkersAdapt.Fill(BankTable);
                DGDatabase.DataSource = BankTable.DefaultView;
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
            DGDatabase.ClearSelection();
        }

        private void cbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReportType.SelectedItem.ToString() == "Проценты")
            {
                cbResearch.Enabled = false;
            }
            else
            {
                cbResearch.Enabled = true;
            }
        }

        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
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
