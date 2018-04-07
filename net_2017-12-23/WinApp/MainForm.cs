using System;
using System.Windows.Forms;
using ClassLibrary;

namespace WinApp
{
    

    public partial class MainForm : Form
    {
        ContextDB contextDB = new ContextDB();

        const string FILTER_CSV = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
        const string FILTER_BIN = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
        const string FILTER_XML = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
        const string FILTER_JSON = "json files (*.json)|*.json|All files (*.*)|*.*";


        public MainForm()
        {
            InitializeComponent();
            showStudents();
            showCurStudent(contextDB.GetCurStudent());
            showSelectedStudent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void showCurStudent(Student s)
        {
            if (s == null) return;
            textFirstName.Text = s.firstName;
            textLastName.Text = s.lastName;
            textAge.Text = s.age.ToString();
            textGroup.Text = s.group.name;
            textCourse.Text = s.group.course.ToString();
        }

        void showStudents()
        {
            Student[] students = contextDB.GetStudents();
            listBox.Items.Clear();
            foreach(Student s in students)
            {
                listBox.Items.Add(s);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = (Student)listBox.SelectedItem;
            contextDB.SetCurStudent(s);
            showCurStudent(contextDB.GetCurStudent());
        }

        private void butPrev_Click(object sender, EventArgs e)
        {
            contextDB.Prev();
            showSelectedStudent();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            contextDB.Next();
            showSelectedStudent();
        }

        void showSelectedStudent()
        {
            if (contextDB.GetCurStudent() == null) return;
            if (listBox.Items.IndexOf(contextDB.GetCurStudent()) == -1) return;
            listBox.SelectedIndex = listBox.Items.IndexOf(contextDB.GetCurStudent());
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            delete();
        }


        private void delete()
        {
            contextDB.Remove();
            showStudents();
            showSelectedStudent();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            Student s = new Student(textFirstName.Text, textLastName.Text, Convert.ToInt32(textAge.Text),
                textGroup.Text, Convert.ToInt32(textCourse.Text));
            contextDB.Edit(s);
            showStudents();
            showSelectedStudent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            contextDB.Add(textFirstName.Text, textLastName.Text, Convert.ToInt32(textAge.Text),
                textGroup.Text, Convert.ToInt32(textCourse.Text));
            showStudents();
            showSelectedStudent();
        }

        private void textAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void textCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8) e.KeyChar = '\0';
        }

        private void xMLSaxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToFile(3);
        }

        private void xMLSaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(3);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(1);
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToFile(1);
        }


        private void SaveToFile(byte type)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            switch (type)
            {
                case 1:
                    dialog.Filter = FILTER_CSV;
                    break;
                case 2:
                    dialog.Filter = FILTER_BIN;
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    dialog.Filter = FILTER_XML;
                    break;
                case 7:
                case 8:
                    dialog.Filter = FILTER_JSON;
                    break;
            }
            
            dialog.InitialDirectory = "c:\\";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caption = "Запись файла";
                try
                {

                    contextDB.SaveTo(type, dialog.FileName);

                    MessageBox.Show("Данные записаны в файл успешно", caption,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При записи файла произошла ошибка: \n" + ex.Message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                }
            }
        }

        private void LoadFromFile(byte type)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            switch (type)
            {
                case 1:
                    dialog.Filter = FILTER_CSV;
                    break;
                case 2:
                    dialog.Filter = FILTER_BIN;
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    dialog.Filter = FILTER_XML;
                    break;
                case 7:
                case 8:
                    dialog.Filter = FILTER_JSON;
                    break;
            }

            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caption = "Чтение данных из файла";
                try
                {
                    contextDB.LoadFrom(type, dialog.FileName);

                    showStudents();
                    showSelectedStudent();
                    MessageBox.Show("Данный из файла считаны успешно", caption,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    showStudents();
                    showSelectedStudent();
                    MessageBox.Show("При чтение данных из файла произошла ошибка: \n" + ex.Message, caption,
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }
        }

        private void binToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(2);
        }

        private void binToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToFile(2);
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile(5);
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadFromFile(5);
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    delete();
                    break;
            }
        }

        private void dataContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile(7);
        }

        private void dataContractToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadFromFile(7);
        }

        private void javaScriptSerializerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(8);
        }

        private void jSSerializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile(8);
        }

        private void xMLDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(4);
        }

        private void xMLDOMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveToFile(4);
        }

        private void linqXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveToFile(6);
        }

        private void xMLLinqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFromFile(6);
        }
    }
}
