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
    public class BizLogicObject_V_USER_LOGIN_INFO : ServiceContract_V_USER_LOGIN_INFO
    {
        public BizLogicObject_V_USER_LOGIN_INFO() { }

        private static ServiceContract_V_USER_LOGIN_INFO singleton;
        public static ServiceContract_V_USER_LOGIN_INFO Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_V_USER_LOGIN_INFO();
                    return singleton;
            }
        }

        public DisplayObject_V_USER_LOGIN_INFO Login(CauseObject_V_USER_LOGIN_INFO cause)
        {
            return HelperObject_V_USER_LOGIN_INFO.Login(cause);
        }

        public DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause)
        {
            return HelperObject_V_USER_LOGIN_INFO.Query(cause);
        }

        public DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_USER_LOGIN_INFO.Query(cause,paging,order);
        }
    }
}
