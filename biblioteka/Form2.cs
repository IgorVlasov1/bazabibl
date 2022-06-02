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
    public partial class Form2 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form2()
        {
            InitializeComponent();        
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }

 
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet1.Knigipril". При необходимости она может быть перемещена или удалена.
            this.knigiprilTableAdapter.Fill(this.biblDataSet1.Knigipril);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.Knigipril". При необходимости она может быть перемещена или удалена.
            this.knigiprilTableAdapter.Fill(this.biblDataSet.Knigipril);

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(connect);
            Connection.Open();
            if (textBox1.Text == "")
                MessageBox.Show("Заполните поле");
            else
            {
                
                string query = @"DELETE FROM Knigipril WHERE [Название] =@Kod25";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.Parameters.AddWithValue("@Kod25", textBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные книги успешно удалены");
                this.knigiprilTableAdapter.Fill(this.biblDataSet.Knigipril);
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
                    string query = "Select [Код], [Название], [Автор], [Переплет], [Дата поступления] FROM [Knigipril] WHERE [Код] LIKE '%" + naim1 + "%'";
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
                    string query1 = "Select [Код], [Название], [Автор], [Переплет], [Дата поступления] FROM [Knigipril] WHERE [Название] LIKE '%" + naim + "%'";
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
                    string query2 = "Select [Код],[Название], [Автор], [Переплет], [Дата поступления] FROM [Knigipril] WHERE [Автор] LIKE '%" + marka + "%'";
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
                    string query3 = "Select [Код],[Название], [Автор], [Переплет], [Дата поступления] FROM [Knigipril] WHERE [Переплет] LIKE '%" + art + "%'";
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
                    string query4 = "Select [Код],[Название], [Автор], [Переплет], [Дата поступления] FROM [Knigipril] WHERE [Дата поступления] LIKE '%" + cenaz + "%'";
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
                string query6 = "Select [Код], [Название], [Автор], [Переплет], [Дата поступления] FROM [Knigipril]";
                OleDbDataAdapter command6 = new OleDbDataAdapter(query6, Connection);
                DataTable dt6 = new DataTable();
                command6.Fill(dt6);
                dataGridView1.DataSource = dt6;
                Connection.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.Owner = this;
            F5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(connect);
            Connection.Open();                    
            string query = @"UPDATE Knigipril Set [Дата поступления] = @DAT WHERE [Название] = @Kod";
            OleDbCommand command = new OleDbCommand(query, Connection);
            command.Parameters.AddWithValue("@DAT", dateTimePicker1.Text);          
            command.Parameters.AddWithValue("@Kod", textBox3.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Дата поступления книги обновлена");
            this.knigiprilTableAdapter.Fill(this.biblDataSet.Knigipril);                                                         
        }
    
        private void button6_Click(object sender, EventArgs e)
        {
            Form8 F12 = new Form8();
            F12.Owner = this;
            F12.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

      

}
