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
    public partial class Form4 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form4()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet1.Chita". При необходимости она может быть перемещена или удалена.
            this.chitaTableAdapter.Fill(this.biblDataSet1.Chita);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.Chita". При необходимости она может быть перемещена или удалена.
            this.chitaTableAdapter.Fill(this.biblDataSet.Chita);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(connect);
            Connection.Open();
            if (textBox1.Text == "")
                MessageBox.Show("Заполните поле");
            else
            {          
                string query = "DELETE FROM Chita WHERE [Код] =" + textBox1.Text;
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные читателя успешно удалены");
                this.chitaTableAdapter.Fill(this.biblDataSet.Chita);
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
                    string query = "Select [Код], [Имя], [Фамилия], [Действие билета до], [Статус билета] FROM [Chita] WHERE [Код] LIKE '%" + naim1 + "%'";
                    OleDbDataAdapter command = new OleDbDataAdapter(query, Connection);
                    DataTable dt0 = new DataTable();
                    command.Fill(dt0);
                    dataGridView1.DataSource = dt0;
                    Connection.Close();
                    break;
                case 1:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                    string naim = textBox2.Text;
                    string query1 = "Select [Код], [Имя], [Фамилия], [Действие билета до], [Статус билета] FROM [Chita] WHERE [Имя] LIKE '%" + naim + "%'";
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
                    string query2 = "Select [Код], [Имя], [Фамилия], [Действие билета до], [Статус билета] FROM [Chita] WHERE [Фамилия] LIKE '%" + marka + "%'";
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
                    string query3 = "Select [Код], [Имя], [Фамилия], [Действие билета до], [Статус билета] FROM [Chita] WHERE  [Действие билета до] LIKE '%" + art + "%'";
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
                    string query4 = "Select [Код], [Имя], [Фамилия], [Действие билета до], [Статус билета] FROM [Chita] WHERE [Статус билета] LIKE '%" + cenaz + "%'";
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
            string query6 = "Select [Код], [Имя], [Фамилия], [Действие билета до], [Статус билета]  FROM [Chita]";
            OleDbDataAdapter command6 = new OleDbDataAdapter(query6, Connection);
            DataTable dt6 = new DataTable();
            command6.Fill(dt6);
            dataGridView1.DataSource = dt6;
            Connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.Owner = this;
            F7.Show();
        }      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();
                   
            string query = @"UPDATE Chita SET [Статус билета] = @DAT WHERE [Имя] = @DAT1 AND [Фамилия] = @DAT2";
            OleDbCommand command = new OleDbCommand(query, Connection);
                    command.Parameters.AddWithValue("@DAT", "Активен");
                    command.Parameters.AddWithValue("@DAT1", textBox3.Text);
                    command.Parameters.AddWithValue("@DAT2", textBox4.Text);
                    command.ExecuteNonQuery();
            MessageBox.Show("Данные билета обновлены");
            this.chitaTableAdapter.Fill(this.biblDataSet.Chita);
                    break;
                case 1:
                    Connection = new OleDbConnection(connect);
                    Connection.Open();                 
                    string query1 = @"UPDATE Chita SET [Статус билета] = @DAT WHERE [Имя] = @DAT1 AND [Фамилия] = @DAT2 ";
                    OleDbCommand command1 = new OleDbCommand(query1, Connection);
                    command1.Parameters.AddWithValue("@DAT", "Неактивен");
                    command1.Parameters.AddWithValue("@DAT1", textBox3.Text);
                    command1.Parameters.AddWithValue("@DAT2", textBox4.Text);
                    command1.ExecuteNonQuery();
                    MessageBox.Show("Данные билета обновлены");
                    this.chitaTableAdapter.Fill(this.biblDataSet.Chita);
                    break;
            }
        }
    }
}