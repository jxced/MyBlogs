using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MyBlogs.DBUtility;//Please add references
namespace MyBlogs.DAL
{
	/// <summary>
	/// 数据访问类:BloguserDAL
	/// </summary>
	public partial class BloguserDAL
	{
		public BloguserDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "bloguser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from bloguser");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyBlogs.Model.Bloguser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into bloguser(");
			strSql.Append("LoginName,LoginPwd,CnName,Email,IsLock,IsDel,AddTime,LastLoginTime,LastLoginIp)");
			strSql.Append(" values (");
			strSql.Append("@LoginName,@LoginPwd,@CnName,@Email,@IsLock,@IsDel,@AddTime,@LastLoginTime,@LastLoginIp)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LoginName", MySqlDbType.VarChar,16),
					new MySqlParameter("@LoginPwd", MySqlDbType.VarChar,12),
					new MySqlParameter("@CnName", MySqlDbType.VarChar,25),
					new MySqlParameter("@Email", MySqlDbType.VarChar,20),
					new MySqlParameter("@IsLock", MySqlDbType.Bit),
					new MySqlParameter("@IsDel", MySqlDbType.Bit),
					new MySqlParameter("@AddTime", MySqlDbType.Timestamp),
					new MySqlParameter("@LastLoginTime", MySqlDbType.Timestamp),
					new MySqlParameter("@LastLoginIp", MySqlDbType.VarChar,20)};
			parameters[0].Value = model.LoginName;
			parameters[1].Value = model.LoginPwd;
			parameters[2].Value = model.CnName;
			parameters[3].Value = model.Email;
			parameters[4].Value = model.IsLock;
			parameters[5].Value = model.IsDel;
			parameters[6].Value = model.AddTime;
			parameters[7].Value = model.LastLoginTime;
			parameters[8].Value = model.LastLoginIp;

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
		public bool Update(MyBlogs.Model.Bloguser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update bloguser set ");
			strSql.Append("LoginName=@LoginName,");
			strSql.Append("LoginPwd=@LoginPwd,");
			strSql.Append("CnName=@CnName,");
			strSql.Append("Email=@Email,");
			strSql.Append("IsLock=@IsLock,");
			strSql.Append("IsDel=@IsDel,");
			strSql.Append("LastLoginIp=@LastLoginIp");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@LoginName", MySqlDbType.VarChar,16),
					new MySqlParameter("@LoginPwd", MySqlDbType.VarChar,12),
					new MySqlParameter("@CnName", MySqlDbType.VarChar,25),
					new MySqlParameter("@Email", MySqlDbType.VarChar,20),
					new MySqlParameter("@IsLock", MySqlDbType.Bit),
					new MySqlParameter("@IsDel", MySqlDbType.Bit),
					new MySqlParameter("@LastLoginIp", MySqlDbType.VarChar,20),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.LoginName;
			parameters[1].Value = model.LoginPwd;
			parameters[2].Value = model.CnName;
			parameters[3].Value = model.Email;
			parameters[4].Value = model.IsLock;
			parameters[5].Value = model.IsDel;
			parameters[6].Value = model.LastLoginIp;
			parameters[7].Value = model.Id;

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
			strSql.Append("delete from bloguser ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
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
			strSql.Append("delete from bloguser ");
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
		public MyBlogs.Model.Bloguser GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,LoginName,LoginPwd,CnName,Email,IsLock,IsDel,AddTime,LastLoginTime,LastLoginIp from bloguser ");
			strSql.Append(" where Id=@Id");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32)
			};
			parameters[0].Value = Id;

			MyBlogs.Model.Bloguser model=new MyBlogs.Model.Bloguser();
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
		public MyBlogs.Model.Bloguser DataRowToModel(DataRow row)
		{
			MyBlogs.Model.Bloguser model=new MyBlogs.Model.Bloguser();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["LoginName"]!=null)
				{
					model.LoginName=row["LoginName"].ToString();
				}
				if(row["LoginPwd"]!=null)
				{
					model.LoginPwd=row["LoginPwd"].ToString();
				}
				if(row["CnName"]!=null)
				{
					model.CnName=row["CnName"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["IsLock"]!=null && row["IsLock"].ToString()!="")
				{
					if((row["IsLock"].ToString()=="1")||(row["IsLock"].ToString().ToLower()=="true"))
					{
						model.IsLock=true;
					}
					else
					{
						model.IsLock=false;
					}
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
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["LastLoginTime"]!=null && row["LastLoginTime"].ToString()!="")
				{
					model.LastLoginTime=DateTime.Parse(row["LastLoginTime"].ToString());
				}
				if(row["LastLoginIp"]!=null)
				{
					model.LastLoginIp=row["LastLoginIp"].ToString();
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
			strSql.Append("select Id,LoginName,LoginPwd,CnName,Email,IsLock,IsDel,AddTime,LastLoginTime,LastLoginIp ");
			strSql.Append(" FROM bloguser ");
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
			strSql.Append("select count(1) FROM bloguser ");
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
			strSql.Append(")AS Row, T.*  from bloguser T ");
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
			parameters[0].Value = "bloguser";
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

