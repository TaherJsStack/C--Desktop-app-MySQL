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
    public partial class RECEIPT : Form
    {

        int product_id;
        double total = 0;
        double discount_total = 0;
        bool is_item_inner = true;

        BL.CLS_RECEIPT_INFO rec_info = new BL.CLS_RECEIPT_INFO();
        BL.CLS_RECEIPT_ITEMS rec_items = new BL.CLS_RECEIPT_ITEMS();
        BL.CLS_PRODUCTS product = new BL.CLS_PRODUCTS();

        public RECEIPT()
        {
            InitializeComponent();
        }

        
        private static string RandomReceiptCodeString(int length)
        {
            var random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
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
                txtDiscount.Text = Convert.ToString(0);
                textITEM_COUNT.Text = Convert.ToString(1);
            }

        }

        private void textITEM_COUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textCLIENT_PHONE_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnSaveNoPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewRECEIPT.Rows.Count <= 0)
            {
                MessageBox.Show("لا توجد منتجات للتسجيل");
            }
            else
            {
                textCLIENT_NAME.Text = "new client name";
                textCLIENT_PHONE.Text = "new client phone";
                string r_code = Convert.ToString(DateTime.Now.ToString("yymmdd")) + RandomReceiptCodeString(4);
                rec_info.ADD_RECEIPT_INFO(
                    textCLIENT_NAME.Text, 
                    textCLIENT_PHONE.Text, 
                    Convert.ToDouble(total), 
                    Convert.ToDouble(discount_total), 
                    r_code);

                //dataGridViewsTATISTICS
                for (int i = 0; i < dataGridViewRECEIPT.Rows.Count; i++)
                {
                    rec_items.ADD_RECEIPT_ITEM(
                        Convert.ToString(this.dataGridViewRECEIPT.Rows[i].Cells[1].Value), //pname
                        Convert.ToInt32(this.dataGridViewRECEIPT.Rows[i].Cells[0].Value),  //pid
                        Convert.ToDouble(this.dataGridViewRECEIPT.Rows[i].Cells[3].Value), //pprice
                        Convert.ToInt32(this.dataGridViewRECEIPT.Rows[i].Cells[2].Value), //pcount
                        Convert.ToInt32(this.dataGridViewRECEIPT.Rows[i].Cells[5].Value), //pdiscountcount
                        Convert.ToDouble(this.dataGridViewRECEIPT.Rows[i].Cells[4].Value), //ptotal
                        Convert.ToDouble(this.dataGridViewRECEIPT.Rows[i].Cells[6].Value), //ptotal finall
                        r_code); //receipt_no
                }
                DASHBOARD.getDASHBOARD.dataGridViewRECEIPT.DataSource = rec_info.GET_ALL_RECEIPT_INFO();
                DASHBOARD.getDASHBOARD.dataGridViewsTATISTICS.DataSource = rec_items.GET_SALES_STATISTICS();
                DASHBOARD_WORKER.getDASHBOARD_WORKER.dataGridViewRECEIPT_WORKER.DataSource = rec_info.GET_ALL_RECEIPT_INFO();
                MessageBox.Show(" تم تسجيل الفاتورة ");
                this.Close();
                total = 0;
                discount_total = 0;
                textTOTAL.Text = string.Format("{0}ج", 0);
                txtTotalDisc.Text = string.Empty;
                dataGridViewRECEIPT.Rows.Clear();
                txtTotalDisc.Text = string.Empty;
                textPRO_NAME.Text = string.Empty;
                textBARCODE.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
            }
        }

        private void btnADD_PROD_TO_CART_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textPRO_NAME.Text) && !string.IsNullOrEmpty(textITEM_PRICE.Text) && !string.IsNullOrEmpty(textITEM_COUNT.Text))
            {
                BL.CLS_RECEIPT obj = new BL.CLS_RECEIPT();

                obj.الرقم = product_id;
                obj.الاسم = textPRO_NAME.Text;
                obj.السعر = Convert.ToDouble(textITEM_PRICE.Text);
                obj.الكميه = Convert.ToInt32(textITEM_COUNT.Text);
                obj.الخصم = Convert.ToDouble(txtDiscount.Text);

                total += obj.السعر * obj.الكميه - obj.الخصم;
                discount_total += obj.الخصم;
                if (total > 0)
                {
                    cLSRECEIPTBindingSource.Add(obj);
                }
                cLSRECEIPTBindingSource.MoveLast();
                textPRO_NAME.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textBARCODE.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                textTOTAL.Text = string.Format("{0}ج", total);
                txtTotalDisc.Text = string.Format("{0}ج", discount_total);
            }
        }

        private void btnDELET_PROD_CART_Click(object sender, EventArgs e)
        {
            BL.CLS_RECEIPT obj = cLSRECEIPTBindingSource.Current as BL.CLS_RECEIPT;
            if (obj != null)
            {
                total -= obj.السعر * obj.الكميه - obj.الخصم;
                discount_total -= obj.الخصم;
                textTOTAL.Text = string.Format("{0}ج", total);
                txtTotalDisc.Text = string.Format("{0}ج", discount_total);
                cLSRECEIPTBindingSource.RemoveCurrent();
            }
            else
            {
                MessageBox.Show("لا توجد منتجات بالفاتورة");
            }
        }

        private void btnPRINT_RECIPT_Click(object sender, EventArgs e)
        {

            if (dataGridViewRECEIPT.Rows.Count <= 0)
            {
                MessageBox.Show("لا توجد منتجات للتسجيل");
            }
            else
            {
                textCLIENT_NAME.Text = "new client name";
                textCLIENT_PHONE.Text = "new client phone";
                string r_code = Convert.ToString(DateTime.Now.ToString("yymmdd")) + RandomReceiptCodeString(4);
                rec_info.ADD_RECEIPT_INFO(textCLIENT_NAME.Text, textCLIENT_PHONE.Text, Convert.ToDouble(total), Convert.ToDouble(discount_total), r_code);

                RPT.REPORT_VIEW frm_rece = new RPT.REPORT_VIEW(dataGridViewRECEIPT);
                frm_rece.c_name = textCLIENT_NAME.Text;
                frm_rece.r_date = DateTime.Now.ToString();
                frm_rece.r_total = Convert.ToString(total);
                frm_rece.r_code = r_code;
                frm_rece.c_phone = textCLIENT_PHONE.Text;

                //dataGridViewsTATISTICS
                for (int i = 0; i < dataGridViewRECEIPT.Rows.Count; i++)
                {
                    rec_items.ADD_RECEIPT_ITEM(
                        Convert.ToString(this.dataGridViewRECEIPT.Rows[i].Cells[1].Value), //pname
                        Convert.ToInt32(this.dataGridViewRECEIPT.Rows[i].Cells[0].Value),  //pid
                        Convert.ToDouble(this.dataGridViewRECEIPT.Rows[i].Cells[3].Value), //pprice
                        Convert.ToInt32(this.dataGridViewRECEIPT.Rows[i].Cells[2].Value), //pcount
                        Convert.ToInt32(this.dataGridViewRECEIPT.Rows[i].Cells[5].Value), //pdiscountcount
                        Convert.ToDouble(this.dataGridViewRECEIPT.Rows[i].Cells[4].Value), //ptotal
                        Convert.ToDouble(this.dataGridViewRECEIPT.Rows[i].Cells[6].Value), //ptotal finall
                        r_code); //receipt_no
                }
                DASHBOARD.getDASHBOARD.dataGridViewRECEIPT.DataSource = rec_info.GET_ALL_RECEIPT_INFO();
                DASHBOARD.getDASHBOARD.dataGridViewsTATISTICS.DataSource = rec_items.GET_SALES_STATISTICS();
                DASHBOARD_WORKER.getDASHBOARD_WORKER.dataGridViewRECEIPT_WORKER.DataSource = rec_info.GET_ALL_RECEIPT_INFO();
                MessageBox.Show(" تم تسجيل الفاتورة ");
                total = 0;
                discount_total = 0;

                frm_rece.ShowDialog();
                this.Close();
                textTOTAL.Text = string.Format("{0}ج", 0);
                txtDiscount.Text = string.Format("{0}ج", 0);
                dataGridViewRECEIPT.Rows.Clear();
                txtTotalDisc.Text = string.Empty;
                textPRO_NAME.Text = string.Empty;
                textBARCODE.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
            }
        }

        private void RECEIPT_Load(object sender, EventArgs e)
        {
            total = 0;
            discount_total = 0;

            textTOTAL.Text = string.Format("{0}ج", 0);
            txtDiscount.Text = string.Format("{0}ج", 0);
            dataGridViewRECEIPT.Rows.Clear();
            txtTotalDisc.Text = string.Empty;
            textPRO_NAME.Text = string.Empty;
            textBARCODE.Text = string.Empty;
            textITEM_COUNT.Text = string.Empty;
            textITEM_PRICE.Text = string.Empty;
        }

        private void btnTypeSwitch_Click(object sender, EventArgs e)
        {
            if (is_item_inner)
            {
                is_item_inner = false;
                btnTypeSwitch.Text = " قطع خارجي ";
                textPRO_NAME.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
            }
            else
            {
                is_item_inner = true;
                btnTypeSwitch.Text = " قطع داخلي ";
                textPRO_NAME.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
            }
            DataTable Dt = new DataTable();
            Dt = product.SEARCH_PRODUCT_BARCODE(is_item_inner, textBARCODE.Text);

            if (Dt.Rows.Count > 0)
            {
                product_id = Convert.ToInt32(Dt.Rows[0][0]);
                textPRO_NAME.Text = Convert.ToString(Dt.Rows[0][1]);
                textITEM_PRICE.Text = Convert.ToString(Dt.Rows[0][2]);
                txtDiscount.Text = Convert.ToString(0);
                textITEM_COUNT.Text = Convert.ToString(1);
            }
            else {
                textPRO_NAME.Text = string.Empty;
                textITEM_COUNT.Text = string.Empty;
                textITEM_PRICE.Text = string.Empty;
            }
        }

    }
}
