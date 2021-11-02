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
	
	[DataObject("HEM_B_STAFF_MEMBER")]
	public partial class CauseObject_HEM_B_STAFF_MEMBER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		
		System.String _WEIC = string.Empty;
		
		public System.String  WEIC{get{ return _WEIC; }set{ _WEIC = value;}}

		System.String _MINGC = string.Empty;

		public System.String MINGC { get { return _MINGC; } set { _MINGC = value; } }

		System.DateTime _MGBDAT;

		public System.DateTime MGBDAT { get { return _MGBDAT; } set { _MGBDAT = value; } }

		System.String _MPCODE;
		public System.String MPCODE { get { return _MPCODE; } set { _MPCODE = value; } }

		System.String _GZDWJZW;
		public System.String GZDWJZW { get { return _GZDWJZW; } set { _GZDWJZW = value; } }

		System.String _COMMENTS;

		public System.String COMMENTS { get { return _COMMENTS; } set { _COMMENTS = value; } }

		System.String _COMMENTS1;

		public System.String COMMENTS1 { get { return _COMMENTS1; } set { _COMMENTS1 = value; } }

		#endregion
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_MEMBER")]
	public partial class DisplayObject_HEM_B_STAFF_MEMBER:EntityObject_HEM_B_STAFF_MEMBER
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_MEMBER")]
	public partial class EntityObject_HEM_B_STAFF_MEMBER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}

		System.String _WEIC = string.Empty;

		public System.String WEIC { get { return _WEIC; } set { _WEIC = value; } }

		System.String _MINGC = string.Empty;

		public System.String MINGC { get { return _MINGC; } set { _MINGC = value; } }

		System.DateTime _MGBDAT;

		public System.DateTime MGBDAT { get { return _MGBDAT; } set { _MGBDAT = value; } }

		System.String _MPCODE;
		public System.String MPCODE { get { return _MPCODE; } set { _MPCODE = value; } }

		System.String _GZDWJZW;
		public System.String GZDWJZW { get { return _GZDWJZW; } set { _GZDWJZW = value; } }

		System.String _COMMENTS;

		public System.String COMMENTS { get { return _COMMENTS; } set { _COMMENTS = value; } }

		System.String _COMMENTS1;

		public System.String COMMENTS1 { get { return _COMMENTS1; } set { _COMMENTS1 = value; } }

		#endregion
	}	
}
