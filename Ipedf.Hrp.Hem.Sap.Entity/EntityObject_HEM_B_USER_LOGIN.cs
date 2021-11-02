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
    
    [DataObject("HEM_B_USER_LOGIN")]
    public partial class CauseObject_HEM_B_USER_LOGIN : CauseBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.Decimal _IS_USABL = ConstLibrary.Template.UndefineDecimal;
        
        public System.Decimal IS_USABL { get { return _IS_USABL; } set { _IS_USABL = value; } }
        System.String _ACCOUNT = string.Empty;
        
        public System.String ACCOUNT { get { return _ACCOUNT; } set { _ACCOUNT = value; } }
        System.String _PASSWORD = string.Empty;
        
        public System.String PASSWORD { get { return _PASSWORD; } set { _PASSWORD = value; } }
        System.String _ID = string.Empty;
        
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.Decimal _FLAG = ConstLibrary.Template.UndefineDecimal;
        
        public System.Decimal FLAG { get { return _FLAG; } set { _FLAG = value; } }

        #endregion
    }
    [Serializable]
    
    [DataObject("HEM_B_USER_LOGIN")]
    public partial class DisplayObject_HEM_B_USER_LOGIN : EntityObject_HEM_B_USER_LOGIN
    {
        #region Attribute Block

        //平台自动生成代码

        #endregion
    }
    [Serializable]
    
    [DataObject("HEM_B_USER_LOGIN")]
    public partial class EntityObject_HEM_B_USER_LOGIN : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.Decimal _IS_USABL;
        
        public System.Decimal IS_USABL { get { return _IS_USABL; } set { _IS_USABL = value; } }
        System.String _ACCOUNT;
        
        public System.String ACCOUNT { get { return _ACCOUNT; } set { _ACCOUNT = value; } }
        System.String _PASSWORD;
        
        public System.String PASSWORD { get { return _PASSWORD; } set { _PASSWORD = value; } }
        System.String _ID;
        
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.Decimal _FLAG;
        
        public System.Decimal FLAG { get { return _FLAG; } set { _FLAG = value; } }

        #endregion
    }	
}
