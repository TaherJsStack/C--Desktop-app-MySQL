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
    public partial class ADD_CLIENT_ACCOUNT : Form
    {

        public string form_state = "add";
        public int account_id = 0;

        BL.CLS_CLIENS_ACCOUNT account = new BL.CLS_CLIENS_ACCOUNT();


        public ADD_CLIENT_ACCOUNT()
        {
            InitializeComponent();

            comAType.Items.Add("دائن");
            comAType.Items.Add("مدين");  

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAStoreName.Text)
                || String.IsNullOrEmpty(txtEmpName.Text)
                || String.IsNullOrEmpty(txtEmpPhone.Text)
                || String.IsNullOrEmpty(comAType.Text)
        )
            {
                MessageBox.Show("رجاء اضافة كل الحقول");
            }
            else
            {
                if (form_state == "update")
                {
                    account.UPDATE_CLIENT_ACCOUNT(account_id, txtAStoreName.Text, txtEmpName.Text, Convert.ToInt32(txtEmpPhone.Text), Convert.ToString(comAType.SelectedItem), txtADesk.Text);

                    this.Close();
                    MessageBox.Show("تم تعديل البيانات بنجاح....");
                    DASHBOARD.getDASHBOARD.dataGridViewClientsAccount.DataSource = account.GET_ALL_CLIENTS_ACCOUNT(DASHBOARD.getDASHBOARD.Is_AccType);
                    DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_CRED_Stats.DataSource = account.GET_CLIENTS_ACC_CRED_STATISTICS();
                    DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_DEBIT_Stats.DataSource = account.GET_CLIENTS_ACC_DEBIT_STATISTICS();
                }
                else
                {
                    account.ADD_CLIENT_ACCOUNT(txtAStoreName.Text, txtEmpName.Text, Convert.ToInt32(txtEmpPhone.Text), Convert.ToString(comAType.SelectedItem), txtADesk.Text);

                    this.Close();
                    MessageBox.Show("تمت اضافه حساب بنجاح....");
                    DASHBOARD.getDASHBOARD.dataGridViewClientsAccount.DataSource = account.GET_ALL_CLIENTS_ACCOUNT(DASHBOARD.getDASHBOARD.Is_AccType);
                    DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_CRED_Stats.DataSource = account.GET_CLIENTS_ACC_CRED_STATISTICS();
                    DASHBOARD.getDASHBOARD.dataGridViewClients_Acc_DEBIT_Stats.DataSource = account.GET_CLIENTS_ACC_DEBIT_STATISTICS();
                }
            }


        }

        private void txtEmpPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            txtADesk.Text          = string.Empty;
            txtAStoreName.Text = string.Empty;
            txtEmpName.Text    = string.Empty;
            txtEmpPhone.Text   = string.Empty;
        }

 






    }
}
