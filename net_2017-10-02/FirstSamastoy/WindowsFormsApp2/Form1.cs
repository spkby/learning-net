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
            string inputStr = "";
            string outStr = "";

            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                inputStr = textBox1.Lines[i];
                outStr = "";
                for (int j = 0; j < inputStr.Length; j++)
                {
                    if(Char.IsUpper(inputStr[j]))
                    {
                        outStr += Char.ToLower(inputStr[j]);
                    }
                    else
                    {
                        if(Char.IsLower(inputStr[j]))
                        {
                            outStr += Char.ToUpper(inputStr[i]);
                        }
                    } 
                }

                textBox2.AppendText(outStr);
            }
        }
    }
}
