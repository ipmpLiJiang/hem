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

    [DataObject("HEM_B_STAFF_EDUCATION")]
    public partial class CauseObject_HEM_B_STAFF_EDUCATION : CauseBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _SLART = string.Empty;

        public System.String SLART { get { return _SLART; } set { _SLART = value; } }
        System.String _ID = string.Empty;

        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.String _TYPE_ID = string.Empty;

        public System.String TYPE_ID { get { return _TYPE_ID; } set { _TYPE_ID = value; } }
        System.String _STAFF_ID = string.Empty;

        public System.String STAFF_ID { get { return _STAFF_ID; } set { _STAFF_ID = value; } }
        System.Decimal _IS_HIGHEST = ConstLibrary.Template.UndefineDecimal;

        public System.Decimal IS_HIGHEST { get { return _IS_HIGHEST; } set { _IS_HIGHEST = value; } }
        System.String _ZHRXYJFX = string.Empty;

        public System.String ZHRXYJFX { get { return _ZHRXYJFX; } set { _ZHRXYJFX = value; } }
        System.String _ZHRXKZY2 = string.Empty;

        public System.String ZHRXKZY2 { get { return _ZHRXKZY2; } set { _ZHRXKZY2 = value; } }
        DateSpan _ENDDA = null;

        public DateSpan ENDDA { get { return _ENDDA; } set { _ENDDA = value; } }
        System.String _ZHRXKZY1 = string.Empty;

        public System.String ZHRXKZY1 { get { return _ZHRXKZY1; } set { _ZHRXKZY1 = value; } }
        DateSpan _BEGDA = null;

        public DateSpan BEGDA { get { return _BEGDA; } set { _BEGDA = value; } }
        System.String _INSTI = string.Empty;

        public System.String INSTI { get { return _INSTI; } set { _INSTI = value; } }
        System.String _ZHRDSXM = string.Empty;

        public System.String ZHRDSXM { get { return _ZHRDSXM; } set { _ZHRDSXM = value; } }

        #endregion
    }
    [Serializable]

    [DataObject("HEM_B_STAFF_EDUCATION")]
    public partial class DisplayObject_HEM_B_STAFF_EDUCATION : EntityObject_HEM_B_STAFF_EDUCATION
    {
        #region Attribute Block

        //平台自动生成代码

        #endregion
    }
    [Serializable]

    [DataObject("HEM_B_STAFF_EDUCATION")]
    public partial class EntityObject_HEM_B_STAFF_EDUCATION : EntityBase
    {
        #region Attribute Block

        //平台自动生成代码
        System.String _SLART;

        public System.String SLART { get { return _SLART; } set { _SLART = value; } }
        System.String _ID;

        public System.String ID { get { return _ID; } set { _ID = value; } }
        System.String _TYPE_ID;

        public System.String TYPE_ID { get { return _TYPE_ID; } set { _TYPE_ID = value; } }
        System.String _STAFF_ID;

        public System.String STAFF_ID { get { return _STAFF_ID; } set { _STAFF_ID = value; } }
        System.Decimal _IS_HIGHEST;

        public System.Decimal IS_HIGHEST { get { return _IS_HIGHEST; } set { _IS_HIGHEST = value; } }
        System.String _ZHRXYJFX;

        public System.String ZHRXYJFX { get { return _ZHRXYJFX; } set { _ZHRXYJFX = value; } }
        System.String _ZHRXKZY2;

        public System.String ZHRXKZY2 { get { return _ZHRXKZY2; } set { _ZHRXKZY2 = value; } }
        System.DateTime _ENDDA;

        public System.DateTime ENDDA { get { return _ENDDA; } set { _ENDDA = value; } }
        System.String _ZHRXKZY1;

        public System.String ZHRXKZY1 { get { return _ZHRXKZY1; } set { _ZHRXKZY1 = value; } }
        System.DateTime _BEGDA;

        public System.DateTime BEGDA { get { return _BEGDA; } set { _BEGDA = value; } }
        System.String _INSTI;

        public System.String INSTI { get { return _INSTI; } set { _INSTI = value; } }
        System.String _ZHRDSXM;

        public System.String ZHRDSXM { get { return _ZHRDSXM; } set { _ZHRDSXM = value; } }

        #endregion
    }
}
