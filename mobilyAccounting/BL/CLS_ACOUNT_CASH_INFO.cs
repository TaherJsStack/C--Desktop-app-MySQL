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
    class CLS_ACOUNT_CASH_INFO
    {

        public void ADD_CASH_TO_ACC(int c_a_id, string c_type, string c_name, double total, string note )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[6];

            param[0] = new MySqlParameter("_C_ACOUNT_ID", c_a_id);
            param[1] = new MySqlParameter("_C_ACC_TYPE", c_type);
            param[2] = new MySqlParameter("_C_ANAME", c_name);
            param[3] = new MySqlParameter("_C_CASH_TOTAL", total);
            param[4] = new MySqlParameter("_C_NOTE", note);
            param[5] = new MySqlParameter("_C_CREATED_AT", DateTime.Now);

            DAL.ExecuteCommand("ADD_CASH_TO_ACC", param);
            DAL.CloseConnection();
        }

        //public DataTable GET_ALL_ACCOUNTS_CASH()
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DAL.OpenConnection();
        //    DataTable dt = new DataTable();
        //    dt = DAL.SelectData("GET_ALL_ACOUNT_RECEIPT_INFO", null);
        //    DAL.CloseConnection();
        //    return dt;
        //}

        public DataTable GET_ALL_ACCOUNT_CASH(int a_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_C_ID", a_id);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_ACCOUNT_CASH", param);
            DAL.CloseConnection();
            return dt;
        }




    }
}
