using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace HandlerCaptcha
{
    /// <summary>
    /// Сводное описание для Captcha
    /// </summary>
    public class Captcha : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string name = context.Request.QueryString["name"];

            

            Bitmap image = new Bitmap(300, 100);
            Graphics graphics = Graphics.FromImage(image);
            Font font = new Font("Impact", 20, FontStyle.Regular);

            graphics.DrawString(name, font, Brushes.Blue, 10, 5);

            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 55, 55));

            graphics.FillEllipse(solidBrush, 5, 5, 10, 10);
            context.Response.ContentType = "image/jpeg";
            image.Save(context.Response.OutputStream, ImageFormat.Jpeg);
            
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