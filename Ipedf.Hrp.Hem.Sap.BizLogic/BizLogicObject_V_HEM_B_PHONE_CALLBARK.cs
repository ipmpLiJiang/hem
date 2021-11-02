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
using System.Management;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public class BizLogicObject_V_HEM_B_PHONE_CALLBARK : ServiceContract_V_HEM_B_PHONE_CALLBARK
    {
        public BizLogicObject_V_HEM_B_PHONE_CALLBARK() { }

        private static ServiceContract_V_HEM_B_PHONE_CALLBARK singleton;
        public static ServiceContract_V_HEM_B_PHONE_CALLBARK Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_B_PHONE_CALLBARK();
                    return singleton;
            }
        }

        public DisplayObject_V_HEM_B_PHONE_CALLBARK[] Query(CauseObject_V_HEM_B_PHONE_CALLBARK cause)
        {
            return HelperObject_V_HEM_B_PHONE_CALLBARK.Query(cause);
        }

        public DisplayObject_V_HEM_B_PHONE_CALLBARK[] Query(CauseObject_V_HEM_B_PHONE_CALLBARK cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_B_PHONE_CALLBARK.Query(cause,paging,order);
        }
    }
}
