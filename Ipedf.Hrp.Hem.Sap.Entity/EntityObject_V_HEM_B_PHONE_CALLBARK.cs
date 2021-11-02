using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_PHONE_CALLBARK")]
	public partial class CauseObject_V_HEM_B_PHONE_CALLBARK:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _TYPE_NAME = string.Empty;
		
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _STAFF_IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.Decimal _USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String _IS_NURSE_NAME = string.Empty;
		
		public System.String  IS_NURSE_NAME{get{ return  _IS_NURSE_NAME;}set{ _IS_NURSE_NAME = value;}}
		System.String _MOBILE = string.Empty;
		
		public System.String  MOBILE{get{ return  _MOBILE;}set{ _MOBILE = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
		System.Decimal _MANAGE_USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		DateSpan _INSERTTIME = null;
		
		public DateSpan  INSERTTIME{get{ return  _INSERTTIME;}set{ _INSERTTIME = value;}}
		System.String _APPLY_ID = string.Empty;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String _MANAGE_USER_ID = string.Empty;
		
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String _BARK_STATUS_NAME = string.Empty;
		
		public System.String  BARK_STATUS_NAME{get{ return  _BARK_STATUS_NAME;}set{ _BARK_STATUS_NAME = value;}}
		System.String _MANAGE_USER_ID_NAME = string.Empty;
		
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal _BARK_STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  BARK_STATUS{get{ return  _BARK_STATUS;}set{ _BARK_STATUS = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.String _NACHN = string.Empty;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String _CONTENT = string.Empty;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String _ACCOUNT = string.Empty;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _TASKID = string.Empty;
		
		public System.String  TASKID{get{ return  _TASKID;}set{ _TASKID = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_B_PHONE_CALLBARK:EntityObject_V_HEM_B_PHONE_CALLBARK
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_PHONE_CALLBARK:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _TYPE_NAME;
		
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.Decimal  _IS_PUBLIC;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _STAFF_IS_NURSE;
		
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.Decimal  _USER_IS_USABL;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String  _IS_NURSE_NAME;
		
		public System.String  IS_NURSE_NAME{get{ return  _IS_NURSE_NAME;}set{ _IS_NURSE_NAME = value;}}
		System.String  _MOBILE;
		
		public System.String  MOBILE{get{ return  _MOBILE;}set{ _MOBILE = value;}}
		System.Decimal  _IS_NURSE;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
		System.Decimal  _MANAGE_USER_IS_USABL;
		
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.DateTime  _INSERTTIME;
		
		public System.DateTime  INSERTTIME{get{ return  _INSERTTIME;}set{ _INSERTTIME = value;}}
		System.String  _APPLY_ID;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String  _MANAGE_USER_ID;
		
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String  _BARK_STATUS_NAME;
		
		public System.String  BARK_STATUS_NAME{get{ return  _BARK_STATUS_NAME;}set{ _BARK_STATUS_NAME = value;}}
		System.String  _MANAGE_USER_ID_NAME;
		
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String  _RECRUIT_POSITION;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal  _BARK_STATUS;
		
		public System.Decimal  BARK_STATUS{get{ return  _BARK_STATUS;}set{ _BARK_STATUS = value;}}
		System.String  _STAFF_TYPE_ID;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.String  _NACHN;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String  _CONTENT;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String  _ACCOUNT;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _TASKID;
		
		public System.String  TASKID{get{ return  _TASKID;}set{ _TASKID = value;}}

		#endregion 
	}	
}
