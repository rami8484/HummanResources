using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamiProj
{
    public class DatabaseRolesList
    {
        public IList<string> list;
        public DatabaseRolesList()
        {
            list = new List<string>();
            list.Add("db_owner");
            list.Add("db_accessadmin");
            list.Add("db_datareader");
            list.Add("db_datawriter");
            list.Add("db_ddladmin");
            list.Add("db_backupoperator");
            list.Add("db_denydatareader");
            list.Add("db_denydatawriter");
        }
    }
}
