using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace HandlerCaptcha
{
    /// <summary>
    /// Сводное описание для Handler2
    /// </summary>
    public class Handler2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string name = context.Request.QueryString["img"];
            Bitmap image = null;
            switch (name)
            {
                case "1":
                    image = new Bitmap(@"C:\s\learning_net\net_2018-03-17\HandlerCaptcha\1.jpg");
                    break;
                case "2":
                    image = new Bitmap(@"C:\s\learning_net\net_2018-03-17\HandlerCaptcha\2.jpg");
                    break;
                case "3":
                    image = new Bitmap(@"C:\s\learning_net\net_2018-03-17\HandlerCaptcha\3.jpg");
                    break;
            }
            
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