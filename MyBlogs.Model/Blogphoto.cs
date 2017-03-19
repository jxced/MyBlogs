using System;
namespace MyBlogs.Model
{
	/// <summary>
	/// Blogphoto:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Blogphoto
	{
		public Blogphoto()
		{}
		#region Model
		private int _id;
		private int _authorid;
		private int _album;
		private string _title;
		private string _remark;
		private string _src;
		private int _status=2;
        private DateTime _addtime;
		private bool _isdel;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int AuthorId
		{
			set{ _authorid=value;}
			get{return _authorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Album
		{
			set{ _album=value;}
			get{return _album;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TItle
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Src
		{
			set{ _src=value;}
			get{return _src;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime AddTime
		{
			set{ _addtime=value;}
			get{return _addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

