using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Hrp.Hem.Sap.DataAccess;
using Ipedf.Hrp.Hem.Sap.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public class BizLogicObject_V_HEM_B_STAFF_APPLY : ServiceContract_V_HEM_B_STAFF_APPLY
    {
        public BizLogicObject_V_HEM_B_STAFF_APPLY() { }

        private static ServiceContract_V_HEM_B_STAFF_APPLY singleton;
        public static ServiceContract_V_HEM_B_STAFF_APPLY Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_B_STAFF_APPLY();
                return singleton;
            }
        }

        public DisplayObject_V_HEM_B_STAFF_APPLY[] Query(CauseObject_V_HEM_B_STAFF_APPLY cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_B_STAFF_APPLY.Query(cause, paging, order);
        }

        public DisplayObject_V_HEM_B_STAFF_APPLY[] Query(CauseObject_V_HEM_B_STAFF_APPLY cause)
        {
            return HelperObject_V_HEM_B_STAFF_APPLY.Query(cause);
        }
    }
}
