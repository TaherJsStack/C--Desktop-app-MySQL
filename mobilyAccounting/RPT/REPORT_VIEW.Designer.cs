namespace mobilyAccounting.RPT
{
    partial class REPORT_VIEW
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
            this.crvDataTable = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDataTable
            // 
            this.crvDataTable.ActiveViewIndex = -1;
            this.crvDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDataTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDataTable.Location = new System.Drawing.Point(0, 0);
            this.crvDataTable.Name = "crvDataTable";
            this.crvDataTable.Size = new System.Drawing.Size(549, 734);
            this.crvDataTable.TabIndex = 0;
            this.crvDataTable.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvDataTable.Load += new System.EventHandler(this.crvDataTable_Load);
            // 
            // REPORT_VIEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 734);
            this.Controls.Add(this.crvDataTable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "REPORT_VIEW";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "طباعة فاتورة";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDataTable;
    }
}