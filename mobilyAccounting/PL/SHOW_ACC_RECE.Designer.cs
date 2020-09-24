namespace mobilyAccounting.PL
{
    partial class SHOW_ACC_RECE
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
            this.dataGridViewAccReceInfo = new System.Windows.Forms.DataGridView();
            this.btnShowBillInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccReceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccReceInfo
            // 
            this.dataGridViewAccReceInfo.AllowUserToAddRows = false;
            this.dataGridViewAccReceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAccReceInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccReceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccReceInfo.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAccReceInfo.Name = "dataGridViewAccReceInfo";
            this.dataGridViewAccReceInfo.ReadOnly = true;
            this.dataGridViewAccReceInfo.RowTemplate.Height = 26;
            this.dataGridViewAccReceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccReceInfo.Size = new System.Drawing.Size(1009, 522);
            this.dataGridViewAccReceInfo.TabIndex = 0;
            // 
            // btnShowBillInfo
            // 
            this.btnShowBillInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowBillInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnShowBillInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowBillInfo.Location = new System.Drawing.Point(12, 550);
            this.btnShowBillInfo.Name = "btnShowBillInfo";
            this.btnShowBillInfo.Size = new System.Drawing.Size(155, 47);
            this.btnShowBillInfo.TabIndex = 5;
            this.btnShowBillInfo.Text = "عرض تفاصيل فاتورة";
            this.btnShowBillInfo.UseVisualStyleBackColor = true;
            this.btnShowBillInfo.Click += new System.EventHandler(this.btnShowBillInfo_Click);
            // 
            // SHOW_ACC_RECE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 609);
            this.Controls.Add(this.btnShowBillInfo);
            this.Controls.Add(this.dataGridViewAccReceInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SHOW_ACC_RECE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير خاصة بحساب بعميل";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccReceInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewAccReceInfo;
        public System.Windows.Forms.Button btnShowBillInfo;

    }
}