using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_STAFF_APPLY_N")]
	public partial class CauseObject_V_HEM_B_STAFF_APPLY_N:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _PUBLISH_DATE = null;
		
		public DateSpan  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _POSTER_ID = string.Empty;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.Decimal _EDUCATION_COUNT = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  EDUCATION_COUNT{get{ return  _EDUCATION_COUNT;}set{ _EDUCATION_COUNT = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		DateSpan _END_DATE = null;
		
		public DateSpan  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal _POSTER_STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  POSTER_STATUS{get{ return  _POSTER_STATUS;}set{ _POSTER_STATUS = value;}}
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_B_STAFF_APPLY_N:EntityObject_V_HEM_B_STAFF_APPLY_N
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_STAFF_APPLY_N:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _PUBLISH_DATE;
		
		public System.DateTime  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _POSTER_ID;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.Decimal  _EDUCATION_COUNT;
		
		public System.Decimal  EDUCATION_COUNT{get{ return  _EDUCATION_COUNT;}set{ _EDUCATION_COUNT = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.DateTime  _END_DATE;
		
		public System.DateTime  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.String  _STAFF_TYPE_ID;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal  _POSTER_STATUS;
		
		public System.Decimal  POSTER_STATUS{get{ return  _POSTER_STATUS;}set{ _POSTER_STATUS = value;}}
		System.Decimal  _IS_PUBLIC;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.Decimal  _IS_NURSE;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}	
}
