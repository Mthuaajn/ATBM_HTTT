using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivilegesDAO = DAO.PrivilegesDAO;

namespace BUS
{
    public class PrivilegesBUS
    {
        PrivilegesDAO privileges = new PrivilegesDAO();
        public DataTable LoadAllusersInTabLevel() => privileges.LoadAllUsersInTabLevel();

        public DataTable LoadAllusersInColLevel() => privileges.LoadAllUsersInColLevel();

        public DataTable LoadAllRolesInTabLevel() => privileges.LoadAllRolesInTabLevel();

        public DataTable LoadAllRolesInColLevel() => privileges.LoadAllRolesInColLevel();

        public DataTable FilterUsersInTabLevel(string userName) => privileges.FilterUsersInTabLevel(userName);

        public DataTable FilterUsersInColLevel(string userName) => privileges.FilterUsersInColLevel((string)userName);

        public DataTable FilterRolesInTabLevel(string role) => privileges.FilterRolesInTabLevel((string)role);

        public DataTable FilterRolesInColLevel(string role) => privileges.FilterRolesInColLevel((string)role);

        public DataTable LoadTables() => privileges.LoadTables();

        public DataTable LoadColumnsOfTable(string table) => privileges.LoadColumnsOfTable(table);

        public void GrantUser(string privilege, string table, string user) => privileges.GrantUser(privilege, table, user);

        public void GrantUserWithGrantOption(string privilege, string tablem, string user) => privileges.GrantUserWithGrantOption((string)privilege, tablem, user);

        public void GrantUserToColLevel(string privilege, string column, string table, string user) => privileges.GrantUserToColLevel(privilege, column, table, user);
        public void GrantUserToColLevelWithGrantOption(string privilege, string column, string table, string user) => privileges.GrantUserToColLevelWithGrantOption(privilege, column, table, user);

        public void GrantUserSelectToColLevel(string column, string table, string user) => privileges.GrantUserSelectToColLevel((string)column, table, user);   
        public void GrantUserSelectToColLevelWithGrantOption(string column, string table, string user) => privileges.GrantUserSelectToColLevelWithGrantOption((string)column, table, user);       
        
        public void RevokeUser(string privilege, string table, string user) => privileges.RevokeUser(privilege, table, user);
    }
}
