namespace _00_TeamProject2
{
    partial class frmEditSupplier
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEditSupName = new System.Windows.Forms.TextBox();
            this.txtEditSupID = new System.Windows.Forms.TextBox();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // txtEditSupName
            // 
            this.txtEditSupName.Location = new System.Drawing.Point(124, 62);
            this.txtEditSupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSupName.Name = "txtEditSupName";
            this.txtEditSupName.Size = new System.Drawing.Size(328, 23);
            this.txtEditSupName.TabIndex = 1;
            this.txtEditSupName.Tag = "Supplier Name Input";
            // 
            // txtEditSupID
            // 
            this.txtEditSupID.Location = new System.Drawing.Point(124, 31);
            this.txtEditSupID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSupID.Name = "txtEditSupID";
            this.txtEditSupID.Size = new System.Drawing.Size(328, 23);
            this.txtEditSupID.TabIndex = 0;
            this.txtEditSupID.Tag = "Supplier Id Input";
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditCancel.Location = new System.Drawing.Point(356, 92);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(96, 29);
            this.btnEditCancel.TabIndex = 3;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEditOK
            // 
            this.btnEditOK.Location = new System.Drawing.Point(254, 92);
            this.btnEditOK.Name = "btnEditOK";
            this.btnEditOK.Size = new System.Drawing.Size(96, 29);
            this.btnEditOK.TabIndex = 2;
            this.btnEditOK.Text = "OK";
            this.btnEditOK.UseVisualStyleBackColor = true;
            // 
            // frmEditSupplier
            // 
            this.AcceptButton = this.btnEditOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CancelButton = this.btnEditCancel;
            this.ClientSize = new System.Drawing.Size(542, 182);
            this.Controls.Add(this.btnEditCancel);
            this.Controls.Add(this.btnEditOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditSupName);
            this.Controls.Add(this.txtEditSupID);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Supplier";
            this.Load += new System.EventHandler(this.frmEditSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditSupName;
        private System.Windows.Forms.TextBox txtEditSupID;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditOK;
    }
}