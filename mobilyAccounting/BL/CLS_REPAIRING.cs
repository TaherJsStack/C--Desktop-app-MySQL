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
    class CLS_REPAIRING
    {

        public void ADD_DEVICE(string OWNER_NAME, string OWNER_PHONE, string DEVICE_NAME, string DEVICE_TYPE, string DEVICE_STATE, double cost , bool IS_PAY, bool IS_REPAIR, bool IS_DELIVERED, string NOTE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[11];

            param[0] = new MySqlParameter("_R_OWNER_NAME",   OWNER_NAME);
            param[1] = new MySqlParameter("_R_OWNER_PHONE", OWNER_PHONE);
            param[2] = new MySqlParameter("_R_DEVICE_NAME",   DEVICE_NAME);
            param[3] = new MySqlParameter("_R_DEVICE_TYPE",    DEVICE_TYPE);
            param[4] = new MySqlParameter("_R_DEVICE_STATE",   DEVICE_STATE);
            param[5] = new MySqlParameter("_R_COST", cost);
            param[6] = new MySqlParameter("_R_IS_PAY", IS_PAY);
            param[7] = new MySqlParameter("_R_IS_REPAIR",        IS_REPAIR);
            param[8] = new MySqlParameter("_R_IS_DELIVERED", IS_DELIVERED);
            param[9] = new MySqlParameter("_R_NOTE", NOTE);
            param[10] = new MySqlParameter("_R_CREATED_AT", DateTime.Now);
            
            DAL.ExecuteCommand("ADD_DEVICE_REPAIRING", param);
            DAL.CloseConnection();
        }

        public DataTable GET_ALL_REPAIRING()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ALL_DEVICE_REPAIRING", null);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable SEARCH_REPAIRING(string r_o_phone)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_R_OWNER_PHONE", r_o_phone);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SEARCH_REPAIRING", param);
            DAL.CloseConnection();
            return dt;
        }

        public void DELETE_DEVICE(int r_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_R_ID", r_id);
            DAL.ExecuteCommand("DELETE_DEVICE", param);
            DAL.CloseConnection();
        }

        public void UPDATE_DEVICE(int ID, string OWNER_NAME, string OWNER_PHONE, string DEVICE_NAME, string DEVICE_TYPE, string DEVICE_STATE, double cost, bool IS_PAY, bool IS_REPAIR, bool IS_DELIVERED, string NOTE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[11];

            param[0] = new MySqlParameter("_R_ID", ID);
            param[1] = new MySqlParameter("_R_OWNER_NAME", OWNER_NAME);
            param[2] = new MySqlParameter("_R_OWNER_PHONE", OWNER_PHONE);
            param[3] = new MySqlParameter("_R_DEVICE_NAME", DEVICE_NAME);
            param[4] = new MySqlParameter("_R_DEVICE_TYPE", DEVICE_TYPE);
            param[5] = new MySqlParameter("_R_DEVICE_STATE", DEVICE_STATE);
            param[6] = new MySqlParameter("_R_COST", cost);            
            param[7] = new MySqlParameter("_R_IS_PAY", IS_PAY);
            param[8] = new MySqlParameter("_R_IS_REPAIR", IS_REPAIR);
            param[9] = new MySqlParameter("_R_IS_DELIVERED", IS_DELIVERED);
            param[10] = new MySqlParameter("_R_NOTE", NOTE);

            DAL.ExecuteCommand("UPDATE_DEVICE", param);
            DAL.CloseConnection();
        }

        public DataTable GET_REPAIR_STATISTICS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_REPAIR_STATISTICS", null);
            DAL.CloseConnection();
            return dt;
        }

        
    }
}
