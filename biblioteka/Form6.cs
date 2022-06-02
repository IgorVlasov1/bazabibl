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
    public partial class Form6 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form6()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == ""
               || textBox5.Text == "")
                MessageBox.Show("Не все поля заполнены");
            else
            {
                          
                string query = @"INSERT INTO [Knigi_sclad] ([Название], [Автор], [Переплет], [Количество]) VALUES (@Kod1122, @Kod2222, @Kod3322, @Kod4422)";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.Parameters.AddWithValue("@Kod1122", textBox2.Text);
                command.Parameters.AddWithValue("@Kod2222", textBox3.Text);
                command.Parameters.AddWithValue("@Kod3322", textBox4.Text);
                command.Parameters.AddWithValue("@Kod4422", textBox5.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные книги успешно добавлены");
            }
    }
}
}