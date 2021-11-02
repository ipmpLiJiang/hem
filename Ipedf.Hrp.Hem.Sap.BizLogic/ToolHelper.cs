using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public class ToolHelper
    {
        public static PropertyInfo[] GetPropertyInfoArray<T>(T t)
        {
            PropertyInfo[] props = null;
            try
            {
                props = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            }
            catch (Exception ex)
            { }
            return props;
        }

        public static string[] GetPropertyColumnsArray(object obj)
        {
            string[] arrStr = null;

            PropertyInfo[] a = GetPropertyInfoArray(obj);
            if (a.Length > 0)
            {
                arrStr = new string[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    arrStr[i] = a[i].Name;
                }
            }
            return arrStr;
        }
    }
}
