using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;

namespace UsersManagement
{
    internal class Modify
    {
        public Modify()
        {
        }
        //OracleDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable Table(string query) // Tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
            {
                oracleConnection.Open();
 
                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {

                        dataTable.Load(reader);
                    }
                }
                oracleConnection.Close();
            }
            return dataTable;
        }
    }
}
