namespace mobilyAccounting.PL
{
    partial class ADD_ACCOUNT_CASH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.txtAccName = new System.Windows.Forms.TextBox();
            this.txtCashVal = new System.Windows.Forms.TextBox();
            this.txtCashNote = new System.Windows.Forms.TextBox();
            this.btnAddCashVal = new System.Windows.Forms.Button();
            this.btnClosh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "نوع الحساب : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(71, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "اسم العميل : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "المبلغ المضاف :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(94, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "ملاحظات : ";
            // 
            // txtAccType
            // 
            this.txtAccType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAccType.Location = new System.Drawing.Point(210, 49);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.ReadOnly = true;
            this.txtAccType.Size = new System.Drawing.Size(236, 28);
            this.txtAccType.TabIndex = 1;
            // 
            // txtAccName
            // 
            this.txtAccName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAccName.Location = new System.Drawing.Point(210, 98);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(236, 28);
            this.txtAccName.TabIndex = 1;
            // 
            // txtCashVal
            // 
            this.txtCashVal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCashVal.Location = new System.Drawing.Point(210, 143);
            this.txtCashVal.Name = "txtCashVal";
            this.txtCashVal.Size = new System.Drawing.Size(236, 28);
            this.txtCashVal.TabIndex = 0;
            this.txtCashVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashVal_KeyPress);
            // 
            // txtCashNote
            // 
            this.txtCashNote.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtCashNote.Location = new System.Drawing.Point(210, 200);
            this.txtCashNote.Multiline = true;
            this.txtCashNote.Name = "txtCashNote";
            this.txtCashNote.Size = new System.Drawing.Size(236, 107);
            this.txtCashNote.TabIndex = 1;
            // 
            // btnAddCashVal
            // 
            this.btnAddCashVal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCashVal.Location = new System.Drawing.Point(116, 397);
            this.btnAddCashVal.Name = "btnAddCashVal";
            this.btnAddCashVal.Size = new System.Drawing.Size(196, 38);
            this.btnAddCashVal.TabIndex = 3;
            this.btnAddCashVal.Text = "اضافة مبلغ للحساب ";
            this.btnAddCashVal.UseVisualStyleBackColor = true;
            this.btnAddCashVal.Click += new System.EventHandler(this.btnAddCashVal_Click);
            // 
            // btnClosh
            // 
            this.btnClosh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClosh.Location = new System.Drawing.Point(332, 397);
            this.btnClosh.Name = "btnClosh";
            this.btnClosh.Size = new System.Drawing.Size(114, 38);
            this.btnClosh.TabIndex = 4;
            this.btnClosh.Text = "الغاء";
            this.btnClosh.UseVisualStyleBackColor = true;
            this.btnClosh.Click += new System.EventHandler(this.btnClosh_Click);
            // 
            // ADD_ACCOUNT_CASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 490);
            this.Controls.Add(this.btnClosh);
            this.Controls.Add(this.btnAddCashVal);
            this.Controls.Add(this.txtCashNote);
            this.Controls.Add(this.txtCashVal);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADD_ACCOUNT_CASH";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة نقدية لحساب عميل";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCashVal;
        private System.Windows.Forms.TextBox txtCashNote;
        private System.Windows.Forms.Button btnClosh;
        public System.Windows.Forms.TextBox txtAccType;
        public System.Windows.Forms.TextBox txtAccName;
        public System.Windows.Forms.Button btnAddCashVal;
    }
}