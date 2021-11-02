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
	
	[DataObject("HEM_B_RECRUIT_POSTER")]
	public partial class CauseObject_HEM_B_RECRUIT_POSTER:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _CONTENT = string.Empty;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _PUBLISH_DATE = null;
		
		public DateSpan  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		DateSpan _CREATE_DATE = null;
		
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _TITLE = string.Empty;
		
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.String _PUBLISHER = string.Empty;
		
		public System.String  PUBLISHER{get{ return  _PUBLISHER;}set{ _PUBLISHER = value;}}
		DateSpan _END_DATE = null;
		
		public DateSpan  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String _DATA_SOURCE = string.Empty;
		
		public System.String  DATA_SOURCE{get{ return  _DATA_SOURCE;}set{ _DATA_SOURCE = value;}}
		System.String _MODIFY_USER_ID = string.Empty;
		
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.String _REMARK = string.Empty;
		
		public System.String  REMARK{get{ return  _REMARK;}set{ _REMARK = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_RECRUIT_POSTER")]
	public partial class DisplayObject_HEM_B_RECRUIT_POSTER:EntityObject_HEM_B_RECRUIT_POSTER
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_RECRUIT_POSTER")]
	public partial class EntityObject_HEM_B_RECRUIT_POSTER:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _CONTENT;
		
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _PUBLISH_DATE;
		
		public System.DateTime  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.Decimal  _STATUS;
		
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.DateTime  _CREATE_DATE;
		
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _TITLE;
		
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.String  _PUBLISHER;
		
		public System.String  PUBLISHER{get{ return  _PUBLISHER;}set{ _PUBLISHER = value;}}
		System.DateTime  _END_DATE;
		
		public System.DateTime  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.Decimal  _IS_PUBLIC;
		
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String  _DATA_SOURCE;
		
		public System.String  DATA_SOURCE{get{ return  _DATA_SOURCE;}set{ _DATA_SOURCE = value;}}
		System.String  _MODIFY_USER_ID;
		
		public System.String  MODIFY_USER_ID{get{ return  _MODIFY_USER_ID;}set{ _MODIFY_USER_ID = value;}}
		System.String  _RECRUIT_POSITION;
		
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.String  _REMARK;
		
		public System.String  REMARK{get{ return  _REMARK;}set{ _REMARK = value;}}
		System.Decimal  _IS_NURSE;
		
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
        System.Decimal _IS_SEND;

        public System.Decimal IS_SEND { get { return _IS_SEND; } set { _IS_SEND = value; } }
		#endregion 
	}	
}
