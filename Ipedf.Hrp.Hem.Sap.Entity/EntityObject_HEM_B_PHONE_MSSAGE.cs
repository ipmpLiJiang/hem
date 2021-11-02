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
	
	[DataObject("HEM_B_PHONE_MSSAGE")]
	public partial class CauseObject_HEM_B_PHONE_MSSAGE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _OVERDUE_TIME = null;
		
		public DateSpan  OVERDUE_TIME{get{ return  _OVERDUE_TIME;}set{ _OVERDUE_TIME = value;}}
		System.String _CONTENT = string.Empty;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _SEND_ERROR = string.Empty;
		
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String _SEND_PHONE = string.Empty;
		
		public System.String  SEND_PHONE{get{ return  _SEND_PHONE;}set{ _SEND_PHONE = value;}}
		DateSpan _SEND_TIME = null;
		
		public DateSpan  SEND_TIME{get{ return  _SEND_TIME;}set{ _SEND_TIME = value;}}
		System.Decimal _IS_SEND = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_SEND{get{ return  _IS_SEND;}set{ _IS_SEND = value;}}
		System.String _APPLY_ID = string.Empty;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String _REPLY_STATUS = string.Empty;
		
		public System.String  REPLY_STATUS{get{ return  _REPLY_STATUS;}set{ _REPLY_STATUS = value;}}
		System.String _MAC = string.Empty;
		
		public System.String  MAC{get{ return  _MAC;}set{ _MAC = value;}}
		System.String _SEND_ID = string.Empty;
		
		public System.String  SEND_ID{get{ return  _SEND_ID;}set{ _SEND_ID = value;}}
		System.Decimal _APPLY_STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  APPLY_STATUS{get{ return  _APPLY_STATUS;}set{ _APPLY_STATUS = value;}}
		DateSpan _ACCEPT_TIME = null;
		
		public DateSpan  ACCEPT_TIME{get{ return  _ACCEPT_TIME;}set{ _ACCEPT_TIME = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_PHONE_MSSAGE")]
	public partial class DisplayObject_HEM_B_PHONE_MSSAGE:EntityObject_HEM_B_PHONE_MSSAGE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_PHONE_MSSAGE")]
	public partial class EntityObject_HEM_B_PHONE_MSSAGE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _OVERDUE_TIME;
		
		public System.DateTime  OVERDUE_TIME{get{ return  _OVERDUE_TIME;}set{ _OVERDUE_TIME = value;}}
		System.String  _CONTENT;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _SEND_ERROR;
		
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String  _SEND_PHONE;
		
		public System.String  SEND_PHONE{get{ return  _SEND_PHONE;}set{ _SEND_PHONE = value;}}
		System.DateTime  _SEND_TIME;
		
		public System.DateTime  SEND_TIME{get{ return  _SEND_TIME;}set{ _SEND_TIME = value;}}
		System.Decimal  _IS_SEND;
		
		public System.Decimal  IS_SEND{get{ return  _IS_SEND;}set{ _IS_SEND = value;}}
		System.String  _APPLY_ID;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String  _REPLY_STATUS;
		
		public System.String  REPLY_STATUS{get{ return  _REPLY_STATUS;}set{ _REPLY_STATUS = value;}}
		System.String  _MAC;
		
		public System.String  MAC{get{ return  _MAC;}set{ _MAC = value;}}
		System.String  _SEND_ID;
		
		public System.String  SEND_ID{get{ return  _SEND_ID;}set{ _SEND_ID = value;}}
		System.Decimal  _APPLY_STATUS;
		
		public System.Decimal  APPLY_STATUS{get{ return  _APPLY_STATUS;}set{ _APPLY_STATUS = value;}}
		System.DateTime  _ACCEPT_TIME;
		
		public System.DateTime  ACCEPT_TIME{get{ return  _ACCEPT_TIME;}set{ _ACCEPT_TIME = value;}}

		#endregion 
	}	
}
