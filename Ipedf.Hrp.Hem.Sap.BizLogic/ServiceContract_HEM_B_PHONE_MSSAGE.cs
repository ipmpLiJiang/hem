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
    public interface ServiceContract_HEM_B_PHONE_MSSAGE
    {
        BizLogicMsg Delete(CauseObject_HEM_B_PHONE_MSSAGE cuase);

        BizLogicMsg Delete(EntityObject_HEM_B_PHONE_MSSAGE obj);

        BizLogicMsg Save(EntityObject_HEM_B_PHONE_MSSAGE obj);

        BizLogicMsg CommitUpdate(EntityObject_HEM_B_PHONE_MSSAGE[] saveEntities, EntityObject_HEM_B_PHONE_MSSAGE[] updateEntities);

        BizLogicMsg SaveUpdate(EntityObject_HEM_B_PHONE_MSSAGE obj);

        BizLogicMsg Update(EntityObject_HEM_B_PHONE_MSSAGE obj);

        DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause);

        DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause, PagingParamter paging, OrderByParameter order);

        string SendMessage(string strPhone, string MAC, string content);

        string GetMac();

        BizLogicMsg PhoneMsg(EntityObject_HEM_B_STAFF_APPLY[] itemEntity, string Content);

        BizLogicMsg PhoneMsg(CauseObject_V_HEM_B_STAFF_APPLY cause, string Content);

    }
}
