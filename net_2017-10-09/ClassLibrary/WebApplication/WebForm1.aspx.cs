using System;
using ClassLibrary;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double xA, xB, xC, yA, yB, yC;

            xA = Convert.ToDouble(TextBoxAx.Text);
            xB = Convert.ToDouble(TextBoxBx.Text);
            xC = Convert.ToDouble(TextBoxCx.Text);
            yA = Convert.ToDouble(TextBoxAy.Text);
            yB = Convert.ToDouble(TextBoxBy.Text);
            yC = Convert.ToDouble(TextBoxCy.Text);

            Triangle tr = new Triangle(xA, xB, xC, yA, yB, yC);

            if(tr.CheckExist())
            {
                LabelP.Visible = true;
                LabelP.Text = tr.GetP().ToString();

                LabelS.Visible = true;
                LabelS.Text = tr.GetS().ToString();
            }
            else
            {
                return;               
            }
           
        }
    }
}