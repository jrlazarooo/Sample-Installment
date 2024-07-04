namespace Sample_Installment
{
    partial class frmMotor
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.txtMonthly = new System.Windows.Forms.TextBox();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.chkInstallment = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 24);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(91, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Motorcycle Model";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(268, 24);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(61, 13);
            this.lblCash.TabIndex = 1;
            this.lblCash.Text = "Cash Value";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(148, 76);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(75, 13);
            this.lblInsurance.TabIndex = 2;
            this.lblInsurance.Text = "Insurance Fee";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(139, 102);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(84, 13);
            this.lblRegistration.TabIndex = 3;
            this.lblRegistration.Text = "Registration Fee";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Location = new System.Drawing.Point(45, 141);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(88, 13);
            this.lblMonthly.TabIndex = 4;
            this.lblMonthly.Text = "Monthly Payment";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(99, 234);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(34, 13);
            this.lblCredit.TabIndex = 5;
            this.lblCredit.Text = "Credit";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(108, 176);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCash.Enabled = false;
            this.txtCash.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCash.Location = new System.Drawing.Point(208, 41);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(121, 20);
            this.txtCash.TabIndex = 7;
            // 
            // cboModel
            // 
            this.cboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(12, 40);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(121, 21);
            this.cboModel.TabIndex = 8;
            // 
            // txtInsurance
            // 
            this.txtInsurance.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtInsurance.Enabled = false;
            this.txtInsurance.Location = new System.Drawing.Point(229, 69);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.ReadOnly = true;
            this.txtInsurance.Size = new System.Drawing.Size(100, 20);
            this.txtInsurance.TabIndex = 9;
            // 
            // txtRegistration
            // 
            this.txtRegistration.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRegistration.Enabled = false;
            this.txtRegistration.Location = new System.Drawing.Point(229, 95);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.ReadOnly = true;
            this.txtRegistration.Size = new System.Drawing.Size(100, 20);
            this.txtRegistration.TabIndex = 10;
            // 
            // txtMonthly
            // 
            this.txtMonthly.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMonthly.Enabled = false;
            this.txtMonthly.Location = new System.Drawing.Point(191, 134);
            this.txtMonthly.Name = "txtMonthly";
            this.txtMonthly.ReadOnly = true;
            this.txtMonthly.Size = new System.Drawing.Size(138, 20);
            this.txtMonthly.TabIndex = 11;
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(191, 227);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(138, 20);
            this.txtCredit.TabIndex = 12;
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(191, 169);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(138, 20);
            this.txtTax.TabIndex = 13;
            // 
            // chkInstallment
            // 
            this.chkInstallment.AutoSize = true;
            this.chkInstallment.Location = new System.Drawing.Point(253, 283);
            this.chkInstallment.Name = "chkInstallment";
            this.chkInstallment.Size = new System.Drawing.Size(76, 17);
            this.chkInstallment.TabIndex = 14;
            this.chkInstallment.Text = "Installment";
            this.chkInstallment.UseVisualStyleBackColor = true;
            this.chkInstallment.CheckedChanged += new System.EventHandler(this.chkInstallment_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(254, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkInstallment);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.txtMonthly);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.txtInsurance);
            this.Controls.Add(this.cboModel);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblMonthly);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblModel);
            this.Name = "frmMotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorcycle Installmenr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.TextBox txtMonthly;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.CheckBox chkInstallment;
        private System.Windows.Forms.Button btnSave;
    }
}

