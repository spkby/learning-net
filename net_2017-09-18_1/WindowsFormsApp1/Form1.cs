using ClassLibrary;
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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassRoot root = new ClassRoot();
            double d = root.root(Convert.ToDouble(textPow.Text.Replace(".", ",")), Convert.ToDouble(textNumber.Text.Replace(".", ",")), Convert.ToDouble(textAccuracy.Text.Replace(".", ",")));

            labelResult.Text = d.ToString();
            labelResult.Visible = true;

            d = root.chk(Convert.ToDouble(textPow.Text.Replace(".", ",")), Convert.ToDouble(textNumber.Text.Replace(".", ",")), Convert.ToDouble(textAccuracy.Text.Replace(".", ",")));
            labelChk.Text = d.ToString();
            labelChk.Visible = true;
        }
    }
}
