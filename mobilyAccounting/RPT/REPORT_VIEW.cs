using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace mobilyAccounting.RPT
{
    public partial class REPORT_VIEW : Form
    {

        protected DataGridView D_G_View;
        public string c_name, r_total, r_date, r_code, c_phone;

        public REPORT_VIEW(DataGridView dataSource)
        {
            InitializeComponent();
            D_G_View = dataSource;
        }

        private void crvDataTable_Load(object sender, EventArgs e)
        {

            DataTable info = new DataTable();
            info.Columns.Add("c_name", typeof(string));
            info.Columns.Add("r_total", typeof(string));
            info.Columns.Add("r_date", typeof(string));
            info.Columns.Add("r_code", typeof(string));
            info.Columns.Add("c_phone", typeof(string));
            //add info data
            info.Rows.Add(c_name, r_total, r_date, r_code, c_phone);

            //Declare datatable
            DataTable Product = new DataTable();
            Product.Columns.Add("PId", typeof(int));
            Product.Columns.Add("PName", typeof(string));
            Product.Columns.Add("Quantity", typeof(int));
            Product.Columns.Add("Price", typeof(double));
            Product.Columns.Add("Total", typeof(double));
            Product.Columns.Add("Discou", typeof(double));

            //Insert test rows
            for (int i = 0; i < D_G_View.Rows.Count; i++)
            {
                Product.Rows.Add(
                    Convert.ToInt32(this.D_G_View.Rows[i].Cells[0].Value),  //pid, 
                    Convert.ToString(this.D_G_View.Rows[i].Cells[1].Value), //pname
                    Convert.ToInt32(this.D_G_View.Rows[i].Cells[2].Value), //pcount,
                    Convert.ToDouble(this.D_G_View.Rows[i].Cells[3].Value), //pprice);
                    Convert.ToDouble(this.D_G_View.Rows[i].Cells[6].Value), //ptotal
                    Convert.ToDouble(this.D_G_View.Rows[i].Cells[5].Value) //Discou
                );
            };

            crv_RECEIPT crpt = new crv_RECEIPT();
            crpt.Database.Tables["DSRECEIPT"].SetDataSource(Product);
            crpt.Database.Tables["INFO"].SetDataSource(info);
            crvDataTable.ReportSource = null;
            crvDataTable.ReportSource = crpt;
        }
    }
}
