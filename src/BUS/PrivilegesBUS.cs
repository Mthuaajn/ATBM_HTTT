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
    }
}
