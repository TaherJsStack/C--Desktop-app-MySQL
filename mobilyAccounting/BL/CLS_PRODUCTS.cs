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
    class CLS_PRODUCTS
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.CloseConnection();
            return dt;
        }

        public void ADD_PRODUCT(string name, double price, double s_price, int quantatiy, string deskripition, string barcode, int cat_id, bool is_item_inner )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[8];

            param[0] = new MySqlParameter("_P_NAME", name);
            param[1] = new MySqlParameter("_P_PRICE", price);
            param[2] = new MySqlParameter("_P_PRICE_SELL", s_price);
            param[3] = new MySqlParameter("_P_QUANTITY", quantatiy);
            param[4] = new MySqlParameter("_P_DESKRIPTION", deskripition);

            param[5] = new MySqlParameter("_P_BARCODE", barcode);
            param[6] = new MySqlParameter("_P_CATE_ID", cat_id);
            param[7] = new MySqlParameter("_P_IS_ITEM_INNER", is_item_inner);

            DAL.ExecuteCommand("ADD_PRODUCT", param);
            DAL.CloseConnection();
            
        }

        public void UPDATE_PRODUCT(int id, string name, double price, double s_price, int quantatiy, string deskripition, string barcode, int cat_id, bool is_item_inner)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[9];

            param[0] = new MySqlParameter("_P_ID", id);
            param[1] = new MySqlParameter("_P_NAME", name);
            param[2] = new MySqlParameter("_P_PRICE", price);
            param[3] = new MySqlParameter("_P_PRICE_SELL", s_price);
            param[4] = new MySqlParameter("_P_QUANTITY", quantatiy);
            param[5] = new MySqlParameter("_P_DESKRIPTION", deskripition);
            param[6] = new MySqlParameter("_P_BARCODE", barcode);
            param[7] = new MySqlParameter("_P_CATE_ID", cat_id);
            param[8] = new MySqlParameter("_P_IS_ITEM_INNER", is_item_inner);

            DAL.ExecuteCommand("UPDATE_PRODUCT", param);
            DAL.CloseConnection();
        }

        public DataTable CHECK_IS_PRODUCT_EXISTS(string p_name, bool i_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("_P_NAME", p_name);
            param[1] = new MySqlParameter("_P_BARCODE", i_code);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECK_IS_PRODUCT_EXISTS", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable CHECK_IS_PRODUCT_TYPE(string p_name, string i_code, bool is_inner)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[3];
            param[0] = new MySqlParameter("_P_NAME", p_name);
            param[1] = new MySqlParameter("_P_BARCODE", i_code);
            param[2] = new MySqlParameter("_P_IS_ITEM_INNER", is_inner);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECK_IS_PRODUCT_TYPE", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable CHECK_IS_PRODUCT_TYPE_AND_NAME(string p_name, bool is_inner)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("_P_NAME", p_name);
            param[1] = new MySqlParameter("_P_IS_ITEM_INNER", is_inner);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECK_IS_PRODUCT_TYPE_AND_NAME", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable CHECK_IS_PRODUCT_TYPE_AND_CODE(string i_code, bool is_inner)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("_P_BARCODE", i_code);
            param[1] = new MySqlParameter("_P_IS_ITEM_INNER", is_inner);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECK_IS_PRODUCT_TYPE_AND_CODE", param);
            DAL.CloseConnection();
            return dt;
        }

        
        public DataTable CHECk_PRODUCT_QUANTITY(int p_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_P_ID", p_id);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECk_PRODUCT_QUANTITY", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_ALL_PRODUCTS(bool is_item_inner)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_P_IS_ITEM_INNER", is_item_inner);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PRODUCTS", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable SEARCH_PRODUCT_BY_CODE(bool is_item_inner, string item_code)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("_P_IS_ITEM_INNER", is_item_inner);
            param[1] = new MySqlParameter("_P_BARCODE", item_code);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_PRODUCT_BY_CODE", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable SEARCH_PRODUCT(string p_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_P_NAME", p_name);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_PRODUCT", param);
            DAL.CloseConnection();
            return dt;
        }

        public void DELETE_PRODUCT(int p_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_P_ID", p_id);
            DAL.ExecuteCommand("DELETE_PRODUCT", param);
            DAL.CloseConnection();
        }

        public DataTable GET_PRODUCTS_STATISTICS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PRODUCTS_STATISTICS", null);
            DAL.CloseConnection();
            return dt;
        }

   
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       // 
     
        public DataTable CHECk_IS_BARCODE_EXISTS(string barcode)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_P_BARCODE", barcode);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECk_IS_BARCODE_EXISTS", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable GET_ALL_PRODUCTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_PRODUCTS", null);
            DAL.CloseConnection();
            return dt;
        }

   
        public DataTable GET_PRODUCT_IMAGE(int p_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_P_ID", p_id);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_PRODUCT_IMAGE", param);
            DAL.CloseConnection();
            return dt;
        }

        public void UPDATE_PRODUCT(int id, string name, string deskripition, int quantatiy, double price, double buy_price, string barcode, int cate_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[8];

            param[0] = new MySqlParameter("_P_ID", id);
            param[1] = new MySqlParameter("_P_NAME", name);
            param[2] = new MySqlParameter("_P_DESKRIPTION", deskripition);
            param[3] = new MySqlParameter("_P_QUAANITY", quantatiy);
            param[4] = new MySqlParameter("_P_PRICE", price);
            param[5] = new MySqlParameter("_P_BUY_PRICE", buy_price);
            param[6] = new MySqlParameter("_P_BARCODE", barcode);
            param[7] = new MySqlParameter("_P_CATE_ID", cate_id);
            DAL.ExecuteCommand("UPDATE_PRODUCT", param);
            DAL.CloseConnection();
        }

        public DataTable SEARCH_PRODUCT_BARCODE(bool is_inner , string p_barcode)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("_P_BARCODE", p_barcode);
            param[1] = new MySqlParameter("_P_IS_ITEM_INNER", is_inner);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_PRODUCT_BARCODE", param);
            DAL.CloseConnection();
            return dt;
        }
        





    }
}
