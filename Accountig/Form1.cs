using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Accountig
{

    public partial class MainWindow : Form
    {

        SqlConnection SqlConnection;
        private async void RefreshTable()
        {
            decimal accountSum = 0;
            listBox1.Items.Clear();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Invoice] ", SqlConnection);

            // обработчик
            try
            {
                // присвоить результат выполнения команды для дальнейшего вывода
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    // вывод таблицы
                    listBox1.Items.Add(Convert.ToString(SqlReader["Id"]) + "\t" + Convert.ToString(SqlReader["Name"]) + "  " + Convert.ToString(SqlReader["Date"]) + "         " + Convert.ToString(SqlReader["Account"]));
                    // формируется сумма по счетам 
                    accountSum = accountSum + Convert.ToDecimal(SqlReader["Account"]);
                }
                // запишем сумму по счетам
                listBox2.Items.Clear();
                listBox2.Items.Add(Convert.ToString(accountSum));
                // сумма по счетам записана
            }
            catch (Exception ex)
            {
                // показать сообщение MessageBox.Show(текст, заголовок, кнопка, иконка)
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // обязательно закрыть ридер если ему все же было присвоено значение
                if (SqlReader != null)
                {
                    SqlReader.Close();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            decimal accountSum = 0;
            string dir = Directory.GetCurrentDirectory();
            dir = System.IO.Path.GetDirectoryName(dir);
            dir = System.IO.Path.GetDirectoryName(dir);
            dir = String.Concat(dir, @"\");
            // подключение к БД
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = "+@dir+"Database.mdf; Integrated Security = True";
            // открытие асинхронного запроса
            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();
            // поучить данные в табл представлении
            SqlDataReader SqlReader = null;
            //запрос sqlCommand(инструкция, )
            SqlCommand command = new SqlCommand("SELECT * FROM [Invoice] ", SqlConnection);
            
            // обработчик
            try
            {
                // присвоить результат выполнения команды для дальнейшего вывода
                SqlReader = await command.ExecuteReaderAsync();
                
                while (await SqlReader.ReadAsync())
                {
                    // вывод таблицы
                    listBox1.Items.Add(Convert.ToString(SqlReader["Id"]) + "\t" + Convert.ToString(SqlReader["Name"]) + "  " + Convert.ToString(SqlReader["Date"]) +"         "+ Convert.ToString(SqlReader["Account"]));
                    // формируется сумма по счетам 
                    accountSum = accountSum + Convert.ToDecimal(SqlReader["Account"]);
                }
                // запишем сумму по счетам
                listBox2.Items.Clear();
                listBox2.Items.Add(Convert.ToString(accountSum));
                // сумма по счетам записана

            }
            catch (Exception ex)
            {
                // показать сообщение MessageBox.Show(текст, заголовок, кнопка, иконка)
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // обязательно закрыть ридер если ему все же было присвоено значение
                if (SqlReader != null)
                {
                    SqlReader.Close();
                }        
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SqlConnection != null && SqlConnection.State != ConnectionState.Closed)
                SqlConnection.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (label6.Visible) { label6.Visible = false; };

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Invoice] (Name, Account)VALUES(@Name,@Account)", SqlConnection);
                //присвоить параметры для использования в инструкции
                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Account", textBox2.Text);

                await command.ExecuteNonQueryAsync();
                textBox1.Text = "";
                textBox2.Text = "";
                RefreshTable();
            }
            else
            {
                label6.Visible = true;
                label6.Text = "Input all data!";
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (label8.Visible) { label8.Visible = false; };
            if (!string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Invoice] SET [Name] = @Name, [Account] = @Account WHERE [Id] = @Id",SqlConnection);

                command.Parameters.AddWithValue("Id", textBox5.Text);
                command.Parameters.AddWithValue("Name", textBox4.Text);
                command.Parameters.AddWithValue("Account", textBox3.Text);

               await command.ExecuteNonQueryAsync();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                RefreshTable();
            }
            else
            {
                label8.Text = "Input Id !";
                label8.Visible = true;
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (label9.Visible)
            { label9.Visible = false; }

            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Invoice] WHERE [Id]=@Id", SqlConnection);

                command.Parameters.AddWithValue("Id", textBox8.Text);

                await command.ExecuteNonQueryAsync();

                textBox8.Text = "";
                RefreshTable();
            }
            else
            {
                label9.Visible = true;

                label9.Text = "Input Id !";
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            dir = System.IO.Path.GetDirectoryName(dir);
            dir = System.IO.Path.GetDirectoryName(dir);
            dir = String.Concat(dir, @"\");
            listBox3.Items.Clear();
            // подключение к БД
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + @dir + "Database.mdf; Integrated Security = True";
            //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\dmytro\Documents\Visual Studio 2015\Projects\Accountig\Accountig\Database.mdf'; Integrated Security = True";
            // открытие асинхронного запроса
            SqlConnection = new SqlConnection(connectionString);
            await SqlConnection.OpenAsync();
            // поучить данные в табл представлении
            SqlDataReader SqlReader = null;
            //запрос sqlCommand(инструкция, )
            SqlCommand command = new SqlCommand("SELECT * FROM [Invoice] WHERE [Name]=@Name ", SqlConnection);

            command.Parameters.AddWithValue("Name", textBox6.Text);

            // обработчик
            try
            {
                // присвоить результат выполнения команды для дальнейшего вывода
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    // вывод таблицы
                    listBox3.Items.Add(Convert.ToString(SqlReader["Id"]) + "\t" + Convert.ToString(SqlReader["Name"]) + "  " + Convert.ToString(SqlReader["Date"]) + "         " + Convert.ToString(SqlReader["Account"]));
                }
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                // показать сообщение MessageBox.Show(текст, заголовок, кнопка, иконка)
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
                // обязательно закрыть ридер если ему все же было присвоено значение
                if (SqlReader != null)
                {
                    
                    SqlReader.Close();
                }
            }
        }
    }
}
