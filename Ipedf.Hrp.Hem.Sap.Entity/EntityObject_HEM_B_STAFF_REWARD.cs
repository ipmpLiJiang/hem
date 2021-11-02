using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.Serialization;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	
	[DataObject("HEM_B_STAFF_REWARD")]
	public partial class CauseObject_HEM_B_STAFF_REWARD:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		

		System.String _MINGCI = string.Empty;

		public System.String MINGCI { get { return _MINGCI; } set { _MINGCI = value; } }

		System.DateTime _HJSJ;

		public System.DateTime HJSJ { get { return _HJSJ; } set { _HJSJ = value; } }

		System.String _JXNAME;
		public System.String JXNAME { get { return _JXNAME; } set { _JXNAME = value; } }


		System.String _COMMENTS;

		public System.String COMMENTS { get { return _COMMENTS; } set { _COMMENTS = value; } }

		System.String _COMMENTS1;

		public System.String COMMENTS1 { get { return _COMMENTS1; } set { _COMMENTS1 = value; } }

		#endregion
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_REWARD")]
	public partial class DisplayObject_HEM_B_STAFF_REWARD:EntityObject_HEM_B_STAFF_REWARD
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_REWARD")]
	public partial class EntityObject_HEM_B_STAFF_REWARD:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}

		System.DateTime _HJSJ;

		public System.DateTime HJSJ { get { return _HJSJ; } set { _HJSJ = value; } }


		System.String _MINGCI = string.Empty;

		public System.String MINGCI { get { return _MINGCI; } set { _MINGCI = value; } }

		

		System.String _JXNAME;
		public System.String JXNAME { get { return _JXNAME; } set { _JXNAME = value; } }


		System.String _COMMENTS;

		public System.String COMMENTS { get { return _COMMENTS; } set { _COMMENTS = value; } }

		System.String _COMMENTS1;

		public System.String COMMENTS1 { get { return _COMMENTS1; } set { _COMMENTS1 = value; } }

		#endregion
	}	
}
