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
	
	[DataObject("HEM_B_STAFF_PROJECT")]
	public partial class CauseObject_HEM_B_STAFF_PROJECT:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		DateSpan _ENDDA = null;
		
		public DateSpan  ENDDA{get{ return  _ENDDA;}set{ _ENDDA = value;}}
		System.String _ZHRXMLBLY = string.Empty;
		
		public System.String  ZHRXMLBLY{get{ return  _ZHRXMLBLY;}set{ _ZHRXMLBLY = value;}}
		System.String _ZHRXMMC = string.Empty;
		
		public System.String  ZHRXMMC{get{ return  _ZHRXMMC;}set{ _ZHRXMMC = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ZHRXMJF = string.Empty;
		
		public System.String  ZHRXMJF{get{ return  _ZHRXMJF;}set{ _ZHRXMJF = value;}}
		System.String _ZHRXMPM = string.Empty;
		
		public System.String  ZHRXMPM{get{ return  _ZHRXMPM;}set{ _ZHRXMPM = value;}}
		DateSpan _BEGDA = null;
		
		public DateSpan  BEGDA{get{ return  _BEGDA;}set{ _BEGDA = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_PROJECT")]
	public partial class DisplayObject_HEM_B_STAFF_PROJECT:EntityObject_HEM_B_STAFF_PROJECT
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_PROJECT")]
	public partial class EntityObject_HEM_B_STAFF_PROJECT:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.DateTime  _ENDDA;
		
		public System.DateTime  ENDDA{get{ return  _ENDDA;}set{ _ENDDA = value;}}
		System.String  _ZHRXMLBLY;
		
		public System.String  ZHRXMLBLY{get{ return  _ZHRXMLBLY;}set{ _ZHRXMLBLY = value;}}
		System.String  _ZHRXMMC;
		
		public System.String  ZHRXMMC{get{ return  _ZHRXMMC;}set{ _ZHRXMMC = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ZHRXMJF;
		
		public System.String  ZHRXMJF{get{ return  _ZHRXMJF;}set{ _ZHRXMJF = value;}}
		System.String  _ZHRXMPM;
		
		public System.String  ZHRXMPM{get{ return  _ZHRXMPM;}set{ _ZHRXMPM = value;}}
		System.DateTime  _BEGDA;
		
		public System.DateTime  BEGDA{get{ return  _BEGDA;}set{ _BEGDA = value;}}

		#endregion 
	}	
}
