﻿namespace TravelExpert_Application
{
    partial class frmAddPackage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.txtCommision = new System.Windows.Forms.TextBox();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkAddEnd = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTxtStart = new System.Windows.Forms.MaskedTextBox();
            this.chkAddStart = new System.Windows.Forms.CheckBox();
            this.maskedTxtEnd = new System.Windows.Forms.MaskedTextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeAddStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAddEnd = new System.Windows.Forms.DateTimePicker();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(22, 226);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(104, 13);
            pkgAgencyCommissionLabel.TabIndex = 3;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(22, 200);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(61, 13);
            pkgBasePriceLabel.TabIndex = 5;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(20, 70);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(60, 13);
            pkgDescLabel.TabIndex = 7;
            pkgDescLabel.Text = "Description";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(22, 175);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(55, 13);
            pkgEndDateLabel.TabIndex = 9;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(22, 41);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(38, 13);
            pkgNameLabel.TabIndex = 11;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(22, 145);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(58, 13);
            pkgStartDateLabel.TabIndex = 13;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // txtCommision
            // 
            this.txtCommision.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgAgencyCommission", true));
            this.txtCommision.Location = new System.Drawing.Point(154, 223);
            this.txtCommision.Name = "txtCommision";
            this.txtCommision.Size = new System.Drawing.Size(200, 20);
            this.txtCommision.TabIndex = 4;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataSource = typeof(Project_4_Data.Packages);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgBasePrice", true));
            this.txtBasePrice.Location = new System.Drawing.Point(154, 197);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBasePrice.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgDesc", true));
            this.txtDesc.Location = new System.Drawing.Point(154, 67);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(200, 45);
            this.txtDesc.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgName", true));
            this.txtName.Location = new System.Drawing.Point(154, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 12;
            // 
            // chkAddEnd
            // 
            this.chkAddEnd.AutoSize = true;
            this.chkAddEnd.Location = new System.Drawing.Point(365, 175);
            this.chkAddEnd.Name = "chkAddEnd";
            this.chkAddEnd.Size = new System.Drawing.Size(84, 17);
            this.chkAddEnd.TabIndex = 16;
            this.chkAddEnd.Text = "Check if null";
            this.chkAddEnd.UseVisualStyleBackColor = true;
            this.chkAddEnd.CheckedChanged += new System.EventHandler(this.chkAddEnd_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(95, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add new package";
            // 
            // maskedTxtStart
            // 
            this.maskedTxtStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgStartDate", true));
            this.maskedTxtStart.Location = new System.Drawing.Point(515, 192);
            this.maskedTxtStart.Mask = "00/00/0000";
            this.maskedTxtStart.Name = "maskedTxtStart";
            this.maskedTxtStart.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtStart.TabIndex = 22;
            this.maskedTxtStart.ValidatingType = typeof(System.DateTime);
            // 
            // chkAddStart
            // 
            this.chkAddStart.AutoSize = true;
            this.chkAddStart.Location = new System.Drawing.Point(365, 148);
            this.chkAddStart.Name = "chkAddStart";
            this.chkAddStart.Size = new System.Drawing.Size(84, 17);
            this.chkAddStart.TabIndex = 15;
            this.chkAddStart.Text = "Check if null";
            this.chkAddStart.UseVisualStyleBackColor = true;
            this.chkAddStart.CheckedChanged += new System.EventHandler(this.chkAddStart_CheckedChanged);
            // 
            // maskedTxtEnd
            // 
            this.maskedTxtEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packagesBindingSource, "PkgEndDate", true));
            this.maskedTxtEnd.Location = new System.Drawing.Point(515, 219);
            this.maskedTxtEnd.Mask = "00/00/0000";
            this.maskedTxtEnd.Name = "maskedTxtEnd";
            this.maskedTxtEnd.Size = new System.Drawing.Size(100, 20);
            this.maskedTxtEnd.TabIndex = 23;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(515, 146);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 24;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(515, 168);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(100, 20);
            this.txtEnd.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "mm/dd/yyyy";
            // 
            // dateTimeAddStart
            // 
            this.dateTimeAddStart.Location = new System.Drawing.Point(154, 142);
            this.dateTimeAddStart.Name = "dateTimeAddStart";
            this.dateTimeAddStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAddStart.TabIndex = 27;
            // 
            // dateTimeAddEnd
            // 
            this.dateTimeAddEnd.Location = new System.Drawing.Point(154, 172);
            this.dateTimeAddEnd.Name = "dateTimeAddEnd";
            this.dateTimeAddEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAddEnd.TabIndex = 28;
            // 
            // frmAddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 318);
            this.Controls.Add(this.dateTimeAddEnd);
            this.Controls.Add(this.dateTimeAddStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.maskedTxtEnd);
            this.Controls.Add(this.maskedTxtStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkAddEnd);
            this.Controls.Add(this.chkAddStart);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.txtCommision);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(pkgStartDateLabel);
            this.Name = "frmAddPackage";
            this.Text = "Add Packages";
            this.Load += new System.EventHandler(this.frmAddPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.TextBox txtCommision;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkAddEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTxtStart;
        private System.Windows.Forms.CheckBox chkAddStart;
        private System.Windows.Forms.MaskedTextBox maskedTxtEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeAddStart;
        private System.Windows.Forms.DateTimePicker dateTimeAddEnd;
    }
}