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

namespace Accountig
{
    public partial class MainWindow : Form
    {
        SqlConnection SqlConnection;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            // подключение к БД
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 'C:\Users\dmytro\Documents\Visual Studio 2015\Projects\Accountig\Accountig\Database.mdf'; Integrated Security = True";
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
                    listBox1.Items.Add(Convert.ToString(SqlReader["Id"]) + "  " + Convert.ToString(SqlReader["Name"]) + "  " + Convert.ToString(SqlReader["Date"]) + "  " + Convert.ToString(SqlReader["Account"]));
                }
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
    }
}
