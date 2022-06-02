using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace biblioteka
{
    public partial class Form5 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
       
        public Form5()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Не все поля заполнены");
            else
            {             
                string query = "INSERT INTO [Knigipril] ([Название], [Автор], [Переплет], [Дата поступления]) VALUES (@Kod111, @Kod222, @Kod333, @Kod444)";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.Parameters.AddWithValue("@Kod111", textBox2.Text);
                command.Parameters.AddWithValue("@Kod222", textBox3.Text);
                command.Parameters.AddWithValue("@Kod333", textBox4.Text);
                command.Parameters.AddWithValue("@Kod444", dateTimePicker1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные книги успешно добавлены");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
