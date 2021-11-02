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
    public class BizLogicObject_V_HEM_B_RECRUIT_POSTER : ServiceContract_V_HEM_B_RECRUIT_POSTER
    {
        public BizLogicObject_V_HEM_B_RECRUIT_POSTER() { }

        private static ServiceContract_V_HEM_B_RECRUIT_POSTER singleton;
        public static ServiceContract_V_HEM_B_RECRUIT_POSTER Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_B_RECRUIT_POSTER();
                return singleton;
            }
        }

        public DisplayObject_V_HEM_B_RECRUIT_POSTER[] Query(CauseObject_V_HEM_B_RECRUIT_POSTER cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_B_RECRUIT_POSTER.Query(cause, paging, order);
        }

        public DisplayObject_V_HEM_B_RECRUIT_POSTER[] Query(CauseObject_V_HEM_B_RECRUIT_POSTER cause)
        {
            return HelperObject_V_HEM_B_RECRUIT_POSTER.Query(cause);
        }
    }
}
