using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WFAdo : System.Web.UI.Page
    {

        string connstr = "Data Source=vsstudents.mssql.somee.com;Initial Catalog = vsstudents; Persist Security Info=True;User ID = login; Password=pass";
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
           dt = new DataTable();
           // fillCombo();
            fill();

        }

        private void fill()
        {
            fillTable();
            fillListView();
        }

        private void fillTable()
        {
            string queryString = "SELECT idexam,fio,name,dateexam,examvalue FROM Exams " +
              "inner join students on students.idstudent = exams.idstudent " +
              "inner join subjects on subjects.idsubject = exams.idsubject " + "";
          
            using (var connection = new SqlConnection(connstr))
            {
                SqlDataAdapter ada = new SqlDataAdapter(queryString, connection);
                ada.Fill(dt);
            }
        }

        private void fillListView()
        {
            GridView1.DataSource = dt;
            GridView1.DataBind();
            //GridView1.Columns[0].Visible = false;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;

        }
    }
}