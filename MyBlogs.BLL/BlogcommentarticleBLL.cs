using System;
using System.Data;
using System.Collections.Generic;
using MyBlogs.Common;
using MyBlogs.Model;
namespace MyBlogs.BLL
{
	/// <summary>
	/// BlogcommentarticleBLL
	/// </summary>
	public partial class BlogcommentarticleBLL
	{
		private readonly MyBlogs.DAL.BlogcommentarticleDAL dal=new MyBlogs.DAL.BlogcommentarticleDAL();
		public BlogcommentarticleBLL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MyBlogs.Model.Blogcommentarticle model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MyBlogs.Model.Blogcommentarticle model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(MyBlogs.Common.PageValidate.SafeLongFilter(Idlist,0) );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MyBlogs.Model.Blogcommentarticle GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public MyBlogs.Model.Blogcommentarticle GetModelByCache(int Id)
		{
			
			string CacheKey = "BlogcommentarticleModel-" + Id;
			object objModel = MyBlogs.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Id);
					if (objModel != null)
					{
						int ModelCache = MyBlogs.Common.ConfigHelper.GetConfigInt("ModelCache");
						MyBlogs.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (MyBlogs.Model.Blogcommentarticle)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyBlogs.Model.Blogcommentarticle> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MyBlogs.Model.Blogcommentarticle> DataTableToList(DataTable dt)
		{
			List<MyBlogs.Model.Blogcommentarticle> modelList = new List<MyBlogs.Model.Blogcommentarticle>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MyBlogs.Model.Blogcommentarticle model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

