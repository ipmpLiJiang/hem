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
    public interface ServiceContract_HEM_B_USER
    {
        DisplayObject_HEM_B_USER[] Query(CauseObject_HEM_B_USER cause);

        DisplayObject_HEM_B_USER[] Query(CauseObject_HEM_B_USER cause, PagingParamter paging, OrderByParameter order);

        BizLogicMsg Save(EntityObject_HEM_B_USER obj);

        BizLogicMsg Update(EntityObject_HEM_B_USER obj);

        BizLogicMsg Update(EntityObject_HEM_B_USER obj, EntityObject_HEM_B_USER_LOGIN objlogin);


    }
}

