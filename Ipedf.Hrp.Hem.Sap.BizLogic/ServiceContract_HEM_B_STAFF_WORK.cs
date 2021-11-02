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
    public interface ServiceContract_HEM_B_STAFF_WORK
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_WORK obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_WORK obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_WORK[] itemObj);

        DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause);

        DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_WORK Get(EntityObject_HEM_B_STAFF_WORK entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_WORK obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_WORK[] itemObj);
    }
}

