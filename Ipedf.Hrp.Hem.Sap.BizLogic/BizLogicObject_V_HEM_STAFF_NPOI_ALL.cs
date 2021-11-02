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
    public class BizLogicObject_V_HEM_STAFF_NPOI_ALL : ServiceContract_V_HEM_STAFF_NPOI_ALL
    {
        public BizLogicObject_V_HEM_STAFF_NPOI_ALL() { }

        private static ServiceContract_V_HEM_STAFF_NPOI_ALL singleton;
        public static ServiceContract_V_HEM_STAFF_NPOI_ALL Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_STAFF_NPOI_ALL();
                return singleton;
            }
        }

        public DisplayObject_V_HEM_STAFF_NPOI_ALL[] Query(CauseObject_V_HEM_STAFF_NPOI_ALL cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_STAFF_NPOI_ALL.Query(cause, paging, order);
        }

        public DisplayObject_V_HEM_STAFF_NPOI_ALL[] Query(CauseObject_V_HEM_STAFF_NPOI_ALL cause)
        {
            return HelperObject_V_HEM_STAFF_NPOI_ALL.Query(cause);
        }
        
    }
}
