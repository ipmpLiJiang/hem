using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_USER_STAFF")]
	public partial class CauseObject_V_HEM_B_USER_STAFF:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _STAFF_IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TYPE_NAME = string.Empty;
		
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.Decimal _USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal _IS_CERTIFICATE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		DateSpan _GBDAT = null;
		
		public DateSpan  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.String _INSTI = string.Empty;
		
		public System.String  INSTI{get{ return  _INSTI;}set{ _INSTI = value;}}
		System.String _SLART_NAME = string.Empty;
		
		public System.String  SLART_NAME{get{ return  _SLART_NAME;}set{ _SLART_NAME = value;}}
		System.String _GESCH = string.Empty;
		
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.String _TYPE_ID = string.Empty;
		
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _NACHN = string.Empty;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String _ZHRJG = string.Empty;
		
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String _USRID_TEL = string.Empty;
		
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
		System.String _STAFF_IS_NURSE_NAME = string.Empty;
		
		public System.String  STAFF_IS_NURSE_NAME{get{ return  _STAFF_IS_NURSE_NAME;}set{ _STAFF_IS_NURSE_NAME = value;}}
		System.String _USRID_MAIL = string.Empty;
		
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_B_USER_STAFF:EntityObject_V_HEM_B_USER_STAFF
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_USER_STAFF:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _STAFF_IS_NURSE;
		
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TYPE_NAME;
		
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.Decimal  _USER_IS_USABL;
		
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String  _STAFF_TYPE_ID;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal  _IS_CERTIFICATE;
		
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.DateTime  _GBDAT;
		
		public System.DateTime  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String  _RECRUIT_POSITION;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.String  _INSTI;
		
		public System.String  INSTI{get{ return  _INSTI;}set{ _INSTI = value;}}
		System.String  _SLART_NAME;
		
		public System.String  SLART_NAME{get{ return  _SLART_NAME;}set{ _SLART_NAME = value;}}
		System.String  _GESCH;
		
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.String  _TYPE_ID;
		
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _NACHN;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String  _ZHRJG;
		
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String  _USRID_TEL;
		
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
		System.String  _STAFF_IS_NURSE_NAME;
		
		public System.String  STAFF_IS_NURSE_NAME{get{ return  _STAFF_IS_NURSE_NAME;}set{ _STAFF_IS_NURSE_NAME = value;}}
		System.String  _USRID_MAIL;
		
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}

		#endregion 
	}	
}
