using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string[] str = textBox1.Lines;
            for (int i = 0; i < str.Length; i++)
            {
                string[] numbers = str[i].Split(',');

                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = numbers[j].Replace('.', ',');
                }               
                textBox2.AppendText("X: "+ numbers[0] + " Y: "+numbers[1]+"\n");
            }
        }
    }
}
