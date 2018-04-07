using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandlerCaptcha
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<table>");
            for (int i = 1; i <= 3; i++)
            {
                Response.Write("<tr><td>"+i.ToString()+"</td><td>");
                Response.Write("<img src='Handler4.ashx?num=" + i.ToString()+"'>");
                Response.Write("</td></tr>");
            }
            Response.Write("</table>");
        }
    }
}