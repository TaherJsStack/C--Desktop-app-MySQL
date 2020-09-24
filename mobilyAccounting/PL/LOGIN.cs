using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management;

namespace mobilyAccounting.PL
{
    public partial class LOGIN : Form
    {

        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        PL.ErrorForm err = new PL.ErrorForm();

        public LOGIN()
        {
            InitializeComponent();
            //string p = ReturnProcessorId();
            //if( p != "BFEBFBFF000306C3" )
            //{
                //err.ShowDialog();
                //this.Close();
                //System.Windows.Forms.Application.ExitThread();
                //System.Windows.Forms.Application.Exit();  
                //btnLogin.Visible = false;
                //btnLogin.Enabled = false;

                //txtName.Visible = false;
                //txtPassword.Visible = false;
                //// WinForms app
                //System.Windows.Forms.Application.Exit();
            //}
        }

        //private static string ReturnProcessorId()
        //{
        //    string strProcessorId = string.Empty;
        //    SelectQuery query = new SelectQuery("Win32_processor");
        //    ManagementObjectSearcher search = new ManagementObjectSearcher(query);

        //    foreach (ManagementObject info in search.Get())
        //    {
        //        strProcessorId = info["ProcessorID"].ToString();
        //    }
        //    return Convert.ToString(strProcessorId);
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PL.DASHBOARD A_DASHBOARD = new PL.DASHBOARD();
            PL.DASHBOARD_WORKER W_DASH = new PL.DASHBOARD_WORKER();

            DataTable Dt = log.LOGIN(txtName.Text, txtPassword.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Convert.ToString(Dt.Rows[0][3]) == "aminstritor")
                {
                    this.Hide();
                    A_DASHBOARD.ShowDialog();
                }
                else 
                {
                    this.Hide();
                    W_DASH.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("كلمة السر او الدخول ليست صحيحه");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
