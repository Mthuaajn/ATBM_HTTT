using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManagement;

namespace DAO
{
    public class LoginDAO
    {
        Modify modify = new Modify();
        public OracleConnection GetAppConnection(string username, string password, string role)
        {
            if (role == "SYSDBA")
                return new OracleConnection($@"DATA SOURCE=localhost:1521/XEPDB1;DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\Admin\Oracle\network\admin;PASSWORD={password};PERSIST SECURITY INFO=True;USER ID={username}");
            //string newStringConnection = $@"DATA SOURCE = localhost:1521/XEPDB1; USER ID={username} ;PASSWORD={password}";

            string newStringConnection = $@"DATA SOURCE=localhost:1521/XEPDB1;TNS_ADMIN=C:\Users\Admin\Oracle\network\admin;PASSWORD={password};PERSIST SECURITY INFO=True;USER ID={username}";
            return new OracleConnection(newStringConnection);
        }
    }
}
