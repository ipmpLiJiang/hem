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
	
	[DataObject("HEM_B_STAFF_TYPE")]
	public partial class CauseObject_HEM_B_STAFF_TYPE:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _TYPE_ID = string.Empty;
		
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.Decimal _IS_ACTION = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_ACTION{get{ return  _IS_ACTION;}set{ _IS_ACTION = value;}}
		System.String _FILE_PATH = string.Empty;
		
		public System.String  FILE_PATH{get{ return  _FILE_PATH;}set{ _FILE_PATH = value;}}
		System.String _PRACTICE_TYPE_ID = string.Empty;
		
		public System.String  PRACTICE_TYPE_ID{get{ return  _PRACTICE_TYPE_ID;}set{ _PRACTICE_TYPE_ID = value;}}
		System.Decimal _IS_CERTIFICATE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_TYPE")]
	public partial class DisplayObject_HEM_B_STAFF_TYPE:EntityObject_HEM_B_STAFF_TYPE
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_TYPE")]
	public partial class EntityObject_HEM_B_STAFF_TYPE:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _TYPE_ID;
		
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.Decimal  _IS_ACTION;
		
		public System.Decimal  IS_ACTION{get{ return  _IS_ACTION;}set{ _IS_ACTION = value;}}
		System.String  _FILE_PATH;
		
		public System.String  FILE_PATH{get{ return  _FILE_PATH;}set{ _FILE_PATH = value;}}
		System.String  _PRACTICE_TYPE_ID;
		
		public System.String  PRACTICE_TYPE_ID{get{ return  _PRACTICE_TYPE_ID;}set{ _PRACTICE_TYPE_ID = value;}}
		System.Decimal  _IS_CERTIFICATE;
		
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.Decimal  _IS_NURSE;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}	
}
