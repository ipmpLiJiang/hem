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
	
	[DataObject("HEM_B_STAFF")]
	public partial class CauseObject_HEM_B_STAFF:CauseBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String _FIRSTCHOICE = string.Empty;
		
		public System.String  FIRSTCHOICE{get{ return  _FIRSTCHOICE;}set{ _FIRSTCHOICE = value;}}
		System.String _ZHRTC = string.Empty;
		
		public System.String  ZHRTC{get{ return  _ZHRTC;}set{ _ZHRTC = value;}}
		System.String _ZHRYRXX = string.Empty;
		
		public System.String  ZHRYRXX{get{ return  _ZHRYRXX;}set{ _ZHRYRXX = value;}}
		System.String _USRID_MAIL = string.Empty;
		
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}
		DateSpan _GBDAT = null;
		
		public DateSpan  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String _LOCAT_JT = string.Empty;
		
		public System.String  LOCAT_JT{get{ return  _LOCAT_JT;}set{ _LOCAT_JT = value;}}
		System.String _USER_ID = string.Empty;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String _ZHRGRSG = string.Empty;
		
		public System.String  ZHRGRSG{get{ return  _ZHRGRSG;}set{ _ZHRGRSG = value;}}
		System.String _ID = string.Empty;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String _FAMST = string.Empty;
		
		public System.String  FAMST{get{ return  _FAMST;}set{ _FAMST = value;}}
		System.String _ZHRHJJL = string.Empty;
		
		public System.String  ZHRHJJL{get{ return  _ZHRHJJL;}set{ _ZHRHJJL = value;}}
		System.String _ZHRSXXX = string.Empty;
		
		public System.String  ZHRSXXX{get{ return  _ZHRSXXX;}set{ _ZHRSXXX = value;}}
		System.String _ZHRSLJZ = string.Empty;
		
		public System.String  ZHRSLJZ{get{ return  _ZHRSLJZ;}set{ _ZHRSLJZ = value;}}
		System.String _USRID_TEL = string.Empty;
		
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
		System.String _ZHRJSJSP = string.Empty;
		
		public System.String  ZHRJSJSP{get{ return  _ZHRJSJSP;}set{ _ZHRJSJSP = value;}}
		System.String _ZHRWYFS = string.Empty;
		
		public System.String  ZHRWYFS{get{ return  _ZHRWYFS;}set{ _ZHRWYFS = value;}}
		System.String _ZHRGZNX = string.Empty;
		
		public System.String  ZHRGZNX{get{ return  _ZHRGZNX;}set{ _ZHRGZNX = value;}}
		DateSpan _FGBDT = null;
		
		public DateSpan  FGBDT{get{ return  _FGBDT;}set{ _FGBDT = value;}}
		System.String _FANAM = string.Empty;
		
		public System.String  FANAM{get{ return  _FANAM;}set{ _FANAM = value;}}
		System.String _ICNUM = string.Empty;
		
		public System.String  ICNUM{get{ return  _ICNUM;}set{ _ICNUM = value;}}
		System.String _GESCH = string.Empty;
		
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.String _ZHRWYSP = string.Empty;
		
		public System.String  ZHRWYSP{get{ return  _ZHRWYSP;}set{ _ZHRWYSP = value;}}
		System.String _NACHN = string.Empty;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.Decimal _ANZKD = ConstLibrary.Template.UndefineDecimal;
		
		public System.Decimal  ANZKD{get{ return  _ANZKD;}set{ _ANZKD = value;}}
		System.String _ZHRBZ = string.Empty;
		
		public System.String  ZHRBZ{get{ return  _ZHRBZ;}set{ _ZHRBZ = value;}}
		System.String _TELNR = string.Empty;
		
		public System.String  TELNR{get{ return  _TELNR;}set{ _TELNR = value;}}
		System.String _FASEX = string.Empty;
		
		public System.String  FASEX{get{ return  _FASEX;}set{ _FASEX = value;}}
		System.String _ZHRJKZK = string.Empty;
		
		public System.String  ZHRJKZK{get{ return  _ZHRJKZK;}set{ _ZHRJKZK = value;}}
		System.String _SECONDCHOICE = string.Empty;
		
		public System.String  SECONDCHOICE{get{ return  _SECONDCHOICE;}set{ _SECONDCHOICE = value;}}
		System.String _PCODE = string.Empty;
		
		public System.String  PCODE{get{ return  _PCODE;}set{ _PCODE = value;}}
		System.String _ZHRGRTZ = string.Empty;
		
		public System.String  ZHRGRTZ{get{ return  _ZHRGRTZ;}set{ _ZHRGRTZ = value;}}
		System.String _LOCAT_XJ = string.Empty;
		
		public System.String  LOCAT_XJ{get{ return  _LOCAT_XJ;}set{ _LOCAT_XJ = value;}}
		System.String _ZHRTZGG = string.Empty;
		
		public System.String  ZHRTZGG{get{ return  _ZHRTZGG;}set{ _ZHRTZGG = value;}}
		System.String _ZHRFZDJ = string.Empty;
		
		public System.String  ZHRFZDJ{get{ return  _ZHRFZDJ;}set{ _ZHRFZDJ = value;}}
		System.String _ZHRJG = string.Empty;
		
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String _RACKY = string.Empty;
		
		public System.String  RACKY{get{ return  _RACKY;}set{ _RACKY = value;}}
		System.String _LOCAT_HJ = string.Empty;
		
		public System.String  LOCAT_HJ{get{ return  _LOCAT_HJ;}set{ _LOCAT_HJ = value;}}
		System.String _ZHRZWJS = string.Empty;
		
		public System.String  ZHRZWJS{get{ return  _ZHRZWJS;}set{ _ZHRZWJS = value;}}

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF")]
	public partial class DisplayObject_HEM_B_STAFF:EntityObject_HEM_B_STAFF
	{
		#region Attribute Block
		
			//平台自动生成代码

		#endregion 
	}
	[Serializable]
	
	[DataObject("HEM_B_STAFF")]
	public partial class EntityObject_HEM_B_STAFF:EntityBase
	{
		#region Attribute Block
		
			//平台自动生成代码
		System.String  _FIRSTCHOICE;
		
		public System.String  FIRSTCHOICE{get{ return  _FIRSTCHOICE;}set{ _FIRSTCHOICE = value;}}
		System.String  _ZHRTC;
		
		public System.String  ZHRTC{get{ return  _ZHRTC;}set{ _ZHRTC = value;}}
		System.String  _ZHRYRXX;
		
		public System.String  ZHRYRXX{get{ return  _ZHRYRXX;}set{ _ZHRYRXX = value;}}
		System.String  _USRID_MAIL;
		
		public System.String  USRID_MAIL{get{ return  _USRID_MAIL;}set{ _USRID_MAIL = value;}}
		System.DateTime  _GBDAT;
		
		public System.DateTime  GBDAT{get{ return  _GBDAT;}set{ _GBDAT = value;}}
		System.String  _LOCAT_JT;
		
		public System.String  LOCAT_JT{get{ return  _LOCAT_JT;}set{ _LOCAT_JT = value;}}
		System.String  _USER_ID;
		
		public System.String  USER_ID{get{ return  _USER_ID;}set{ _USER_ID = value;}}
		System.String  _ZHRGRSG;
		
		public System.String  ZHRGRSG{get{ return  _ZHRGRSG;}set{ _ZHRGRSG = value;}}
		System.String  _ID;
		
		public System.String  ID{get{ return  _ID;}set{ _ID = value;}}
		System.String  _FAMST;
		
		public System.String  FAMST{get{ return  _FAMST;}set{ _FAMST = value;}}
		System.String  _ZHRHJJL;
		
		public System.String  ZHRHJJL{get{ return  _ZHRHJJL;}set{ _ZHRHJJL = value;}}
		System.String  _ZHRSXXX;
		
		public System.String  ZHRSXXX{get{ return  _ZHRSXXX;}set{ _ZHRSXXX = value;}}
        System.String _YJSSXXX;

        public System.String YJSSXXX { get { return _YJSSXXX; } set { _YJSSXXX = value; } }
		System.String  _ZHRSLJZ;
		
		public System.String  ZHRSLJZ{get{ return  _ZHRSLJZ;}set{ _ZHRSLJZ = value;}}
		System.String  _USRID_TEL;
		
		public System.String  USRID_TEL{get{ return  _USRID_TEL;}set{ _USRID_TEL = value;}}
		System.String  _ZHRJSJSP;
		
		public System.String  ZHRJSJSP{get{ return  _ZHRJSJSP;}set{ _ZHRJSJSP = value;}}
		System.String  _ZHRWYFS;
		
		public System.String  ZHRWYFS{get{ return  _ZHRWYFS;}set{ _ZHRWYFS = value;}}
		System.String  _ZHRGZNX;
		
		public System.String  ZHRGZNX{get{ return  _ZHRGZNX;}set{ _ZHRGZNX = value;}}
		System.DateTime  _FGBDT;
		
		public System.DateTime  FGBDT{get{ return  _FGBDT;}set{ _FGBDT = value;}}
		System.String  _FANAM;
		
		public System.String  FANAM{get{ return  _FANAM;}set{ _FANAM = value;}}
		System.String  _ICNUM;
		
		public System.String  ICNUM{get{ return  _ICNUM;}set{ _ICNUM = value;}}
		System.String  _GESCH;
		
		public System.String  GESCH{get{ return  _GESCH;}set{ _GESCH = value;}}
		System.String  _ZHRWYSP;
		
		public System.String  ZHRWYSP{get{ return  _ZHRWYSP;}set{ _ZHRWYSP = value;}}
		System.String  _NACHN;
		
		public System.String  NACHN{get{ return  _NACHN;}set{ _NACHN = value;}}
		System.Decimal  _ANZKD;
		
		public System.Decimal  ANZKD{get{ return  _ANZKD;}set{ _ANZKD = value;}}
		System.String  _ZHRBZ;
		
		public System.String  ZHRBZ{get{ return  _ZHRBZ;}set{ _ZHRBZ = value;}}
		System.String  _TELNR;
		
		public System.String  TELNR{get{ return  _TELNR;}set{ _TELNR = value;}}
		System.String  _FASEX;
		
		public System.String  FASEX{get{ return  _FASEX;}set{ _FASEX = value;}}
		System.String  _ZHRJKZK;
		
		public System.String  ZHRJKZK{get{ return  _ZHRJKZK;}set{ _ZHRJKZK = value;}}
		System.String  _SECONDCHOICE;
		
		public System.String  SECONDCHOICE{get{ return  _SECONDCHOICE;}set{ _SECONDCHOICE = value;}}
		System.String  _PCODE;
		
		public System.String  PCODE{get{ return  _PCODE;}set{ _PCODE = value;}}
		System.String  _ZHRGRTZ;
		
		public System.String  ZHRGRTZ{get{ return  _ZHRGRTZ;}set{ _ZHRGRTZ = value;}}
		System.String  _LOCAT_XJ;
		
		public System.String  LOCAT_XJ{get{ return  _LOCAT_XJ;}set{ _LOCAT_XJ = value;}}
		System.String  _ZHRTZGG;
		
		public System.String  ZHRTZGG{get{ return  _ZHRTZGG;}set{ _ZHRTZGG = value;}}
		System.String  _ZHRFZDJ;
		
		public System.String  ZHRFZDJ{get{ return  _ZHRFZDJ;}set{ _ZHRFZDJ = value;}}
		System.String  _ZHRJG;
		
		public System.String  ZHRJG{get{ return  _ZHRJG;}set{ _ZHRJG = value;}}
		System.String  _RACKY;
		
		public System.String  RACKY{get{ return  _RACKY;}set{ _RACKY = value;}}
		System.String  _LOCAT_HJ;
		
		public System.String  LOCAT_HJ{get{ return  _LOCAT_HJ;}set{ _LOCAT_HJ = value;}}
		System.String  _ZHRZWJS;
		
		public System.String  ZHRZWJS{get{ return  _ZHRZWJS;}set{ _ZHRZWJS = value;}}

		System.String _SCHOOLINFO;

		public System.String SCHOOLINFO { get { return _SCHOOLINFO; } set { _SCHOOLINFO = value; } }

		System.String _JWBS;

		public System.String JWBS { get { return _JWBS; } set { _JWBS = value; } }

		System.Decimal _IS_STANDARD;

        public System.Decimal IS_STANDARD { get { return _IS_STANDARD; } set { _IS_STANDARD = value; } }

        System.Decimal _IS_SZHY;
        public System.Decimal IS_SZHY { get { return _IS_SZHY; } set { _IS_SZHY = value; } }
        #endregion
    }	
}
