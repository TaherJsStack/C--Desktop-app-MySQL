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
    class CLS_RECEIPT_INFO
    {

        public void ADD_RECEIPT_INFO(string name, string phone, double total, double dis_total, string receipt_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[7];

            param[0] = new MySqlParameter("_R_I_NAME", name);
            param[1] = new MySqlParameter("_R_I_PHONE", phone);
            param[2] = new MySqlParameter("_R_I_TOTAL", total);
            param[3] = new MySqlParameter("_R_I_DISCOUNT", dis_total);
            param[4] = new MySqlParameter("_R_I_NO", receipt_no);
            param[5] = new MySqlParameter("_R_I_TYPE", "مبيعات");
            param[6] = new MySqlParameter("_R_I_CREATED_AT", DateTime.Now);
            DAL.ExecuteCommand("ADD_RECEIPT_INFO", param);
            DAL.CloseConnection();
        }

        public DataTable GET_ALL_RECEIPT_INFO()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_RECEIPT_INFO", null);
            DAL.CloseConnection();
            return dt;
        }

        public void DELETE_I_RECEIPT(int r_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_R_I_ID", r_id);
            DAL.ExecuteCommand("DELETE_RECEIPT", param);
            DAL.CloseConnection();
        }

        public DataTable SEARCH_RECEIPT_BY_NO(string r_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_R_I_NO", r_no);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_RECEIPT_BY_NO", param);
            DAL.CloseConnection();
            return dt;
        }
        

    }
}
