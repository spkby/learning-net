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
            textBox2.Clear();
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                string strIn = textBox1.Lines[i];
                string strOut = "";

                for (int j = 0; j < strIn.Length; j++)
                {
                    if (Char.IsUpper(strIn[j]) == true)
                    {
                        strOut += Char.ToLower(strIn[j]);
                    }
                    else
                    {
                        strOut += Char.ToUpper(strIn[j]);
                    }
                }
                textBox2.AppendText(strOut + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                MatchCollection m = Regex.Matches(textBox1.Lines[i], "[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]");
                for (int j = 0; j < m.Count; j++)
                {
                    textBox2.AppendText(m[j].ToString() + "\n");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                string[] str = Regex.Split(textBox1.Lines[i], @"[+*/\-]");
                MatchCollection m = Regex.Matches(textBox1.Lines[i], @"[+*/\-]");
                float sum = 0;
                for (int j = 0, k = 0; j < str.Length; j++)
                {
                    if (j == 0)
                    {
                        sum = Convert.ToInt32(str[j].ToString());
                        continue;
                    }
                    switch (m[k].ToString())
                    {
                        case "+":
                            sum = sum + Convert.ToInt32(str[j].ToString());
                            break;
                        case "-":
                            sum = sum - Convert.ToInt32(str[j].ToString());
                            break;
                        case "*":
                            sum = sum * Convert.ToInt32(str[j].ToString());
                            break;
                        case "/":
                            sum = sum / Convert.ToInt32(str[j].ToString());
                            break;
                    }
                    k++;
                }
                textBox2.AppendText(sum.ToString());
            }

        }
    }
}
