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
    public partial class Form9 : Form
    {
        public static string connect = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = bibl.mdb";
        private OleDbConnection Connection;
        public Form9()
        {
            InitializeComponent();
            Connection = new OleDbConnection(connect);
            Connection.Open();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biblDataSet.UchetVid". При необходимости она может быть перемещена или удалена.
            this.uchetVidTableAdapter.Fill(this.biblDataSet.UchetVid);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection = new OleDbConnection(connect);
            Connection.Open();
            if ((textBox1.Text == "") || (textBox2.Text == ""))
                MessageBox.Show("Заполните поле");
            else
            {
                string query = "DELETE FROM UchetVid WHERE [Имя читателя] = @DAT12 AND [Фамилия читателя] = @DAT23";
                OleDbCommand command = new OleDbCommand(query, Connection);
                command.Parameters.AddWithValue("@DAT12", textBox1.Text);
                command.Parameters.AddWithValue("@DAT23", textBox2.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные читателя успешно удалены");
                this.uchetVidTableAdapter.Fill(this.biblDataSet.UchetVid);
            }
        }
    }
}
