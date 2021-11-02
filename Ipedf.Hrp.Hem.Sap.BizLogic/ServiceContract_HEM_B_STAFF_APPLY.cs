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
    public interface ServiceContract_HEM_B_STAFF_APPLY
    {
        BizLogicMsg Recruit_Apply(EntityObject_HEM_B_STAFF_APPLY obj, EntityObject_V_USER_LOGIN_INFO ULI, decimal IS_NURSE);

        BizLogicMsg Save(EntityObject_HEM_B_STAFF_APPLY obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_APPLY obj);

        BizLogicMsg UpdateState(EntityObject_HEM_B_STAFF_APPLY obj);

        BizLogicMsg Update(CauseObject_V_HEM_B_STAFF_APPLY cause, decimal STATUS);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_APPLY[] itemObj);

        DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause, PagingParamter paging, OrderByParameter order);

        DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause);

        EntityObject_HEM_B_STAFF_APPLY Get(EntityObject_HEM_B_STAFF_APPLY entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_APPLY obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_APPLY[] itemObj);

    }
}
