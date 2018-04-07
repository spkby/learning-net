using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void examsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
      

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void examsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.examsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsstudentsDataSet);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsstudentsDataSet.Subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.vsstudentsDataSet.Subjects);
            // TODO: This line of code loads data into the 'vsstudentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.vsstudentsDataSet.Students);
            // TODO: This line of code loads data into the 'vsstudentsDataSet.Exams' table. You can move, or remove it, as needed.
            this.examsTableAdapter.Fill(this.vsstudentsDataSet.Exams);

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            using (StudentsForm form = new StudentsForm())
            {
                form.ShowDialog();
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            using (SubjectsForm form = new SubjectsForm())
            {
                form.ShowDialog();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            using (ADOForm form = new ADOForm())
            {
                form.ShowDialog();
            }
        }
    }
}
