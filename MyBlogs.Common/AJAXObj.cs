using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogs.Common
{
    public class AJAXObj
    {
        string status;
        string msg;
        object datas;

        public string Msg { get => msg; set => msg = value; }
        public object Datas { get => datas; set => datas = value; }
        public string Status { get => status; set => status = value; }
    }
}
