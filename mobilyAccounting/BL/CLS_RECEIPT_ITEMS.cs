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
    class CLS_RECEIPT_ITEMS
    {

        public void ADD_RECEIPT_ITEM(
            string pname, 
            int pid, 
            double pprice, 
            int pcount, 
            double pdiscount, 
            double ptotal, 
            double finall_total, 
            string receipt_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            //
            MySqlParameter[] param = new MySqlParameter[9];
            param[0] = new MySqlParameter("_R_ITEM_NAME", pname);
            param[1] = new MySqlParameter("_R_ITEM_PRODUCT_ID", pid);
            param[2] = new MySqlParameter("_R_ITEM_PRICE", pprice);
            param[3] = new MySqlParameter("_R_ITEM_COUNT", pcount);
            param[4] = new MySqlParameter("_R_ITEM_DISCOUNT", pdiscount);
            param[5] = new MySqlParameter("_R_ITEM_TOTAL", ptotal);
            param[6] = new MySqlParameter("_R_ITEM_FINAL_TOTAL", finall_total);
            param[7] = new MySqlParameter("_R_INFO_NO", receipt_no);
            param[8] = new MySqlParameter("_R_ITEM_CRETED_AT", DateTime.Now);

            DAL.ExecuteCommand("ADD_RECEIPT_ITEMS", param);
            DAL.CloseConnection();
        }


        public DataTable GET_ALL_RECEIPT_ITEMS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("ADD_RECEIPT_ITEMS", null);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable SEARCH_RECEIPT_ITEMS(string r_no)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_R_I_NO", r_no);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_RECEIPT_ITEMS", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_SALES_STATISTICS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_SALES_STATISTICS", null);
            DAL.CloseConnection();
            return dt;
        }

    }
}
