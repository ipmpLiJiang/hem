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
    public interface ServiceContract_HEM_B_STAFF
    {
        BizLogicMsg StaffSubmitOrCheck(string UserID, decimal IsNurse);

        BizLogicMsg StaffSubmitOrCheckNoMessage(string UserID, decimal IsNurse);

        BizLogicMsg Save(EntityObject_HEM_B_STAFF obj);

        BizLogicMsg Save(EntityObject_HEM_B_STAFF obj, EntityObject_HEM_B_STAFF_TYPE objNurse);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF obj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF[] itemObj);

        BizLogicMsg Update(EntityObject_HEM_B_STAFF obj, EntityObject_HEM_B_STAFF_TYPE entityNurse);

        DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause, PagingParamter paging, OrderByParameter order);

        DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause);

        EntityObject_HEM_B_STAFF Get(EntityObject_HEM_B_STAFF entity);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF obj);

        BizLogicMsg Delete(EntityObject_HEM_B_STAFF[] itemObj);

        DataTable GetHem_Staff_Gather(string staff_type_ids);

        HEM_B_STAFF_HEADER[] GetHem_Header_Gather();

        DataTable GetHem_Staff_Nyn_Gather(string staff_type_ids);

        HEM_B_STAFF_HEADER[] GetHem_Nyn_Header_Gather();

        DataTable GetHem_Staff_Nyw_Gather(string staff_type_ids);

        HEM_B_STAFF_HEADER[] GetHem_Nyw_Header_Gather();

        DataTable GetHem_Staff_Nwj_Gather(string staff_type_ids);

        HEM_B_STAFF_HEADER[] GetHem_Nwj_Header_Gather();

        DataTable GetHem_Staff_Nyj_Gather(string staff_type_ids);

        HEM_B_STAFF_HEADER[] GetHem_Nyj_Header_Gather();
    }
}
