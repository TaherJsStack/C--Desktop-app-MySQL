namespace mobilyAccounting.PL
{
    partial class DASHBOARD_WORKER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textSERCH_RECEIPT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddReceiptFrm = new System.Windows.Forms.Button();
            this.btnShowReceipt = new System.Windows.Forms.Button();
            this.dataGridViewRECEIPT_WORKER = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRECEIPT_WORKER)).BeginInit();
            this.SuspendLayout();
            // 
            // textSERCH_RECEIPT
            // 
            this.textSERCH_RECEIPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSERCH_RECEIPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSERCH_RECEIPT.Location = new System.Drawing.Point(183, 22);
            this.textSERCH_RECEIPT.Name = "textSERCH_RECEIPT";
            this.textSERCH_RECEIPT.Size = new System.Drawing.Size(357, 24);
            this.textSERCH_RECEIPT.TabIndex = 17;
            this.textSERCH_RECEIPT.TextChanged += new System.EventHandler(this.textSERCH_RECEIPT_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "البحث عن فاتورة بالرقم :";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Tan;
            this.groupBox5.Controls.Add(this.btnAddReceiptFrm);
            this.groupBox5.Controls.Add(this.btnShowReceipt);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 9F);
            this.groupBox5.Location = new System.Drawing.Point(41, 657);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1080, 100);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "العمليات";
            // 
            // btnAddReceiptFrm
            // 
            this.btnAddReceiptFrm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddReceiptFrm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddReceiptFrm.Location = new System.Drawing.Point(890, 35);
            this.btnAddReceiptFrm.Name = "btnAddReceiptFrm";
            this.btnAddReceiptFrm.Size = new System.Drawing.Size(116, 46);
            this.btnAddReceiptFrm.TabIndex = 1;
            this.btnAddReceiptFrm.Text = "اضافة فاتورة";
            this.btnAddReceiptFrm.UseVisualStyleBackColor = true;
            this.btnAddReceiptFrm.Click += new System.EventHandler(this.btnAddReceiptFrm_Click);
            // 
            // btnShowReceipt
            // 
            this.btnShowReceipt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowReceipt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnShowReceipt.Location = new System.Drawing.Point(705, 35);
            this.btnShowReceipt.Name = "btnShowReceipt";
            this.btnShowReceipt.Size = new System.Drawing.Size(156, 46);
            this.btnShowReceipt.TabIndex = 0;
            this.btnShowReceipt.Text = "عرض بيانات فاتورة";
            this.btnShowReceipt.UseVisualStyleBackColor = true;
            this.btnShowReceipt.Click += new System.EventHandler(this.btnShowReceipt_Click);
            // 
            // dataGridViewRECEIPT_WORKER
            // 
            this.dataGridViewRECEIPT_WORKER.AllowUserToAddRows = false;
            this.dataGridViewRECEIPT_WORKER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRECEIPT_WORKER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRECEIPT_WORKER.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRECEIPT_WORKER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRECEIPT_WORKER.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewRECEIPT_WORKER.Name = "dataGridViewRECEIPT_WORKER";
            this.dataGridViewRECEIPT_WORKER.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRECEIPT_WORKER.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRECEIPT_WORKER.RowTemplate.Height = 26;
            this.dataGridViewRECEIPT_WORKER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRECEIPT_WORKER.Size = new System.Drawing.Size(1142, 757);
            this.dataGridViewRECEIPT_WORKER.TabIndex = 14;
            // 
            // DASHBOARD_WORKER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 859);
            this.Controls.Add(this.textSERCH_RECEIPT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridViewRECEIPT_WORKER);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DASHBOARD_WORKER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قائمة مبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRECEIPT_WORKER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSERCH_RECEIPT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button btnAddReceiptFrm;
        private System.Windows.Forms.Button btnShowReceipt;
        public System.Windows.Forms.DataGridView dataGridViewRECEIPT_WORKER;



    }
}