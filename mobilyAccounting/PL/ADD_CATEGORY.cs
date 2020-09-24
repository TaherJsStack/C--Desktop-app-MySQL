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
    public partial class ADD_CATEGORY : Form
    {

        bool is_cate = false;

        BL.CLS_CATEGORY cate = new BL.CLS_CATEGORY();


        public ADD_CATEGORY()
        {
            InitializeComponent();
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            if ( String.IsNullOrEmpty(txtDName.Text) )
            {
                MessageBox.Show("رجاء اضافة اسم القسم ");
            }
            else
            {
                if (!is_cate)
                {
                    cate.ADD_CATEGORY(txtDName.Text, txtDDeskreption.Text);
                    MessageBox.Show("تمت اضافة قسم ");
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("اسم القسم موجود..."); // just showing message but user can add exist name
                    txtDName.Focus();
                    txtDName.SelectionStart = 0;
                    txtDName.SelectionLength = txtDName.TextLength;
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDName_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = cate.CHECk_IS_CATEGORY_EXISTS(txtDName.Text);
            if (Dt.Rows.Count > 0)
            {
                MessageBox.Show("اسم القسم موجود..."); // just showing message but user can add exist name
                is_cate = true; // don't let user add new category with same name exist
                txtDName.Focus();
                txtDName.SelectionStart = 0;
                txtDName.SelectionLength = txtDName.TextLength;
            }
            else
            {
                is_cate = false;
            }
        }
    }
}
