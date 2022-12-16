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
    public partial class AddClientForm : Form
    {
        SqlConnection sqlcon = new SqlConnection(StartForm.server);
        DataTable BankTable = new DataTable();
        DataTable IncomeTypeTable = new DataTable();
        DataTable RegionTable = new DataTable();
        DataTable EducationTypeTable = new DataTable();
        DataTable GenderTable = new DataTable();
        DataTable RegistrationTable = new DataTable();
        DataTable ExtSourceTable = new DataTable();
        SqlDataAdapter WorkersAdapt;
        double extSource3;
        double extSource2;
        public AddClientForm()
        {
            InitializeComponent();
        }       

        private void btClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientsDataForm clientsDataForm = new ClientsDataForm();
            clientsDataForm.Show();
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

        private void AddClientForm_Shown(object sender, EventArgs e)
        {            
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
                DGDatabase.Columns[1].Visible = false;
                DGDatabase.Columns[1].HeaderText = "Решение о кредите";
                DGDatabase.Columns[2].HeaderText = "Возраст";
                DGDatabase.Columns[5].HeaderText = "Образование";
                DGDatabase.Columns[6].HeaderText = "Рейтинг региона";
                DGDatabase.Columns[7].HeaderText = "Тип дохода";
                DGDatabase.Columns[8].HeaderText = "Пол";
                DGDatabase.Columns[9].HeaderText = "Дней с последнего изменения телефона";
                DGDatabase.Columns[10].HeaderText = "Дней с последнего изменения паспорта";
                DGDatabase.Columns[11].HeaderText = "Место работы совпадает с местом проживания";
                cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
                cbEducation.DropDownStyle = ComboBoxStyle.DropDownList;
                cbRegion.DropDownStyle = ComboBoxStyle.DropDownList;
                cbIncom.DropDownStyle = ComboBoxStyle.DropDownList;
                cbRegistration.DropDownStyle = ComboBoxStyle.DropDownList;
                string queryGenders = "SELECT DISTINCT bankdata.CODE_GENDER FROM bankdata";
                SqlCommand command1 = new SqlCommand(queryGenders, sqlcon);
                SqlDataAdapter ClientsAdapt1 = new SqlDataAdapter(command1);
                ClientsAdapt1.Fill(GenderTable);
                for (int i = 0; i < GenderTable.Rows.Count; i++)
                {
                    cbGender.Items.Add(GenderTable.Rows[i].Field<string>("CODE_GENDER"));
                }
                string queryEducation = "SELECT DISTINCT bankdata.NAME_EDUCATION_TYPE FROM bankdata";
                SqlCommand command2 = new SqlCommand(queryEducation, sqlcon);
                SqlDataAdapter ClientsAdapt2 = new SqlDataAdapter(command2);
                ClientsAdapt2.Fill(EducationTypeTable);
                for (int i = 0; i < EducationTypeTable.Rows.Count; i++)
                {
                    cbEducation.Items.Add(EducationTypeTable.Rows[i].Field<string>("NAME_EDUCATION_TYPE"));
                }
                string queryRegion = "SELECT DISTINCT bankdata.REGION_RATING_CLIENT FROM bankdata";
                SqlCommand command3 = new SqlCommand(queryRegion, sqlcon);
                SqlDataAdapter ClientsAdapt3 = new SqlDataAdapter(command3);
                ClientsAdapt3.Fill(RegionTable);
                for (int i = 0; i < RegionTable.Rows.Count; i++)
                {
                    cbRegion.Items.Add(RegionTable.Rows[i].Field<string>("REGION_RATING_CLIENT"));
                }
                string queryIncom = "SELECT DISTINCT bankdata.NAME_INCOME_TYPE FROM bankdata";
                SqlCommand command4 = new SqlCommand(queryIncom, sqlcon);
                SqlDataAdapter ClientsAdapt4 = new SqlDataAdapter(command4);
                ClientsAdapt4.Fill(IncomeTypeTable);
                for (int i = 0; i < IncomeTypeTable.Rows.Count; i++)
                {
                    cbIncom.Items.Add(IncomeTypeTable.Rows[i].Field<string>("NAME_INCOME_TYPE"));
                }
                string queryRegistration = "SELECT DISTINCT bankdata.REG_CITY_NOT_WORK_CITY FROM bankdata";
                SqlCommand command5 = new SqlCommand(queryRegistration, sqlcon);
                SqlDataAdapter ClientsAdapt5 = new SqlDataAdapter(command5);
                ClientsAdapt5.Fill(RegistrationTable);
                for (int i = 0; i < RegistrationTable.Rows.Count; i++)
                {
                    cbRegistration.Items.Add(RegistrationTable.Rows[i].Field<int>("REG_CITY_NOT_WORK_CITY"));
                }
                cbGender.SelectedIndex = 0;
                cbEducation.SelectedIndex = 0;
                cbRegion.SelectedIndex = 0;
                cbIncom.SelectedIndex = 0;
                cbRegistration.SelectedIndex = 0;
                string queryExtSource = "SELECT AVG(EXT_SOURCE_3)-0.3 as EXT_SOURCE_3, AVG(EXT_SOURCE_2)-0.34 as EXT_SOURCE_2 FROM bankdata";
                SqlCommand command6 = new SqlCommand(queryExtSource, sqlcon);
                SqlDataAdapter ClientsAdapt6 = new SqlDataAdapter(command6);
                ClientsAdapt6.Fill(ExtSourceTable);
                extSource3 = ExtSourceTable.Rows[0].Field<double>("EXT_SOURCE_3");
                extSource2 = ExtSourceTable.Rows[0].Field<double>("EXT_SOURCE_2");
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int daysBirth = Convert.ToInt32((today - dateBirth.Value).TotalDays) * (-1);
            int daysPhone = Convert.ToInt32((today - dateChangeMobile.Value).TotalDays) * (-1);
            int daysPassport = Convert.ToInt32((today - dateChangePassport.Value).TotalDays) * (-1);
            int clientId = 0;

            try
            {
                sqlcon.Open();
                string query = "INSERT INTO bankdata(DAYS_BIRTH, EXT_SOURCE_3, EXT_SOURCE_2, NAME_EDUCATION_TYPE, REGION_RATING_CLIENT, NAME_INCOME_TYPE, CODE_GENDER, " +
                    "DAYS_LAST_PHONE_CHANGE, DAYS_ID_PUBLISH, REG_CITY_NOT_WORK_CITY)" +
                    " VALUES('" + daysBirth.ToString() + "', " + extSource3.ToString().Replace(',', '.') + ", " + extSource2.ToString().Replace(',', '.') + ", '" + cbEducation.SelectedItem.ToString() + "', '" +
                    cbRegion.SelectedItem.ToString() + "', '" + cbIncom.SelectedItem.ToString() + "', '" + cbGender.SelectedItem.ToString() + "', " + daysPhone.ToString() +
                    ", " + daysPassport.ToString() + ", " + cbRegistration.SelectedItem.ToString() + ")";
                SqlCommand command = new SqlCommand(query, sqlcon);
                command.ExecuteNonQuery();
                BankTable.Clear();
                WorkersAdapt.Fill(BankTable);
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

            
            DataTable BankTableId = new DataTable();
            SqlDataAdapter WorkersAdaptId;
            sqlcon.Open();
            string queryId = "SELECT TOP 1 * FROM bankdata ORDER BY Id_Client DESC";
            SqlCommand commandId = new SqlCommand(queryId, sqlcon);
            WorkersAdaptId = new SqlDataAdapter(commandId);
            dataGridView1.DataSource = BankTableId.DefaultView;
            BankTableId.Clear();
            WorkersAdaptId.Fill(BankTableId);
            clientId = Convert.ToInt32(dataGridView1[0, 0].Value);
            sqlcon.Close();
            try
            {
                
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
                DataTable BankTableLog = new DataTable();
                SqlDataAdapter WorkersAdaptLog;
                sqlcon.Open();
                string queryLog = "INSERT INTO Operations_Logs(Id_Worker, Id_Client, Operation_Type, Date) VALUES(" + StartForm.Id_Worker + ", " + clientId.ToString() + ", 'AddClient', '" + today.ToShortDateString() + "')";
                SqlCommand commandLog = new SqlCommand(queryLog, sqlcon);
                WorkersAdaptLog = new SqlDataAdapter(commandLog);
                commandLog.ExecuteNonQuery();
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
        }

        private void сменитьПользователяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }

        private void AddClientForm_FormClosed(object sender, FormClosedEventArgs e)
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
