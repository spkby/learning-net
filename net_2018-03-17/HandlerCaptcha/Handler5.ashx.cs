﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandlerCaptcha
{
    /// <summary>
    /// Сводное описание для Handler5
    /// </summary>
    public class Handler5 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Привет всем!");
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