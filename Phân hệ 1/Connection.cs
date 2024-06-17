using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace UsersManagement
{
    internal class Connection
    {
        
        private static readonly string stringConnection = @"DATA SOURCE=localhost:1521/XE;DBA PRIVILEGE=SYSDBA;USER ID=sys;PASSWORD=123456";
        public static OracleConnection GetOracleConnection()
        {
            return new OracleConnection(stringConnection);
        }
    }
}
