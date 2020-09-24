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
    public partial class ADD_DEVICE : Form
    {

        public string form_state = "add";
        public int device_id = 0;

        BL.CLS_REPAIRING repair = new BL.CLS_REPAIRING();


        public ADD_DEVICE()
        {
            InitializeComponent();
        }

        private void btnADD_DEVICE_Click_1(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textNAME.Text)
                    || String.IsNullOrEmpty(textPHONE_NO.Text)
                    || String.IsNullOrEmpty(textDEVICE_NAME.Text)
                    || String.IsNullOrEmpty(textDEVICE_TYPE.Text)
                    || String.IsNullOrEmpty(textDEVICE_REPIR.Text)
                    || String.IsNullOrEmpty(txtCost.Text)
                    )
            {
                MessageBox.Show("رجاء اضافة كل الحقول");
            }
            else
            {
                if (form_state == "update")
                {
                    repair.UPDATE_DEVICE(
                        device_id, 
                        textNAME.Text, 
                        textPHONE_NO.Text, 
                        textDEVICE_NAME.Text, 
                        textDEVICE_TYPE.Text, 
                        textDEVICE_REPIR.Text,
                        Convert.ToDouble(txtCost.Text),
                        checkBAY.Checked, 
                        checkREPAIR.Checked, 
                        checkDELEVRED.Checked, 
                        textNOTE.Text);
                    this.Close();
                    MessageBox.Show("تم تعديل البيانات بنجاح....");
                    DASHBOARD.getDASHBOARD.dataGridViewRepairStats.DataSource = repair.GET_REPAIR_STATISTICS();
                    DASHBOARD.getDASHBOARD.repairDataGridView.DataSource = repair.GET_ALL_REPAIRING();
                    device_id = 0;
                    textNAME.Text = string.Empty;
                    textPHONE_NO.Text = string.Empty;
                    textDEVICE_NAME.Text = string.Empty;
                    textDEVICE_TYPE.Text = string.Empty;
                    textDEVICE_REPIR.Text = string.Empty;
                    txtCost.Text = string.Empty;
                    checkBAY.Checked = false;
                    checkREPAIR.Checked = false;
                    checkDELEVRED.Checked = false;
                    textNOTE.Text = string.Empty;
                }
                else
                {
                    repair.ADD_DEVICE(
                        textNAME.Text, 
                        textPHONE_NO.Text, 
                        textDEVICE_NAME.Text, 
                        textDEVICE_TYPE.Text, 
                        textDEVICE_REPIR.Text,
                        Convert.ToDouble(txtCost.Text),
                        checkBAY.Checked, 
                        checkREPAIR.Checked, 
                        checkDELEVRED.Checked, 
                        textNOTE.Text);
                    this.Close();
                    MessageBox.Show("تمت اضافه الجهاز بنجاح....");
                    DASHBOARD.getDASHBOARD.dataGridViewRepairStats.DataSource = repair.GET_REPAIR_STATISTICS();
                    DASHBOARD.getDASHBOARD.repairDataGridView.DataSource = repair.GET_ALL_REPAIRING();
                    device_id = 0;
                    textNAME.Text = string.Empty;
                    textPHONE_NO.Text = string.Empty;
                    textDEVICE_NAME.Text = string.Empty;
                    textDEVICE_TYPE.Text = string.Empty;
                    textDEVICE_REPIR.Text = string.Empty;
                    txtCost.Text = string.Empty;
                    checkBAY.Checked = false;
                    checkREPAIR.Checked = false;
                    checkDELEVRED.Checked = false;
                    textNOTE.Text = string.Empty;
                }
            }
        }

        private void textPHONE_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCANSEL_Click(object sender, EventArgs e)
        {
            this.Close();
            device_id = 0; 
            textNAME.Text = string.Empty; 
            textPHONE_NO.Text = string.Empty; 
            textDEVICE_NAME.Text = string.Empty;
            textDEVICE_TYPE.Text = string.Empty;
            textDEVICE_REPIR.Text = string.Empty;
            txtCost.Text = string.Empty;
            checkBAY.Checked = false; 
            checkREPAIR.Checked = false;
            checkDELEVRED.Checked = false;
            textNOTE.Text = string.Empty;
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ADD_DEVICE_Load(object sender, EventArgs e)
        {
  
        }
    

    }
}
