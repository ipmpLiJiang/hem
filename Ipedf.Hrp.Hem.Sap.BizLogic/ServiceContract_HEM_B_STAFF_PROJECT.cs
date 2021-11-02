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
    public interface ServiceContract_HEM_B_STAFF_PROJECT
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_PROJECT obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_PROJECT obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_PROJECT[] itemObj);

        DisplayObject_HEM_B_STAFF_PROJECT[] Query(CauseObject_HEM_B_STAFF_PROJECT cause);

        DisplayObject_HEM_B_STAFF_PROJECT[] Query(CauseObject_HEM_B_STAFF_PROJECT cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_PROJECT Get(EntityObject_HEM_B_STAFF_PROJECT entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_PROJECT obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_PROJECT[] itemObj);
    }
}

