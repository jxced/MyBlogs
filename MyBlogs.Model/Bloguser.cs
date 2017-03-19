using System;
namespace MyBlogs.Model
{
	/// <summary>
	/// Bloguser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Bloguser
	{
		public Bloguser()
		{}
		#region Model
		private int _id;
		private string _loginname;
		private string _loginpwd;
		private string _cnname;
		private string _email;
		private bool _islock= false;
		private bool _isdel= false;
        private DateTime _addtime;
        private DateTime _lastlogintime;
		private string _lastloginip;
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
		public string LoginName
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginPwd
		{
			set{ _loginpwd=value;}
			get{return _loginpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CnName
		{
			set{ _cnname=value;}
			get{return _cnname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsLock
		{
			set{ _islock=value;}
			get{return _islock;}
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
		public DateTime LastLoginTime
		{
			set{ _lastlogintime=value;}
			get{return _lastlogintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastLoginIp
		{
			set{ _lastloginip=value;}
			get{return _lastloginip;}
		}
		#endregion Model

	}
}

