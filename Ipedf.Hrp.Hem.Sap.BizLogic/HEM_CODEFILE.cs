using System;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public enum APPLY_STATUS : int
    {
        未处理 = 0,
        简历通过 = 1,
        安排面试 = 2,
        已拒绝 = 3,
        已完成 = 4,
        传输成功 = 5
    }

    public enum POSTER_STATUS : int
    {
        未发布 = 0,
        已发布 = 1,
        已过期 = 2
    }

    public enum LOGIN_STATUS : int
    {
        可用 = 0,
        不可用 = 1
    }

    public enum IS_STATUS : int
    {
        是 = 1,
        否 = 2
    }
}