using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace mobilyAccounting.BL
{
    class CLS_CLIENS_ACCOUNT
    {

        public void ADD_CLIENT_ACCOUNT(string store_name, string c_name, int c_phone, string a_type, string desk)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("_A_STORE_NAME", store_name);
            param[1] = new MySqlParameter("_A_C_NAME", c_name);
            param[2] = new MySqlParameter("_A_C_PHONE", c_phone);
            param[3] = new MySqlParameter("_A_TYPE", a_type);
            param[4] = new MySqlParameter("_A_DESKRIPTION", desk);
            param[5] = new MySqlParameter("_CREATED_AT", DateTime.Now);
            
            DAL.ExecuteCommand("ADD_CLIENT_ACCOUNT", param);
            DAL.CloseConnection();

        }

        public void UPDATE_CLIENT_ACCOUNT(int id, string store_name, string c_name, int c_phone, string a_type, string desk)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("_A_ID", id);
            param[1] = new MySqlParameter("_A_STORE_NAME", store_name);
            param[2] = new MySqlParameter("_A_C_NAME", c_name);
            param[3] = new MySqlParameter("_A_C_PHONE", c_phone);
            param[4] = new MySqlParameter("_A_TYPE", a_type);
            param[5] = new MySqlParameter("_A_DESKRIPTION", desk);

            DAL.ExecuteCommand("UPDATE_CLIENT_ACCOUNT", param);
            DAL.CloseConnection();
        }

        public DataTable GET_ALL_CLIENTS_ACCOUNT(string acc_type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_A_TYPE", acc_type);

            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CLIENTS_ACCOUNT", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_CLIENTS_ACC_CRED_STATISTICS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CLIENTS_ACC_CRED_STATISTICS", null);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_CLIENTS_ACC_DEBIT_STATISTICS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CLIENTS_ACC_DEBIT_STATISTICS", null);
            DAL.CloseConnection();
            return dt;
        }     
    }
}
