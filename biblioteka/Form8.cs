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
    public partial class Form8 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form8()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Connection = new OleDbConnection(connect);
           Connection.Open();

            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
                MessageBox.Show("Не все поля заполнены");
            else
            {
                Connection = new OleDbConnection(connect);
                Connection.Open();          
                string query = @" INSERT INTO [UchetVid] ( [Дата выдачи], [Имя читателя], [Фамилия читателя], [Название книги], [Автор]) VALUES (@DAT, @Kod, @Kod1, @Kod2, @Kod3)";
               string query12 = @"UPDATE [Knigi_sclad] SET [Количество] = [Количество] - 1 WHERE [Название] = @Kod22";
                OleDbCommand command = new OleDbCommand(query, Connection);
                OleDbCommand command1 = new OleDbCommand(query12, Connection);
                command1.Parameters.AddWithValue("@Kod22", comboBox3.Text);
                command.Parameters.AddWithValue("@DAT", dateTimePicker1.Text);
                command.Parameters.AddWithValue("@Kod", comboBox1.Text);
                command.Parameters.AddWithValue("@Kod1", comboBox2.Text);
                command.Parameters.AddWithValue("@Kod2", comboBox3.Text);           
                command.Parameters.AddWithValue("@Kod3", comboBox4.Text);
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();              
                MessageBox.Show("Книга выдана");
            }
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.Chita". При необходимости она может быть перемещена или удалена.
            this.chitaTableAdapter.Fill(this.biblDataSet.Chita);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.Knigipril". При необходимости она может быть перемещена или удалена.
            this.knigiprilTableAdapter.Fill(this.biblDataSet.Knigipril);

        }
    }
}
