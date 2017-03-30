using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogs.Site.actions
{
    /// <summary>
    /// _base 的摘要说明
    /// </summary>
    public abstract class baseAshx : IHttpHandler
    {
        public HttpRequest Request { get { return Context.Request; } }
        public HttpResponse Response { get { return Context.Response; }}
        public HttpContext Context { get { return HttpContext.Current; } }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //todo:验证稍后
           
            SubProcessRequest(context);
        }
        public abstract void SubProcessRequest(HttpContext context);
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}