using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PrivilegesDAO
    {
        Modify modify = new Modify();

        public DataTable LoadAllUsersInTabLevel()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT U.USERNAME, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_USERS U LEFT JOIN DBA_TAB_PRIVS P ON U.USERNAME = P.GRANTEE";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable LoadAllUsersInColLevel()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT U.USERNAME, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_USERS U LEFT JOIN DBA_COL_PRIVS P ON U.USERNAME = P.GRANTEE";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable LoadAllRolesInTabLevel()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT R.ROLE, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_ROLES R LEFT JOIN DBA_TAB_PRIVS P ON R.ROLE = P.GRANTEE";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable LoadAllRolesInColLevel()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT R.ROLE, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_ROLES R LEFT JOIN DBA_COL_PRIVS P ON R.ROLE = P.GRANTEE";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable FilterUsersInTabLevel(string userName)
        { 
            DataTable dataTable = new DataTable();
            string query = "SELECT U.USERNAME, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_USERS U LEFT JOIN DBA_TAB_PRIVS P ON U.USERNAME = P.GRANTEE " +
                                                        "WHERE U.USERNAME = '" + userName + "'";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable FilterUsersInColLevel(string userName)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT U.USERNAME, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_USERS U LEFT JOIN DBA_COL_PRIVS P ON U.USERNAME = P.GRANTEE " +
                                                        "WHERE U.USERNAME = '" + userName + "'";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable FilterRolesInTabLevel(string role)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT R.ROLE, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_ROLES R LEFT JOIN DBA_TAB_PRIVS P ON R.ROLE = P.GRANTEE " +
                                                        "WHERE R.ROLE = '" + role + "'";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public DataTable FilterRolesInColLevel(string role)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT R.ROLE, " +
                                                        "COALESCE(P.TABLE_NAME, 'N/A') AS TABLE_NAME, " +
                                                        "COALESCE(P.COLUMN_NAME, 'N/A') AS COLUMN_NAME, " +
                                                        "COALESCE(P.GRANTOR, 'N/A') AS GRANTOR, " +
                                                        "COALESCE(P.PRIVILEGE, 'N/A') AS PRIVILEGE, " +
                                                        "COALESCE(P.GRANTABLE, 'N/A') AS GRANTABLE " +
                                                        "FROM DBA_ROLES R LEFT JOIN DBA_COL_PRIVS P ON R.ROLE = P.GRANTEE " +
                                                        "WHERE R.ROLE = '" + role + "'";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }
    }
}
