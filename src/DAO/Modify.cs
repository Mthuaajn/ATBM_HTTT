using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersManagement;

namespace DAO
{
    public class Modify
    {
        public Modify()
        {
        }
        //OracleDataAdapter dataAdapter;
        //SqlCommand sqlCommand;
        public DataTable LoadTable(string query) // Tra ve bang du lieu
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
        public void ExecuteQuery(string query) // Thuc thi cau lenh
        {
            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
            {
                oracleConnection.Open();
                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                {
                    command.ExecuteNonQuery();
                }
                oracleConnection.Close();
            }
        }
    }
}
