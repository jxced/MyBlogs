using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyBlogs.Site
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string M { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            M = "4";
    }
    }
}