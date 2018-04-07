using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // забираем данные из формы
            string fio = textBox1.Text;
            string tel = textBox2.Text;
            string email = textBox3.Text;

            // описываем регулярки
            Regex r1 = new Regex(@"[a-z]+");
            Regex r2 = new Regex(@"\d\d\d-\d\d-\d\d");
            Regex r3 = new Regex(@"\w{1,10}@\w{1,5}.\w{1,3}");

            if (!r1.IsMatch(fio))
            {
                label4.Visible = true;
            }
            if (!r2.IsMatch(tel))
            {
                label5.Visible = true;
            }
            if (!r3.IsMatch(email))
            {
                label6.Visible = true;
            }
        }
    }
}
