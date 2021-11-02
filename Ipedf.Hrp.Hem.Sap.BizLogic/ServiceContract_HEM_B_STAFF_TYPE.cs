
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
	public partial interface ServiceContract_HEM_B_STAFF_TYPE
	{	
		BizLogicMsg Save(EntityObject_HEM_B_STAFF_TYPE obj);

        BizLogicMsg MyUpdate(EntityObject_HEM_B_STAFF_TYPE[] ayyObj, string ID);

		BizLogicMsg Update(EntityObject_HEM_B_STAFF_TYPE obj);

		BizLogicMsg Delete(EntityObject_HEM_B_STAFF_TYPE obj);

		EntityObject_HEM_B_STAFF_TYPE Get(EntityObject_HEM_B_STAFF_TYPE obj);

		DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause);

        DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause, PagingParamter paging, OrderByParameter order);

	}
}
