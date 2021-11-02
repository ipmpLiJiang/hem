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
	
	[DataObject("HEM_B_STAFF_APPLY")]
	public partial class CauseObject_HEM_B_STAFF_APPLY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _STAFF_TYPE_ID = string.Empty;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.String _POSTER_ID = string.Empty;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _CREATE_DATE = null;
		
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_APPLY")]
	public partial class DisplayObject_HEM_B_STAFF_APPLY:EntityObject_HEM_B_STAFF_APPLY
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_APPLY")]
	public partial class EntityObject_HEM_B_STAFF_APPLY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _STAFF_TYPE_ID;
		
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.String  _POSTER_ID;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _CREATE_DATE;
		
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}

		#endregion 
	}	
}
