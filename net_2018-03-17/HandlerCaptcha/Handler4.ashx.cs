using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace HandlerCaptcha
{
    /// <summary>
    /// Сводное описание для Handler4
    /// </summary>
    public class Handler4 : IHttpHandler
    {
        string connString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void ProcessRequest(HttpContext context)
        {
            string num = context.Request.QueryString["num"];

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand("select img from Images where id=@num", connection);
            command.Parameters.AddWithValue("@num", Convert.ToInt32(num));
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();            
            reader.Read();

            byte[] imgfromdb = reader.GetSqlBytes(0).Value;
            MemoryStream stream = new MemoryStream(imgfromdb);          
            Bitmap img = new Bitmap(stream);

            context.Response.ContentType = "image/jpeg";
            img.Save(context.Response.OutputStream, ImageFormat.Jpeg);
            connection.Close();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}