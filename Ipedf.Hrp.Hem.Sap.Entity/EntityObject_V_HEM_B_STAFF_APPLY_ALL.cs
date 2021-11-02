using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_STAFF_APPLY_ALL")]
	public partial class CauseObject_V_HEM_B_STAFF_APPLY_ALL:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _POSTER_ID = string.Empty;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String _TYPE_ID = string.Empty;
		
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_B_STAFF_APPLY_ALL:EntityObject_V_HEM_B_STAFF_APPLY_ALL
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_STAFF_APPLY_ALL:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _POSTER_ID;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String  _TYPE_ID;
		
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _STAFF_TYPE_ID;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.Decimal  _IS_NURSE;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}	
}
