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
    
    [DataObject("HEM_B_USER")]
    public partial class CauseObject_HEM_B_USER : CauseBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _MOBILE = string.Empty;
        
        public System.String MOBILE { get { return _MOBILE; } set { _MOBILE = value; } }
        System.String _NAME = string.Empty;
        
        public System.String NAME { get { return _NAME; } set { _NAME = value; } }
        System.String _ID = string.Empty;
        
        public System.String ID { get { return _ID; } set { _ID = value; } }
        DateSpan _CREATE_DATE = null;
        
        public DateSpan CREATE_DATE { get { return _CREATE_DATE; } set { _CREATE_DATE = value; } }
        System.String _USER_LOGIN_ID = string.Empty;
        
        public System.String USER_LOGIN_ID { get { return _USER_LOGIN_ID; } set { _USER_LOGIN_ID = value; } }
        System.String _EMAIL = string.Empty;
        
        public System.String EMAIL { get { return _EMAIL; } set { _EMAIL = value; } }

        #endregion
    }
    [Serializable]
    
    [DataObject("HEM_B_USER")]
    public partial class DisplayObject_HEM_B_USER : EntityObject_HEM_B_USER
    {
        #region Attribute Block

        //平台自动生成代码

        #endregion
    }
    [Serializable]
    
    [DataObject("HEM_B_USER")]
    public partial class EntityObject_HEM_B_USER : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _MOBILE;
        
        public System.String MOBILE { get { return _MOBILE; } set { _MOBILE = value; } }
        System.String _NAME;
        
        public System.String NAME { get { return _NAME; } set { _NAME = value; } }
        System.String _ID;
        
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.DateTime _CREATE_DATE;
        
        public System.DateTime CREATE_DATE { get { return _CREATE_DATE; } set { _CREATE_DATE = value; } }
        System.String _USER_LOGIN_ID;
        
        public System.String USER_LOGIN_ID { get { return _USER_LOGIN_ID; } set { _USER_LOGIN_ID = value; } }
        System.String _EMAIL;
        
        public System.String EMAIL { get { return _EMAIL; } set { _EMAIL = value; } }
        System.Decimal? _OUTOCEAN;

        public System.Decimal? OUTOCEAN { get { return _OUTOCEAN; } set { _OUTOCEAN = value; } }

        #endregion
    }	
}
