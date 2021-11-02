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
    public interface ServiceContract_SYS_DATA_TYPE
    {
        BizLogicMsg Save(EntityObject_SYS_DATA_TYPE obj);

        BizLogicMsg Update(EntityObject_SYS_DATA_TYPE obj);

        BizLogicMsg Update(EntityObject_SYS_DATA_TYPE[] itemObj);

        DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause);

        DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause, PagingParamter paging, OrderByParameter order);

        EntityObject_SYS_DATA_TYPE Get(EntityObject_SYS_DATA_TYPE entity);

        BizLogicMsg Delete(EntityObject_SYS_DATA_TYPE obj);

        BizLogicMsg Delete(EntityObject_SYS_DATA_TYPE[] itemObj);


    }
}

