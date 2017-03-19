using System;
namespace MyBlogs.Model
{
	/// <summary>
	/// Blogcommentarticle:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Blogcommentarticle
	{
		public Blogcommentarticle()
		{}
		#region Model
		private int _id;
		private int _articleid;
		private int _authorid;
		private string _commenttitle;
		private string _commentcontent;
        private DateTime _addtime;
		private bool _isdel= false;
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
		public int ArticleId
		{
			set{ _articleid=value;}
			get{return _articleid;}
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
		public string CommentTitle
		{
			set{ _commenttitle=value;}
			get{return _commenttitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommentContent
		{
			set{ _commentcontent=value;}
			get{return _commentcontent;}
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

