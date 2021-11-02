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
    public interface ServiceContract_HEM_B_STAFF_EDUCATION
    {
        BizLogicMsg Save(EntityObject_HEM_B_STAFF_EDUCATION obj, EntityObject_HEM_B_STAFF entityStaff, decimal IS_NURSE);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_EDUCATION obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF_EDUCATION[] itemObj);

        DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause);

        DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause, PagingParamter paging, OrderByParameter order);

        EntityObject_HEM_B_STAFF_EDUCATION Get(EntityObject_HEM_B_STAFF_EDUCATION entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_EDUCATION obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF_EDUCATION[] itemObj);


    }
}
