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
    public partial class ADD_ACCOUNT_RECEIPT : Form
    {

        double total = 0;
        int product_id;
        bool is_item_inner = true;
        public int account_id = 0;
        public bool is_acc_Creditor = false;
        
        BL.CLS_RECEIPT_INFO rec_info = new BL.CLS_RECEIPT_INFO();
        BL.CLS_RECEIPT_ITEMS rec_items = new BL.CLS_RECEIPT_ITEMS();
        BL.CLS_PRODUCTS product = new BL.CLS_PRODUCTS();

        BL.CLS_ACOUNT_RECEIPT_INFO a_r_info = new BL.CLS_ACOUNT_RECEIPT_INFO();
        BL.CLS_ACOUNT_RECEIPT_ITEMS a_r_items = new BL.CLS_ACOUNT_RECEIPT_ITEMS();
        BL.CLS_CLIENS_ACCOUNT account = new BL.CLS_CLIENS_ACCOUNT();

        public ADD_ACCOUNT_RECEIPT()
        {
            InitializeComponent();
            btnTypeSwitch.Text = " قطع داخلي ";
        }

        private void textBARCODE_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = product.SEARCH_PRODUCT_BARCODE(is_item_inner, textBARCODE.Text);

            if (Dt.Rows.Count > 0)
            {
                product_id = Convert.ToInt32(Dt.Rows[0][0]);
                textPRO_NAME.Text = Convert.ToString(Dt.Rows[0][1]);
                textITEM_PRICE.Text = Convert.ToString(Dt.Rows[0][2]);
                textITEM_COUNT.Text = Convert.ToString(1);
            }
            else 
            {
                product_id = 0;
                textPRO_NAME.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
            }
        }

        private void textITEM_COUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textITEM_COUNT_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = product.CHECk_PRODUCT_QUANTITY(product_id);

            if (Dt.Rows.Count > 0)
            {
                int BDquantity = Convert.ToInt32(Dt.Rows[0][0]);
                int count;

                if (BDquantity == 0)
                {
                    MessageBox.Show("  المنتج المطلوب غير متاح " + BDquantity);
                    textBARCODE.Text = string.Empty;
                }

                if (Int32.TryParse(textITEM_COUNT.Text, out count))
                {

                    if (BDquantity < count)
                    {
                        MessageBox.Show("  الكمية المتاحة من المنتج " + BDquantity);
                        textITEM_COUNT.Text = string.Empty;
                    }
                    else if (BDquantity == count)
                    {
                        MessageBox.Show(" الكمية الحاليه ستصبح 0");
                    }
                    else if (BDquantity == 0)
                    {
                        MessageBox.Show(" تم الابلاغ مسبقا الكمية الحاليه 0");
                    }
                }
            }
        }

        private void btnADD_PROD_TO_CART_Click(object sender, EventArgs e)
        {
            if (
                   !string.IsNullOrEmpty(textPRO_NAME.Text) && 
                   !string.IsNullOrEmpty(textITEM_PRICE.Text) && 
                   !string.IsNullOrEmpty(textITEM_COUNT.Text)
                )
            {
                BL.CLS_RECEIPT_ACOUNT obj = new BL.CLS_RECEIPT_ACOUNT();

                obj.الرقم = product_id;
                obj.الاسم = textPRO_NAME.Text;
                obj.السعر = Convert.ToDouble(textITEM_PRICE.Text);
                obj.الكميه = Convert.ToInt32(textITEM_COUNT.Text);
                obj.النوع = btnTypeSwitch.Text;

                total += obj.السعر * obj.الكميه;

                if (total > 0)
                {
                    cLSRECEIPTACOUNTBindingSource.Add(obj);
                }
                cLSRECEIPTACOUNTBindingSource.MoveLast();
                textPRO_NAME.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textBARCODE.Text = string.Empty;
                txtTOTAL.Text = string.Format("{0}ج", total);
            }
            else 
            {
                MessageBox.Show("عفوا لا توجد منتجات للاضافة ");
            }
        }

        private void btnDELET_PROD_CART_Click(object sender, EventArgs e)
        {
            BL.CLS_RECEIPT_ACOUNT obj = cLSRECEIPTACOUNTBindingSource.Current as BL.CLS_RECEIPT_ACOUNT;
            if (obj != null)
            {
                total -= obj.السعر * obj.الكميه;
                txtTOTAL.Text = string.Format("{0}ج", total);
                cLSRECEIPTACOUNTBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("لا توجد منتجات بالفاتورة");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            txtTOTAL.Text = string.Format("{0}ج", 0);
            dataGridViewAccountReceipt.Rows.Clear();
            this.Close();
        }

        private static string RandomReceiptCodeString(int length)
        {
            var random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }

        private void btnSaveNoPrint_Click(object sender, EventArgs e)
        {
   
            if (dataGridViewAccountReceipt.Rows.Count <= 0)
            {
                MessageBox.Show("لا توجد منتجات للتسجيل");
            }
            else
            {
                string r_code = Convert.ToString(DateTime.Now.ToString("yymmdd")) + RandomReceiptCodeString(4);
                a_r_info.ADD_ACOUNT_RECEIPT_INFO(
                        account_id, 
                        Convert.ToString(txtClientName.Text), 
                        Convert.ToDouble(total), 
                        Convert.ToString(r_code));
                if(txtAcountType.Text == "مدين") 
                {
                    is_acc_Creditor = true;
                }
                //dataGridViewsTATISTICS
                for (int i = 0; i < dataGridViewAccountReceipt.Rows.Count; i++)
                {
                   // string code, string i_name, int prod_id, string item_type, int quant, double price, double tota
                    a_r_items.ADD_ACOUNT_RECEIPT_INFO(
                        is_acc_Creditor,
                        r_code, //code
                        Convert.ToString(this.dataGridViewAccountReceipt.Rows[i].Cells[1].Value), //i_name
                        Convert.ToInt32(this.dataGridViewAccountReceipt.Rows[i].Cells[0].Value), //prod_id
                        Convert.ToString(this.dataGridViewAccountReceipt.Rows[i].Cells[2].Value), //item_type
                        Convert.ToInt32(this.dataGridViewAccountReceipt.Rows[i].Cells[3].Value), //quant
                        Convert.ToDouble(this.dataGridViewAccountReceipt.Rows[i].Cells[4].Value), //price
                        Convert.ToDouble(this.dataGridViewAccountReceipt.Rows[i].Cells[5].Value) //tota
                    );
                }
                // BL.CLS_CLIENS_ACCOUNT account = new BL.CLS_CLIENS_ACCOUNT();
                DASHBOARD.getDASHBOARD.dataGridViewClientsAccount.DataSource = account.GET_ALL_CLIENTS_ACCOUNT(DASHBOARD.getDASHBOARD.Is_AccType);                
                DASHBOARD.getDASHBOARD.dataGridViewRECEIPT.DataSource = rec_info.GET_ALL_RECEIPT_INFO();
                DASHBOARD.getDASHBOARD.dataGridViewsTATISTICS.DataSource = rec_items.GET_SALES_STATISTICS();
                DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_CRED_Stats.DataSource = account.GET_CLIENTS_ACC_CRED_STATISTICS();
                DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_DEBIT_Stats.DataSource = account.GET_CLIENTS_ACC_DEBIT_STATISTICS();
                MessageBox.Show(" تم تسجيل الفاتورة ");
                this.Close();
                total = 0;
                txtTOTAL.Text = string.Format("{0}ج", 0);
                dataGridViewAccountReceipt.Rows.Clear();
            }

        }

        private void btnTypeSwitch_Click(object sender, EventArgs e)
        {
            if (is_item_inner)
            {
                is_item_inner = false;
                btnTypeSwitch.Text = " قطع خارجي ";
            }
            else
            {
                is_item_inner = true;
                btnTypeSwitch.Text = " قطع داخلي ";
            }
            DataTable Dt = new DataTable();
            Dt = product.SEARCH_PRODUCT_BARCODE(is_item_inner, textBARCODE.Text);
            if (Dt.Rows.Count > 0)
            {
                product_id = Convert.ToInt32(Dt.Rows[0][0]);
                textPRO_NAME.Text = Convert.ToString(Dt.Rows[0][1]);
                textITEM_PRICE.Text = Convert.ToString(Dt.Rows[0][2]);
                textITEM_COUNT.Text = Convert.ToString(1);
            }
        }

        private void ADD_ACCOUNT_RECEIPT_Load(object sender, EventArgs e)
        {
            total = 0;
            txtTOTAL.Text = string.Format("{0}ج", 0);
            dataGridViewAccountReceipt.Rows.Clear();
            product_id = 0;
            textPRO_NAME.Text    = string.Empty;
            textITEM_PRICE.Text  = string.Empty;
            textITEM_COUNT.Text = string.Empty;
        }

     
    }
}
