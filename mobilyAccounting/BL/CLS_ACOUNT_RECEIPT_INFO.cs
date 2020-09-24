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
    class CLS_ACOUNT_RECEIPT_INFO
    {

        public void ADD_ACOUNT_RECEIPT_INFO(int c_a_id, string c_name, double total, string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[5];

            param[0] = new MySqlParameter("_C_ACOUNT_ID", c_a_id);
            param[1] = new MySqlParameter("_C_ANAME", c_name);
            param[2] = new MySqlParameter("_R_TOTAL", total);
            param[3] = new MySqlParameter("_R_CODE", code);
            param[4] = new MySqlParameter("_R_CREATED_AT", DateTime.Now);

            DAL.ExecuteCommand("ADD_ACOUNT_RECEIPT_INFO", param);
            DAL.CloseConnection();
        }

        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_ACOUNT_RECEIPT_INFO", null);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_ALL_ACCOUNT_RECEIPT(int a_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_C_ACOUNT_ID", a_id);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_ACCOUNT_RECEIPT", param);
            DAL.CloseConnection();
            return dt;
        }



    }
}
