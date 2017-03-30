using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MyBlogs.DBUtility;//Please add references

namespace MyBlogs.DAL
{
    public partial class BlogarticleDAL
    {
        public DataSet GetList_Exp(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,CategoryId,AuthorId,Content,ImgSrc,CommentNum,AllowComment,IsTop,Tag,CickNum,Status,AddTime,UpdateTime,IsDel,HtmlSrc ");
            strSql.Append(" FROM blogarticle ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}
