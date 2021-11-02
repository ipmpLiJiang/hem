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
    public interface ServiceContract_HEM_B_STAFF_ESSAY
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_ESSAY obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_ESSAY obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_ESSAY[] itemObj);

        DisplayObject_HEM_B_STAFF_ESSAY[] Query(CauseObject_HEM_B_STAFF_ESSAY cause);

        DisplayObject_HEM_B_STAFF_ESSAY[] Query(CauseObject_HEM_B_STAFF_ESSAY cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_ESSAY Get(EntityObject_HEM_B_STAFF_ESSAY entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_ESSAY obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_ESSAY[] itemObj);
    }
}

