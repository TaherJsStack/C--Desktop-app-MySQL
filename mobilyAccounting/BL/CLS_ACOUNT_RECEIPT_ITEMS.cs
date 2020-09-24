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
    class CLS_ACOUNT_RECEIPT_ITEMS
    {

        public void ADD_ACOUNT_RECEIPT_INFO(
                bool acc_type,    string code, string i_name, int prod_id, 
                string item_type, int quant,     double price,   double total)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("ACC_TYPE", acc_type);
            param[1] = new MySqlParameter("_A_R_INFO_CODE", code);
            param[2] = new MySqlParameter("_AR_ITEM_NAME", i_name);
            param[3] = new MySqlParameter("_AR_ITEM_PROD_ID", prod_id);
            param[4] = new MySqlParameter("_AR_ITEM_TYPE", item_type);
            param[5] = new MySqlParameter("_AR_ITEM_QUANTITY", quant);
            param[6] = new MySqlParameter("_AR_PRICE", price);
            param[7] = new MySqlParameter("_AR_TOTAL_PRICE", total);
            param[8] = new MySqlParameter("_AR_CREATED_AT", DateTime.Now);

            DAL.ExecuteCommand("ADD_ACOUNT_RECEIPT_ITEMS", param);
            DAL.CloseConnection();
        }

        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_ACOUNT_RECEIPT_ITEMS", null);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_ACOUNT_RECEIPT_ITEMS(string code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_A_R_INFO_CODE", code);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ACOUNT_RECEIPT_ITEMS", param);
            DAL.CloseConnection();
            return dt;
        }

    }
}
