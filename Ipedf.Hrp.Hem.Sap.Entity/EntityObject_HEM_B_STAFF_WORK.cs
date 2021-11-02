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
	
	[DataObject("HEM_B_STAFF_WORK")]
	public partial class CauseObject_HEM_B_STAFF_WORK:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _SLART = string.Empty;
		
		public System.String  SLART{get{ return  _SLART;}set{ _SLART = value;}}
		DateSpan _ENDDA = null;
		
		public DateSpan  ENDDA{get{ return  _ENDDA;}set{ _ENDDA = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ZHRXXDW = string.Empty;
		
		public System.String  ZHRXXDW{get{ return  _ZHRXXDW;}set{ _ZHRXXDW = value;}}
		System.String _ZHRGZZW = string.Empty;
		
		public System.String  ZHRGZZW{get{ return  _ZHRGZZW;}set{ _ZHRGZZW = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String _ZHRZYBM = string.Empty;
		
		public System.String  ZHRZYBM{get{ return  _ZHRZYBM;}set{ _ZHRZYBM = value;}}
		DateSpan _BEGDA = null;
		
		public DateSpan  BEGDA{get{ return  _BEGDA;}set{ _BEGDA = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_WORK")]
	public partial class DisplayObject_HEM_B_STAFF_WORK:EntityObject_HEM_B_STAFF_WORK
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_WORK")]
	public partial class EntityObject_HEM_B_STAFF_WORK:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _SLART;
		
		public System.String  SLART{get{ return  _SLART;}set{ _SLART = value;}}
		System.DateTime  _ENDDA;
		
		public System.DateTime  ENDDA{get{ return  _ENDDA;}set{ _ENDDA = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ZHRXXDW;
		
		public System.String  ZHRXXDW{get{ return  _ZHRXXDW;}set{ _ZHRXXDW = value;}}
		System.String  _ZHRGZZW;
		
		public System.String  ZHRGZZW{get{ return  _ZHRGZZW;}set{ _ZHRGZZW = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String  _ZHRZYBM;
		
		public System.String  ZHRZYBM{get{ return  _ZHRZYBM;}set{ _ZHRZYBM = value;}}
		System.DateTime  _BEGDA;
		
		public System.DateTime  BEGDA{get{ return  _BEGDA;}set{ _BEGDA = value;}}

		#endregion 
	}	
}
