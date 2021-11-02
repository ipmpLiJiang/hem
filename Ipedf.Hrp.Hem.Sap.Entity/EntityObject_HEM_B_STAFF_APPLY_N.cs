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
	
	[DataObject("HEM_B_STAFF_APPLY_N")]
	public partial class CauseObject_HEM_B_STAFF_APPLY_N:CauseBase
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _POSTER_ID = string.Empty;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_APPLY_N")]
	public partial class DisplayObject_HEM_B_STAFF_APPLY_N:EntityObject_HEM_B_STAFF_APPLY_N
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF_APPLY_N")]
	public partial class EntityObject_HEM_B_STAFF_APPLY_N:EntityBase
	{
		#region Attribute Block
		
			//ƽ̨�Զ����ɴ���
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _POSTER_ID;
		
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}

		#endregion 
	}	
}
