using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class ADOForm : Form
    {
        string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["WinApp.Properties.Settings.vsstudentsConnectionString"].ConnectionString;
        DataTable dt;

        public ADOForm()
        {
            dt = new DataTable();
            InitializeComponent();
            fillCombo();
            fill();
        }


        private bool checkFileds()
        {
            if (comboBoxFIO.Text == "")
            {
                MessageBox.Show("Необходимо выбрать студента", "Внимание");
                return false;
            }
            if (comboBoxSubj.Text == "")
            {
                MessageBox.Show("Необходимо выбрать предмет", "Внимание");
                return false;
            }
            if (textBoxValue.Text == "")
            {
                MessageBox.Show("Поле с оценкой не может быть пустым", "Внимание");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!checkFileds()) return;

            string idStud = getIdStud(comboBoxFIO.Text);
            string idSubj = getIdSubj(comboBoxSubj.Text);

            string date = "";
            if (textBoxDate.Text == "")
            {
                date = DateTime.Now.ToString("dd-MM-yyyy");
            }
            else date = textBoxDate.Text;
            string value = textBoxValue.Text;


            using (var connection = new SqlConnection(connstr))
            {
                string queryString = "insert into exams (idstudent, idsubject, dateexam, examvalue) " +
                    "values(@idstud,@idsubj,@date,@value)";
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@idstud", Convert.ToInt32(idStud));
                command.Parameters.AddWithValue("@idsubj", Convert.ToInt32(idSubj));
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@value", Convert.ToInt32(value));
                connection.Open();
                int res = command.ExecuteNonQuery();
                if(res != -1)
                {
                    MessageBox.Show("Экзамен добавлен","Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fill();
        }

        private string getIdSubj(string str)
        {
            using (var connection = new SqlConnection(connstr))
            {
                string qs = "select idsubject from subjects " +
                    "where name = @subj";
                var command = new SqlCommand(qs, connection);
                command.Parameters.AddWithValue("@subj", str);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader[0].ToString();
                    }
                    else return null;
                }
            }
        }

        private string getIdStud(string str)
        {
            using (var connection = new SqlConnection(connstr))
            {
                string qs = "select idstudent from students " +
                    "where fio = @fio";
                var command = new SqlCommand(qs, connection);
                command.Parameters.AddWithValue("@fio",str);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return reader[0].ToString();
                    }
                    else return null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) return;

            if (!checkFileds()) return;

            ListViewItem items = listView1.SelectedItems[0];
            int idExam = Convert.ToInt32(items.SubItems[0].Text);

            string idStud = getIdStud(comboBoxFIO.Text);
            string idSubj = getIdSubj(comboBoxSubj.Text);
            string value = textBoxValue.Text;

            string date = "";
            if (textBoxDate.Text == "")
            {
                date = DateTime.Now.ToString("dd-MM-yyyy");
            }
            else date = textBoxDate.Text;

            DialogResult dialogResult = MessageBox.Show("Хотите изменить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            

            using (var connection = new SqlConnection(connstr))
            {
                string queryString = "update exams " +
                    "set idstudent = @idstud, idsubject = @idsubj, dateexam = @date, examvalue = @value " +
                    "where idexam = @idExam";
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@idstud", Convert.ToInt32(idStud));
                command.Parameters.AddWithValue("@idsubj", Convert.ToInt32(idSubj));
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@value", Convert.ToInt32(value));
                command.Parameters.AddWithValue("@idexam", idExam);
                connection.Open();
                int res = command.ExecuteNonQuery();
                if (res != -1)
                {
                    MessageBox.Show("Экзамен изменен", "Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fill();
        }

        private void fillCombo()
        {
            using (var connection = new SqlConnection(connstr))
            {
                string qs = "select fio from students";
                var command = new SqlCommand(qs, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxFIO.Items.Add(reader[0]);
                    }
                }
            }
            
            using (var connection = new SqlConnection(connstr))
            {
                string qs = "select name from subjects";
                var command = new SqlCommand(qs, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxSubj.Items.Add(reader[0]);
                    }
                }
            }

        }

        private void fillTable()
        {
            string queryString = "SELECT idexam,fio,name,dateexam,examvalue FROM Exams " +
               "inner join students on students.idstudent = exams.idstudent " +
               "inner join subjects on subjects.idsubject = exams.idsubject " + "";
               /*"where exams.examvalue > @ev";*/
            using (var connection = new SqlConnection(connstr))
            {
                SqlDataAdapter ada = new SqlDataAdapter(queryString, connection);
                ada.Fill(dt);
            }
        }

        private void sortListView(string column)
        {
            dt.DefaultView.Sort = column+" asc";
            dt = dt.DefaultView.ToTable();
            fillListView();
        }

        private void fillListView()
        {
            listView1.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["idexam"].ToString());
                listitem.SubItems.Add(dr["fio"].ToString());
                listitem.SubItems.Add(dr["name"].ToString());
                listitem.SubItems.Add(dr["dateexam"].ToString());
                listitem.SubItems.Add(dr["examValue"].ToString());
                listView1.Items.Add(listitem);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) return;
            
            ListViewItem items = listView1.SelectedItems[0];
            int idExam = Convert.ToInt32(items.SubItems[0].Text);

            DialogResult dialogResult = MessageBox.Show("Хотите удалить?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            using (var connection = new SqlConnection(connstr))
            {
                string queryString = "delete from exams where idexam = @idExam";
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@idexam", idExam);
                connection.Open();
                int res = command.ExecuteNonQuery();
                if (res != -1)
                {
                    MessageBox.Show("Экзамен удален", "Сообщение",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            fill();
        }

        private void fill()
        {
            fillTable();
            fillListView();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 1:
                    sortListView("fio");
                    break;
                case 2:
                    sortListView("name");
                    break;
                case 3:
                    sortListView("dateexam");
                    break;
                case 4:
                    sortListView("examvalue");
                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) return;

            // Get the selected item.
            ListViewItem items = listView1.SelectedItems[0];

            comboBoxFIO.SelectedIndex = comboBoxFIO.Items.IndexOf(items.SubItems[1].Text);
            comboBoxSubj.SelectedIndex = comboBoxSubj.Items.IndexOf(items.SubItems[2].Text);
            textBoxDate.Text = items.SubItems[3].Text;
            textBoxValue.Text = items.SubItems[4].Text;
        }
    }
}
