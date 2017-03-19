using System;
namespace MyBlogs.Model
{
	/// <summary>
	/// Blogphotoalblum:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Blogphotoalblum
	{
		public Blogphotoalblum()
		{}
		#region Model
		private int _id;
		private int _authorid;
		private string _title;
		private string _coversrc= "no.jpg";
		private int _photonum=0;
		private int _status=1;
        private DateTime _addtime;
		private bool _isdel= false;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CoverSrc
		{
			set{ _coversrc=value;}
			get{return _coversrc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PhotoNum
		{
			set{ _photonum=value;}
			get{return _photonum;}
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

