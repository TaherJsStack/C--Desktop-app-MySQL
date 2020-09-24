using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobilyAccounting.PL
{
    public partial class SHOW_ACC_RECE : Form
    {

        public SHOW_ACC_RECE()
        {
            InitializeComponent();
        }

        private void btnShowBillInfo_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccReceInfo.RowCount <= 0)
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
            else
            {
                BL.CLS_ACOUNT_RECEIPT_ITEMS acc_receipt_items = new BL.CLS_ACOUNT_RECEIPT_ITEMS();
                PL.SHOW_ITEMS items = new PL.SHOW_ITEMS();
                DataTable Dt = new DataTable();
                Dt = acc_receipt_items.GET_ACOUNT_RECEIPT_ITEMS(Convert.ToString(this.dataGridViewAccReceInfo.CurrentRow.Cells[4].Value));
                if (Dt.Rows.Count > 0)
                {
                    items.dataGridViewITEMS.DataSource = Dt;
                }
                items.ShowDialog();
            }
        }
    }
}
