﻿namespace TravelExpert_Application
{
    partial class frmPackages
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdPackages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataSource = typeof(Project_4_Data.Packages);
            // 
            // grdPackages
            // 
            this.grdPackages.AutoGenerateColumns = false;
            this.grdPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.clmUpdate});
            this.grdPackages.DataSource = this.packagesBindingSource;
            this.grdPackages.Location = new System.Drawing.Point(8, 42);
            this.grdPackages.Name = "grdPackages";
            this.grdPackages.RowHeadersVisible = false;
            this.grdPackages.Size = new System.Drawing.Size(716, 289);
            this.grdPackages.TabIndex = 1;
            this.grdPackages.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPackages_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackgeId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = "N/A";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "N/A";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Base Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // clmUpdate
            // 
            this.clmUpdate.HeaderText = "Update";
            this.clmUpdate.Name = "clmUpdate";
            this.clmUpdate.Text = "Update";
            this.clmUpdate.UseColumnTextForButtonValue = true;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Location = new System.Drawing.Point(234, 337);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(158, 23);
            this.btnAddPackage.TabIndex = 2;
            this.btnAddPackage.Text = "&Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // frmPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 374);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.grdPackages);
            this.Name = "frmPackages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.frmPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPackages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource packagesBindingSource;
        private System.Windows.Forms.DataGridView grdPackages;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn clmUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}

