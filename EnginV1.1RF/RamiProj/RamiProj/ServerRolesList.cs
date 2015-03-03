using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamiProj
{
    public class ServerRolesList
    {
        public IList<string> list;
        public ServerRolesList()
        {
            list = new List<string>();
            list.Add("sysadmin");
            list.Add("serveradmin");
            list.Add("setupadmin");
            list.Add("securityadmin");
            list.Add("processadmin");
            list.Add("dbcreator");
            list.Add("diskadmin");
        }
    }
}
