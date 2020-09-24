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
    public partial class DASHBOARD_WORKER : Form
    {

        BL.CLS_RECEIPT_INFO receipt_info = new BL.CLS_RECEIPT_INFO();
        PL.RECEIPT receipt = new PL.RECEIPT();


        private static DASHBOARD_WORKER frm_dash_workers;

        static void frm_FormClosed(object sender, EventArgs e)
        {
            frm_dash_workers = null;
        }

        // TO MACK UPDATE ENABLE LIKE REAL TIME FROM ANY OTHER FORM
        public static DASHBOARD_WORKER getDASHBOARD_WORKER
        {
            get
            {
                if (frm_dash_workers == null)
                {
                    frm_dash_workers = new DASHBOARD_WORKER();
                    frm_dash_workers.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm_dash_workers;
            }
        }

        public DASHBOARD_WORKER()
        {
            if (frm_dash_workers == null)
                frm_dash_workers = this;


            InitializeComponent();
            dataGridViewRECEIPT_WORKER.DataSource = receipt_info.GET_ALL_RECEIPT_INFO();

        }

        private void btnAddReceiptFrm_Click(object sender, EventArgs e)
        {
            receipt.ShowDialog();
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridViewRECEIPT_WORKER.RowCount <= 0)
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
            else
            {
                BL.CLS_RECEIPT_ITEMS receipt_items = new BL.CLS_RECEIPT_ITEMS();
                PL.SHOW_ITEMS items = new PL.SHOW_ITEMS();
                DataTable Dt = new DataTable();
                Dt = receipt_items.SEARCH_RECEIPT_ITEMS(Convert.ToString(this.dataGridViewRECEIPT_WORKER.CurrentRow.Cells[5].Value));
                if (Dt.Rows.Count > 0)
                {
                    items.dataGridViewITEMS.DataSource = Dt;
                }
                items.ShowDialog();
            }
        }

        private void textSERCH_RECEIPT_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = receipt_info.SEARCH_RECEIPT_BY_NO(Convert.ToString(textSERCH_RECEIPT.Text));
            if (Dt.Rows.Count > 0)
            {
                this.dataGridViewRECEIPT_WORKER.DataSource = Dt;
            }
            else
            {
                this.dataGridViewRECEIPT_WORKER.DataSource = receipt_info.GET_ALL_RECEIPT_INFO();
            }
        }
    }
}
