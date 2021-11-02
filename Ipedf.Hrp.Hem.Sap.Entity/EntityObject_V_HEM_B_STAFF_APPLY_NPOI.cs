using System;
using System.Data;
using System.Collections;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using System.Runtime.Serialization;
namespace Ipedf.Hrp.Hem.Sap.Entity
{
	[Serializable]
	[DataObject("V_HEM_B_STAFF_APPLY_NPOI")]
	public partial class CauseObject_V_HEM_B_STAFF_APPLY_NPOI:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal _IS_PUBLIC = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String _SF_GZ_EDUCATION_INSTI = string.Empty;
		[DataMember]
		public System.String  SF_GZ_EDUCATION_INSTI{get{ return  _SF_GZ_EDUCATION_INSTI;}set{ _SF_GZ_EDUCATION_INSTI = value;}}
		System.String _SF_BS_EDUCATION_INSTI = string.Empty;
		[DataMember]
		public System.String  SF_BS_EDUCATION_INSTI{get{ return  _SF_BS_EDUCATION_INSTI;}set{ _SF_BS_EDUCATION_INSTI = value;}}
		System.String _SF_SS_EDUCATION_ZHRDSXM = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_ZHRDSXM{get{ return  _SF_SS_EDUCATION_ZHRDSXM;}set{ _SF_SS_EDUCATION_ZHRDSXM = value;}}
		System.String _TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.String _STAFF_TYPE_ID = string.Empty;
		[DataMember]
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal _ESB = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ESB{get{ return  _ESB;}set{ _ESB = value;}}
		System.String _SEX = string.Empty;
		[DataMember]
		public System.String  SEX{get{ return  _SEX;}set{ _SEX = value;}}
		System.String _DT_SS_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  DT_SS_TYPE_NAME{get{ return  _DT_SS_TYPE_NAME;}set{ _DT_SS_TYPE_NAME = value;}}
		System.String _SF_ZHRJSJSP_NAME = string.Empty;
		[DataMember]
		public System.String  SF_ZHRJSJSP_NAME{get{ return  _SF_ZHRJSJSP_NAME;}set{ _SF_ZHRJSJSP_NAME = value;}}
		System.String _ICNUM = string.Empty;
		[DataMember]
		public System.String  ICNUM{get{ return  _ICNUM;}set{ _ICNUM = value;}}
		System.Decimal _EQW = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EQW{get{ return  _EQW;}set{ _EQW = value;}}
		System.String _ZHRJG = string.Empty;
		[DataMember]
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String _STAFF_ID = string.Empty;
		[DataMember]
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String _SF_BK_EDUCATION_INSTI = string.Empty;
		[DataMember]
		public System.String  SF_BK_EDUCATION_INSTI{get{ return  _SF_BK_EDUCATION_INSTI;}set{ _SF_BK_EDUCATION_INSTI = value;}}
		System.Decimal _STATUS = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.Decimal _MANAGE_USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.String _STATUS_NAME = string.Empty;
		[DataMember]
		public System.String  STATUS_NAME{get{ return  _STATUS_NAME;}set{ _STATUS_NAME = value;}}
		System.String _SF_BS_EDUCATION_ZHRXKZY1 = string.Empty;
		[DataMember]
		public System.String  SF_BS_EDUCATION_ZHRXKZY1{get{ return  _SF_BS_EDUCATION_ZHRXKZY1;}set{ _SF_BS_EDUCATION_ZHRXKZY1 = value;}}
		System.String _DT_BS_EDUCATION_NAME = string.Empty;
		[DataMember]
		public System.String  DT_BS_EDUCATION_NAME{get{ return  _DT_BS_EDUCATION_NAME;}set{ _DT_BS_EDUCATION_NAME = value;}}
		System.Decimal _EYB = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EYB{get{ return  _EYB;}set{ _EYB = value;}}
		System.Decimal _ZHRTZGG = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ZHRTZGG{get{ return  _ZHRTZGG;}set{ _ZHRTZGG = value;}}
		System.Decimal _IS_SEND = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_SEND{get{ return  _IS_SEND;}set{ _IS_SEND = value;}}
		System.Decimal _STAFF_IS_NURSE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.String _SF_BS_EDUCATION_ZHRDSXM = string.Empty;
		[DataMember]
		public System.String  SF_BS_EDUCATION_ZHRDSXM{get{ return  _SF_BS_EDUCATION_ZHRDSXM;}set{ _SF_BS_EDUCATION_ZHRDSXM = value;}}
		System.String _SF_BS_EDUCATION_ENDDA = string.Empty;
		[DataMember]
		public System.String  SF_BS_EDUCATION_ENDDA{get{ return  _SF_BS_EDUCATION_ENDDA;}set{ _SF_BS_EDUCATION_ENDDA = value;}}
		System.String _SF_SS_EDUCATION_INSTI = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_INSTI{get{ return  _SF_SS_EDUCATION_INSTI;}set{ _SF_SS_EDUCATION_INSTI = value;}}
		System.String _SF_HH_EDUCATION_INSTI = string.Empty;
		[DataMember]
		public System.String  SF_HH_EDUCATION_INSTI{get{ return  _SF_HH_EDUCATION_INSTI;}set{ _SF_HH_EDUCATION_INSTI = value;}}
		System.String _GESCH = string.Empty;
		[DataMember]
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.String _MSSAGE_ID = string.Empty;
		[DataMember]
		public System.String  MSSAGE_ID{get{ return  _MSSAGE_ID;}set{ _MSSAGE_ID = value;}}
		System.String _SF_BK_EDUCATION_BEGDA = string.Empty;
		[DataMember]
		public System.String  SF_BK_EDUCATION_BEGDA{get{ return  _SF_BK_EDUCATION_BEGDA;}set{ _SF_BK_EDUCATION_BEGDA = value;}}
		System.Decimal _IS_CERTIFICATE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.String _CONTENT = string.Empty;
		[DataMember]
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String _SF_HH_EDUCATION_ENDDA = string.Empty;
		[DataMember]
		public System.String  SF_HH_EDUCATION_ENDDA{get{ return  _SF_HH_EDUCATION_ENDDA;}set{ _SF_HH_EDUCATION_ENDDA = value;}}
		System.String _RACKY_NAME = string.Empty;
		[DataMember]
		public System.String  RACKY_NAME{get{ return  _RACKY_NAME;}set{ _RACKY_NAME = value;}}
		System.String _MANAGE_USER_ID = string.Empty;
		[DataMember]
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String _SF_BK_EDUCATION_ZHRXKZY1 = string.Empty;
		[DataMember]
		public System.String  SF_BK_EDUCATION_ZHRXKZY1{get{ return  _SF_BK_EDUCATION_ZHRXKZY1;}set{ _SF_BK_EDUCATION_ZHRXKZY1 = value;}}
		System.String _SF_SS_EDUCATION_ENDDA = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_ENDDA{get{ return  _SF_SS_EDUCATION_ENDDA;}set{ _SF_SS_EDUCATION_ENDDA = value;}}
		System.String _POSTER_ID = string.Empty;
		[DataMember]
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String _SECONDCHOICE = string.Empty;
		[DataMember]
		public System.String  SECONDCHOICE{get{ return  _SECONDCHOICE;}set{ _SECONDCHOICE = value;}}
		System.Decimal _OPERATOR_ONE = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  OPERATOR_ONE{get{ return  _OPERATOR_ONE;}set{ _OPERATOR_ONE = value;}}
		System.Decimal _ZHRGRTZ = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ZHRGRTZ{get{ return  _ZHRGRTZ;}set{ _ZHRGRTZ = value;}}
		System.String _SF_BS_EDUCATION_BEGDA = string.Empty;
		[DataMember]
		public System.String  SF_BS_EDUCATION_BEGDA{get{ return  _SF_BS_EDUCATION_BEGDA;}set{ _SF_BS_EDUCATION_BEGDA = value;}}
		System.String _SF_ZHRWYSP_NAME = string.Empty;
		[DataMember]
		public System.String  SF_ZHRWYSP_NAME{get{ return  _SF_ZHRWYSP_NAME;}set{ _SF_ZHRWYSP_NAME = value;}}
		System.String _ID = string.Empty;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _SF_WORK_SX_ZHRXXDW = string.Empty;
		[DataMember]
		public System.String  SF_WORK_SX_ZHRXXDW{get{ return  _SF_WORK_SX_ZHRXXDW;}set{ _SF_WORK_SX_ZHRXXDW = value;}}
		System.String _SF_FAMST_NAME = string.Empty;
		[DataMember]
		public System.String  SF_FAMST_NAME{get{ return  _SF_FAMST_NAME;}set{ _SF_FAMST_NAME = value;}}
		System.String _ZHRHJJL = string.Empty;
		[DataMember]
		public System.String  ZHRHJJL{get{ return  _ZHRHJJL;}set{ _ZHRHJJL = value;}}
		System.String _SX_ZHRGZNX = string.Empty;
		[DataMember]
		public System.String  SX_ZHRGZNX{get{ return  _SX_ZHRGZNX;}set{ _SX_ZHRGZNX = value;}}
		System.String _DT_HH_EDUCATION_NAME = string.Empty;
		[DataMember]
		public System.String  DT_HH_EDUCATION_NAME{get{ return  _DT_HH_EDUCATION_NAME;}set{ _DT_HH_EDUCATION_NAME = value;}}
		System.String _RECRUIT_POSITION = string.Empty;
		[DataMember]
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal _ESC = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ESC{get{ return  _ESC;}set{ _ESC = value;}}
		System.String _SF_WORK_YJ_ZHRXXDW = string.Empty;
		[DataMember]
		public System.String  SF_WORK_YJ_ZHRXXDW{get{ return  _SF_WORK_YJ_ZHRXXDW;}set{ _SF_WORK_YJ_ZHRXXDW = value;}}
		System.String _DT_BS_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  DT_BS_TYPE_NAME{get{ return  _DT_BS_TYPE_NAME;}set{ _DT_BS_TYPE_NAME = value;}}
		System.Decimal _ESA = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ESA{get{ return  _ESA;}set{ _ESA = value;}}
		System.String _YJ_ZHRGZNX = string.Empty;
		[DataMember]
		public System.String  YJ_ZHRGZNX{get{ return  _YJ_ZHRGZNX;}set{ _YJ_ZHRGZNX = value;}}
		System.Decimal _WRITTEN_THEORY = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  WRITTEN_THEORY{get{ return  _WRITTEN_THEORY;}set{ _WRITTEN_THEORY = value;}}
		System.Decimal _EOTHER = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EOTHER{get{ return  _EOTHER;}set{ _EOTHER = value;}}
		System.String _PCODE_NAME = string.Empty;
		[DataMember]
		public System.String  PCODE_NAME{get{ return  _PCODE_NAME;}set{ _PCODE_NAME = value;}}
		System.String _SF_HH_EDUCATION_BEGDA = string.Empty;
		[DataMember]
		public System.String  SF_HH_EDUCATION_BEGDA{get{ return  _SF_HH_EDUCATION_BEGDA;}set{ _SF_HH_EDUCATION_BEGDA = value;}}
		DateSpan _CREATE_DATE = null;
		[DataMember]
		public DateSpan  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String _TYPE_ID = string.Empty;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		DateSpan _GBDAT = null;
		[DataMember]
		public DateSpan  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String _PRACTICE_TYPE_ID_NAME = string.Empty;
		[DataMember]
		public System.String  PRACTICE_TYPE_ID_NAME{get{ return  _PRACTICE_TYPE_ID_NAME;}set{ _PRACTICE_TYPE_ID_NAME = value;}}
		System.Decimal _EHX = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  EHX{get{ return  _EHX;}set{ _EHX = value;}}
		System.String _SF_HH_EDUCATION_ZHRXKZY1 = string.Empty;
		[DataMember]
		public System.String  SF_HH_EDUCATION_ZHRXKZY1{get{ return  _SF_HH_EDUCATION_ZHRXKZY1;}set{ _SF_HH_EDUCATION_ZHRXKZY1 = value;}}
		System.String _ZHRSLJZ = string.Empty;
		[DataMember]
		public System.String  ZHRSLJZ{get{ return  _ZHRSLJZ;}set{ _ZHRSLJZ = value;}}
		System.String _FIRSTCHOICE = string.Empty;
		[DataMember]
		public System.String  FIRSTCHOICE{get{ return  _FIRSTCHOICE;}set{ _FIRSTCHOICE = value;}}
		System.String _DT_SS_EDUCATION_NAME = string.Empty;
		[DataMember]
		public System.String  DT_SS_EDUCATION_NAME{get{ return  _DT_SS_EDUCATION_NAME;}set{ _DT_SS_EDUCATION_NAME = value;}}
		System.Decimal _WRITTEN_ENGLISH = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  WRITTEN_ENGLISH{get{ return  _WRITTEN_ENGLISH;}set{ _WRITTEN_ENGLISH = value;}}
		System.String _SF_SS_EDUCATION_ZHRXKZY1 = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_ZHRXKZY1{get{ return  _SF_SS_EDUCATION_ZHRXKZY1;}set{ _SF_SS_EDUCATION_ZHRXKZY1 = value;}}
		System.String _ZHRSXXX = string.Empty;
		[DataMember]
		public System.String  ZHRSXXX{get{ return  _ZHRSXXX;}set{ _ZHRSXXX = value;}}
		System.Decimal _ESCI = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ESCI{get{ return  _ESCI;}set{ _ESCI = value;}}
		System.String _DT_BK_EDUCATION_NAME = string.Empty;
		[DataMember]
		public System.String  DT_BK_EDUCATION_NAME{get{ return  _DT_BK_EDUCATION_NAME;}set{ _DT_BK_EDUCATION_NAME = value;}}
		System.Decimal _WRITTEN_TOTAL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  WRITTEN_TOTAL{get{ return  _WRITTEN_TOTAL;}set{ _WRITTEN_TOTAL = value;}}
		System.String _SF_HH_EDUCATION_ZHRDSXM = string.Empty;
		[DataMember]
		public System.String  SF_HH_EDUCATION_ZHRDSXM{get{ return  _SF_HH_EDUCATION_ZHRDSXM;}set{ _SF_HH_EDUCATION_ZHRDSXM = value;}}
		System.Decimal _REAL_ZHRGRTZ = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REAL_ZHRGRTZ{get{ return  _REAL_ZHRGRTZ;}set{ _REAL_ZHRGRTZ = value;}}
		System.Decimal _REAL_ZHRGRSG = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REAL_ZHRGRSG{get{ return  _REAL_ZHRGRSG;}set{ _REAL_ZHRGRSG = value;}}
		System.Decimal _ZHRGRSG = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  ZHRGRSG{get{ return  _ZHRGRSG;}set{ _ZHRGRSG = value;}}
		System.String _ACCOUNT = string.Empty;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String _ZHRTC = string.Empty;
		[DataMember]
		public System.String  ZHRTC{get{ return  _ZHRTC;}set{ _ZHRTC = value;}}
		System.String _SF_SS_EDUCATION_BEGDA = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_BEGDA{get{ return  _SF_SS_EDUCATION_BEGDA;}set{ _SF_SS_EDUCATION_BEGDA = value;}}
		System.String _MANAGE_USER_ID_NAME = string.Empty;
		[DataMember]
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String _SEND_ERROR = string.Empty;
		[DataMember]
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String _DT_ZG_TYPE_NAME = string.Empty;
		[DataMember]
		public System.String  DT_ZG_TYPE_NAME{get{ return  _DT_ZG_TYPE_NAME;}set{ _DT_ZG_TYPE_NAME = value;}}
		System.String _SF_SS_EDUCATION_SLART = string.Empty;
		[DataMember]
		public System.String  SF_SS_EDUCATION_SLART{get{ return  _SF_SS_EDUCATION_SLART;}set{ _SF_SS_EDUCATION_SLART = value;}}
		System.String _SF_BK_EDUCATION_ENDDA = string.Empty;
		[DataMember]
		public System.String  SF_BK_EDUCATION_ENDDA{get{ return  _SF_BK_EDUCATION_ENDDA;}set{ _SF_BK_EDUCATION_ENDDA = value;}}
		System.String _ZHRWZMC = string.Empty;
		[DataMember]
		public System.String  ZHRWZMC{get{ return  _ZHRWZMC;}set{ _ZHRWZMC = value;}}
		System.Decimal _REAL_ZHRSLJZ = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  REAL_ZHRSLJZ{get{ return  _REAL_ZHRSLJZ;}set{ _REAL_ZHRSLJZ = value;}}
		System.String _NACHN = string.Empty;
		[DataMember]
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String _USER_ID = string.Empty;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _USRID_MAIL = string.Empty;
		[DataMember]
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}
		System.String _ZHRBZ = string.Empty;
		[DataMember]
		public System.String  ZHRBZ{get{ return  _ZHRBZ;}set{ _ZHRBZ = value;}}
		System.Decimal _USER_IS_USABL = ConstLibrary.Template.UndefineDecimal;
		[DataMember]
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String _STAFF_IS_NURSE_NAME = string.Empty;
		[DataMember]
		public System.String  STAFF_IS_NURSE_NAME{get{ return  _STAFF_IS_NURSE_NAME;}set{ _STAFF_IS_NURSE_NAME = value;}}
		System.String _USRID_TEL = string.Empty;
		[DataMember]
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
        System.String _IS_STANDARD = string.Empty;
		[DataMember]
		public System.String  IS_STANDARD{get{ return  _IS_STANDARD;}set{ _IS_STANDARD = value;}}

        System.String _IS_SZHY = string.Empty;
        [DataMember]
        public System.String IS_SZHY { get { return _IS_SZHY; } set { _IS_SZHY = value; } }
        #endregion
    }
	[Serializable]
	public partial class DisplayObject_V_HEM_B_STAFF_APPLY_NPOI:EntityObject_V_HEM_B_STAFF_APPLY_NPOI
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	public partial class EntityObject_V_HEM_B_STAFF_APPLY_NPOI:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.Decimal  _IS_PUBLIC;
		[DataMember]
		public System.Decimal  IS_PUBLIC{get{ return  _IS_PUBLIC;}set{ _IS_PUBLIC = value;}}
		System.String  _SF_GZ_EDUCATION_INSTI;
		[DataMember]
		public System.String  SF_GZ_EDUCATION_INSTI{get{ return  _SF_GZ_EDUCATION_INSTI;}set{ _SF_GZ_EDUCATION_INSTI = value;}}
		System.String  _SF_BS_EDUCATION_INSTI;
		[DataMember]
		public System.String  SF_BS_EDUCATION_INSTI{get{ return  _SF_BS_EDUCATION_INSTI;}set{ _SF_BS_EDUCATION_INSTI = value;}}
		System.String  _SF_SS_EDUCATION_ZHRDSXM;
		[DataMember]
		public System.String  SF_SS_EDUCATION_ZHRDSXM{get{ return  _SF_SS_EDUCATION_ZHRDSXM;}set{ _SF_SS_EDUCATION_ZHRDSXM = value;}}
		System.String  _TYPE_NAME;
		[DataMember]
		public System.String  TYPE_NAME{get{ return  _TYPE_NAME;}set{ _TYPE_NAME = value;}}
		System.String  _STAFF_TYPE_ID;
		[DataMember]
		public System.String  STAFF_TYPE_ID{get{ return  _STAFF_TYPE_ID;}set{ _STAFF_TYPE_ID = value;}}
		System.Decimal  _ESB;
		[DataMember]
		public System.Decimal  ESB{get{ return  _ESB;}set{ _ESB = value;}}
		System.String  _SEX;
		[DataMember]
		public System.String  SEX{get{ return  _SEX;}set{ _SEX = value;}}
		System.String  _DT_SS_TYPE_NAME;
		[DataMember]
		public System.String  DT_SS_TYPE_NAME{get{ return  _DT_SS_TYPE_NAME;}set{ _DT_SS_TYPE_NAME = value;}}
		System.String  _SF_ZHRJSJSP_NAME;
		[DataMember]
		public System.String  SF_ZHRJSJSP_NAME{get{ return  _SF_ZHRJSJSP_NAME;}set{ _SF_ZHRJSJSP_NAME = value;}}
		System.String  _ICNUM;
		[DataMember]
		public System.String  ICNUM{get{ return  _ICNUM;}set{ _ICNUM = value;}}
		System.Decimal  _EQW;
		[DataMember]
		public System.Decimal  EQW{get{ return  _EQW;}set{ _EQW = value;}}
		System.String  _ZHRJG;
		[DataMember]
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String  _STAFF_ID;
		[DataMember]
		public System.String  STAFF_ID{get{ return  _STAFF_ID;}set{ _STAFF_ID = value;}}
		System.String  _SF_BK_EDUCATION_INSTI;
		[DataMember]
		public System.String  SF_BK_EDUCATION_INSTI{get{ return  _SF_BK_EDUCATION_INSTI;}set{ _SF_BK_EDUCATION_INSTI = value;}}
		System.Decimal  _STATUS;
		[DataMember]
		public System.Decimal  STATUS{get{ return  _STATUS;}set{ _STATUS = value;}}
		System.Decimal  _MANAGE_USER_IS_USABL;
		[DataMember]
		public System.Decimal  MANAGE_USER_IS_USABL{get{ return  _MANAGE_USER_IS_USABL;}set{ _MANAGE_USER_IS_USABL = value;}}
		System.String  _STATUS_NAME;
		[DataMember]
		public System.String  STATUS_NAME{get{ return  _STATUS_NAME;}set{ _STATUS_NAME = value;}}
		System.String  _SF_BS_EDUCATION_ZHRXKZY1;
		[DataMember]
		public System.String  SF_BS_EDUCATION_ZHRXKZY1{get{ return  _SF_BS_EDUCATION_ZHRXKZY1;}set{ _SF_BS_EDUCATION_ZHRXKZY1 = value;}}
		System.String  _DT_BS_EDUCATION_NAME;
		[DataMember]
		public System.String  DT_BS_EDUCATION_NAME{get{ return  _DT_BS_EDUCATION_NAME;}set{ _DT_BS_EDUCATION_NAME = value;}}
		System.Decimal  _EYB;
		[DataMember]
		public System.Decimal  EYB{get{ return  _EYB;}set{ _EYB = value;}}
		System.Decimal  _ZHRTZGG;
		[DataMember]
		public System.Decimal  ZHRTZGG{get{ return  _ZHRTZGG;}set{ _ZHRTZGG = value;}}
		System.Decimal  _IS_SEND;
		[DataMember]
		public System.Decimal  IS_SEND{get{ return  _IS_SEND;}set{ _IS_SEND = value;}}
		System.Decimal  _STAFF_IS_NURSE;
		[DataMember]
		public System.Decimal  STAFF_IS_NURSE{get{ return  _STAFF_IS_NURSE;}set{ _STAFF_IS_NURSE = value;}}
		System.String  _SF_BS_EDUCATION_ZHRDSXM;
		[DataMember]
		public System.String  SF_BS_EDUCATION_ZHRDSXM{get{ return  _SF_BS_EDUCATION_ZHRDSXM;}set{ _SF_BS_EDUCATION_ZHRDSXM = value;}}
		System.String  _SF_BS_EDUCATION_ENDDA;
		[DataMember]
		public System.String  SF_BS_EDUCATION_ENDDA{get{ return  _SF_BS_EDUCATION_ENDDA;}set{ _SF_BS_EDUCATION_ENDDA = value;}}
		System.String  _SF_SS_EDUCATION_INSTI;
		[DataMember]
		public System.String  SF_SS_EDUCATION_INSTI{get{ return  _SF_SS_EDUCATION_INSTI;}set{ _SF_SS_EDUCATION_INSTI = value;}}
		System.String  _SF_HH_EDUCATION_INSTI;
		[DataMember]
		public System.String  SF_HH_EDUCATION_INSTI{get{ return  _SF_HH_EDUCATION_INSTI;}set{ _SF_HH_EDUCATION_INSTI = value;}}
		System.String  _GESCH;
		[DataMember]
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.String  _MSSAGE_ID;
		[DataMember]
		public System.String  MSSAGE_ID{get{ return  _MSSAGE_ID;}set{ _MSSAGE_ID = value;}}
		System.String  _SF_BK_EDUCATION_BEGDA;
		[DataMember]
		public System.String  SF_BK_EDUCATION_BEGDA{get{ return  _SF_BK_EDUCATION_BEGDA;}set{ _SF_BK_EDUCATION_BEGDA = value;}}
		System.Decimal  _IS_CERTIFICATE;
		[DataMember]
		public System.Decimal  IS_CERTIFICATE{get{ return  _IS_CERTIFICATE;}set{ _IS_CERTIFICATE = value;}}
		System.String  _CONTENT;
		[DataMember]
		public System.String  CONTENT{get{ return  _CONTENT;}set{ _CONTENT = value;}}
		System.String  _SF_HH_EDUCATION_ENDDA;
		[DataMember]
		public System.String  SF_HH_EDUCATION_ENDDA{get{ return  _SF_HH_EDUCATION_ENDDA;}set{ _SF_HH_EDUCATION_ENDDA = value;}}
		System.String  _RACKY_NAME;
		[DataMember]
		public System.String  RACKY_NAME{get{ return  _RACKY_NAME;}set{ _RACKY_NAME = value;}}
		System.String  _MANAGE_USER_ID;
		[DataMember]
		public System.String  MANAGE_USER_ID{get{ return  _MANAGE_USER_ID;}set{ _MANAGE_USER_ID = value;}}
		System.String  _SF_BK_EDUCATION_ZHRXKZY1;
		[DataMember]
		public System.String  SF_BK_EDUCATION_ZHRXKZY1{get{ return  _SF_BK_EDUCATION_ZHRXKZY1;}set{ _SF_BK_EDUCATION_ZHRXKZY1 = value;}}
		System.String  _SF_SS_EDUCATION_ENDDA;
		[DataMember]
		public System.String  SF_SS_EDUCATION_ENDDA{get{ return  _SF_SS_EDUCATION_ENDDA;}set{ _SF_SS_EDUCATION_ENDDA = value;}}
		System.String  _POSTER_ID;
		[DataMember]
		public System.String  POSTER_ID{get{ return  _POSTER_ID;}set{ _POSTER_ID = value;}}
		System.String  _SECONDCHOICE;
		[DataMember]
		public System.String  SECONDCHOICE{get{ return  _SECONDCHOICE;}set{ _SECONDCHOICE = value;}}
		System.Decimal  _OPERATOR_ONE;
		[DataMember]
		public System.Decimal  OPERATOR_ONE{get{ return  _OPERATOR_ONE;}set{ _OPERATOR_ONE = value;}}
		System.Decimal  _ZHRGRTZ;
		[DataMember]
		public System.Decimal  ZHRGRTZ{get{ return  _ZHRGRTZ;}set{ _ZHRGRTZ = value;}}
		System.String  _SF_BS_EDUCATION_BEGDA;
		[DataMember]
		public System.String  SF_BS_EDUCATION_BEGDA{get{ return  _SF_BS_EDUCATION_BEGDA;}set{ _SF_BS_EDUCATION_BEGDA = value;}}
		System.String  _SF_ZHRWYSP_NAME;
		[DataMember]
		public System.String  SF_ZHRWYSP_NAME{get{ return  _SF_ZHRWYSP_NAME;}set{ _SF_ZHRWYSP_NAME = value;}}
		System.String  _ID;
		[DataMember]
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _SF_WORK_SX_ZHRXXDW;
		[DataMember]
		public System.String  SF_WORK_SX_ZHRXXDW{get{ return  _SF_WORK_SX_ZHRXXDW;}set{ _SF_WORK_SX_ZHRXXDW = value;}}
		System.String  _SF_FAMST_NAME;
		[DataMember]
		public System.String  SF_FAMST_NAME{get{ return  _SF_FAMST_NAME;}set{ _SF_FAMST_NAME = value;}}
		System.String  _ZHRHJJL;
		[DataMember]
		public System.String  ZHRHJJL{get{ return  _ZHRHJJL;}set{ _ZHRHJJL = value;}}
		System.String  _SX_ZHRGZNX;
		[DataMember]
		public System.String  SX_ZHRGZNX{get{ return  _SX_ZHRGZNX;}set{ _SX_ZHRGZNX = value;}}
		System.String  _DT_HH_EDUCATION_NAME;
		[DataMember]
		public System.String  DT_HH_EDUCATION_NAME{get{ return  _DT_HH_EDUCATION_NAME;}set{ _DT_HH_EDUCATION_NAME = value;}}
		System.String  _RECRUIT_POSITION;
		[DataMember]
		public System.String  RECRUIT_POSITION{get{ return  _RECRUIT_POSITION;}set{ _RECRUIT_POSITION = value;}}
		System.Decimal  _ESC;
		[DataMember]
		public System.Decimal  ESC{get{ return  _ESC;}set{ _ESC = value;}}
		System.String  _SF_WORK_YJ_ZHRXXDW;
		[DataMember]
		public System.String  SF_WORK_YJ_ZHRXXDW{get{ return  _SF_WORK_YJ_ZHRXXDW;}set{ _SF_WORK_YJ_ZHRXXDW = value;}}
		System.String  _DT_BS_TYPE_NAME;
		[DataMember]
		public System.String  DT_BS_TYPE_NAME{get{ return  _DT_BS_TYPE_NAME;}set{ _DT_BS_TYPE_NAME = value;}}
		System.Decimal  _ESA;
		[DataMember]
		public System.Decimal  ESA{get{ return  _ESA;}set{ _ESA = value;}}
		System.String  _YJ_ZHRGZNX;
		[DataMember]
		public System.String  YJ_ZHRGZNX{get{ return  _YJ_ZHRGZNX;}set{ _YJ_ZHRGZNX = value;}}
		System.Decimal  _WRITTEN_THEORY;
		[DataMember]
		public System.Decimal  WRITTEN_THEORY{get{ return  _WRITTEN_THEORY;}set{ _WRITTEN_THEORY = value;}}
		System.Decimal  _EOTHER;
		[DataMember]
		public System.Decimal  EOTHER{get{ return  _EOTHER;}set{ _EOTHER = value;}}
		System.String  _PCODE_NAME;
		[DataMember]
		public System.String  PCODE_NAME{get{ return  _PCODE_NAME;}set{ _PCODE_NAME = value;}}
		System.String  _SF_HH_EDUCATION_BEGDA;
		[DataMember]
		public System.String  SF_HH_EDUCATION_BEGDA{get{ return  _SF_HH_EDUCATION_BEGDA;}set{ _SF_HH_EDUCATION_BEGDA = value;}}
		System.DateTime  _CREATE_DATE;
		[DataMember]
		public System.DateTime  CREATE_DATE{get{ return  _CREATE_DATE;}set{ _CREATE_DATE = value;}}
		System.String  _TYPE_ID;
		[DataMember]
		public System.String  TYPE_ID{get{ return  _TYPE_ID;}set{ _TYPE_ID = value;}}
		System.DateTime  _GBDAT;
		[DataMember]
		public System.DateTime  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String  _PRACTICE_TYPE_ID_NAME;
		[DataMember]
		public System.String  PRACTICE_TYPE_ID_NAME{get{ return  _PRACTICE_TYPE_ID_NAME;}set{ _PRACTICE_TYPE_ID_NAME = value;}}
		System.Decimal  _EHX;
		[DataMember]
		public System.Decimal  EHX{get{ return  _EHX;}set{ _EHX = value;}}
		System.String  _SF_HH_EDUCATION_ZHRXKZY1;
		[DataMember]
		public System.String  SF_HH_EDUCATION_ZHRXKZY1{get{ return  _SF_HH_EDUCATION_ZHRXKZY1;}set{ _SF_HH_EDUCATION_ZHRXKZY1 = value;}}
		System.String  _ZHRSLJZ;
		[DataMember]
		public System.String  ZHRSLJZ{get{ return  _ZHRSLJZ;}set{ _ZHRSLJZ = value;}}
		System.String  _FIRSTCHOICE;
		[DataMember]
		public System.String  FIRSTCHOICE{get{ return  _FIRSTCHOICE;}set{ _FIRSTCHOICE = value;}}
		System.String  _DT_SS_EDUCATION_NAME;
		[DataMember]
		public System.String  DT_SS_EDUCATION_NAME{get{ return  _DT_SS_EDUCATION_NAME;}set{ _DT_SS_EDUCATION_NAME = value;}}
		System.Decimal  _WRITTEN_ENGLISH;
		[DataMember]
		public System.Decimal  WRITTEN_ENGLISH{get{ return  _WRITTEN_ENGLISH;}set{ _WRITTEN_ENGLISH = value;}}
		System.String  _SF_SS_EDUCATION_ZHRXKZY1;
		[DataMember]
		public System.String  SF_SS_EDUCATION_ZHRXKZY1{get{ return  _SF_SS_EDUCATION_ZHRXKZY1;}set{ _SF_SS_EDUCATION_ZHRXKZY1 = value;}}
		System.String  _ZHRSXXX;
		[DataMember]
		public System.String  ZHRSXXX{get{ return  _ZHRSXXX;}set{ _ZHRSXXX = value;}}
        System.String _YJSSXXX;
        [DataMember]
        public System.String YJSSXXX { get { return _YJSSXXX; } set { _YJSSXXX = value; } }
		System.Decimal  _ESCI;
		[DataMember]
		public System.Decimal  ESCI{get{ return  _ESCI;}set{ _ESCI = value;}}
		System.String  _DT_BK_EDUCATION_NAME;
		[DataMember]
		public System.String  DT_BK_EDUCATION_NAME{get{ return  _DT_BK_EDUCATION_NAME;}set{ _DT_BK_EDUCATION_NAME = value;}}
		System.Decimal  _WRITTEN_TOTAL;
		[DataMember]
		public System.Decimal  WRITTEN_TOTAL{get{ return  _WRITTEN_TOTAL;}set{ _WRITTEN_TOTAL = value;}}
		System.String  _SF_HH_EDUCATION_ZHRDSXM;
		[DataMember]
		public System.String  SF_HH_EDUCATION_ZHRDSXM{get{ return  _SF_HH_EDUCATION_ZHRDSXM;}set{ _SF_HH_EDUCATION_ZHRDSXM = value;}}
		System.Decimal  _REAL_ZHRGRTZ;
		[DataMember]
		public System.Decimal  REAL_ZHRGRTZ{get{ return  _REAL_ZHRGRTZ;}set{ _REAL_ZHRGRTZ = value;}}
		System.Decimal  _REAL_ZHRGRSG;
		[DataMember]
		public System.Decimal  REAL_ZHRGRSG{get{ return  _REAL_ZHRGRSG;}set{ _REAL_ZHRGRSG = value;}}
		System.Decimal  _ZHRGRSG;
		[DataMember]
		public System.Decimal  ZHRGRSG{get{ return  _ZHRGRSG;}set{ _ZHRGRSG = value;}}
		System.String  _ACCOUNT;
		[DataMember]
		public System.String  ACCOUNT{get{ return  _ACCOUNT;}set{ _ACCOUNT = value;}}
		System.String  _ZHRTC;
		[DataMember]
		public System.String  ZHRTC{get{ return  _ZHRTC;}set{ _ZHRTC = value;}}
		System.String  _SF_SS_EDUCATION_BEGDA;
		[DataMember]
		public System.String  SF_SS_EDUCATION_BEGDA{get{ return  _SF_SS_EDUCATION_BEGDA;}set{ _SF_SS_EDUCATION_BEGDA = value;}}
		System.String  _MANAGE_USER_ID_NAME;
		[DataMember]
		public System.String  MANAGE_USER_ID_NAME{get{ return  _MANAGE_USER_ID_NAME;}set{ _MANAGE_USER_ID_NAME = value;}}
		System.String  _SEND_ERROR;
		[DataMember]
		public System.String  SEND_ERROR{get{ return  _SEND_ERROR;}set{ _SEND_ERROR = value;}}
		System.String  _DT_ZG_TYPE_NAME;
		[DataMember]
		public System.String  DT_ZG_TYPE_NAME{get{ return  _DT_ZG_TYPE_NAME;}set{ _DT_ZG_TYPE_NAME = value;}}
		System.String  _SF_SS_EDUCATION_SLART;
		[DataMember]
		public System.String  SF_SS_EDUCATION_SLART{get{ return  _SF_SS_EDUCATION_SLART;}set{ _SF_SS_EDUCATION_SLART = value;}}
		System.String  _SF_BK_EDUCATION_ENDDA;
		[DataMember]
		public System.String  SF_BK_EDUCATION_ENDDA{get{ return  _SF_BK_EDUCATION_ENDDA;}set{ _SF_BK_EDUCATION_ENDDA = value;}}
		System.String  _ZHRWZMC;
		[DataMember]
		public System.String  ZHRWZMC{get{ return  _ZHRWZMC;}set{ _ZHRWZMC = value;}}
		System.Decimal  _REAL_ZHRSLJZ;
		[DataMember]
		public System.Decimal  REAL_ZHRSLJZ{get{ return  _REAL_ZHRSLJZ;}set{ _REAL_ZHRSLJZ = value;}}
		System.String  _NACHN;
		[DataMember]
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.String  _USER_ID;
		[DataMember]
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _USRID_MAIL;
		[DataMember]
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}
		System.String  _ZHRBZ;
		[DataMember]
		public System.String  ZHRBZ{get{ return  _ZHRBZ;}set{ _ZHRBZ = value;}}
		System.Decimal  _USER_IS_USABL;
		[DataMember]
		public System.Decimal  USER_IS_USABL{get{ return  _USER_IS_USABL;}set{ _USER_IS_USABL = value;}}
		System.String  _STAFF_IS_NURSE_NAME;
		[DataMember]
		public System.String  STAFF_IS_NURSE_NAME{get{ return  _STAFF_IS_NURSE_NAME;}set{ _STAFF_IS_NURSE_NAME = value;}}
		System.String  _USRID_TEL;
		[DataMember]
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
        System.String _IS_STANDARD;
        [DataMember]
        public System.String IS_STANDARD { get { return _IS_STANDARD; } set { _IS_STANDARD = value; } }

        System.String _IS_SZHY;
        [DataMember]
        public System.String IS_SZHY { get { return _IS_SZHY; } set { _IS_SZHY = value; } }

        System.String _OUTOCEAN;
        [DataMember]
        public System.String OUTOCEAN { get { return _OUTOCEAN; } set { _OUTOCEAN = value; } }

		System.String _JWBS;
		[DataMember]
		public System.String JWBS { get { return _JWBS; } set { _JWBS = value; } }

		#endregion
	}	
}
