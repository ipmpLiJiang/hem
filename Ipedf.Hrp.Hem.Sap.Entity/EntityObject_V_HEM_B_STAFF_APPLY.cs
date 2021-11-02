using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_STAFF_APPLY")]
	public partial class CauseObject_V_HEM_B_STAFF_APPLY:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _WRITTEN_TOTAL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  WRITTEN_TOTAL{get{ return  _WRITTEN_TOTAL;}set{ _WRITTEN_TOTAL = value;}}
		System.String _POSTER_ID = string.Empty;
		[DataMember]
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String _STAFF_IS_NURSE_NAME = string.Empty;
		[DataMember]
		public System.String  STAFF_IS_NURSE_NAME{get{ return  _STAFF_IS_NURSE_NAME;}set{ _STAFF_IS_NURSE_NAME = value;}}
		System.String _SF_SS_EDUCATION_SLART = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_SLART{get{ return  _SF_SS_EDUCATION_SLART;}set{ _SF_SS_EDUCATION_SLART = value;}}
		System.Decimal _REAL_ZHRGRTZ = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REAL_ZHRGRTZ{get{ return  _REAL_ZHRGRTZ;}set{ _REAL_ZHRGRTZ = value;}}
		System.Decimal _IS_CERTIFICATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		DateSpan _END_DATE = null;
		[DataMember]
		public DateSpan  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.Decimal _ZHRGRTZ = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ZHRGRTZ{get{ return  _ZHRGRTZ;}set{ _ZHRGRTZ = value;}}
		System.Decimal _POSTER_STATUS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  POSTER_STATUS{get{ return  _POSTER_STATUS;}set{ _POSTER_STATUS = value;}}
		System.String _ED_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  ED_TYPE_NAME{get{ return  _ED_TYPE_NAME;}set{ _ED_TYPE_NAME = value;}}
		System.String _CONTENT = string.Empty;
		[DataMember]
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String _IS_SEND_NAME = string.Empty;
		[DataMember]
		public System.String  IS_SEND_NAME{get{ return  _IS_SEND_NAME;}set{ _IS_SEND_NAME = value;}}
		System.String _MANAGE_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String _SEND_ID = string.Empty;
		[DataMember]
		public System.String  SEND_ID{get{ return  _SEND_ID;}set{ _SEND_ID = value;}}
		System.Decimal _USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String _IS_NURSE_NAME = string.Empty;
		[DataMember]
		public System.String  IS_NURSE_NAME{get{ return  _IS_NURSE_NAME;}set{ _IS_NURSE_NAME = value;}}
		System.Decimal _IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
		System.String _DT_HH_EDUCATION_NAME = string.Empty;
		[DataMember]
		public System.String  DT_HH_EDUCATION_NAME{get{ return  _DT_HH_EDUCATION_NAME;}set{ _DT_HH_EDUCATION_NAME = value;}}
		System.String _GESCH = string.Empty;
		[DataMember]
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.Decimal _REAL_ZHRGRSG = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REAL_ZHRGRSG{get{ return  _REAL_ZHRGRSG;}set{ _REAL_ZHRGRSG = value;}}
		System.String _ACCOUNT = string.Empty;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.Decimal _WRITTEN_THEORY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  WRITTEN_THEORY{get{ return  _WRITTEN_THEORY;}set{ _WRITTEN_THEORY = value;}}
		System.String _USRID_MAIL = string.Empty;
		[DataMember]
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}
		System.String _REPLY_STATUS = string.Empty;
		[DataMember]
		public System.String  REPLY_STATUS{get{ return  _REPLY_STATUS;}set{ _REPLY_STATUS = value;}}
		System.String _PRACTICE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String  PRACTICE_TYPE_ID_NAME{get{ return  _PRACTICE_TYPE_ID_NAME;}set{ _PRACTICE_TYPE_ID_NAME = value;}}
		System.String _STAFF_ID = string.Empty;
		[DataMember]
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String _SLART_NAME = string.Empty;
		[DataMember]
		public System.String  SLART_NAME{get{ return  _SLART_NAME;}set{ _SLART_NAME = value;}}
		System.Decimal _MANAGE_USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.Decimal _ZHRGRSG = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ZHRGRSG{get{ return  _ZHRGRSG;}set{ _ZHRGRSG = value;}}
		System.String _TITLE = string.Empty;
		[DataMember]
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.String _STATUS_NAME = string.Empty;
		[DataMember]
		public System.String  STATUS_NAME{get{ return  _STATUS_NAME;}set{ _STATUS_NAME = value;}}
		System.String _USRID_TEL = string.Empty;
		[DataMember]
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
		System.String _SF_SS_EDUCATION_TYPE = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_TYPE{get{ return  _SF_SS_EDUCATION_TYPE;}set{ _SF_SS_EDUCATION_TYPE = value;}}
		DateSpan _GBDAT = null;
		[DataMember]
		public DateSpan  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		[DataMember]
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal _IS_SEND = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_SEND{get{ return  _IS_SEND;}set{ _IS_SEND = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		DateSpan _PUBLISH_DATE = null;
		[DataMember]
		public DateSpan  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.Decimal _OPERATOR_ONE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  OPERATOR_ONE{get{ return  _OPERATOR_ONE;}set{ _OPERATOR_ONE = value;}}
		System.Decimal _ZHRTZGG = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ZHRTZGG{get{ return  _ZHRTZGG;}set{ _ZHRTZGG = value;}}
		System.Decimal _REAL_ZHRSLJZ = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REAL_ZHRSLJZ{get{ return  _REAL_ZHRSLJZ;}set{ _REAL_ZHRSLJZ = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal _STAFF_IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.String _INSTI = string.Empty;
		[DataMember]
		public System.String  INSTI{get{ return  _INSTI;}set{ _INSTI = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _SEX = string.Empty;
		[DataMember]
		public System.String  SEX{get{ return  _SEX;}set{ _SEX = value;}}
		System.String _FIRSTCHOICE = string.Empty;
		[DataMember]
		public System.String  FIRSTCHOICE{get{ return  _FIRSTCHOICE;}set{ _FIRSTCHOICE = value;}}
		System.String _NACHN = string.Empty;
		[DataMember]
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String _SEND_ERROR = string.Empty;
		[DataMember]
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String _TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.String _ZHRJG = string.Empty;
		[DataMember]
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String _MANAGE_USER_ID = string.Empty;
		[DataMember]
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.Decimal _WRITTEN_ENGLISH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  WRITTEN_ENGLISH{get{ return  _WRITTEN_ENGLISH;}set{ _WRITTEN_ENGLISH = value;}}
		System.String _MSSAGE_ID = string.Empty;
		[DataMember]
		public System.String  MSSAGE_ID{get{ return  _MSSAGE_ID;}set{ _MSSAGE_ID = value;}}

		#endregion 
	}
	[Serializable]
	public partial class DisplayObject_V_HEM_B_STAFF_APPLY:EntityObject_V_HEM_B_STAFF_APPLY
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_STAFF_APPLY:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _WRITTEN_TOTAL;
		[DataMember]
		public System.Decimal  WRITTEN_TOTAL{get{ return  _WRITTEN_TOTAL;}set{ _WRITTEN_TOTAL = value;}}
		System.String  _POSTER_ID;
		[DataMember]
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String  _STAFF_IS_NURSE_NAME;
		[DataMember]
		public System.String  STAFF_IS_NURSE_NAME{get{ return  _STAFF_IS_NURSE_NAME;}set{ _STAFF_IS_NURSE_NAME = value;}}
		System.String  _SF_SS_EDUCATION_SLART;
		[DataMember]
		public System.String  SF_SS_EDUCATION_SLART{get{ return  _SF_SS_EDUCATION_SLART;}set{ _SF_SS_EDUCATION_SLART = value;}}
		System.Decimal  _REAL_ZHRGRTZ;
		[DataMember]
		public System.Decimal  REAL_ZHRGRTZ{get{ return  _REAL_ZHRGRTZ;}set{ _REAL_ZHRGRTZ = value;}}
		System.Decimal  _IS_CERTIFICATE;
		[DataMember]
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.Decimal  _STATUS;
		[DataMember]
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.DateTime  _END_DATE;
		[DataMember]
		public System.DateTime  END_DATE{get{ return  _END_DATE;}set{ _END_DATE = value;}}
		System.Decimal  _ZHRGRTZ;
		[DataMember]
		public System.Decimal  ZHRGRTZ{get{ return  _ZHRGRTZ;}set{ _ZHRGRTZ = value;}}
		System.Decimal  _POSTER_STATUS;
		[DataMember]
		public System.Decimal  POSTER_STATUS{get{ return  _POSTER_STATUS;}set{ _POSTER_STATUS = value;}}
		System.String  _ED_TYPE_NAME;
		[DataMember]
		public System.String  ED_TYPE_NAME{get{ return  _ED_TYPE_NAME;}set{ _ED_TYPE_NAME = value;}}
		System.String  _CONTENT;
		[DataMember]
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.String  _IS_SEND_NAME;
		[DataMember]
		public System.String  IS_SEND_NAME{get{ return  _IS_SEND_NAME;}set{ _IS_SEND_NAME = value;}}
		System.String  _MANAGE_USER_ID_NAME;
		[DataMember]
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String  _SEND_ID;
		[DataMember]
		public System.String  SEND_ID{get{ return  _SEND_ID;}set{ _SEND_ID = value;}}
		System.Decimal  _USER_IS_USABL;
		[DataMember]
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String  _IS_NURSE_NAME;
		[DataMember]
		public System.String  IS_NURSE_NAME{get{ return  _IS_NURSE_NAME;}set{ _IS_NURSE_NAME = value;}}
		System.Decimal  _IS_NURSE;
		[DataMember]
		public System.Decimal  IS_NURSE{get{ return  _IS_NURSE;}set{ _IS_NURSE = value;}}
		System.String  _DT_HH_EDUCATION_NAME;
		[DataMember]
		public System.String  DT_HH_EDUCATION_NAME{get{ return  _DT_HH_EDUCATION_NAME;}set{ _DT_HH_EDUCATION_NAME = value;}}
		System.String  _GESCH;
		[DataMember]
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.Decimal  _REAL_ZHRGRSG;
		[DataMember]
		public System.Decimal  REAL_ZHRGRSG{get{ return  _REAL_ZHRGRSG;}set{ _REAL_ZHRGRSG = value;}}
		System.String  _ACCOUNT;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.Decimal  _IS_PUBLIC;
		[DataMember]
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.Decimal  _WRITTEN_THEORY;
		[DataMember]
		public System.Decimal  WRITTEN_THEORY{get{ return  _WRITTEN_THEORY;}set{ _WRITTEN_THEORY = value;}}
		System.String  _USRID_MAIL;
		[DataMember]
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}
		System.String  _REPLY_STATUS;
		[DataMember]
		public System.String  REPLY_STATUS{get{ return  _REPLY_STATUS;}set{ _REPLY_STATUS = value;}}
		System.String  _PRACTICE_TYPE_ID_NAME;
		[DataMember]
		public System.String  PRACTICE_TYPE_ID_NAME{get{ return  _PRACTICE_TYPE_ID_NAME;}set{ _PRACTICE_TYPE_ID_NAME = value;}}
		System.String  _STAFF_ID;
		[DataMember]
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String  _SLART_NAME;
		[DataMember]
		public System.String  SLART_NAME{get{ return  _SLART_NAME;}set{ _SLART_NAME = value;}}
		System.Decimal  _MANAGE_USER_IS_USABL;
		[DataMember]
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.Decimal  _ZHRGRSG;
		[DataMember]
		public System.Decimal  ZHRGRSG{get{ return  _ZHRGRSG;}set{ _ZHRGRSG = value;}}
		System.String  _TITLE;
		[DataMember]
		public System.String  TITLE{get{ return  _TITLE;}set{ _TITLE = value;}}
		System.String  _STATUS_NAME;
		[DataMember]
		public System.String  STATUS_NAME{get{ return  _STATUS_NAME;}set{ _STATUS_NAME = value;}}
		System.String  _USRID_TEL;
		[DataMember]
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
		System.String  _SF_SS_EDUCATION_TYPE;
		[DataMember]
		public System.String  SF_SS_EDUCATION_TYPE{get{ return  _SF_SS_EDUCATION_TYPE;}set{ _SF_SS_EDUCATION_TYPE = value;}}
		System.DateTime  _GBDAT;
		[DataMember]
		public System.DateTime  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String  _RECRUIT_POSITION;
		[DataMember]
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal  _IS_SEND;
		[DataMember]
		public System.Decimal  IS_SEND{get{ return  _IS_SEND;}set{ _IS_SEND = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.DateTime  _PUBLISH_DATE;
		[DataMember]
		public System.DateTime  PUBLISH_DATE{get{ return  _PUBLISH_DATE;}set{ _PUBLISH_DATE = value;}}
		System.Decimal  _OPERATOR_ONE;
		[DataMember]
		public System.Decimal  OPERATOR_ONE{get{ return  _OPERATOR_ONE;}set{ _OPERATOR_ONE = value;}}
		System.Decimal  _ZHRTZGG;
		[DataMember]
		public System.Decimal  ZHRTZGG{get{ return  _ZHRTZGG;}set{ _ZHRTZGG = value;}}
		System.Decimal  _REAL_ZHRSLJZ;
		[DataMember]
		public System.Decimal  REAL_ZHRSLJZ{get{ return  _REAL_ZHRSLJZ;}set{ _REAL_ZHRSLJZ = value;}}
		System.String  _STAFF_TYPE_ID;
		[DataMember]
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal  _STAFF_IS_NURSE;
		[DataMember]
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.String  _INSTI;
		[DataMember]
		public System.String  INSTI{get{ return  _INSTI;}set{ _INSTI = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _SEX;
		[DataMember]
		public System.String  SEX{get{ return  _SEX;}set{ _SEX = value;}}
		System.String  _FIRSTCHOICE;
		[DataMember]
		public System.String  FIRSTCHOICE{get{ return  _FIRSTCHOICE;}set{ _FIRSTCHOICE = value;}}
		System.String  _NACHN;
		[DataMember]
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String  _SEND_ERROR;
		[DataMember]
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String  _TYPE_NAME;
		[DataMember]
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.String  _ZHRJG;
		[DataMember]
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String  _MANAGE_USER_ID;
		[DataMember]
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.Decimal  _WRITTEN_ENGLISH;
		[DataMember]
		public System.Decimal  WRITTEN_ENGLISH{get{ return  _WRITTEN_ENGLISH;}set{ _WRITTEN_ENGLISH = value;}}
		System.String  _MSSAGE_ID;
		[DataMember]
		public System.String  MSSAGE_ID{get{ return  _MSSAGE_ID;}set{ _MSSAGE_ID = value;}}
        System.String _FILE_PATH;
		[DataMember]
        public System.String FILE_PATH { get { return _FILE_PATH; } set { _FILE_PATH = value; } }
        System.String _OUTOCEAN;
        [DataMember]
        public System.String OUTOCEAN { get { return _OUTOCEAN; } set { _OUTOCEAN = value; } }
        
		#endregion 
	}	
}
