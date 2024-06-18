using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManagement;

namespace DAO
{
    public class SystemUsersDAO
    {
        Modify modify = new Modify();
        public DataTable GetAllSystemUsers()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT U.USERNAME, " +
                                                            "COALESCE(DRP.GRANTED_ROLE, 'N/A') AS GRANTED_ROLE, " +
                                                            "COALESCE(DRP.ADMIN_OPTION, 'N/A') AS ADMIN_OPTION, " +
                                                            "COALESCE(DRP.DEFAULT_ROLE, 'N/A') AS DEFAULT_ROLE, " +
                                                            "COALESCE(DRP.INHERITED, 'N/A') AS INHERITED " +
                                                    "FROM  DBA_USERS U " +
                                                    "LEFT JOIN DBA_ROLE_PRIVS DRP ON  U.USERNAME = DRP.GRANTEE";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable FilterSystemUsers(string userName)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT U.USERNAME, " +
                                                            "COALESCE(DRP.GRANTED_ROLE, 'N/A') AS GRANTED_ROLE, " +
                                                            "COALESCE(DRP.ADMIN_OPTION, 'N/A') AS ADMIN_OPTION, " +
                                                            "COALESCE(DRP.DEFAULT_ROLE, 'N/A') AS DEFAULT_ROLE, " +
                                                            "COALESCE(DRP.INHERITED, 'N/A') AS INHERITED " +
                                                    "FROM  DBA_USERS U " +
                                                    "LEFT JOIN DBA_ROLE_PRIVS DRP ON  U.USERNAME = DRP.GRANTEE " +
                                                    "WHERE UPPER(U.USERNAME) LIKE '%" + userName + "%' ";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }
    }
}
