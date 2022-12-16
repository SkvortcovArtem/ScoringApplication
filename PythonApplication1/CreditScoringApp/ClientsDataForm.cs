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
    public partial class ClientsDataForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(StartForm.server);
        DataTable BankTable = new DataTable();
        DataTable IncomeTypeTable = new DataTable();
        DataTable CreditDecisionTable = new DataTable();
        DataTable EducationTypeTable = new DataTable();
        DataTable GenderTable = new DataTable();
        DataTable RegistrationTable = new DataTable();
        SqlDataAdapter WorkersAdapt;

        private void ClientsDataForm_Shown(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                string query = "SELECT * FROM bankdata";
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
                cbCredit.DropDownStyle = ComboBoxStyle.DropDownList;
                cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
                cbRegistration.DropDownStyle = ComboBoxStyle.DropDownList;
                cbEducation.DropDownStyle = ComboBoxStyle.DropDownList;
                cbIncom.DropDownStyle = ComboBoxStyle.DropDownList;
                string queryGenders = "SELECT DISTINCT bankdata.CODE_GENDER FROM bankdata";
                SqlCommand command1 = new SqlCommand(queryGenders, sqlcon);
                SqlDataAdapter ClientsAdapt1 = new SqlDataAdapter(command1);
                ClientsAdapt1.Fill(GenderTable);
                cbGender.Items.Add("Любой");
                cbGender.SelectedItem = "Любой";                
                for (int i = 0; i < GenderTable.Rows.Count; i++)
                {
                    cbGender.Items.Add(GenderTable.Rows[i].Field<string>("CODE_GENDER"));
                }
                string queryCredit = "SELECT DISTINCT bankdata.TARGET FROM bankdata";
                SqlCommand command2 = new SqlCommand(queryCredit, sqlcon);
                SqlDataAdapter ClientsAdapt2 = new SqlDataAdapter(command2);
                ClientsAdapt2.Fill(CreditDecisionTable);
                cbCredit.Items.Add("Любой");
                cbCredit.SelectedItem = "Любой";
                for (int i = 0; i < CreditDecisionTable.Rows.Count; i++)
                {
                    if (CreditDecisionTable.Rows[i].Field<object>("TARGET") != null)
                    {
                        cbCredit.Items.Add(CreditDecisionTable.Rows[i].Field<int>("TARGET"));
                    }                    
                }
                string queryRegistration = "SELECT DISTINCT bankdata.REG_CITY_NOT_WORK_CITY FROM bankdata";
                SqlCommand command3 = new SqlCommand(queryRegistration, sqlcon);
                SqlDataAdapter ClientsAdapt3 = new SqlDataAdapter(command3);
                ClientsAdapt3.Fill(RegistrationTable);
                cbRegistration.Items.Add("Любой");
                cbRegistration.SelectedItem = "Любой";
                for (int i = 0; i < RegistrationTable.Rows.Count; i++)
                {
                    cbRegistration.Items.Add(RegistrationTable.Rows[i].Field<int>("REG_CITY_NOT_WORK_CITY"));
                }
                string queryEducation = "SELECT DISTINCT bankdata.NAME_EDUCATION_TYPE FROM bankdata";
                SqlCommand command4 = new SqlCommand(queryEducation, sqlcon);
                SqlDataAdapter ClientsAdapt4 = new SqlDataAdapter(command4);
                ClientsAdapt4.Fill(EducationTypeTable);
                cbEducation.Items.Add("Любой");
                cbEducation.SelectedItem = "Любой";
                for (int i = 0; i < EducationTypeTable.Rows.Count; i++)
                {
                    cbEducation.Items.Add(EducationTypeTable.Rows[i].Field<string>("NAME_EDUCATION_TYPE"));
                }
                string queryIncom = "SELECT DISTINCT bankdata.NAME_INCOME_TYPE FROM bankdata";
                SqlCommand command5 = new SqlCommand(queryIncom, sqlcon);
                SqlDataAdapter ClientsAdapt5 = new SqlDataAdapter(command5);
                ClientsAdapt5.Fill(IncomeTypeTable);
                cbIncom.Items.Add("Любой");
                cbIncom.SelectedItem = "Любой";
                for (int i = 0; i < IncomeTypeTable.Rows.Count; i++)
                {
                    cbIncom.Items.Add(IncomeTypeTable.Rows[i].Field<string>("NAME_INCOME_TYPE"));
                }
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
        public ClientsDataForm()
        {
            InitializeComponent();
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

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {
                string queryAddition = "";
                List<string> selectedParameters = new List<string>();
                selectedParameters.Add(cbCredit.SelectedItem.ToString());
                selectedParameters.Add(cbGender.SelectedItem.ToString());
                selectedParameters.Add(cbRegistration.SelectedItem.ToString());
                selectedParameters.Add(cbEducation.SelectedItem.ToString());
                selectedParameters.Add(cbIncom.SelectedItem.ToString());
                List<string> nameParameters = new List<string>() { "TARGET", "CODE_GENDER", "REG_CITY_NOT_WORK_CITY", "NAME_EDUCATION_TYPE", "NAME_INCOME_TYPE" };
                if(selectedParameters.Distinct().Skip(1).Any())
                {
                    queryAddition = " WHERE";
                    for (int i = 0; i < selectedParameters.Count; i++) 
                    {
                        if (String.Compare(selectedParameters[i], "Любой") != 0)
                        {
                            queryAddition = queryAddition + " " + nameParameters[i] + "='" + selectedParameters[i] + "'AND";                            
                        }
                    }
                    if (queryAddition.EndsWith("AND"))
                    {
                        queryAddition = queryAddition.Remove(queryAddition.Length - 3);
                    }
                }    
                sqlcon.Open();
                string query = "SELECT * FROM bankdata" + queryAddition;
                SqlCommand command = new SqlCommand(query, sqlcon);
                WorkersAdapt = new SqlDataAdapter(command);
                BankTable.Clear();
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
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupportClass sc = new SupportClass();
            sc.SaveFileToExcel(DGDatabase, e);
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

        private void ClientsDataForm_FontChanged(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
