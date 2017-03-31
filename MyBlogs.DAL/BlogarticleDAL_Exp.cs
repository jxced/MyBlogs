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
            strSql.Append("SELECT a.*,ac.`Name`,u.CnName,e.Type,e.CnName AS statusName FROM blogarticle as a	left JOIN blogarticlecategory as ac on a.CategoryId=ac.Id LEFT JOIN bloguser as u ON u.Id=a.AuthorId LEFT JOIN enumeration as e ON e.Id=a.`Status`");
            //strSql.Append("");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperMySQL.Query(strSql.ToString());
        }
    }
}
