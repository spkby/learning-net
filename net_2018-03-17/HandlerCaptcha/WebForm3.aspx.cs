using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandlerCaptcha
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string connString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            if(FileUpload1.HasFiles)
            {
                MemoryStream stream = new MemoryStream(FileUpload1.FileBytes);
                SqlConnection connection = new SqlConnection(connString);
                SqlCommand command = new SqlCommand("insert into Images(id,img) values(2,@img)",connection);
                command.Parameters.AddWithValue("@img", FileUpload1.FileBytes);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}