using System;
using System.Collections.Generic;
using System.Text;
using Umrah.Data.SqlServer;

namespace Umrah.Code.Helper
{
    public static class ConfigurationObjectManager
    {
        private static Dictionary<string, object> ObjectList = new Dictionary<string, object>();

        public static void Register(string ObjectName, object ObjectValue)
        {
            ObjectList.Add(ObjectName, ObjectValue);
        }

        public static object GetObject(string ObjectName)
        {
            return ObjectList[ObjectName];
        }
    }
}
