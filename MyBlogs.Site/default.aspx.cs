using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyBlogs.Model;
using MyBlogs.BLL;
using MyBlogs.Common;
using System.Data;

namespace MyBlogs.Site
{
    public partial class _default : System.Web.UI.Page
    {
        BlogarticlecategoryBLL articlecategoryBLL = new BlogarticlecategoryBLL();
        protected string responsestr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string method = Request.HttpMethod.ToLower();
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            if (method=="get")
            {
                DataTable ds = articlecategoryBLL.GetListExt("enums.IsDel=0 AND bac.IsDel=0 AND buser.IsDel=0").Tables[0];
                //< div class="table-row-group">
                //         <ul class="table-row">
                //             <li class="table-cell">
                //                 <input type = "checkbox" /></ li >
                //             < li class="table-cell">John</li>
                //             <li class="table-cell">19</li>
                //             <li class="table-cell">1</li>
                //             <li class="table-cell">John</li>
                //             <li class="table-cell">19</li>
                //         </ul>
                //     </div>
                if (ds.Rows.Count > 0)
                {
                    sb.Append("<div class=\"table-row-group\">");
                    foreach (DataRow row in ds.Rows)
                    {
                        sb.Append("<ul class=\"table-row\">");
                        sb.Append("<li class=\"table-cell\"><input type = \"checkbox\" name=\"chk\" value='"+row["Id"]+"' /></li>");
                        sb.Append("<li class=\"table-cell\">" + row["Id"] + "</li>");
                        sb.Append("<li class=\"table-cell\">" + row["CnName"] + "</li>");
                        sb.Append("<li class=\"table-cell\">" + row["Name"] + "</li>");
                        sb.Append("<li class=\"table-cell\">" + row["Remark"] + "</li>");
                        sb.Append("<li class=\"table-cell\">" + row["typename"] + "</li>");
                        sb.Append("<li class=\"table-cell\"><a href='javascript: void(0);' onclick='#'>编辑</a>|<a href='javascript: void(0);' onclick='#'>删除</a></li>");
                        sb.Append("</ul>");
                    }
                    sb.Append("</div>");
                    responsestr = sb.ToString();
                }
            }
            if (method=="post")
            {
                string s= Request.Form["chk"];
                if (!string.IsNullOrEmpty(s))
                {
                    articlecategoryBLL.DeleteList(s);
                }
            }
        }
    }
}