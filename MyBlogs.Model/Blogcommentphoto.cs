using System;
namespace MyBlogs.Model
{
	/// <summary>
	/// Blogcommentphoto:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Blogcommentphoto
	{
		public Blogcommentphoto()
		{}
		#region Model
		private int _id;
		private int _authorid;
		private int _photoid;
		private string _title;
		private string _content;
        private DateTime _addtime;
		private bool _isdel;
		/// <summary>
		/// auto_increment
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
		public int PhotoId
		{
			set{ _photoid=value;}
			get{return _photoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
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

