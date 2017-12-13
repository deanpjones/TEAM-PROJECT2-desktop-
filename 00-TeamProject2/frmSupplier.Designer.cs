namespace _00_TeamProject2
{
    partial class frmSupplier
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
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnRemoveSupplier = new System.Windows.Forms.Button();
            this.tabSupplierControl = new System.Windows.Forms.TabControl();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.grpEditSupplier = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditSupName = new System.Windows.Forms.TextBox();
            this.txtEditSupID = new System.Windows.Forms.TextBox();
            this.btnEditSupplierOK = new System.Windows.Forms.Button();
            this.btnEditSupplierCancel = new System.Windows.Forms.Button();
            this.grpSortBy = new System.Windows.Forms.GroupBox();
            this.radSortName = new System.Windows.Forms.RadioButton();
            this.radSortID = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpAddSupplier = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabSupplierControl.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            this.grpEditSupplier.SuspendLayout();
            this.grpSortBy.SuspendLayout();
            this.grpAddSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSupID
            // 
            this.txtSupID.Location = new System.Drawing.Point(161, 26);
            this.txtSupID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(328, 23);
            this.txtSupID.TabIndex = 0;
            this.txtSupID.Tag = "Supplier Id Input";
            this.txtSupID.TextChanged += new System.EventHandler(this.txtSupID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 16;
            this.lstSuppliers.Items.AddRange(new object[] {
            "aaa"});
            this.lstSuppliers.Location = new System.Drawing.Point(201, 157);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(328, 372);
            this.lstSuppliers.TabIndex = 0;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(496, 23);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(96, 29);
            this.btnAddSupplier.TabIndex = 2;
            this.btnAddSupplier.Text = "&Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(536, 157);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(96, 29);
            this.btnEditSupplier.TabIndex = 1;
            this.btnEditSupplier.Text = "&Edit";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnRemoveSupplier
            // 
            this.btnRemoveSupplier.Location = new System.Drawing.Point(536, 192);
            this.btnRemoveSupplier.Name = "btnRemoveSupplier";
            this.btnRemoveSupplier.Size = new System.Drawing.Size(96, 29);
            this.btnRemoveSupplier.TabIndex = 2;
            this.btnRemoveSupplier.Text = "&Remove";
            this.btnRemoveSupplier.UseVisualStyleBackColor = true;
            this.btnRemoveSupplier.Click += new System.EventHandler(this.btnRemoveSupplier_Click);
            // 
            // tabSupplierControl
            // 
            this.tabSupplierControl.Controls.Add(this.tabSuppliers);
            this.tabSupplierControl.Location = new System.Drawing.Point(2, 2);
            this.tabSupplierControl.Name = "tabSupplierControl";
            this.tabSupplierControl.SelectedIndex = 0;
            this.tabSupplierControl.Size = new System.Drawing.Size(750, 730);
            this.tabSupplierControl.TabIndex = 0;
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.BackColor = System.Drawing.Color.Silver;
            this.tabSuppliers.Controls.Add(this.grpEditSupplier);
            this.tabSuppliers.Controls.Add(this.grpSortBy);
            this.tabSuppliers.Controls.Add(this.label5);
            this.tabSuppliers.Controls.Add(this.lblInfo);
            this.tabSuppliers.Controls.Add(this.grpAddSupplier);
            this.tabSuppliers.Controls.Add(this.lstSuppliers);
            this.tabSuppliers.Controls.Add(this.btnRemoveSupplier);
            this.tabSuppliers.Controls.Add(this.btnEditSupplier);
            this.tabSuppliers.Controls.Add(this.label3);
            this.tabSuppliers.Controls.Add(this.label2);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabSuppliers.Size = new System.Drawing.Size(742, 701);
            this.tabSuppliers.TabIndex = 0;
            this.tabSuppliers.Text = "Suppliers";
            // 
            // grpEditSupplier
            // 
            this.grpEditSupplier.Controls.Add(this.label6);
            this.grpEditSupplier.Controls.Add(this.label7);
            this.grpEditSupplier.Controls.Add(this.txtEditSupName);
            this.grpEditSupplier.Controls.Add(this.txtEditSupID);
            this.grpEditSupplier.Controls.Add(this.btnEditSupplierOK);
            this.grpEditSupplier.Controls.Add(this.btnEditSupplierCancel);
            this.grpEditSupplier.Location = new System.Drawing.Point(40, 535);
            this.grpEditSupplier.Name = "grpEditSupplier";
            this.grpEditSupplier.Size = new System.Drawing.Size(640, 129);
            this.grpEditSupplier.TabIndex = 10;
            this.grpEditSupplier.TabStop = false;
            this.grpEditSupplier.Text = "Edit Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "ID:";
            // 
            // txtEditSupName
            // 
            this.txtEditSupName.Location = new System.Drawing.Point(161, 57);
            this.txtEditSupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSupName.Name = "txtEditSupName";
            this.txtEditSupName.Size = new System.Drawing.Size(328, 23);
            this.txtEditSupName.TabIndex = 1;
            this.txtEditSupName.Tag = "Supplier Name Input";
            // 
            // txtEditSupID
            // 
            this.txtEditSupID.Enabled = false;
            this.txtEditSupID.Location = new System.Drawing.Point(161, 26);
            this.txtEditSupID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditSupID.Name = "txtEditSupID";
            this.txtEditSupID.Size = new System.Drawing.Size(328, 23);
            this.txtEditSupID.TabIndex = 0;
            this.txtEditSupID.Tag = "Supplier Id Input";
            // 
            // btnEditSupplierOK
            // 
            this.btnEditSupplierOK.Location = new System.Drawing.Point(292, 87);
            this.btnEditSupplierOK.Name = "btnEditSupplierOK";
            this.btnEditSupplierOK.Size = new System.Drawing.Size(96, 29);
            this.btnEditSupplierOK.TabIndex = 3;
            this.btnEditSupplierOK.Text = "OK";
            this.btnEditSupplierOK.UseVisualStyleBackColor = true;
            this.btnEditSupplierOK.Click += new System.EventHandler(this.btnEditSupplierOK_Click);
            // 
            // btnEditSupplierCancel
            // 
            this.btnEditSupplierCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditSupplierCancel.Location = new System.Drawing.Point(394, 87);
            this.btnEditSupplierCancel.Name = "btnEditSupplierCancel";
            this.btnEditSupplierCancel.Size = new System.Drawing.Size(96, 29);
            this.btnEditSupplierCancel.TabIndex = 4;
            this.btnEditSupplierCancel.Text = "Cancel";
            this.btnEditSupplierCancel.UseVisualStyleBackColor = true;
            this.btnEditSupplierCancel.Click += new System.EventHandler(this.btnEditSupplierCancel_Click);
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.radSortName);
            this.grpSortBy.Controls.Add(this.radSortID);
            this.grpSortBy.Location = new System.Drawing.Point(40, 157);
            this.grpSortBy.Name = "grpSortBy";
            this.grpSortBy.Size = new System.Drawing.Size(144, 92);
            this.grpSortBy.TabIndex = 10;
            this.grpSortBy.TabStop = false;
            this.grpSortBy.Tag = "SupName";
            this.grpSortBy.Text = "Sort by";
            // 
            // radSortName
            // 
            this.radSortName.AutoSize = true;
            this.radSortName.Location = new System.Drawing.Point(34, 48);
            this.radSortName.Name = "radSortName";
            this.radSortName.Size = new System.Drawing.Size(62, 20);
            this.radSortName.TabIndex = 1;
            this.radSortName.TabStop = true;
            this.radSortName.Text = "Name";
            this.radSortName.UseVisualStyleBackColor = true;
            this.radSortName.CheckedChanged += new System.EventHandler(this.radSortName_CheckedChanged);
            // 
            // radSortID
            // 
            this.radSortID.AutoSize = true;
            this.radSortID.Location = new System.Drawing.Point(34, 22);
            this.radSortID.Name = "radSortID";
            this.radSortID.Size = new System.Drawing.Size(40, 20);
            this.radSortID.TabIndex = 0;
            this.radSortID.TabStop = true;
            this.radSortID.Text = "ID";
            this.radSortID.UseVisualStyleBackColor = true;
            this.radSortID.CheckedChanged += new System.EventHandler(this.radSortID_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Info:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(83, 667);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(82, 16);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "label info...";
            // 
            // grpAddSupplier
            // 
            this.grpAddSupplier.Controls.Add(this.label4);
            this.grpAddSupplier.Controls.Add(this.label1);
            this.grpAddSupplier.Controls.Add(this.txtSupName);
            this.grpAddSupplier.Controls.Add(this.btnAddSupplier);
            this.grpAddSupplier.Controls.Add(this.txtSupID);
            this.grpAddSupplier.Location = new System.Drawing.Point(40, 16);
            this.grpAddSupplier.Name = "grpAddSupplier";
            this.grpAddSupplier.Size = new System.Drawing.Size(640, 105);
            this.grpAddSupplier.TabIndex = 9;
            this.grpAddSupplier.TabStop = false;
            this.grpAddSupplier.Text = "Add Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(161, 57);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(328, 23);
            this.txtSupName.TabIndex = 1;
            this.txtSupName.Tag = "Supplier Name Input";
            this.txtSupName.TextChanged += new System.EventHandler(this.txtSupName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // frmSupplier
            // 
            this.AcceptButton = this.btnEditSupplierOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnEditSupplierCancel;
            this.ClientSize = new System.Drawing.Size(754, 734);
            this.Controls.Add(this.tabSupplierControl);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Information";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.tabSupplierControl.ResumeLayout(false);
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            this.grpEditSupplier.ResumeLayout(false);
            this.grpEditSupplier.PerformLayout();
            this.grpSortBy.ResumeLayout(false);
            this.grpSortBy.PerformLayout();
            this.grpAddSupplier.ResumeLayout(false);
            this.grpAddSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnRemoveSupplier;
        private System.Windows.Forms.TabControl tabSupplierControl;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.Button btnEditSupplierCancel;
        private System.Windows.Forms.Button btnEditSupplierOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAddSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.RadioButton radSortID;
        private System.Windows.Forms.GroupBox grpSortBy;
        private System.Windows.Forms.RadioButton radSortName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpEditSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditSupName;
        private System.Windows.Forms.TextBox txtEditSupID;
    }
}