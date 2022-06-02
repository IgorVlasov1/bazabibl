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
    public partial class Form7 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form7()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
                           || textBox5.Text == "" )
                MessageBox.Show("Не все поля заполнены");
            else
            {                                      
                string query = @"INSERT INTO [Chita] ([Имя], [Фамилия], [Действие билета до], [Статус билета]) VALUES (@Kod11, @Kod22, @Kod33, @Kod44)";
                OleDbCommand command = new OleDbCommand(query, Connection);                    
                command.Parameters.AddWithValue("@Kod11", textBox2.Text);
                command.Parameters.AddWithValue("@Kod22", textBox3.Text);
                command.Parameters.AddWithValue("@Kod33", textBox4.Text);
                command.Parameters.AddWithValue("@Kod44", textBox5.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные читателя успешно добавлены");
            }
    }
}
}