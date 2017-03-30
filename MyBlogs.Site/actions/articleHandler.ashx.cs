using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBlogs.BLL;
using MyBlogs.Model;
using MyBlogs.Common;

namespace MyBlogs.Site.actions
{
    /// <summary>
    /// articleHandler1 的摘要说明
    /// </summary>
    public class articleHandler : baseAshx
    {

        //public void ProcessRequest(HttpContext context)
        //{
        //    context.Response.ContentType = "text/plain";
        //    context.Response.Write("Hello World");
        //}
        BlogarticleBLL artB = new BlogarticleBLL();
        enum statusEN
        {
            err,
            success
        }
        public override void SubProcessRequest(HttpContext context)
        {
            string type = Request.Params["type"];
            try
            {
                switch (type)
                {
                    case "loadList":
                        LoadList(statusEN.success, null);
                        break;
                    case "add":
                        Add();
                        break;
                    case "edit":
                        Edit();
                        break;
                    case "del":
                        Del();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                LoadList(statusEN.err, ex);
            }
        }

        private void Del()
        {
            List<Blogarticle> artList = artB.GetModelList(" isDel=0 ");
        }

        private void Edit()
        {

        }

        private void Add()
        {

        }

        private void LoadList(statusEN en, Exception ex)
        {
            AJAXObj obj = null;
            if (en == statusEN.err)
            {
                obj = new AJAXObj()
                {
                    Status = statusEN.err.ToString(),
                    Msg = ex.Message,
                    Datas = null
                };
            }
            else if (en == statusEN.success)
            {
                obj = new AJAXObj()
                {
                    Status = statusEN.success.ToString(),
                    Msg = "加载成功",
                    Datas = artB.GetModelList(" IsDel=0 ")
                };
            }
            string jsonStr = Kits.JsSerializer(obj);
            Response.Write(jsonStr);
        }

        //public bool IsReusable
        //{
        //    get
        //    {
        //        return false;
        //    }
        //}
    }
}