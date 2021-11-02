using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_RECRUIT_POSTER_STAFF")]
	public partial class CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _PUBLISH_DATE = null;
		
		public DateSpan  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _DATA_SOURCE = string.Empty;
		
		public System.String  DATA_SOURCE{get{ return  _DATA_SOURCE;}set{ _DATA_SOURCE = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _IS_NURSE_NAME = string.Empty;
		
		public System.String  IS_NURSE_NAME{get{ return  _IS_NURSE_NAME;}set{ _IS_NURSE_NAME = value;}}
		System.String _TITLE = string.Empty;
		
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.String _REMARK = string.Empty;
		
		public System.String  REMARK{get{ return  _REMARK;}set{ _REMARK = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
		System.String _PUBLISHER = string.Empty;
		
		public System.String  PUBLISHER{get{ return  _PUBLISHER;}set{ _PUBLISHER = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal _USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		DateSpan _END_DATE = null;
		
		public DateSpan  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		DateSpan _CREATE_DATE = null;
		
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String _ACCOUNT = string.Empty;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _USER_ID_NAME = string.Empty;
		
		public System.String  USER_ID_NAME{get{ return  _USER_ID_NAME;}set{ _USER_ID_NAME = value;}}
		System.String _CONTENT = string.Empty;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF:EntityObject_V_HEM_B_RECRUIT_POSTER_STAFF
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_RECRUIT_POSTER_STAFF:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _PUBLISH_DATE;
		
		public System.DateTime  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _DATA_SOURCE;
		
		public System.String  DATA_SOURCE{get{ return  _DATA_SOURCE;}set{ _DATA_SOURCE = value;}}
		System.String  _MODIFY_USER_ID;
		
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _IS_NURSE_NAME;
		
		public System.String  IS_NURSE_NAME{get{ return  _IS_NURSE_NAME;}set{ _IS_NURSE_NAME = value;}}
		System.String  _TITLE;
		
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.String  _REMARK;
		
		public System.String  REMARK{get{ return  _REMARK;}set{ _REMARK = value;}}
		System.Decimal  _IS_NURSE;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
		System.String  _PUBLISHER;
		
		public System.String  PUBLISHER{get{ return  _PUBLISHER;}set{ _PUBLISHER = value;}}
		System.String  _RECRUIT_POSITION;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal  _USER_IS_USABL;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.DateTime  _END_DATE;
		
		public System.DateTime  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.DateTime  _CREATE_DATE;
		
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal  _IS_PUBLIC;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String  _ACCOUNT;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _USER_ID_NAME;
		
		public System.String  USER_ID_NAME{get{ return  _USER_ID_NAME;}set{ _USER_ID_NAME = value;}}
		System.String  _CONTENT;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}

		#endregion 
	}	
}
