using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogs.Common
{
    public class Kits
    {
        /// <summary>
        /// json序列号器
        /// </summary>
        /// <param name="obj">序列化对象</param>
        /// <returns>返回json字符串</returns>
        public static string JsSerializer(object obj)
        {
            System.Web.Script.Serialization.JavaScriptSerializer jsSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return jsSerializer.Serialize(obj);
        }

    }

}
