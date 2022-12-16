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
using System.Data.SqlClient;

namespace CreditScoringApp
{    
    public partial class StartForm : Form
    {
        public static string server = @"Data Source = .\SQLEXPRESS; Initial Catalog = CreditScoringDB; Integrated Security = true";
        public static bool adminFlag;
        public static int Id_Worker;

        SqlConnection sqlcon = new SqlConnection(server);
        DataTable BankTable = new DataTable();
        SqlDataAdapter WorkersAdapt;

        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btOK_Click(object sender, EventArgs e)
        {            
            if (txtLogin.Text != "" && txtPassword.Text != "")
            {                
                try
                {
                    sqlcon.Open();
                    string query = "SELECT * FROM Workers WHERE Login='" + txtLogin.Text + "' and Password=" + txtPassword.Text;
                    SqlCommand command = new SqlCommand(query, sqlcon);
                    WorkersAdapt = new SqlDataAdapter(command);
                    WorkersAdapt.Fill(BankTable);
                    DGLogin.DataSource = BankTable.DefaultView;
                    if (DGLogin.Rows.Count > 0 && DGLogin.Rows != null)
                    {                        
                        Id_Worker = Convert.ToInt32(DGLogin[0, 0].Value);
                        if (String.Compare(DGLogin[3, 0].Value.ToString(), "Администратор") == 0)
                        {
                            adminFlag = true;
                        }
                        else
                        {
                            adminFlag = false;
                        }
                        this.Hide();
                        MenuForm menuForm=new MenuForm();
                        menuForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин/пароль!", "Сообщение", MessageBoxButtons.OK , MessageBoxIcon.Information);
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
            }
            else 
            {
                MessageBox.Show("Введите логин и пароль!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }        
    }
}
