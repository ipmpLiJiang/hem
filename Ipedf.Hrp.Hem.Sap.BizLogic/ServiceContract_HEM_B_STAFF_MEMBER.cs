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
    public interface ServiceContract_HEM_B_STAFF_MEMBER
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_MEMBER obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_MEMBER obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_MEMBER[] itemObj);

        DisplayObject_HEM_B_STAFF_MEMBER[] Query(CauseObject_HEM_B_STAFF_MEMBER cause);

        DisplayObject_HEM_B_STAFF_MEMBER[] Query(CauseObject_HEM_B_STAFF_MEMBER cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_MEMBER Get(EntityObject_HEM_B_STAFF_MEMBER entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_MEMBER obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_MEMBER[] itemObj);
    }
}

