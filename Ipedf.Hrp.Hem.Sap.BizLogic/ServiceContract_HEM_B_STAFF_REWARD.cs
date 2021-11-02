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
    public interface ServiceContract_HEM_B_STAFF_REWARD
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_REWARD obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_REWARD obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_REWARD[] itemObj);

        DisplayObject_HEM_B_STAFF_REWARD[] Query(CauseObject_HEM_B_STAFF_REWARD cause);

        DisplayObject_HEM_B_STAFF_REWARD[] Query(CauseObject_HEM_B_STAFF_REWARD cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_REWARD Get(EntityObject_HEM_B_STAFF_REWARD entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_REWARD obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_REWARD[] itemObj);
    }
}

