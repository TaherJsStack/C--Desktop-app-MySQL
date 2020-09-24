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
    public partial class ADD_PRODUCT : Form
    {

        public string form_state = "add";
        public int product_id = 0;
        bool is_product = false;
        bool is_item_code = false;
        bool is_item_type = false;
        bool can_update = true;
        public bool is_item_inner_add_prod = true;

        BL.CLS_CATEGORY cate = new BL.CLS_CATEGORY();
        BL.CLS_PRODUCTS prod = new BL.CLS_PRODUCTS();

        public ADD_PRODUCT()
        {
            InitializeComponent();
            comCategory.DataSource = cate.GET_ALL_CATEGORIES();
            comCategory.DisplayMember = "C_NAME";
            comCategory.ValueMember = "C_ID";
            rdoBTN_INNER.Checked = is_item_inner_add_prod;
        }

        private void rdoBTN_INNER_Click(object sender, EventArgs e)
        {
            is_item_inner_add_prod = true;
            if (form_state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prod.CHECK_IS_PRODUCT_TYPE(Convert.ToString(txtPName.Text), Convert.ToString(txtProdCode.Text), is_item_inner_add_prod);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show(" المنتج موجود..."); // just showing message but user can add exist name
                }
            }
            else if (form_state == "update")
            {
                DataTable Dt = new DataTable();
                Dt = prod.CHECK_IS_PRODUCT_TYPE_AND_NAME(Convert.ToString(txtPName.Text), is_item_inner_add_prod);
                if (Dt.Rows.Count > 0)
                {

                    if (product_id != 0 && Convert.ToUInt32(Dt.Rows[0][0]) != product_id)
                    {
                        can_update = false;  // don't let user upade exsit name
                        //  MessageBox.Show(Convert.ToString(Dt.Rows[0][0]));
                        MessageBox.Show("  لا يمكن التعديل اسم الصنف موجود");
                        txtPName.Focus();
                        txtPName.SelectionStart = 0;
                        txtPName.SelectionLength = txtPName.TextLength;
                    }
                    else
                    {
                        can_update = true;  //  user can upade name
                    }
                }
                else
                {
                    can_update = true;  //  user can upade name
                }
            }
            
        }

        private void rdoBTN_OUTER_Click(object sender, EventArgs e)
        {
            is_item_inner_add_prod = false;
            if (form_state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prod.CHECK_IS_PRODUCT_TYPE(Convert.ToString(txtPName.Text), Convert.ToString(txtProdCode.Text), is_item_inner_add_prod);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show(" المنتج موجود..."); // just showing message but user can add exist name
                }
            }
            else if (form_state == "update")
            {
                DataTable Dt = new DataTable();
                Dt = prod.CHECK_IS_PRODUCT_TYPE_AND_NAME(Convert.ToString(txtPName.Text), is_item_inner_add_prod);
                if (Dt.Rows.Count > 0)
                {

                    if (product_id != 0 && Convert.ToUInt32(Dt.Rows[0][0]) != product_id)
                    {
                        can_update = false;  // don't let user upade exsit name
                        //  MessageBox.Show(Convert.ToString(Dt.Rows[0][0]));
                        MessageBox.Show("  لا يمكن التعديل اسم الصنف موجود");
                        txtPName.Focus();
                        txtPName.SelectionStart = 0;
                        txtPName.SelectionLength = txtPName.TextLength;
                    }
                    else
                    {
                        can_update = true;  //  user can upade name
                    }
                }
                else
                {
                    can_update = true;  //  user can upade name
                }
            }

            
        }



        private void btnAddProd_Click(object sender, EventArgs e)
        {
                if (
                        String.IsNullOrEmpty(txtPName.Text) || 
                        String.IsNullOrEmpty(txtPPrice.Text) || 
                        String.IsNullOrEmpty(txtPQuant.Text) ||
                        String.IsNullOrEmpty(txtSELL_PRICE.Text) ||
                        String.IsNullOrEmpty(txtProdCode.Text)  
                    )
                {
                    MessageBox.Show("رجاء اضافة كل الحقول");
                }
                else
                {

                    //MessageBox.Show("now can ADD or update ");
                    if (form_state == "add")
                    {
                            DataTable Dt = new DataTable();
                            Dt = prod.CHECK_IS_PRODUCT_TYPE(Convert.ToString(txtPName.Text), Convert.ToString(txtProdCode.Text), is_item_inner_add_prod);
                            if (Dt.Rows.Count > 0)
                            {
                                MessageBox.Show(" المنتج موجود..."); 
                            }
                            else 
                            {
                                DataTable nameDt = new DataTable();
                                nameDt = prod.CHECK_IS_PRODUCT_TYPE_AND_NAME(Convert.ToString(txtPName.Text), is_item_inner_add_prod);
                                if (nameDt.Rows.Count > 0)
                                {
                                    MessageBox.Show(" اسم الصنف موجود");
                                    txtPName.Focus();
                                    txtPName.SelectionStart = 0;
                                    txtPName.SelectionLength = txtPName.TextLength;
                                }
                                else
                                { 
                                    DataTable codeDt = new DataTable();
                                    codeDt = prod.CHECK_IS_PRODUCT_TYPE_AND_CODE(Convert.ToString(txtProdCode.Text), is_item_inner_add_prod);
                                    if (codeDt.Rows.Count > 0)
                                    {
                                        MessageBox.Show("كود الصنف موجود");
                                        txtProdCode.Focus();
                                        txtProdCode.SelectionStart = 0;
                                        txtProdCode.SelectionLength = txtProdCode.TextLength;
                                    }
                                    else
                                    {
                                        // add product method
                                        prod.ADD_PRODUCT(
                                            Convert.ToString(txtPName.Text),            //name
                                            Convert.ToDouble(txtPPrice.Text),           // price
                                            Convert.ToDouble(txtSELL_PRICE.Text), //s_price
                                            Convert.ToInt32(txtPQuant.Text),             // quantatiy
                                            Convert.ToString(txtDesk.Text),               // deskreption
                                            Convert.ToString(txtProdCode.Text),       // barcode
                                            Convert.ToInt32(comCategory.SelectedValue),  // category id
                                            Convert.ToBoolean(rdoBTN_INNER.Checked) // boolean value 
                                            );
                                        this.Close();
                                        MessageBox.Show("تمت اضافه الصنف  بنجاح....");
                                        DASHBOARD.getDASHBOARD.dataGridViewProdsStats.DataSource = prod.GET_PRODUCTS_STATISTICS();
                                        DASHBOARD.getDASHBOARD.is_item_inner = Convert.ToBoolean(rdoBTN_INNER.Checked);
                                        DASHBOARD.getDASHBOARD.dataGridViewPROD.DataSource = prod.GET_ALL_PRODUCTS(is_item_inner_add_prod);
                                    } // end of CHECK_IS_PRODUCT_TYPE_AND_CODE

                                } // end of CHECK_IS_PRODUCT_TYPE_AND_NAME
                            } // end of CHECK_IS_PRODUCT_TYPE          
                            
                         }
                        else
                        {
                            DataTable nameDt = new DataTable();
                            nameDt = prod.CHECK_IS_PRODUCT_TYPE_AND_NAME(Convert.ToString(txtPName.Text), is_item_inner_add_prod);
                            if (nameDt.Rows.Count > 0 && product_id != 0 && Convert.ToUInt32(nameDt.Rows[0][0]) != product_id)
                            {
                                MessageBox.Show(" اسم الصنف موجود");
                                txtPName.Focus();
                                txtPName.SelectionStart = 0;
                                txtPName.SelectionLength = txtPName.TextLength;
                            }
                            else
                            {
                                    
                                DataTable codeDt = new DataTable();
                                codeDt = prod.CHECK_IS_PRODUCT_TYPE_AND_CODE(Convert.ToString(txtProdCode.Text), is_item_inner_add_prod);
                                if (codeDt.Rows.Count > 0 && product_id != 0 && Convert.ToUInt32(codeDt.Rows[0][0]) != product_id)
                                {
                                    MessageBox.Show("كود الصنف موجود");
                                    txtProdCode.Focus();
                                    txtProdCode.SelectionStart = 0;
                                    txtProdCode.SelectionLength = txtProdCode.TextLength;
                                }
                                else
                                {
                                    prod.UPDATE_PRODUCT(
                                        Convert.ToInt32(product_id),
                                        Convert.ToString(txtPName.Text),
                                        Convert.ToDouble(txtPPrice.Text),
                                        Convert.ToDouble(txtSELL_PRICE.Text),
                                        Convert.ToInt32(txtPQuant.Text),
                                        Convert.ToString(txtDesk.Text),
                                        Convert.ToString(txtProdCode.Text),
                                        Convert.ToInt32(comCategory.SelectedValue),
                                        Convert.ToBoolean(rdoBTN_INNER.Checked));
                                    this.Close();
                                    MessageBox.Show("تمت تعديل الصنف  بنجاح....");
                                    DASHBOARD.getDASHBOARD.dataGridViewProdsStats.DataSource = prod.GET_PRODUCTS_STATISTICS();
                                    DASHBOARD.getDASHBOARD.is_item_inner = Convert.ToBoolean(rdoBTN_INNER.Checked);
                                    DASHBOARD.getDASHBOARD.dataGridViewPROD.DataSource = prod.GET_ALL_PRODUCTS(is_item_inner_add_prod);

                                }
                            }
                        }
                        
                  } // end of all txtbox have value

        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {
            if (form_state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prod.CHECK_IS_PRODUCT_TYPE_AND_NAME(Convert.ToString(txtPName.Text), is_item_inner_add_prod);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("اسم الصنف موجود..."); // just showing message but user can add exist name
                    is_product = true; // don't let user add new product with same name exist
                    txtPName.Focus();
                    txtPName.SelectionStart = 0;
                    txtPName.SelectionLength = txtPName.TextLength;
                }
                else
                {
                    is_product = false;
                }
            }
            else if (form_state == "update")
            {
                DataTable Dt = new DataTable();
                Dt = prod.CHECK_IS_PRODUCT_TYPE_AND_NAME(Convert.ToString(txtPName.Text), is_item_inner_add_prod);
                if (Dt.Rows.Count > 0)
                {
                    if (product_id != 0 && Convert.ToUInt32(Dt.Rows[0][0]) != product_id)
                    {
                        can_update = false;  // don't let user upade exsit name
                        //  MessageBox.Show(Convert.ToString(Dt.Rows[0][0]));
                        MessageBox.Show("  لا يمكن التعديل اسم الصنف موجود");
                        txtPName.Focus();
                        txtPName.SelectionStart = 0;
                        txtPName.SelectionLength = txtPName.TextLength;
                    }
                    else
                    {
                        can_update = true;  //  user can upade name
                    }
                }
                else
                {
                    can_update = true;  //  user can upade name
                }
            }
        }

        private void txtProdCode_TextChanged(object sender, EventArgs e)
        {
            if (form_state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prod.SEARCH_PRODUCT_BY_CODE(is_item_inner_add_prod, Convert.ToString(txtProdCode.Text));
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("كود المنتج موجود..."); // just showing message but user can add exist name
                    is_product = true; // don't let user add new product with same name exist
                    is_item_code = true;
                    txtProdCode.Focus();
                    txtProdCode.SelectionStart = 0;
                    txtProdCode.SelectionLength = txtProdCode.TextLength;
                }
                else
                {
                    is_product = false;
                    is_item_code = false;
                }
            }
            else if (form_state == "update")
            {
                DataTable Dt = new DataTable();
                Dt = prod.SEARCH_PRODUCT_BY_CODE(is_item_inner_add_prod, Convert.ToString(txtProdCode.Text));
                if (Dt.Rows.Count > 0)
                {
                    if (product_id != 0 && Convert.ToUInt32(Dt.Rows[0][0]) != product_id)
                    {
                        can_update = false;  // don't let user upade exsit name
                        is_item_code = true;
                        //  MessageBox.Show(Convert.ToString(Dt.Rows[0][0]));
                        MessageBox.Show("  لا يمكن التعديل كود المنتج موجود");
                        txtProdCode.Focus();
                        txtProdCode.SelectionStart = 0;
                        txtProdCode.SelectionLength = txtProdCode.TextLength;
                    }
                    else
                    {
                        can_update = true;  //  user can upade name
                        is_item_code = false;
                    }
                }
                else
                {
                    can_update = true;  //  user can upade name
                    is_item_code = false;
                }
            }
        }

















        private void txtSELL_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
