namespace mobilyAccounting.PL
{
    partial class RECEIPT
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewRECEIPT = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPRINT_RECIPT = new System.Windows.Forms.Button();
            this.textCLIENT_NAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textCLIENT_PHONE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTypeSwitch = new System.Windows.Forms.Button();
            this.btnSaveNoPrint = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDELET_PROD_CART = new System.Windows.Forms.Button();
            this.btnADD_PROD_TO_CART = new System.Windows.Forms.Button();
            this.textITEM_COUNT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalDisc = new System.Windows.Forms.TextBox();
            this.textTOTAL = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textITEM_PRICE = new System.Windows.Forms.TextBox();
            this.textBARCODE = new System.Windows.Forms.TextBox();
            this.textPRO_NAME = new System.Windows.Forms.TextBox();
            this.الرقمDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الاسمDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الكميهDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.السعرDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.المجموعDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الخصمDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.المجموعبعدالخصمDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLSRECEIPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRECEIPT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLSRECEIPTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRECEIPT
            // 
            this.dataGridViewRECEIPT.AllowUserToAddRows = false;
            this.dataGridViewRECEIPT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRECEIPT.AutoGenerateColumns = false;
            this.dataGridViewRECEIPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRECEIPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRECEIPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.الرقمDataGridViewTextBoxColumn,
            this.الاسمDataGridViewTextBoxColumn,
            this.الكميهDataGridViewTextBoxColumn,
            this.السعرDataGridViewTextBoxColumn,
            this.المجموعDataGridViewTextBoxColumn,
            this.الخصمDataGridViewTextBoxColumn,
            this.المجموعبعدالخصمDataGridViewTextBoxColumn});
            this.dataGridViewRECEIPT.DataSource = this.cLSRECEIPTBindingSource;
            this.dataGridViewRECEIPT.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRECEIPT.Name = "dataGridViewRECEIPT";
            this.dataGridViewRECEIPT.ReadOnly = true;
            this.dataGridViewRECEIPT.RowTemplate.Height = 26;
            this.dataGridViewRECEIPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRECEIPT.Size = new System.Drawing.Size(851, 295);
            this.dataGridViewRECEIPT.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnPRINT_RECIPT);
            this.groupBox3.Controls.Add(this.textCLIENT_NAME);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textCLIENT_PHONE);
            this.groupBox3.Location = new System.Drawing.Point(12, 614);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(851, 95);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العميل";
            // 
            // btnPRINT_RECIPT
            // 
            this.btnPRINT_RECIPT.Location = new System.Drawing.Point(37, 32);
            this.btnPRINT_RECIPT.Name = "btnPRINT_RECIPT";
            this.btnPRINT_RECIPT.Size = new System.Drawing.Size(106, 47);
            this.btnPRINT_RECIPT.TabIndex = 4;
            this.btnPRINT_RECIPT.Text = "طباعة";
            this.btnPRINT_RECIPT.UseVisualStyleBackColor = true;
            this.btnPRINT_RECIPT.Click += new System.EventHandler(this.btnPRINT_RECIPT_Click);
            // 
            // textCLIENT_NAME
            // 
            this.textCLIENT_NAME.Location = new System.Drawing.Point(514, 32);
            this.textCLIENT_NAME.Name = "textCLIENT_NAME";
            this.textCLIENT_NAME.Size = new System.Drawing.Size(161, 24);
            this.textCLIENT_NAME.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "رقم الهاتف :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "اسم العميل : ";
            // 
            // textCLIENT_PHONE
            // 
            this.textCLIENT_PHONE.Location = new System.Drawing.Point(223, 34);
            this.textCLIENT_PHONE.Name = "textCLIENT_PHONE";
            this.textCLIENT_PHONE.Size = new System.Drawing.Size(141, 24);
            this.textCLIENT_PHONE.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnTypeSwitch);
            this.groupBox2.Controls.Add(this.btnSaveNoPrint);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnDELET_PROD_CART);
            this.groupBox2.Controls.Add(this.btnADD_PROD_TO_CART);
            this.groupBox2.Controls.Add(this.textITEM_COUNT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.txtTotalDisc);
            this.groupBox2.Controls.Add(this.textTOTAL);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textITEM_PRICE);
            this.groupBox2.Controls.Add(this.textBARCODE);
            this.groupBox2.Controls.Add(this.textPRO_NAME);
            this.groupBox2.Location = new System.Drawing.Point(12, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اضافة منتج للفاتورة";
            // 
            // btnTypeSwitch
            // 
            this.btnTypeSwitch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTypeSwitch.Location = new System.Drawing.Point(571, 24);
            this.btnTypeSwitch.Name = "btnTypeSwitch";
            this.btnTypeSwitch.Size = new System.Drawing.Size(114, 38);
            this.btnTypeSwitch.TabIndex = 10;
            this.btnTypeSwitch.Text = "تغيير النوع";
            this.btnTypeSwitch.UseVisualStyleBackColor = true;
            this.btnTypeSwitch.Click += new System.EventHandler(this.btnTypeSwitch_Click);
            // 
            // btnSaveNoPrint
            // 
            this.btnSaveNoPrint.Location = new System.Drawing.Point(116, 212);
            this.btnSaveNoPrint.Name = "btnSaveNoPrint";
            this.btnSaveNoPrint.Size = new System.Drawing.Size(119, 47);
            this.btnSaveNoPrint.TabIndex = 7;
            this.btnSaveNoPrint.Text = "تسجيل فاتورة";
            this.btnSaveNoPrint.UseVisualStyleBackColor = true;
            this.btnSaveNoPrint.Click += new System.EventHandler(this.btnSaveNoPrint_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label15.Location = new System.Drawing.Point(0, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(851, 10);
            this.label15.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Location = new System.Drawing.Point(0, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(845, 10);
            this.label14.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(366, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(683, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "*";
            // 
            // btnDELET_PROD_CART
            // 
            this.btnDELET_PROD_CART.Location = new System.Drawing.Point(325, 212);
            this.btnDELET_PROD_CART.Name = "btnDELET_PROD_CART";
            this.btnDELET_PROD_CART.Size = new System.Drawing.Size(164, 47);
            this.btnDELET_PROD_CART.TabIndex = 4;
            this.btnDELET_PROD_CART.Text = "حذف منتج من الفاتورة";
            this.btnDELET_PROD_CART.UseVisualStyleBackColor = true;
            this.btnDELET_PROD_CART.Click += new System.EventHandler(this.btnDELET_PROD_CART_Click);
            // 
            // btnADD_PROD_TO_CART
            // 
            this.btnADD_PROD_TO_CART.Location = new System.Drawing.Point(595, 212);
            this.btnADD_PROD_TO_CART.Name = "btnADD_PROD_TO_CART";
            this.btnADD_PROD_TO_CART.Size = new System.Drawing.Size(155, 47);
            this.btnADD_PROD_TO_CART.TabIndex = 4;
            this.btnADD_PROD_TO_CART.Text = "اضافة منتج للفاتورة";
            this.btnADD_PROD_TO_CART.UseVisualStyleBackColor = true;
            this.btnADD_PROD_TO_CART.Click += new System.EventHandler(this.btnADD_PROD_TO_CART_Click);
            // 
            // textITEM_COUNT
            // 
            this.textITEM_COUNT.Location = new System.Drawing.Point(292, 141);
            this.textITEM_COUNT.Name = "textITEM_COUNT";
            this.textITEM_COUNT.Size = new System.Drawing.Size(72, 24);
            this.textITEM_COUNT.TabIndex = 2;
            this.textITEM_COUNT.TextChanged += new System.EventHandler(this.textITEM_COUNT_TextChanged);
            this.textITEM_COUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textITEM_COUNT_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(693, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "الباركود :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "اسم المنتج :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(37, 141);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(87, 24);
            this.txtDiscount.TabIndex = 2;
            // 
            // txtTotalDisc
            // 
            this.txtTotalDisc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDisc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTotalDisc.Location = new System.Drawing.Point(290, 26);
            this.txtTotalDisc.Name = "txtTotalDisc";
            this.txtTotalDisc.ReadOnly = true;
            this.txtTotalDisc.Size = new System.Drawing.Size(76, 34);
            this.txtTotalDisc.TabIndex = 2;
            // 
            // textTOTAL
            // 
            this.textTOTAL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTOTAL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textTOTAL.Location = new System.Drawing.Point(37, 26);
            this.textTOTAL.Name = "textTOTAL";
            this.textTOTAL.ReadOnly = true;
            this.textTOTAL.Size = new System.Drawing.Size(106, 34);
            this.textTOTAL.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "عدد القطع :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(697, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "ثمن القطعه :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(122, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "الخصم : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(372, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "اجمالي الخصم :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(149, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "اجمالي المجموع :";
            // 
            // textITEM_PRICE
            // 
            this.textITEM_PRICE.Enabled = false;
            this.textITEM_PRICE.Location = new System.Drawing.Point(527, 137);
            this.textITEM_PRICE.Name = "textITEM_PRICE";
            this.textITEM_PRICE.ReadOnly = true;
            this.textITEM_PRICE.Size = new System.Drawing.Size(158, 24);
            this.textITEM_PRICE.TabIndex = 2;
            // 
            // textBARCODE
            // 
            this.textBARCODE.Location = new System.Drawing.Point(429, 94);
            this.textBARCODE.Name = "textBARCODE";
            this.textBARCODE.Size = new System.Drawing.Size(256, 24);
            this.textBARCODE.TabIndex = 2;
            this.textBARCODE.TextChanged += new System.EventHandler(this.textBARCODE_TextChanged);
            // 
            // textPRO_NAME
            // 
            this.textPRO_NAME.Enabled = false;
            this.textPRO_NAME.Location = new System.Drawing.Point(37, 94);
            this.textPRO_NAME.Name = "textPRO_NAME";
            this.textPRO_NAME.ReadOnly = true;
            this.textPRO_NAME.Size = new System.Drawing.Size(214, 24);
            this.textPRO_NAME.TabIndex = 2;
            // 
            // الرقمDataGridViewTextBoxColumn
            // 
            this.الرقمDataGridViewTextBoxColumn.DataPropertyName = "الرقم";
            this.الرقمDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.الرقمDataGridViewTextBoxColumn.Name = "الرقمDataGridViewTextBoxColumn";
            this.الرقمDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // الاسمDataGridViewTextBoxColumn
            // 
            this.الاسمDataGridViewTextBoxColumn.DataPropertyName = "الاسم";
            this.الاسمDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.الاسمDataGridViewTextBoxColumn.Name = "الاسمDataGridViewTextBoxColumn";
            this.الاسمDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // الكميهDataGridViewTextBoxColumn
            // 
            this.الكميهDataGridViewTextBoxColumn.DataPropertyName = "الكميه";
            this.الكميهDataGridViewTextBoxColumn.HeaderText = "الكميه";
            this.الكميهDataGridViewTextBoxColumn.Name = "الكميهDataGridViewTextBoxColumn";
            this.الكميهDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // السعرDataGridViewTextBoxColumn
            // 
            this.السعرDataGridViewTextBoxColumn.DataPropertyName = "السعر";
            this.السعرDataGridViewTextBoxColumn.HeaderText = "السعر";
            this.السعرDataGridViewTextBoxColumn.Name = "السعرDataGridViewTextBoxColumn";
            this.السعرDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // المجموعDataGridViewTextBoxColumn
            // 
            this.المجموعDataGridViewTextBoxColumn.DataPropertyName = "المجموع";
            this.المجموعDataGridViewTextBoxColumn.HeaderText = "المجموع";
            this.المجموعDataGridViewTextBoxColumn.Name = "المجموعDataGridViewTextBoxColumn";
            this.المجموعDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // الخصمDataGridViewTextBoxColumn
            // 
            this.الخصمDataGridViewTextBoxColumn.DataPropertyName = "الخصم";
            this.الخصمDataGridViewTextBoxColumn.HeaderText = "الخصم";
            this.الخصمDataGridViewTextBoxColumn.Name = "الخصمDataGridViewTextBoxColumn";
            this.الخصمDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // المجموعبعدالخصمDataGridViewTextBoxColumn
            // 
            this.المجموعبعدالخصمDataGridViewTextBoxColumn.DataPropertyName = "المجموع_بعد_الخصم";
            this.المجموعبعدالخصمDataGridViewTextBoxColumn.HeaderText = "المجموع_بعد_الخصم";
            this.المجموعبعدالخصمDataGridViewTextBoxColumn.Name = "المجموعبعدالخصمDataGridViewTextBoxColumn";
            this.المجموعبعدالخصمDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLSRECEIPTBindingSource
            // 
            this.cLSRECEIPTBindingSource.DataSource = typeof(mobilyAccounting.BL.CLS_RECEIPT);
            // 
            // RECEIPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 716);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewRECEIPT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RECEIPT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مبيعات";
            this.Load += new System.EventHandler(this.RECEIPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRECEIPT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLSRECEIPTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn pIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewRECEIPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكميةDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnPRINT_RECIPT;
        public System.Windows.Forms.TextBox textCLIENT_NAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textCLIENT_PHONE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveNoPrint;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnDELET_PROD_CART;
        public System.Windows.Forms.Button btnADD_PROD_TO_CART;
        public System.Windows.Forms.TextBox textITEM_COUNT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.TextBox txtTotalDisc;
        public System.Windows.Forms.TextBox textTOTAL;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textITEM_PRICE;
        public System.Windows.Forms.TextBox textBARCODE;
        private System.Windows.Forms.TextBox textPRO_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn الرقمDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الاسمDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الكميهDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn السعرDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn المجموعDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الخصمDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn المجموعبعدالخصمDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLSRECEIPTBindingSource;
        private System.Windows.Forms.Button btnTypeSwitch;
    }
}