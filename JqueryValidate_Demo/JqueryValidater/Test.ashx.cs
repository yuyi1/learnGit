using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryValidater
{
    /// <summary>
    /// Test 的摘要说明
    /// </summary>
    public class Test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var form = context.Request.Form;
            var keys = form.Keys;
            List<string> lists = new List<string>();

            context.Response.Write("Hello World");
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