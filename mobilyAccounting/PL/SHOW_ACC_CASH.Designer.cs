namespace mobilyAccounting.PL
{
    partial class SHOW_ACC_CASH
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
            this.dataGridViewAccCash = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccCash)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAccCash
            // 
            this.dataGridViewAccCash.AllowUserToAddRows = false;
            this.dataGridViewAccCash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAccCash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAccCash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccCash.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAccCash.Name = "dataGridViewAccCash";
            this.dataGridViewAccCash.ReadOnly = true;
            this.dataGridViewAccCash.RowTemplate.Height = 26;
            this.dataGridViewAccCash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccCash.Size = new System.Drawing.Size(1025, 528);
            this.dataGridViewAccCash.TabIndex = 0;
            // 
            // SHOW_ACC_CASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 552);
            this.Controls.Add(this.dataGridViewAccCash);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SHOW_ACC_CASH";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عمليات نقدية خاصة بحساب";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewAccCash;

    }
}