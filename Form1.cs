using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // переключения между панелями
            EditSwitch.Click += (s, e) => { panelEdit.BringToFront(); };
            dbSwitch.Click += (s, e) => { paneldb.BringToFront(); };

            
        }
        readonly static string dbConnection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        private new void Message(string line)
        {
            MessageBox.Show(line, "Уведомление!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        // метод загрузки данных в dataGridView
        private new void Refresh()
        {
            DataTable data = Select();
            dataGridView1.DataSource = data;
        }
        int num;
        // Создадим метод загрузки данных
        public new DataTable Select()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM [User]";
                using(SqlConnection sql = new SqlConnection(dbConnection))
                {
                    SqlCommand command = new SqlCommand(query, sql);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
            return data;
        }
        // событие загрузки формы и вывода данных
        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        // Кнопка добавления
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = $"insert into [User] ([Name], [Last name], [Status], [Phone], [Gender], [Year of birth]) values ('{txtName.Text}', " +
                    $"'{txt_LastName.Text}','{cmbStatus.Text}'," +
                    $" '{txt_Phone.Text}', '{cmbGender.Text}', " +
                    $"'{dtpDate.Value.ToString()}')"; 
                using (SqlConnection sql = new SqlConnection(dbConnection))
                {
                    sql.Open();
                    SqlCommand command = new SqlCommand(insert, sql);
                    num += command.ExecuteNonQuery();
                    Message("Добавлние прошло успешно!");
                    Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string update = $"update [User] set [Name]='{txtName.Text}', [Last name]='{txt_LastName.Text}', [Status]='{cmbStatus.Text}', [Phone]='{txt_Phone.Text}', [Gender]='{cmbGender.Text}', [Year of birth]='{dtpDate.Value.ToString()}' where id='{textBox1.Text}'";
                using (SqlConnection sql = new SqlConnection(dbConnection))
                {
                    sql.Open();
                    SqlCommand command = new SqlCommand(update, sql);
                    num += command.ExecuteNonQuery();
                    Message("Обновление прошло успешно!");
                    Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = $"delete from [User] where id='{textBox1.Text}'";
                using (SqlConnection sql = new SqlConnection(dbConnection))
                {
                    sql.Open();
                    SqlCommand command = new SqlCommand(delete, sql);
                    num += command.ExecuteNonQuery();
                    Message("Удаление прошло успешно!");
                    Refresh();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
