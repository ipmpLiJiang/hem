using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Hrp.Hem.Sap.DataAccess;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.BizLogic;

namespace Ipedf.Hrp.Hem.Sap.ServiceContract
{
    public interface ServiceContract_V_USER_LOGIN_INFO
    {
        DisplayObject_V_USER_LOGIN_INFO Login(CauseObject_V_USER_LOGIN_INFO cause);

        DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause);

        DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause, PagingParamter paging, OrderByParameter order);
    }
}

