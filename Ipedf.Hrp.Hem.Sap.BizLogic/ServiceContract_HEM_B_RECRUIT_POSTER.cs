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
    public interface ServiceContract_HEM_B_RECRUIT_POSTER
    {
        BizLogicMsg Save(EntityObject_HEM_B_RECRUIT_POSTER obj);

        BizLogicMsg Update(EntityObject_HEM_B_RECRUIT_POSTER obj);

        BizLogicMsg Update(EntityObject_HEM_B_RECRUIT_POSTER[] itemObj);

        DisplayObject_HEM_B_RECRUIT_POSTER[] Query(CauseObject_HEM_B_RECRUIT_POSTER cause, PagingParamter paging, OrderByParameter order);

        DisplayObject_HEM_B_RECRUIT_POSTER[] Query(CauseObject_HEM_B_RECRUIT_POSTER cause);

        EntityObject_HEM_B_RECRUIT_POSTER Get(EntityObject_HEM_B_RECRUIT_POSTER entity);

        BizLogicMsg Delete(EntityObject_HEM_B_RECRUIT_POSTER obj);

        BizLogicMsg Delete(EntityObject_HEM_B_RECRUIT_POSTER[] itemObj);

        BizLogicMsg Copy(EntityObject_HEM_B_RECRUIT_POSTER obj);
    }
}
