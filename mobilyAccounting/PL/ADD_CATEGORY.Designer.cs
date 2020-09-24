namespace mobilyAccounting.PL
{
    partial class ADD_CATEGORY
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
            this.txtDName = new System.Windows.Forms.TextBox();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDDeskreption = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = " اسم القسم :";
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDName.Location = new System.Drawing.Point(149, 54);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(236, 30);
            this.txtDName.TabIndex = 0;
            this.txtDName.TextChanged += new System.EventHandler(this.txtDName_TextChanged);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddCate.Location = new System.Drawing.Point(149, 255);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(121, 45);
            this.btnAddCate.TabIndex = 2;
            this.btnAddCate.Text = "اضافة قسم";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(292, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "الفاء ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(130, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F);
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = " وصف القسم :";
            // 
            // txtDDeskreption
            // 
            this.txtDDeskreption.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDDeskreption.Location = new System.Drawing.Point(149, 127);
            this.txtDDeskreption.Multiline = true;
            this.txtDDeskreption.Name = "txtDDeskreption";
            this.txtDDeskreption.Size = new System.Drawing.Size(236, 85);
            this.txtDDeskreption.TabIndex = 1;
            // 
            // ADD_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCate);
            this.Controls.Add(this.txtDDeskreption);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ADD_CATEGORY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاقسام";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDDeskreption;
    }
}