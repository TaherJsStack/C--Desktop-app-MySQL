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
    public partial class ADD_ACCOUNT_CASH : Form
    {

        public int acc_id = 0;

        BL.CLS_ACOUNT_CASH_INFO acc_cash = new BL.CLS_ACOUNT_CASH_INFO();
        BL.CLS_CLIENS_ACCOUNT account = new BL.CLS_CLIENS_ACCOUNT();

        public ADD_ACCOUNT_CASH()
        {
            InitializeComponent();
        }

        private void btnAddCashVal_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCashVal.Text) )
                {
                    MessageBox.Show("رجاء اضافة كل الحقول");
                }
                else
                {
                    acc_cash.ADD_CASH_TO_ACC(acc_id, txtAccType.Text, txtAccName.Text, Convert.ToDouble(txtCashVal.Text), txtCashNote.Text);
                    MessageBox.Show("تمت اضافة قيمة نقدية للحساب");
                   // BL.CLS_CLIENS_ACCOUNT account = new BL.CLS_CLIENS_ACCOUNT();
                    DASHBOARD.getDASHBOARD.dataGridViewClientsAccount.DataSource = account.GET_ALL_CLIENTS_ACCOUNT(DASHBOARD.getDASHBOARD.Is_AccType);
                    DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_CRED_Stats.DataSource = account.GET_CLIENTS_ACC_CRED_STATISTICS();
                    DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_DEBIT_Stats.DataSource = account.GET_CLIENTS_ACC_DEBIT_STATISTICS();
                    this.Close();
                }
        }

        private void txtCashVal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClosh_Click(object sender, EventArgs e)
        {
            this.Close();
        }



      
    }
}
