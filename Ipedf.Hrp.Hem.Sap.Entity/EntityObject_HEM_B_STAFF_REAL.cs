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
	
	[DataObject("HEM_B_STAFF_REAL")]
	public partial class CauseObject_HEM_B_STAFF_REAL:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _REAL_ZHRSLJZ = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  REAL_ZHRSLJZ{get{ return  _REAL_ZHRSLJZ;}set{ _REAL_ZHRSLJZ = value;}}
		System.Decimal _REAL_ZHRGRSG = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  REAL_ZHRGRSG{get{ return  _REAL_ZHRGRSG;}set{ _REAL_ZHRGRSG = value;}}
		System.Decimal _WRITTEN_ENGLISH = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  WRITTEN_ENGLISH{get{ return  _WRITTEN_ENGLISH;}set{ _WRITTEN_ENGLISH = value;}}
		System.Decimal _OPERATOR_ONE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  OPERATOR_ONE{get{ return  _OPERATOR_ONE;}set{ _OPERATOR_ONE = value;}}
		System.String _REAL_PHONE = string.Empty;
		
		public System.String  REAL_PHONE{get{ return  _REAL_PHONE;}set{ _REAL_PHONE = value;}}
		System.Decimal _REAL_ZHRGRTZ = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  REAL_ZHRGRTZ{get{ return  _REAL_ZHRGRTZ;}set{ _REAL_ZHRGRTZ = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		DateSpan _CREATE_TIME = null;
		
		public DateSpan  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.Decimal _WRITTEN_THEORY = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  WRITTEN_THEORY{get{ return  _WRITTEN_THEORY;}set{ _WRITTEN_THEORY = value;}}
		DateSpan _MODIFY_TIME = null;
		
		public DateSpan  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String _REAL_NAME = string.Empty;
		
		public System.String  REAL_NAME{get{ return  _REAL_NAME;}set{ _REAL_NAME = value;}}
		System.String _APPLY_ID = string.Empty;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String _ERRORMESSAGE = string.Empty;
		
		public System.String  ERRORMESSAGE{get{ return  _ERRORMESSAGE;}set{ _ERRORMESSAGE = value;}}
		System.Decimal _NUM = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  NUM{get{ return  _NUM;}set{ _NUM = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_REAL")]
	public partial class DisplayObject_HEM_B_STAFF_REAL:EntityObject_HEM_B_STAFF_REAL
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_REAL")]
	public partial class EntityObject_HEM_B_STAFF_REAL:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _REAL_ZHRSLJZ;
		
		public System.Decimal  REAL_ZHRSLJZ{get{ return  _REAL_ZHRSLJZ;}set{ _REAL_ZHRSLJZ = value;}}
		System.Decimal  _REAL_ZHRGRSG;
		
		public System.Decimal  REAL_ZHRGRSG{get{ return  _REAL_ZHRGRSG;}set{ _REAL_ZHRGRSG = value;}}
		System.Decimal  _WRITTEN_ENGLISH;
		
		public System.Decimal  WRITTEN_ENGLISH{get{ return  _WRITTEN_ENGLISH;}set{ _WRITTEN_ENGLISH = value;}}
		System.Decimal  _OPERATOR_ONE;
		
		public System.Decimal  OPERATOR_ONE{get{ return  _OPERATOR_ONE;}set{ _OPERATOR_ONE = value;}}
		System.String  _REAL_PHONE;
		
		public System.String  REAL_PHONE{get{ return  _REAL_PHONE;}set{ _REAL_PHONE = value;}}
		System.Decimal  _REAL_ZHRGRTZ;
		
		public System.Decimal  REAL_ZHRGRTZ{get{ return  _REAL_ZHRGRTZ;}set{ _REAL_ZHRGRTZ = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.DateTime  _CREATE_TIME;
		
		public System.DateTime  CREATE_TIME{get{ return  _CREATE_TIME;}set{ _CREATE_TIME = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.Decimal  _WRITTEN_THEORY;
		
		public System.Decimal  WRITTEN_THEORY{get{ return  _WRITTEN_THEORY;}set{ _WRITTEN_THEORY = value;}}
		System.DateTime  _MODIFY_TIME;
		
		public System.DateTime  MODIFY_TIME{get{ return  _MODIFY_TIME;}set{ _MODIFY_TIME = value;}}
		System.String  _REAL_NAME;
		
		public System.String  REAL_NAME{get{ return  _REAL_NAME;}set{ _REAL_NAME = value;}}
		System.String  _APPLY_ID;
		
		public System.String  APPLY_ID{get{ return  _APPLY_ID;}set{ _APPLY_ID = value;}}
		System.String  _ERRORMESSAGE;
		
		public System.String  ERRORMESSAGE{get{ return  _ERRORMESSAGE;}set{ _ERRORMESSAGE = value;}}
		System.Decimal  _NUM;
		
		public System.Decimal  NUM{get{ return  _NUM;}set{ _NUM = value;}}

		#endregion 
	}	
}
