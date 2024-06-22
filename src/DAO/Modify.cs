﻿using Oracle.ManagedDataAccess.Client;
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
        public DataTable LoadTableSys(string query) // Tra ve bang du lieu
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
        public DataTable LoadTable(string query, string username, string password, string role) // Tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection oracleConnection = LoginDAO.GetAppConnection(username,password, role))
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


        // ======= THEM CAC HAM TUONG TU THAY CHO SYS DE LAM VIEC VOI USER ADMIN KHAC NGOAI SYS =======
        public DataTable LoadTableByUser(string query, string username, string password, string role) // Tra ve bang du lieu
        {
            DataTable dataTable = new DataTable();
            using (OracleConnection oracleConnection = LoginDAO.GetAppConnection(username, password, role))
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



        // Thuc thi cau lenh dưới danh nghĩa user hiện tại đang giữ session
        public void ExecuteQueryByUser(string query, string username, string password, string role) 
        {
            using (OracleConnection oracleConnection = LoginDAO.GetAppConnection(username, password, role))
            {
                oracleConnection.Open();
                using (OracleCommand command = new OracleCommand(query, oracleConnection))
                {
                    command.ExecuteNonQuery();
                }
                oracleConnection.Close();
            }
        }

        public object ExecuteScalarByUser(string query, string username, string password, string role)
        {
            object result = null;
            using (OracleConnection oracleConnection = LoginDAO.GetAppConnection(username, password, role))
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
