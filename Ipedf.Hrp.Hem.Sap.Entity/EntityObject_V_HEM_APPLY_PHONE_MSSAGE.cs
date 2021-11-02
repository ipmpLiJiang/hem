using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_APPLY_PHONE_MSSAGE")]
	public partial class CauseObject_V_HEM_APPLY_PHONE_MSSAGE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _IS_SEND_NAME = string.Empty;
		
		public System.String  IS_SEND_NAME{get{ return  _IS_SEND_NAME;}set{ _IS_SEND_NAME = value;}}
		DateSpan _SEND_TIME = null;
		
		public DateSpan  SEND_TIME{get{ return  _SEND_TIME;}set{ _SEND_TIME = value;}}
		System.String _TYPE_NAME = string.Empty;
		
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.Decimal _USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.String _TITLE = string.Empty;
		
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.Decimal _MANAGE_USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.String _MANAGE_USER_ID = string.Empty;
		
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _MANAGE_USER_ID_NAME = string.Empty;
		
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.String _SEND_ERROR = string.Empty;
		
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String _APPLY_STATUS_NAME = string.Empty;
		
		public System.String  APPLY_STATUS_NAME{get{ return  _APPLY_STATUS_NAME;}set{ _APPLY_STATUS_NAME = value;}}
		System.String _NACHN = string.Empty;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.Decimal _APPLY_STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  APPLY_STATUS{get{ return  _APPLY_STATUS;}set{ _APPLY_STATUS = value;}}
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String _ACCOUNT = string.Empty;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _SEND_PHONE = string.Empty;
		
		public System.String  SEND_PHONE{get{ return  _SEND_PHONE;}set{ _SEND_PHONE = value;}}
		System.String _CONTENT = string.Empty;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_APPLY_PHONE_MSSAGE:EntityObject_V_HEM_APPLY_PHONE_MSSAGE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_APPLY_PHONE_MSSAGE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _IS_SEND_NAME;
		
		public System.String  IS_SEND_NAME{get{ return  _IS_SEND_NAME;}set{ _IS_SEND_NAME = value;}}
		System.DateTime  _SEND_TIME;
		
		public System.DateTime  SEND_TIME{get{ return  _SEND_TIME;}set{ _SEND_TIME = value;}}
		System.String  _TYPE_NAME;
		
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.Decimal  _USER_IS_USABL;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String  _STAFF_TYPE_ID;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.String  _TITLE;
		
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.Decimal  _MANAGE_USER_IS_USABL;
		
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.String  _MANAGE_USER_ID;
		
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _MANAGE_USER_ID_NAME;
		
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String  _RECRUIT_POSITION;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.String  _SEND_ERROR;
		
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String  _APPLY_STATUS_NAME;
		
		public System.String  APPLY_STATUS_NAME{get{ return  _APPLY_STATUS_NAME;}set{ _APPLY_STATUS_NAME = value;}}
		System.String  _NACHN;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.Decimal  _APPLY_STATUS;
		
		public System.Decimal  APPLY_STATUS{get{ return  _APPLY_STATUS;}set{ _APPLY_STATUS = value;}}
		System.Decimal  _IS_PUBLIC;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String  _ACCOUNT;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _SEND_PHONE;
		
		public System.String  SEND_PHONE{get{ return  _SEND_PHONE;}set{ _SEND_PHONE = value;}}
		System.String  _CONTENT;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}

		#endregion 
	}	
}
