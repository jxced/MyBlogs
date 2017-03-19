using System;
namespace MyBlogs.Model
{
	/// <summary>
	/// Blogarticle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Blogarticle
	{
		public Blogarticle()
		{}
		#region Model
		private int _id;
		private int _categoryid;
		private int _authorid;
		private string _content;
		private string _imgsrc;
		private int _commentnum=0;
		private bool _allowcomment= false;
		private bool _istop= false;
		private string _tag;
		private int _cicknum=0;
		private int _status=2;
        private DateTime _addtime;
        private DateTime _updatetime;
		private bool _isdel= false;
		private string _htmlsrc;
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
		public int CategoryId
		{
			set{ _categoryid=value;}
			get{return _categoryid;}
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
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgSrc
		{
			set{ _imgsrc=value;}
			get{return _imgsrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CommentNum
		{
			set{ _commentnum=value;}
			get{return _commentnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool AllowComment
		{
			set{ _allowcomment=value;}
			get{return _allowcomment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CickNum
		{
			set{ _cicknum=value;}
			get{return _cicknum;}
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
		/// on update CURRENT_TIMESTAMP
		/// </summary>
		public DateTime UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HtmlSrc
		{
			set{ _htmlsrc=value;}
			get{return _htmlsrc;}
		}
		#endregion Model

	}
}

