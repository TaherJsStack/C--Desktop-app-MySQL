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
    class CLS_LOGIN
    {
        public DataTable LOGIN(string U_NAME, string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("_U_NAME", U_NAME);

            param[1] = new MySqlParameter("_PWD", PWD);

            DAL.OpenConnection();

            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN", param);
            DAL.CloseConnection();
            return dt;
        }

        public DataTable CHECK_PASSWORD(string old_pass)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("_OLD_PASS", old_pass);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECK_PASSWORD", param);
            DAL.CloseConnection();
            return dt;
        }

        public void UPDATE_PASSWORD(int id, string newPass )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();

            MySqlParameter[] param = new MySqlParameter[2];

            param[0] = new MySqlParameter("_ID", id);
            param[1] = new MySqlParameter("_NEW_PASS", newPass);
            DAL.ExecuteCommand("UPDATE_PASSWORD", param);
            DAL.CloseConnection();
        }

        //UPDATE_PASSWORD

        public DataTable CHECK_PASSWORD(string name, string old_pass)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.OpenConnection();
            MySqlParameter[] param = new MySqlParameter[2];
            param[0] = new MySqlParameter("_U_NAME", name);
            param[1] = new MySqlParameter("_OLD_PASS", old_pass);
            DataTable dt = new DataTable();
            dt = DAL.SelectData("CHECK_PASSWORD", param);
            DAL.CloseConnection();
            return dt;
        }

        //public void UPDATE_PASSWORD(int id, string newPass)
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DAL.OpenConnection();

        //    MySqlParameter[] param = new MySqlParameter[2];

        //    param[0] = new MySqlParameter("_ID", id);
        //    param[1] = new MySqlParameter("_NEW_PASS", newPass);
        //    DAL.ExecuteCommand("UPDATE_PASSWORD", param);
        //    DAL.CloseConnection();
        //}

    

    }
}
