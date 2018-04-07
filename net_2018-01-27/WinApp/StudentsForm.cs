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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vsstudentsDataSet);

        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vsstudentsDataSet.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.vsstudentsDataSet.Groups);
            // TODO: This line of code loads data into the 'vsstudentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.vsstudentsDataSet.Students);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (GroupsForm form = new GroupsForm())
            {
                form.ShowDialog();
            }
        }
    }
}
