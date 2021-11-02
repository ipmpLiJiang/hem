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
    public class BizLogicObject_V_HEM_B_USER_STAFF : ServiceContract_V_HEM_B_USER_STAFF
    {
        public BizLogicObject_V_HEM_B_USER_STAFF() { }

        private static ServiceContract_V_HEM_B_USER_STAFF singleton;
        public static ServiceContract_V_HEM_B_USER_STAFF Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_B_USER_STAFF();
                return singleton;
            }
        }

        public DisplayObject_V_HEM_B_USER_STAFF[] Query(CauseObject_V_HEM_B_USER_STAFF cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_B_USER_STAFF.Query(cause, paging, order);
        }

        public DisplayObject_V_HEM_B_USER_STAFF[] Query(CauseObject_V_HEM_B_USER_STAFF cause)
        {
            return HelperObject_V_HEM_B_USER_STAFF.Query(cause);
        }
    }
}
