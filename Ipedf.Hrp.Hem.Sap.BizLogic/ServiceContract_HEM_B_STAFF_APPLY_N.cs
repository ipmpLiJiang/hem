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
    public interface ServiceContract_HEM_B_STAFF_APPLY_N
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_APPLY_N obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_APPLY_N obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_APPLY_N[] itemObj);

        DisplayObject_HEM_B_STAFF_APPLY_N[] Query(CauseObject_HEM_B_STAFF_APPLY_N cause, PagingParamter paging, OrderByParameter order);

        DisplayObject_HEM_B_STAFF_APPLY_N[] Query(CauseObject_HEM_B_STAFF_APPLY_N cause);

        EntityObject_HEM_B_STAFF_APPLY_N Get(EntityObject_HEM_B_STAFF_APPLY_N entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_APPLY_N obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_APPLY_N[] itemObj);
    }
}
