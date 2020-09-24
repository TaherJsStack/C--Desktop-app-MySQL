using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

using System.Windows.Forms;

namespace mobilyAccounting.DAL
{
    class DataAccessLayer
    {

        MySqlConnection connection;

        // this constaractour inisilalize the connection to project
        public DataAccessLayer()
        {
            string connectionString;
            connectionString = "SERVER=localhost;" + "DATABASE=mobilyaccounting;" + "UID=root;" + "PASSWORD=;Charset=utf8";
           
            /*connectionString = @"SERVER=" + Properties.Settings.Default.Server +
                              "; DATABASE=" + Properties.Settings.Default.Database +
                              "; UID=" + Properties.Settings.Default.U_ID +
                              "; PASSWORD=; Charset=utf8";**/
            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
       
        //Close connection to database
       
        // Method To Read Data From Database
      
        //Method To Insert, Update, and Delete From Database
       
         
    }
}
