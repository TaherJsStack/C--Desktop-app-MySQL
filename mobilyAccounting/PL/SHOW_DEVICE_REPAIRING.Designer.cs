namespace mobilyAccounting.PL
{
    partial class SHOW_DEVICE_REPAIRING
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtRepai = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(391, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "اغلاق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCName.Location = new System.Drawing.Point(132, 23);
            this.txtCName.Name = "txtCName";
            this.txtCName.ReadOnly = true;
            this.txtCName.Size = new System.Drawing.Size(298, 30);
            this.txtCName.TabIndex = 1;
            // 
            // txtCPhone
            // 
            this.txtCPhone.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCPhone.Location = new System.Drawing.Point(132, 72);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.ReadOnly = true;
            this.txtCPhone.Size = new System.Drawing.Size(298, 30);
            this.txtCPhone.TabIndex = 1;
            // 
            // txtRepai
            // 
            this.txtRepai.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtRepai.Location = new System.Drawing.Point(132, 127);
            this.txtRepai.Multiline = true;
            this.txtRepai.Name = "txtRepai";
            this.txtRepai.ReadOnly = true;
            this.txtRepai.Size = new System.Drawing.Size(298, 240);
            this.txtRepai.TabIndex = 1;
            // 
            // txtNot
            // 
            this.txtNot.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtNot.Location = new System.Drawing.Point(571, 127);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.ReadOnly = true;
            this.txtNot.Size = new System.Drawing.Size(298, 240);
            this.txtNot.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDate.Location = new System.Drawing.Point(571, 72);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(298, 30);
            this.txtDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "العطل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ملاحظات";
            // 
            // SHOW_DEVICE_REPAIRING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.txtRepai);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SHOW_DEVICE_REPAIRING";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض عطل جهاز";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtCName;
        public System.Windows.Forms.TextBox txtCPhone;
        public System.Windows.Forms.TextBox txtRepai;
        public System.Windows.Forms.TextBox txtNot;
        public System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}