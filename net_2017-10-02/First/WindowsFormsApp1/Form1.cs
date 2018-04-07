using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputStr = "";

            for(int i=0;i<textBox1.Lines.Length;i++)
            {
                inputStr = textBox1.Lines[i];
                string[] subStr = inputStr.Split(',');
                for (int j = 0; j < subStr.Length; j++)
                {
                    subStr[j] = subStr[j].Replace('.', ',');
                }

                textBox2.AppendText("X:" + subStr[0] + "Y:" + subStr[1] + "\n\r");
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
