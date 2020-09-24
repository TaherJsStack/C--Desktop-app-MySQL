namespace mobilyAccounting.PL
{
    partial class SHOW_ITEMS
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
            this.dataGridViewITEMS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewITEMS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewITEMS
            // 
            this.dataGridViewITEMS.AllowUserToAddRows = false;
            this.dataGridViewITEMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewITEMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewITEMS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewITEMS.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewITEMS.Name = "dataGridViewITEMS";
            this.dataGridViewITEMS.ReadOnly = true;
            this.dataGridViewITEMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewITEMS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewITEMS.RowTemplate.Height = 26;
            this.dataGridViewITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewITEMS.Size = new System.Drawing.Size(1059, 399);
            this.dataGridViewITEMS.TabIndex = 0;
            // 
            // SHOW_ITEMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 423);
            this.Controls.Add(this.dataGridViewITEMS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SHOW_ITEMS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض منتجات فاتورة";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewITEMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewITEMS;

    }
}