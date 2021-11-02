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
    public class BizLogicObject_V_HEM_B_STAFF_EXT : ServiceContract_V_HEM_B_STAFF_EXT
    {
        public BizLogicObject_V_HEM_B_STAFF_EXT() { }

        private static ServiceContract_V_HEM_B_STAFF_EXT singleton;
        public static ServiceContract_V_HEM_B_STAFF_EXT Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_B_STAFF_EXT();
                return singleton;
            }
        }

        public DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_B_STAFF_EXT.Query(cause, paging, order);
        }

        public DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause)
        {
            return HelperObject_V_HEM_B_STAFF_EXT.Query(cause);
        }
    }
}
