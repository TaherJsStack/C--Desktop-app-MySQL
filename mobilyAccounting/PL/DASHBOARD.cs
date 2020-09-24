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
    public partial class DASHBOARD : Form
    {
        public bool is_item_inner = true;
        public string Is_AccType = "دائن";

        BL.CLS_PRODUCTS prod = new BL.CLS_PRODUCTS();
        BL.CLS_REPAIRING repair = new BL.CLS_REPAIRING();
        BL.CLS_CLIENS_ACCOUNT account = new BL.CLS_CLIENS_ACCOUNT();
        BL.CLS_RECEIPT_INFO receipt_info = new BL.CLS_RECEIPT_INFO();
        BL.CLS_RECEIPT_ITEMS receipt_cls = new BL.CLS_RECEIPT_ITEMS();
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
       
        PL.RECEIPT receipt = new PL.RECEIPT();
        PL.ADD_DEVICE device = new PL.ADD_DEVICE();
        PL.ADD_CLIENT_ACCOUNT pl_account = new PL.ADD_CLIENT_ACCOUNT();
        PL.LOGIN loginPl = new PL.LOGIN();
        PL.ADD_ACCOUNT_RECEIPT acount_rece = new PL.ADD_ACCOUNT_RECEIPT();

        private static DASHBOARD frm_dash;

        static void frm_FormClosed(object sender, EventArgs e)
        {
            frm_dash = null;
        }

        // TO MACK UPDATE ENABLE LIKE REAL TIME FROM ANY OTHER FORM
        public static DASHBOARD getDASHBOARD
        {
            get
            {
                if (frm_dash == null)
                {
                    frm_dash = new DASHBOARD();
                    frm_dash.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm_dash;
            }
        }

        public DASHBOARD()
        {
            if (frm_dash == null)
                frm_dash = this;

            InitializeComponent();
            btnTypeSwitch.Text = " قطع داخلي";
            labelProdType.Text = btnTypeSwitch.Text;
            dataGridViewPROD.DataSource = prod.GET_ALL_PRODUCTS(is_item_inner);

            repairDataGridView.DataSource                  = repair.GET_ALL_REPAIRING();
            dataGridViewRECEIPT.DataSource             = receipt_info.GET_ALL_RECEIPT_INFO();
            dataGridViewClientsAccount.DataSource     = account.GET_ALL_CLIENTS_ACCOUNT(btnChangAccType.Text);
            dataGridViewsTATISTICS.DataSource         = receipt_cls.GET_SALES_STATISTICS();
            dataGridViewRepairStats.DataSource          = repair.GET_REPAIR_STATISTICS();
            dataGridViewProdsStats.DataSource           = prod.GET_PRODUCTS_STATISTICS();
            dataGridViewClients_Acc_CRED_Stats.DataSource = account.GET_CLIENTS_ACC_CRED_STATISTICS();
            dataGridViewClients_Acc_DEBIT_Stats.DataSource = account.GET_CLIENTS_ACC_DEBIT_STATISTICS();
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
            labelProdType.Text = btnTypeSwitch.Text;
            dataGridViewPROD.DataSource = prod.GET_ALL_PRODUCTS(is_item_inner);

            //MessageBox.Show(Convert.ToString(is_item_inner));
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            PL.ADD_CATEGORY add_category = new PL.ADD_CATEGORY();
            add_category.ShowDialog();
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            receipt.ShowDialog();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            PL.ADD_PRODUCT prod_frm = new PL.ADD_PRODUCT();
            prod_frm.ShowDialog();
        }

        private void btnUpdateProd_Click(object sender, EventArgs e)
        {
            if (dataGridViewPROD.RowCount > 0)
            {
                PL.ADD_PRODUCT frm_prod = new PL.ADD_PRODUCT();
                frm_prod.Text = "تحديث بيانات  : " + frm_prod.txtPName.Text;
                frm_prod.btnAddProd.Text = "تحديث بيانات";
                frm_prod.form_state = "update";
                frm_prod.is_item_inner_add_prod = is_item_inner;
                
                frm_prod.txtPName.Text          = this.dataGridViewPROD.CurrentRow.Cells[1].Value.ToString();
                frm_prod.txtPPrice.Text           = this.dataGridViewPROD.CurrentRow.Cells[2].Value.ToString();
                frm_prod.txtSELL_PRICE.Text = this.dataGridViewPROD.CurrentRow.Cells[3].Value.ToString();
                frm_prod.txtPQuant.Text          = this.dataGridViewPROD.CurrentRow.Cells[4].Value.ToString();
                frm_prod.txtProdCode.Text      = this.dataGridViewPROD.CurrentRow.Cells[8].Value.ToString();
                frm_prod.comCategory.Text    = this.dataGridViewPROD.CurrentRow.Cells[10].Value.ToString();
                frm_prod.txtDesk.Text             = this.dataGridViewPROD.CurrentRow.Cells[11].Value.ToString();
                frm_prod.product_id              = Convert.ToInt32(this.dataGridViewPROD.CurrentRow.Cells[0].Value);

                if (Convert.ToBoolean(this.dataGridViewPROD.CurrentRow.Cells[9].Value) == true)
                {
                    frm_prod.rdoBTN_INNER.Checked = true;
                }
                else
                {
                    frm_prod.rdoBTN_OUTER.Checked = true; 
                }

                frm_prod.ShowDialog();
                //MessageBox.Show(Convert.ToString(this.dataGridViewPROD.CurrentRow.Cells[9].Value));
            }
            else 
            {
                MessageBox.Show("عفوا لا توجد منتجات للتعديل");
            }

        }

        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (dataGridViewPROD.RowCount > 0)
            {
                if (MessageBox.Show("هل تريد اتمام عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prod.DELETE_PRODUCT(Convert.ToInt32(this.dataGridViewPROD.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم الحذف");
                    dataGridViewPROD.DataSource = prod.GET_ALL_PRODUCTS(is_item_inner);
                    dataGridViewsTATISTICS.DataSource = receipt_cls.GET_SALES_STATISTICS();
                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف");
                }
            }
            else
            {
                MessageBox.Show("عفوا لا توجد منتجات ");
            }

        }
       
        private void txtSearchByCode_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prod.SEARCH_PRODUCT_BY_CODE(is_item_inner, Convert.ToString(txtSearchByCode.Text));
            if (Dt.Rows.Count > 0)
            {
                dataGridViewPROD.DataSource = Dt;
            }
            else
            {
                dataGridViewPROD.DataSource = prod.GET_ALL_PRODUCTS(is_item_inner);
            }
        }
       

        ///
        ///  prepair tab
        ///
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            device.ShowDialog();
        }

        private void btnEditDevice_Click(object sender, EventArgs e)
        {
            if (repairDataGridView.RowCount > 0)
            {
                PL.ADD_DEVICE frm_prepair = new PL.ADD_DEVICE();

                frm_prepair.device_id = Convert.ToInt32(this.repairDataGridView.CurrentRow.Cells[0].Value);
                frm_prepair.Text = "تحديث بيانات  : " + frm_prepair.textNAME.Text;
                frm_prepair.btnADD_DEVICE.Text = "تحديث بيانات  ";
                frm_prepair.form_state = "update";

                frm_prepair.textNAME.Text = this.repairDataGridView.CurrentRow.Cells[1].Value.ToString();
                frm_prepair.textPHONE_NO.Text = this.repairDataGridView.CurrentRow.Cells[2].Value.ToString();
                frm_prepair.textDEVICE_NAME.Text = this.repairDataGridView.CurrentRow.Cells[3].Value.ToString();
                frm_prepair.textDEVICE_TYPE.Text = this.repairDataGridView.CurrentRow.Cells[4].Value.ToString();
                frm_prepair.textDEVICE_REPIR.Text = this.repairDataGridView.CurrentRow.Cells[5].Value.ToString();
                frm_prepair.txtCost.Text = this.repairDataGridView.CurrentRow.Cells[6].Value.ToString();
                frm_prepair.checkBAY.Checked = Convert.ToBoolean(this.repairDataGridView.CurrentRow.Cells[7].Value);
                frm_prepair.checkREPAIR.Checked = Convert.ToBoolean(this.repairDataGridView.CurrentRow.Cells[8].Value);
                frm_prepair.checkDELEVRED.Checked = Convert.ToBoolean(this.repairDataGridView.CurrentRow.Cells[9].Value);
                frm_prepair.textNOTE.Text = this.repairDataGridView.CurrentRow.Cells[10].Value.ToString();

                frm_prepair.ShowDialog();
            }
            else
            {
                MessageBox.Show(" عفوا لا توجد اجهزة ف الصيانه");
            }
        }

        private void btnShowDevice_Click(object sender, EventArgs e)
        {
            BL.CLS_REPAIRING repai = new BL.CLS_REPAIRING();
            PL.SHOW_DEVICE_REPAIRING device_repai = new PL.SHOW_DEVICE_REPAIRING();
            
            if (repairDataGridView.RowCount > 0)
            {
                device_repai.txtCName.Text = repairDataGridView.CurrentRow.Cells[1].Value.ToString();
                device_repai.txtCPhone.Text = repairDataGridView.CurrentRow.Cells[2].Value.ToString();
                device_repai.txtRepai.Text = repairDataGridView.CurrentRow.Cells[5].Value.ToString();
                device_repai.txtDate.Text = repairDataGridView.CurrentRow.Cells[11].Value.ToString();
                device_repai.txtNot.Text = repairDataGridView.CurrentRow.Cells[10].Value.ToString();

                device_repai.ShowDialog();
            }
            else
            {
                MessageBox.Show(" عفوا لا توجد اجهزة ف الصيانه");
            }
        }

        private void btnDeleteDecive_Click(object sender, EventArgs e)
        {
            if (repairDataGridView.RowCount > 0)
            {
                if (MessageBox.Show("هل تريد اتمام عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    repair.DELETE_DEVICE(Convert.ToInt32(this.repairDataGridView.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم الحذف");
                    this.repairDataGridView.DataSource = repair.GET_ALL_REPAIRING();
                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف");
                }
            }
            else
            {
                MessageBox.Show(" عفوا لا توجد اجهزة ف الصيانه");
            }
        }

        private void txtSearchDevice_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = repair.SEARCH_REPAIRING(txtSearchDevice.Text); // by client name
            if (Dt.Rows.Count > 0)
            {
                this.repairDataGridView.DataSource = Dt;
            }
            else
            {
                this.repairDataGridView.DataSource = repair.GET_ALL_REPAIRING();
            }
        }

        
        /////
        ///    receipt tab
        /////
        private void btnAddReceiptFrm_Click(object sender, EventArgs e)
        {
            receipt.ShowDialog();
        }

        private void btnShowReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridViewRECEIPT.RowCount <= 0)
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
            else
            {
                BL.CLS_RECEIPT_ITEMS receipt_items = new BL.CLS_RECEIPT_ITEMS();
                PL.SHOW_ITEMS items = new PL.SHOW_ITEMS();
                DataTable Dt = new DataTable();
                Dt = receipt_items.SEARCH_RECEIPT_ITEMS(Convert.ToString(this.dataGridViewRECEIPT.CurrentRow.Cells[5].Value));
                if (Dt.Rows.Count > 0)
                {
                    items.dataGridViewITEMS.DataSource = Dt;
                }
                items.ShowDialog();
            }

        }

        private void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridViewRECEIPT.RowCount > 0)
            {
                if (MessageBox.Show("هل تريد اتمام عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    receipt_info.DELETE_I_RECEIPT(Convert.ToInt32(this.dataGridViewRECEIPT.CurrentRow.Cells[0].Value));
                    MessageBox.Show("تم الحذف");
                    this.dataGridViewRECEIPT.DataSource = receipt_info.GET_ALL_RECEIPT_INFO();
                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف");
                }
            }
            else
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
        }


        /// 
        ///  setting tab  //////////////
        ///


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            pl_account.txtADesk.Text          = string.Empty;
            pl_account.txtAStoreName.Text = string.Empty;
            pl_account.txtEmpName.Text    = string.Empty;
            pl_account.txtEmpPhone.Text   = string.Empty;
            pl_account.ShowDialog();
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsAccount.RowCount > 0 && dataGridViewClientsAccount.RowCount != 0)
            {

                pl_account.account_id = Convert.ToInt32(this.dataGridViewClientsAccount.CurrentRow.Cells[0].Value);
                pl_account.Text = "تحديث بيانات  : " + pl_account.txtEmpName.Text;
                pl_account.btnAddAccount.Text = "تحديث بيانات  ";
                pl_account.form_state = "update";

                pl_account.txtAStoreName.Text      = this.dataGridViewClientsAccount.CurrentRow.Cells[1].Value.ToString();
                pl_account.txtEmpName.Text          = this.dataGridViewClientsAccount.CurrentRow.Cells[2].Value.ToString();
                pl_account.txtEmpPhone.Text         = this.dataGridViewClientsAccount.CurrentRow.Cells[3].Value.ToString();
                pl_account.txtADesk.Text               = this.dataGridViewClientsAccount.CurrentRow.Cells[8].Value.ToString();
                pl_account.comAType.Text             = this.dataGridViewClientsAccount.CurrentRow.Cells[4].Value.ToString();
                //pl_account.checkAActive.Checked = Convert.ToBoolean(this.dataGridViewClientsAccount.CurrentRow.Cells[7].Value);

                pl_account.ShowDialog();
            }
            else
            {
                MessageBox.Show(" عفوا لا يوجد عملاء");
            }
        }

        private void btnAddAccountReceipt_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsAccount.RowCount > 0 && dataGridViewClientsAccount.RowCount != 0)
            {
                acount_rece.account_id = Convert.ToInt32(dataGridViewClientsAccount.CurrentRow.Cells[0].Value);
                acount_rece.txtCompanyName.Text = dataGridViewClientsAccount.CurrentRow.Cells[1].Value.ToString();
                acount_rece.txtClientName.Text       = dataGridViewClientsAccount.CurrentRow.Cells[2].Value.ToString();
                acount_rece.txtClientPhone.Text      = dataGridViewClientsAccount.CurrentRow.Cells[3].Value.ToString();
                acount_rece.txtAcountType.Text      = dataGridViewClientsAccount.CurrentRow.Cells[4].Value.ToString();
            
                acount_rece.ShowDialog();
            }
            else
            {
                MessageBox.Show(" عفوا لا يوجد عملاء");
            }
        }

        private void btnShowAccRece_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsAccount.RowCount <= 0)
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
            else
            {
                BL.CLS_ACOUNT_RECEIPT_INFO acc_receipt_items = new BL.CLS_ACOUNT_RECEIPT_INFO();
                PL.SHOW_ACC_RECE items = new PL.SHOW_ACC_RECE();
                DataTable Dt = new DataTable();
                Dt = acc_receipt_items.GET_ALL_ACCOUNT_RECEIPT(Convert.ToInt32(this.dataGridViewClientsAccount.CurrentRow.Cells[0].Value));
                if (Dt.Rows.Count > 0)
                {
                    items.dataGridViewAccReceInfo.DataSource = Dt;
                }
                items.ShowDialog();
            }
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsAccount.RowCount <= 0)
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
            else
            {
                PL.ADD_ACCOUNT_CASH acc_cash = new PL.ADD_ACCOUNT_CASH();
                
                acc_cash.acc_id               = Convert.ToInt32(this.dataGridViewClientsAccount.CurrentRow.Cells[0].Value);
                acc_cash.txtAccName.Text = Convert.ToString(this.dataGridViewClientsAccount.CurrentRow.Cells[2].Value);
                acc_cash.txtAccType.Text  = Convert.ToString(this.dataGridViewClientsAccount.CurrentRow.Cells[4].Value);

                acc_cash.ShowDialog();
            }
        }

        private void btnShowCash_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientsAccount.RowCount <= 0)
            {
                MessageBox.Show("عفوا لا توجد فواتير");
            }
            else
            {
                BL.CLS_ACOUNT_CASH_INFO acc_cash_info = new BL.CLS_ACOUNT_CASH_INFO();
                PL.SHOW_ACC_CASH acc_cash = new PL.SHOW_ACC_CASH();

                DataTable Dt = new DataTable();
                Dt = acc_cash_info.GET_ALL_ACCOUNT_CASH(Convert.ToInt32(this.dataGridViewClientsAccount.CurrentRow.Cells[0].Value));
                if (Dt.Rows.Count > 0)
                {
                    acc_cash.dataGridViewAccCash.DataSource = Dt;
                }
                acc_cash.ShowDialog();
            }

        }

        private void btnChangAccType_Click(object sender, EventArgs e)
        {
            if (Is_AccType == "دائن")
            {
                Is_AccType = "مدين";
                btnChangAccType.Text = "مدين";
            }
            else
            {
                Is_AccType = "دائن";
                btnChangAccType.Text = "دائن";
            }
            dataGridViewClientsAccount.DataSource = account.GET_ALL_CLIENTS_ACCOUNT(btnChangAccType.Text);
        }

        private void textSERCH_RECEIPT_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = receipt_info.SEARCH_RECEIPT_BY_NO(Convert.ToString(textSERCH_RECEIPT.Text));
            if (Dt.Rows.Count > 0)
            {
                this.dataGridViewRECEIPT.DataSource = Dt;
            }
            else
            {
                this.dataGridViewRECEIPT.DataSource = receipt_info.GET_ALL_RECEIPT_INFO();
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // login.
            if (String.IsNullOrEmpty(txtUName.Text) || String.IsNullOrEmpty( txtOld_Pass.Text ) || String.IsNullOrEmpty( txtNew_Pass.Text ) || String.IsNullOrEmpty(txtConfPass.Text))
            {
                MessageBox.Show("رجاء اضافة كل الحقول");
            }
            else
            {
                DataTable Dt = new DataTable();
                Dt = login.CHECK_PASSWORD(txtUName.Text, txtOld_Pass.Text);
                if (Dt.Rows.Count == 1)
                {
                    if (String.IsNullOrEmpty(txtOld_Pass.Text) || String.IsNullOrEmpty(txtConfPass.Text))
                    {
                        MessageBox.Show("رجاء اضافة كل الحقول");
                    }
                    else
                    {
                        string value1 = txtNew_Pass.Text.Trim();
                        string value2 = txtConfPass.Text.Trim();
                        if (value1 == value2)
                        {
                            PL.LOGIN pl_login = new PL.LOGIN();

                            login.UPDATE_PASSWORD(Convert.ToInt32(Dt.Rows[0][0]), txtConfPass.Text);
                            MessageBox.Show("تم تعديل كلمة السر");
                            this.Hide();
                            pl_login.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("كلمة السر غير متطابقة ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("كلمة السر ليست صحيحه ");
                }
            }
        }

       






    }
}
