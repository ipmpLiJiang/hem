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
    public interface ServiceContract_HEM_B_USER_LOGIN
    {
        DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause);

        DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause, PagingParamter paging, OrderByParameter order);

        BizLogicMsg RegisterSave(EntityObject_HEM_B_USER_LOGIN entityLogin, EntityObject_HEM_B_USER entityUser);

        BizLogicMsg RegisterSave(EntityObject_HEM_B_USER_LOGIN entityLogin, EntityObject_HEM_B_USER entityUser, EntityObject_HEM_B_STAFF_APPLY_N entity);

        BizLogicMsg Login(CauseObject_V_USER_LOGIN_INFO cause,ref EntityObject_HEM_B_RECRUIT_POSTER entityRecruitPoster, ref EntityObject_V_USER_LOGIN_INFO loginEntity);

        BizLogicMsg RegisterUpdate(EntityObject_HEM_B_USER_LOGIN entityLogin, EntityObject_HEM_B_USER entityUser, EntityObject_HEM_B_STAFF entityStaff);

        BizLogicMsg Save(EntityObject_HEM_B_USER_LOGIN obj);

        BizLogicMsg Update(EntityObject_HEM_B_USER_LOGIN obj);


    }
}

