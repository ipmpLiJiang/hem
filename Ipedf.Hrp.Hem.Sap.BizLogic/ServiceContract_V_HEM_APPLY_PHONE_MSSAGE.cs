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
    public interface ServiceContract_V_HEM_APPLY_PHONE_MSSAGE
    {
        DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] Query(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause, PagingParamter paging, OrderByParameter order);

        DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] Query(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause);
    }
}

