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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kal = textBox1.Text;

            Regex r1 = new Regex(@"[-+]?\d+");
            MatchCollection didgits = r1.Matches(kal);
            Console.WriteLine("Количество чисел в тексте {0}", didgits.Count);
            foreach (Match item in didgits)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();

        }
    }
}
