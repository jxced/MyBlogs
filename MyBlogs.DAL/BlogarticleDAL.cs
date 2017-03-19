using System;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MyBlogs.DBUtility;//Please add references
namespace MyBlogs.DAL
{
	/// <summary>
	/// 数据访问类:BlogarticleDAL
	/// </summary>
	public partial class BlogarticleDAL
	{
		public BlogarticleDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperMySQL.GetMaxID("Id", "blogarticle"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from blogarticle");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			return DbHelperMySQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyBlogs.Model.Blogarticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into blogarticle(");
			strSql.Append("Id,CategoryId,AuthorId,Content,ImgSrc,CommentNum,AllowComment,IsTop,Tag,CickNum,Status,AddTime,UpdateTime,IsDel,HtmlSrc)");
			strSql.Append(" values (");
			strSql.Append("@Id,@CategoryId,@AuthorId,@Content,@ImgSrc,@CommentNum,@AllowComment,@IsTop,@Tag,@CickNum,@Status,@AddTime,@UpdateTime,@IsDel,@HtmlSrc)");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11),
					new MySqlParameter("@CategoryId", MySqlDbType.Int32,11),
					new MySqlParameter("@AuthorId", MySqlDbType.Int32,11),
					new MySqlParameter("@Content", MySqlDbType.Text),
					new MySqlParameter("@ImgSrc", MySqlDbType.VarChar,255),
					new MySqlParameter("@CommentNum", MySqlDbType.Int32,11),
					new MySqlParameter("@AllowComment", MySqlDbType.Bit),
					new MySqlParameter("@IsTop", MySqlDbType.Bit),
					new MySqlParameter("@Tag", MySqlDbType.VarChar,20),
					new MySqlParameter("@CickNum", MySqlDbType.Int32,11),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@AddTime", MySqlDbType.Timestamp),
					new MySqlParameter("@UpdateTime", MySqlDbType.Timestamp),
					new MySqlParameter("@IsDel", MySqlDbType.Bit),
					new MySqlParameter("@HtmlSrc", MySqlDbType.VarChar,255)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.CategoryId;
			parameters[2].Value = model.AuthorId;
			parameters[3].Value = model.Content;
			parameters[4].Value = model.ImgSrc;
			parameters[5].Value = model.CommentNum;
			parameters[6].Value = model.AllowComment;
			parameters[7].Value = model.IsTop;
			parameters[8].Value = model.Tag;
			parameters[9].Value = model.CickNum;
			parameters[10].Value = model.Status;
			parameters[11].Value = model.AddTime;
			parameters[12].Value = model.UpdateTime;
			parameters[13].Value = model.IsDel;
			parameters[14].Value = model.HtmlSrc;

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
		public bool Update(MyBlogs.Model.Blogarticle model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update blogarticle set ");
			strSql.Append("CategoryId=@CategoryId,");
			strSql.Append("AuthorId=@AuthorId,");
			strSql.Append("Content=@Content,");
			strSql.Append("ImgSrc=@ImgSrc,");
			strSql.Append("CommentNum=@CommentNum,");
			strSql.Append("AllowComment=@AllowComment,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("Tag=@Tag,");
			strSql.Append("CickNum=@CickNum,");
			strSql.Append("Status=@Status,");
			strSql.Append("IsDel=@IsDel,");
			strSql.Append("HtmlSrc=@HtmlSrc");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@CategoryId", MySqlDbType.Int32,11),
					new MySqlParameter("@AuthorId", MySqlDbType.Int32,11),
					new MySqlParameter("@Content", MySqlDbType.Text),
					new MySqlParameter("@ImgSrc", MySqlDbType.VarChar,255),
					new MySqlParameter("@CommentNum", MySqlDbType.Int32,11),
					new MySqlParameter("@AllowComment", MySqlDbType.Bit),
					new MySqlParameter("@IsTop", MySqlDbType.Bit),
					new MySqlParameter("@Tag", MySqlDbType.VarChar,20),
					new MySqlParameter("@CickNum", MySqlDbType.Int32,11),
					new MySqlParameter("@Status", MySqlDbType.Int32,11),
					new MySqlParameter("@IsDel", MySqlDbType.Bit),
					new MySqlParameter("@HtmlSrc", MySqlDbType.VarChar,255),
					new MySqlParameter("@Id", MySqlDbType.Int32,11)};
			parameters[0].Value = model.CategoryId;
			parameters[1].Value = model.AuthorId;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.ImgSrc;
			parameters[4].Value = model.CommentNum;
			parameters[5].Value = model.AllowComment;
			parameters[6].Value = model.IsTop;
			parameters[7].Value = model.Tag;
			parameters[8].Value = model.CickNum;
			parameters[9].Value = model.Status;
			parameters[10].Value = model.IsDel;
			parameters[11].Value = model.HtmlSrc;
			parameters[12].Value = model.Id;

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
			strSql.Append("delete from blogarticle ");
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
			strSql.Append("delete from blogarticle ");
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
		public MyBlogs.Model.Blogarticle GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,CategoryId,AuthorId,Content,ImgSrc,CommentNum,AllowComment,IsTop,Tag,CickNum,Status,AddTime,UpdateTime,IsDel,HtmlSrc from blogarticle ");
			strSql.Append(" where Id=@Id ");
			MySqlParameter[] parameters = {
					new MySqlParameter("@Id", MySqlDbType.Int32,11)			};
			parameters[0].Value = Id;

			MyBlogs.Model.Blogarticle model=new MyBlogs.Model.Blogarticle();
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
		public MyBlogs.Model.Blogarticle DataRowToModel(DataRow row)
		{
			MyBlogs.Model.Blogarticle model=new MyBlogs.Model.Blogarticle();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["CategoryId"]!=null && row["CategoryId"].ToString()!="")
				{
					model.CategoryId=int.Parse(row["CategoryId"].ToString());
				}
				if(row["AuthorId"]!=null && row["AuthorId"].ToString()!="")
				{
					model.AuthorId=int.Parse(row["AuthorId"].ToString());
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["ImgSrc"]!=null)
				{
					model.ImgSrc=row["ImgSrc"].ToString();
				}
				if(row["CommentNum"]!=null && row["CommentNum"].ToString()!="")
				{
					model.CommentNum=int.Parse(row["CommentNum"].ToString());
				}
				if(row["AllowComment"]!=null && row["AllowComment"].ToString()!="")
				{
					if((row["AllowComment"].ToString()=="1")||(row["AllowComment"].ToString().ToLower()=="true"))
					{
						model.AllowComment=true;
					}
					else
					{
						model.AllowComment=false;
					}
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					if((row["IsTop"].ToString()=="1")||(row["IsTop"].ToString().ToLower()=="true"))
					{
						model.IsTop=true;
					}
					else
					{
						model.IsTop=false;
					}
				}
				if(row["Tag"]!=null)
				{
					model.Tag=row["Tag"].ToString();
				}
				if(row["CickNum"]!=null && row["CickNum"].ToString()!="")
				{
					model.CickNum=int.Parse(row["CickNum"].ToString());
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["AddTime"]!=null && row["AddTime"].ToString()!="")
				{
					model.AddTime=DateTime.Parse(row["AddTime"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
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
				if(row["HtmlSrc"]!=null)
				{
					model.HtmlSrc=row["HtmlSrc"].ToString();
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
			strSql.Append("select Id,CategoryId,AuthorId,Content,ImgSrc,CommentNum,AllowComment,IsTop,Tag,CickNum,Status,AddTime,UpdateTime,IsDel,HtmlSrc ");
			strSql.Append(" FROM blogarticle ");
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
			strSql.Append("select count(1) FROM blogarticle ");
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
			strSql.Append(")AS Row, T.*  from blogarticle T ");
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
			parameters[0].Value = "blogarticle";
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

