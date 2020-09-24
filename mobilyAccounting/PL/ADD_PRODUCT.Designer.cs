namespace mobilyAccounting.PL
{
    partial class ADD_PRODUCT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtDesk = new System.Windows.Forms.TextBox();
            this.txtPQuant = new System.Windows.Forms.TextBox();
            this.txtPPrice = new System.Windows.Forms.TextBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSELL_PRICE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comCategory = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rdoBTN_INNER = new System.Windows.Forms.RadioButton();
            this.rdoBTN_OUTER = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label2.Location = new System.Drawing.Point(38, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم المنتج : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(74, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "الوصف : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label4.Location = new System.Drawing.Point(56, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "عدد القطع :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label5.Location = new System.Drawing.Point(47, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "سعر البيع : ";
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPName.Location = new System.Drawing.Point(183, 146);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(235, 28);
            this.txtPName.TabIndex = 3;
            this.txtPName.TextChanged += new System.EventHandler(this.txtPName_TextChanged);
            // 
            // txtDesk
            // 
            this.txtDesk.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDesk.Location = new System.Drawing.Point(183, 448);
            this.txtDesk.Multiline = true;
            this.txtDesk.Name = "txtDesk";
            this.txtDesk.Size = new System.Drawing.Size(235, 57);
            this.txtDesk.TabIndex = 8;
            // 
            // txtPQuant
            // 
            this.txtPQuant.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPQuant.Location = new System.Drawing.Point(183, 264);
            this.txtPQuant.Name = "txtPQuant";
            this.txtPQuant.Size = new System.Drawing.Size(235, 28);
            this.txtPQuant.TabIndex = 5;
            this.txtPQuant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPQuant_KeyPress);
            // 
            // txtPPrice
            // 
            this.txtPPrice.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPPrice.Location = new System.Drawing.Point(183, 387);
            this.txtPPrice.Name = "txtPPrice";
            this.txtPPrice.Size = new System.Drawing.Size(235, 28);
            this.txtPPrice.TabIndex = 7;
            this.txtPPrice.TextChanged += new System.EventHandler(this.txtPPrice_TextChanged);
            this.txtPPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPPrice_KeyPress);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddProd.Location = new System.Drawing.Point(183, 531);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(114, 45);
            this.btnAddProd.TabIndex = 9;
            this.btnAddProd.Text = "اضافة منتج";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(325, 531);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "الغاء";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(143, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(143, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(143, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "*";
            // 
            // txtSELL_PRICE
            // 
            this.txtSELL_PRICE.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSELL_PRICE.Location = new System.Drawing.Point(183, 327);
            this.txtSELL_PRICE.Name = "txtSELL_PRICE";
            this.txtSELL_PRICE.Size = new System.Drawing.Size(235, 28);
            this.txtSELL_PRICE.TabIndex = 6;
            this.txtSELL_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSELL_PRICE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(36, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "سعر الشراء : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(143, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label10.Location = new System.Drawing.Point(38, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "صنف المنتج : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(143, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "*";
            // 
            // comCategory
            // 
            this.comCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comCategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comCategory.FormattingEnabled = true;
            this.comCategory.Location = new System.Drawing.Point(183, 38);
            this.comCategory.Name = "comCategory";
            this.comCategory.Size = new System.Drawing.Size(235, 29);
            this.comCategory.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label14.Location = new System.Drawing.Point(56, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "كود المنتج : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(143, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 17);
            this.label15.TabIndex = 6;
            this.label15.Text = "*";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtProdCode.Location = new System.Drawing.Point(183, 205);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(235, 28);
            this.txtProdCode.TabIndex = 4;
            this.txtProdCode.TextChanged += new System.EventHandler(this.txtProdCode_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label12.Location = new System.Drawing.Point(89, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "النوع :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(147, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "*";
            // 
            // rdoBTN_INNER
            // 
            this.rdoBTN_INNER.AutoSize = true;
            this.rdoBTN_INNER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rdoBTN_INNER.Location = new System.Drawing.Point(307, 92);
            this.rdoBTN_INNER.Name = "rdoBTN_INNER";
            this.rdoBTN_INNER.Size = new System.Drawing.Size(115, 22);
            this.rdoBTN_INNER.TabIndex = 1;
            this.rdoBTN_INNER.TabStop = true;
            this.rdoBTN_INNER.Text = "صنف داخلي";
            this.rdoBTN_INNER.UseVisualStyleBackColor = true;
            this.rdoBTN_INNER.Click += new System.EventHandler(this.rdoBTN_INNER_Click);
            // 
            // rdoBTN_OUTER
            // 
            this.rdoBTN_OUTER.AutoSize = true;
            this.rdoBTN_OUTER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rdoBTN_OUTER.Location = new System.Drawing.Point(187, 92);
            this.rdoBTN_OUTER.Name = "rdoBTN_OUTER";
            this.rdoBTN_OUTER.Size = new System.Drawing.Size(120, 22);
            this.rdoBTN_OUTER.TabIndex = 2;
            this.rdoBTN_OUTER.TabStop = true;
            this.rdoBTN_OUTER.Text = "صنف خارجي";
            this.rdoBTN_OUTER.UseVisualStyleBackColor = true;
            this.rdoBTN_OUTER.Click += new System.EventHandler(this.rdoBTN_OUTER_Click);
            // 
            // ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 604);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.rdoBTN_OUTER);
            this.Controls.Add(this.rdoBTN_INNER);
            this.Controls.Add(this.comCategory);
            this.Controls.Add(this.txtSELL_PRICE);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.txtPPrice);
            this.Controls.Add(this.txtPQuant);
            this.Controls.Add(this.txtDesk);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADD_PRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtPName;
        public System.Windows.Forms.TextBox txtDesk;
        public System.Windows.Forms.TextBox txtPQuant;
        public System.Windows.Forms.TextBox txtPPrice;
        public System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtSELL_PRICE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comCategory;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.RadioButton rdoBTN_INNER;
        public System.Windows.Forms.RadioButton rdoBTN_OUTER;
    }
}