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
    class CLS_CATEGORY
    {

        public void ADD_CATEGORY(string name, string deskripition)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("_C_NAME", name);
            param[1] = new MySqlParameter("_C_DESKRIPTION", deskripition);

            DAL.ExecuteCommand("ADD_CATEGORY", param);
            DAL.CloseConnection();
        }

        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_CATEGORIES", null);
            DAL.CloseConnection();
            return dt;
        }


        public DataTable CHECk_IS_CATEGORY_EXISTS(string c_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_C_NAME", c_name);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECk_IS_CATEGORY_EXISTS", param);
            DAL.CloseConnection();
            return dt;
        }

        
    }
}
