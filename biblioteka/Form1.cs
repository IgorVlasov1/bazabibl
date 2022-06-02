using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F2 = new Form2();
            F3 = new Form3();
            F4 = new Form4();
            F9 = new Form9();
        }
        Form2 F2;
        Form3 F3;
        Form4 F4;
        Form9 F9;
      
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Owner = this;
            F2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Owner = this;
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Owner = this;
            F4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 F9 = new Form9();
            F9.Owner = this;
            F9.Show();
        }
    }
}
