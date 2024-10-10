using Umrah.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Umrah.Code.Helper
{
    public static class DependencyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigurationObjectManager.Register("Buses", new BusesEntity());
            ConfigurationObjectManager.Register("SystemRecords", new SystemRecordsEntity());
            ConfigurationObjectManager.Register("Users", new UsersEntity());
            ConfigurationObjectManager.Register("UsersRoles", new UsersRolesEntity());
            ConfigurationObjectManager.Register("Customers", new CustomersEntity());
        }
    }
}
