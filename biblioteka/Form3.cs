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
    public partial class Form3 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form3()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.Knigi_sclad". При необходимости она может быть перемещена или удалена.
            this.knigi_scladTableAdapter.Fill(this.biblDataSet.Knigi_sclad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Заполните поле");
            else
            {
                Connection = new OleDbConnection(connect);
                Connection.Open();            
                string query = "DELETE FROM Knigi_sclad WHERE [Название] = @Kod253";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.Parameters.AddWithValue("@Kod253", textBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные книги успешно удалены");
                this.knigi_scladTableAdapter.Fill(this.biblDataSet.Knigi_sclad);
                Connection.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                    string naim1 = textBox2.Text;
                    string query = "Select [Код], [Название], [Автор], [Переплет], [Количество] FROM [Knigi_sclad] WHERE [Код] LIKE '%" + naim1 + "%'";
                    OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
                    DataTable dt = new DataTable();
                    command.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Connection.Close();
                    break;
                case 1:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                    string naim = textBox2.Text;
                    string query1 = "Select [Код], [Название], [Автор], [Переплет], [Количество] FROM [Knigi_sclad] WHERE [Название] LIKE '%" + naim + "%'";
                    OleDbDataAdapter command1 = new OleDbDataAdapter(query1, Connection);
                    DataTable dt1 = new DataTable();
                    command1.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                    Connection.Close();
                    break;
                case 2:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                    string marka = textBox2.Text;
                    string query2 = "Select [Код], [Название], [Автор], [Переплет], [Количество] FROM [Knigi_sclad] WHERE [Автор] LIKE '%" + marka + "%'";
                    OleDbDataAdapter command2 = new OleDbDataAdapter(query2, Connection);
                    DataTable dt2 = new DataTable();
                    command2.Fill(dt2);
                    dataGridView1.DataSource = dt2;
                    Connection.Close();
                    break;
                case 3:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                    string art = textBox2.Text;
                    string query3 = "Select [Код], [Название], [Автор], [Переплет], [Количество] FROM [Knigi_sclad] WHERE [Переплет] LIKE '%" + art + "%'";
                    OleDbDataAdapter command3 = new OleDbDataAdapter(query3, Connection);
                    DataTable dt3 = new DataTable();
                    command3.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    Connection.Close();
                    break;
                case 4:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                    string cenaz = textBox2.Text;
                    string query4 = "Select [Код], [Название], [Автор], [Переплет], [Количество] FROM [Knigi_sclad] WHERE [Количество] LIKE '%" + cenaz + "%'";
                    OleDbDataAdapter command4 = new OleDbDataAdapter(query4, Connection);
                    DataTable dt4 = new DataTable();
                    command4.Fill(dt4);
                    dataGridView1.DataSource = dt4;
                    Connection.Close();
                    break;
                
            }
    }
        private void button2_Click(object sender, EventArgs e)
        {
                Connection = new OleDbConnection(connect);
                Connection.Open();
                string query6 = "Select [Код], [Название], [Автор], [Переплет], [Количество]  FROM [Knigi_sclad]";
                OleDbDataAdapter command6 = new OleDbDataAdapter(query6, Connection);
                DataTable dt6 = new DataTable();
                command6.Fill(dt6);
                dataGridView1.DataSource = dt6;
                Connection.Close();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Owner = this;
            F6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(connect);
            Connection.Open();         
            string query = "UPDATE Knigi_sclad SET Количество = @Kod2535 WHERE [Название] = @Kod2537";
            OleDbCommand command = new OleDbCommand(query, Connection);
            command.Parameters.AddWithValue("@Kod2535", textBox4.Text);
            command.Parameters.AddWithValue("@Kod2537", textBox3.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Количество книг на складе обновлено");
            this.knigi_scladTableAdapter.Fill(this.biblDataSet.Knigi_sclad);
            Connection.Close();
        }

    }
}