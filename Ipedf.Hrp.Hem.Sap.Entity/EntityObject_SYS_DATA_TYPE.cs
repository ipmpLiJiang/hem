using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;

namespace Ipedf.Hrp.Hem.Sap.Entity
{
    [Serializable]
    
    [DataObject("SYS_DATA_TYPE")]
    public partial class CauseObject_SYS_DATA_TYPE : CauseBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.Decimal _IS_USABL = ConstLibrary.Template.UndefineDecimal;
        
        public System.Decimal IS_USABL { get { return _IS_USABL; } set { _IS_USABL = value; } }
        System.String _PARENT_ID = string.Empty;
        
        public System.String PARENT_ID { get { return _PARENT_ID; } set { _PARENT_ID = value; } }
        System.String _NAME = string.Empty;
        
        public System.String NAME { get { return _NAME; } set { _NAME = value; } }
        System.String _ID = string.Empty;
        
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.String _CODE = string.Empty;
        
        public System.String CODE { get { return _CODE; } set { _CODE = value; } }

        #endregion
    }
    [Serializable]
    
    [DataObject("SYS_DATA_TYPE")]
    public partial class DisplayObject_SYS_DATA_TYPE : EntityObject_SYS_DATA_TYPE
    {
        #region Attribute Block

        //平台自动生成代码

        #endregion
    }
    [Serializable]
    
    [DataObject("SYS_DATA_TYPE")]
    public partial class EntityObject_SYS_DATA_TYPE : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.Decimal _IS_USABL;
        
        public System.Decimal IS_USABL { get { return _IS_USABL; } set { _IS_USABL = value; } }
        System.String _PARENT_ID;
        
        public System.String PARENT_ID { get { return _PARENT_ID; } set { _PARENT_ID = value; } }
        System.String _NAME;
        
        public System.String NAME { get { return _NAME; } set { _NAME = value; } }
        System.String _ID;
        
        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.String _CODE;
        
        public System.String CODE { get { return _CODE; } set { _CODE = value; } }

        #endregion
    }	
}
