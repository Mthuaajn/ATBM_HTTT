using Oracle.ManagedDataAccess.Client;
using System.Data;
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

        public object ExecuteScalar(string query)
        {
            object result = null;
            using (OracleConnection oracleConnection = Connection.GetOracleConnection())
            {
                oracleConnection.Open();
                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                {
                    result = command.ExecuteScalar();
                }
                oracleConnection.Close();
            }
            return result;
        }
    }
}
