using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MyBlogs.DBUtility;//Please add references
namespace MyBlogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogphotoalblumDAL
	/// </summary>
	public partial class BlogphotoalblumDAL
	{
		public BlogphotoalblumDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "blogphotoalblum"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from blogphotoalblum");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyBlogs.Model.Blogphotoalblum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into blogphotoalblum(");
			strSql.Append("Id,AuthorId,Title,CoverSrc,PhotoNum,Status,AddTime,IsDel)");
			strSql.Append(" values (");
			strSql.Append("@Id,@AuthorId,@Title,@CoverSrc,@PhotoNum,@Status,@AddTime,@IsDel)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@AuthorId", MySqlDbType.Int32,11),
					new MySqlParameter("@Title", MySqlDbType.VarChar,50),
					new MySqlParameter("@CoverSrc", MySqlDbType.VarChar,255),
					new MySqlParameter("@PhotoNum", MySqlDbType.Int32,11),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@AddTime", MySqlDbType.Timestamp),
					new MySqlParameter("@IsDel", MySqlDbType.Bit)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.AuthorId;
			parameters[2].Value = model.Title;
			parameters[3].Value = model.CoverSrc;
			parameters[4].Value = model.PhotoNum;
			parameters[5].Value = model.Status;
			parameters[6].Value = model.AddTime;
			parameters[7].Value = model.IsDel;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyBlogs.Model.Blogphotoalblum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update blogphotoalblum set ");
			strSql.Append("AuthorId=@AuthorId,");
			strSql.Append("Title=@Title,");
			strSql.Append("CoverSrc=@CoverSrc,");
			strSql.Append("PhotoNum=@PhotoNum,");
			strSql.Append("Status=@Status,");
			strSql.Append("IsDel=@IsDel");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@AuthorId", MySqlDbType.Int32,11),
					new MySqlParameter("@Title", MySqlDbType.VarChar,50),
					new MySqlParameter("@CoverSrc", MySqlDbType.VarChar,255),
					new MySqlParameter("@PhotoNum", MySqlDbType.Int32,11),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@IsDel", MySqlDbType.Bit),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.AuthorId;
			parameters[1].Value = model.Title;
			parameters[2].Value = model.CoverSrc;
			parameters[3].Value = model.PhotoNum;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.IsDel;
			parameters[6].Value = model.Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from blogphotoalblum ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from blogphotoalblum ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperMySQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyBlogs.Model.Blogphotoalblum GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,AuthorId,Title,CoverSrc,PhotoNum,Status,AddTime,IsDel from blogphotoalblum ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			MyBlogs.Model.Blogphotoalblum model=new MyBlogs.Model.Blogphotoalblum();
			DataSet ds=DbHelperMySQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyBlogs.Model.Blogphotoalblum DataRowToModel(DataRow row)
		{
			MyBlogs.Model.Blogphotoalblum model=new MyBlogs.Model.Blogphotoalblum();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["AuthorId"]!=null && row["AuthorId"].ToString()!="")
				{
					model.AuthorId=int.Parse(row["AuthorId"].ToString());
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["CoverSrc"]!=null)
				{
					model.CoverSrc=row["CoverSrc"].ToString();
				}
				if(row["PhotoNum"]!=null && row["PhotoNum"].ToString()!="")
				{
					model.PhotoNum=int.Parse(row["PhotoNum"].ToString());
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["IsDel"]!=null && row["IsDel"].ToString()!="")
				{
					if((row["IsDel"].ToString()=="1")||(row["IsDel"].ToString().ToLower()=="true"))
					{
						model.IsDel=true;
					}
					else
					{
						model.IsDel=false;
					}
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,AuthorId,Title,CoverSrc,PhotoNum,Status,AddTime,IsDel ");
			strSql.Append(" FROM blogphotoalblum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM blogphotoalblum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperMySQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from blogphotoalblum T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperMySQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			MySqlParameter[] parameters = {
					new MySqlParameter("@tblName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@fldName", MySqlDbType.VarChar, 255),
					new MySqlParameter("@PageSize", MySqlDbType.Int32),
					new MySqlParameter("@PageIndex", MySqlDbType.Int32),
					new MySqlParameter("@IsReCount", MySqlDbType.Bit),
					new MySqlParameter("@OrderType", MySqlDbType.Bit),
					new MySqlParameter("@strWhere", MySqlDbType.VarChar,1000),
					};
			parameters[0].Value = "blogphotoalblum";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperMySQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

