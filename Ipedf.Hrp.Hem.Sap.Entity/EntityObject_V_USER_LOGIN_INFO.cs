using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_USER_LOGIN_INFO")]
	public partial class CauseObject_V_USER_LOGIN_INFO:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ACCOUNT = string.Empty;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _PASSWORD = string.Empty;
		
		public System.String  PASSWORD{get{ return  _PASSWORD;}set{ _PASSWORD = value;}}
		System.Decimal _IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_USABL{get{ return  _IS_USABL;}set{ _IS_USABL = value;}}
		System.String _IS_USABL_NAME = string.Empty;
		
		public System.String  IS_USABL_NAME{get{ return  _IS_USABL_NAME;}set{ _IS_USABL_NAME = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _NAME = string.Empty;
		
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal _FLAG = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  FLAG{get{ return  _FLAG;}set{ _FLAG = value;}}
		DateSpan _CREATE_DATE = null;
		
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _MOBILE = string.Empty;
		
		public System.String  MOBILE{get{ return  _MOBILE;}set{ _MOBILE = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _WMC_IS_NURSE = string.Empty;
		
		public System.String  WMC_IS_NURSE{get{ return  _WMC_IS_NURSE;}set{ _WMC_IS_NURSE = value;}}
		System.String _TYPE_ID_NAME = string.Empty;
		
		public System.String  TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		System.String _EMAIL = string.Empty;
		
		public System.String  EMAIL{get{ return  _EMAIL;}set{ _EMAIL = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_USER_LOGIN_INFO:EntityObject_V_USER_LOGIN_INFO
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_USER_LOGIN_INFO:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ACCOUNT;
		
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _PASSWORD;
		
		public System.String  PASSWORD{get{ return  _PASSWORD;}set{ _PASSWORD = value;}}
		System.Decimal  _IS_USABL;
		
		public System.Decimal  IS_USABL{get{ return  _IS_USABL;}set{ _IS_USABL = value;}}
		System.String  _IS_USABL_NAME;
		
		public System.String  IS_USABL_NAME{get{ return  _IS_USABL_NAME;}set{ _IS_USABL_NAME = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _NAME;
		
		public System.String  NAME{get{ return  _NAME;}set{ _NAME = value;}}
		System.Decimal  _FLAG;
		
		public System.Decimal  FLAG{get{ return  _FLAG;}set{ _FLAG = value;}}
		System.DateTime  _CREATE_DATE;
		
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _MOBILE;
		
		public System.String  MOBILE{get{ return  _MOBILE;}set{ _MOBILE = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _WMC_IS_NURSE;
		
		public System.String  WMC_IS_NURSE{get{ return  _WMC_IS_NURSE;}set{ _WMC_IS_NURSE = value;}}
		System.String  _TYPE_ID_NAME;
		
		public System.String  TYPE_ID_NAME{get{ return  _TYPE_ID_NAME;}set{ _TYPE_ID_NAME = value;}}
		System.String  _EMAIL;
		
		public System.String  EMAIL{get{ return  _EMAIL;}set{ _EMAIL = value;}}

		#endregion 
	}	
}
