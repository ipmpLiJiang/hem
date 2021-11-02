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
	
	[DataObject("HEM_B_STAFF_ESSAY")]
	public partial class CauseObject_HEM_B_STAFF_ESSAY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _ZHRYXYZ = string.Empty;
		
		public System.String  ZHRYXYZ{get{ return  _ZHRYXYZ;}set{ _ZHRYXYZ = value;}}
		System.String _ZHRCBKH = string.Empty;
		
		public System.String  ZHRCBKH{get{ return  _ZHRCBKH;}set{ _ZHRCBKH = value;}}
		System.String _STAFF_ID = string.Empty;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String _ZHRBRMP = string.Empty;
		
		public System.String  ZHRBRMP{get{ return  _ZHRBRMP;}set{ _ZHRBRMP = value;}}
		System.String _ZHRFBZT = string.Empty;
		
		public System.String  ZHRFBZT{get{ return  _ZHRFBZT;}set{ _ZHRFBZT = value;}}
		System.String _ZHRCBKW = string.Empty;
		
		public System.String  ZHRCBKW{get{ return  _ZHRCBKW;}set{ _ZHRCBKW = value;}}
		System.String _ZHRWZMC = string.Empty;
		
		public System.String  ZHRWZMC{get{ return  _ZHRWZMC;}set{ _ZHRWZMC = value;}}
		DateSpan _BEGDA = null;
		
		public DateSpan  BEGDA{get{ return  _BEGDA;}set{ _BEGDA = value;}}
		System.String _ZHRKWJB = string.Empty;
		
		public System.String  ZHRKWJB{get{ return  _ZHRKWJB;}set{ _ZHRKWJB = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_ESSAY")]
	public partial class DisplayObject_HEM_B_STAFF_ESSAY:EntityObject_HEM_B_STAFF_ESSAY
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_ESSAY")]
	public partial class EntityObject_HEM_B_STAFF_ESSAY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _ZHRYXYZ;
		
		public System.String  ZHRYXYZ{get{ return  _ZHRYXYZ;}set{ _ZHRYXYZ = value;}}
		System.String  _ZHRCBKH;
		
		public System.String  ZHRCBKH{get{ return  _ZHRCBKH;}set{ _ZHRCBKH = value;}}
		System.String  _STAFF_ID;
		
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String  _ZHRBRMP;
		
		public System.String  ZHRBRMP{get{ return  _ZHRBRMP;}set{ _ZHRBRMP = value;}}
		System.String  _ZHRFBZT;
		
		public System.String  ZHRFBZT{get{ return  _ZHRFBZT;}set{ _ZHRFBZT = value;}}
		System.String  _ZHRCBKW;
		
		public System.String  ZHRCBKW{get{ return  _ZHRCBKW;}set{ _ZHRCBKW = value;}}
		System.String  _ZHRWZMC;
		
		public System.String  ZHRWZMC{get{ return  _ZHRWZMC;}set{ _ZHRWZMC = value;}}
		System.DateTime  _BEGDA;
		
		public System.DateTime  BEGDA{get{ return  _BEGDA;}set{ _BEGDA = value;}}
		System.String  _ZHRKWJB;
		
		public System.String  ZHRKWJB{get{ return  _ZHRKWJB;}set{ _ZHRKWJB = value;}}

		#endregion 
	}	
}
