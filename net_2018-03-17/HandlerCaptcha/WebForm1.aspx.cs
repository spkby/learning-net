using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HandlerCaptcha
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["captcha"] = "123";
            Image.ImageUrl = "~/Captcha.ashx?name="+ Session["captcha"];
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Image.ImageUrl = "~/Captcha.ashx?name=" + TextBox1.Text;
            Session["captcha"] = TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Equals((string)Session["captcha"])) Label1.Text = "Correct";
            else Label1.Text = "Wrong";
            Label1.Visible = true;
        }
    }
}