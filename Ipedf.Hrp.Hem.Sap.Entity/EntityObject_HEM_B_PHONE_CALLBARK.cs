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
	
	[DataObject("HEM_B_PHONE_CALLBARK")]
	public partial class CauseObject_HEM_B_PHONE_CALLBARK:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CONTENT = string.Empty;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _TASKID = string.Empty;
		
		public System.String  TASKID{get{ return  _TASKID;}set{ _TASKID = value;}}
		System.String _APPLY_ID = string.Empty;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String _MOBILE = string.Empty;
		
		public System.String  MOBILE{get{ return  _MOBILE;}set{ _MOBILE = value;}}
		System.String _SEND_ID = string.Empty;
		
		public System.String  SEND_ID{get{ return  _SEND_ID;}set{ _SEND_ID = value;}}
		DateSpan _INSERTTIME = null;
		
		public DateSpan  INSERTTIME{get{ return  _INSERTTIME;}set{ _INSERTTIME = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_PHONE_CALLBARK")]
	public partial class DisplayObject_HEM_B_PHONE_CALLBARK:EntityObject_HEM_B_PHONE_CALLBARK
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_PHONE_CALLBARK")]
	public partial class EntityObject_HEM_B_PHONE_CALLBARK:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CONTENT;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _TASKID;
		
		public System.String  TASKID{get{ return  _TASKID;}set{ _TASKID = value;}}
		System.String  _APPLY_ID;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String  _MOBILE;
		
		public System.String  MOBILE{get{ return  _MOBILE;}set{ _MOBILE = value;}}
		System.String  _SEND_ID;
		
		public System.String  SEND_ID{get{ return  _SEND_ID;}set{ _SEND_ID = value;}}
		System.DateTime  _INSERTTIME;
		
		public System.DateTime  INSERTTIME{get{ return  _INSERTTIME;}set{ _INSERTTIME = value;}}

		#endregion 
	}	
}
