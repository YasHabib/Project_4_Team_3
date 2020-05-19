using Project_4_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_Application
{
    public partial class frmAddPackage : Form
    {
        
        public frmAddPackage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Packages newPackage = new Packages();
            newPackage.PkgName = txtName.Text;
            newPackage.PkgDesc = txtDesc.Text;
            newPackage.PkgStartDate = Convert.ToDateTime(maskedTxtStart.Text);
            newPackage.PkgEndDate = Convert.ToDateTime(maskedTxtEnd.Text);
            newPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
            newPackage.PkgAgencyCommission = Convert.ToDecimal(txtCommision.Text);

            try
            {
                newPackage.PackgeId = PackageDB.AddPackage(newPackage);
                this.DialogResult = DialogResult.OK; // OK if Insert was successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            Refresh();

        }//end of Add click
        //Close this form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDesc.Text = "";
            maskedTxtStart.Text = "";
            maskedTxtEnd.Text = "";
            txtBasePrice.Text = "";
            txtCommision.Text = "";
        }


    }//end of form
}//
