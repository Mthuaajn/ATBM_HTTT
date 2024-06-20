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

        public DataTable LoadTables()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT object_name " +
                           "FROM user_objects " +
                           "WHERE object_type = 'TABLE' AND created >= TO_DATE('2024-04-01', 'YYYY-MM-DD')";
            // Cai ngay nay de t loc may tables he thong thoi chu khong co gi :Đ
            dataTable = modify.LoadTable(query);
            return dataTable ;
        }

        public DataTable LoadColumnsOfTable(string table)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT COLUMN_NAME " +
                           "FROM ALL_TAB_COLUMNS " +
                           $"WHERE TABLE_NAME = '{table}'";
            dataTable = modify.LoadTable(query);
            return dataTable;
        }

        public void GrantUser(string privilege, string table, string user)
        {
            string query = $"GRANT {privilege} ON {table} TO {user}";
            modify.ExecuteQuery(query);
        }
        public void GrantUserWithGrantOption(string privilege, string table, string user)
        {
            string query = $"GRANT {privilege} ON {table} TO {user} WITH GRANT OPTION";
            modify.ExecuteQuery(query);
        }
        public void GrantUserToColLevel(string privilege, string column, string table, string user)
        {
            string query = $"GRANT {privilege}({column}) ON {table} TO {user}";
            modify.ExecuteQuery(query);
        }

        public void GrantUserToColLevelWithGrantOption(string privilege, string column, string table, string user)
        {
            string query = $"GRANT {privilege}({column}) ON {table} TO {user} WITH GRANT OPTION";
            modify.ExecuteQuery(query);
        }

        public void GrantUserSelectToColLevel(string column, string table, string user)
        {
            // Tao cai view select cot
            string query = $"CREATE VIEW {table}_{column}_VIEW AS " +
                            $"SELECT {column} " +
                            $"FROM {table}";
            modify.ExecuteQuery(query);

            // grant select tren view do cho user
            query = $"GRANT SELECT ON {table}_{column}_VIEW TO {user}";
            modify.ExecuteQuery(query);
        }
        public void GrantUserSelectToColLevelWithGrantOption(string column, string table, string user)
        {
            // Tao cai view select cot
            string query = $"CREATE VIEW {table}_{column}_VIEW AS " +
                            $"SELECT {column} " +
                            $"FROM {table}";
            modify.ExecuteQuery(query);

            // grant select tren view do cho user with grant option
            query = $"GRANT SELECT ON {table}_{column}_VIEW TO {user} WITH GRANT OPTION";
            modify.ExecuteQuery(query);
        }
    }
}
