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
        Packages newPackage = new Packages();

        public frmAddPackage()
        {
            InitializeComponent();
        }
        private void frmAddPackage_Load(object sender, EventArgs e)
        {
            //if (chkAddStart.Checked == true)
            //    maskedTxtStart.Enabled = false;
            //if (chkAddEnd.Checked == true)
            //    maskedTxtEnd.Enabled = false;
        }
        //Start date NULL
        private void chkAddStart_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAddStart.Checked)
            //{
            //    maskedTxtStart.Enabled = false;
            //    newPackage.PkgStartDate = null;
            //}
            //else
            //{
            //    maskedTxtStart.Enabled = true;
            //}
        }
        //End date NULL
        private void chkAddEnd_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAddEnd.Checked)
            //{
            //    maskedTxtEnd.Enabled = false;
            //    newPackage.PkgEndDate = null;
            //}
            //else
            //{
            //    maskedTxtEnd.Enabled = true;
            //}
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Without validation (Works, except null)
            //newPackage.PkgName = txtName.Text;
            //newPackage.PkgDesc = txtDesc.Text;
            //newPackage.PkgStartDate = Convert.ToDateTime(maskedTxtStart.Text);
            //newPackage.PkgEndDate = Convert.ToDateTime(maskedTxtEnd.Text);
            //newPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
            //newPackage.PkgAgencyCommission = Convert.ToDecimal(txtCommision.Text);

            //Validation
            //Name and Description
            if (txtName.Text == "")
                MessageBox.Show("Please enter a name", "Input Error");
            else
                newPackage.PkgName = txtName.Text;

            if (txtDesc.Text == "")
                MessageBox.Show("Please enter a description", "Input Error");
            else
                newPackage.PkgDesc = txtDesc.Text;



            //Dates
            if (maskedTxtStart.Text == "")
                newPackage.PkgStartDate = null;
            else if (maskedTxtEnd.Text == "")
                newPackage.PkgEndDate = null;
            else
            {
                //string dateStartString = @"20/05/2012";
                //DateTime startDate = DateTime.ParseExact(dateStartString, @"d/M/yyyy",
                //    System.Globalization.CultureInfo.InvariantCulture);

                DateTime startDate = Convert.ToDateTime(maskedTxtStart.Text); //Error here
                DateTime endDate = Convert.ToDateTime(maskedTxtEnd.Text); //Error here
                if (startDate < endDate)
                    MessageBox.Show("Start date needs to be before end date");
                else
                {
                    newPackage.PkgStartDate = Convert.ToDateTime(maskedTxtStart.Text);
                    newPackage.PkgEndDate = Convert.ToDateTime(maskedTxtEnd.Text);
                }
            }


            //Prices
            if (txtBasePrice.Text == "")
                MessageBox.Show("Please enter a value for base price", "Input Error");
            else
            {
                decimal basePrice = Convert.ToDecimal(txtBasePrice.Text);
                decimal commissionPrice = Convert.ToDecimal(txtCommision.Text);
                if (basePrice < commissionPrice)
                    MessageBox.Show("Base price need to be higher than Agency Commission");
                else
                {
                    newPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                    newPackage.PkgAgencyCommission = Convert.ToDecimal(txtCommision.Text);
                }
            }








            ////Validations
            ////name
            //if (Validation.ValidNull(txtName))
            //    newPackage.PkgName = txtName.Text;

            ////description
            //if (Validation.ValidNull(txtDesc))
            //    newPackage.PkgDesc = txtDesc.Text;

            ////Start Date  


            //if (Validation.ValidDate(maskedTxtStart, maskedTxtEnd))
            //{

            //    if ((chkAddStart.Checked == false) && (maskedTxtStart.Text == ""))
            //        MessageBox.Show("Please check null box or enter a valid date for start date", "Input error");

            //    else if ((chkAddEnd.Checked == false) && (maskedTxtEnd.Text == ""))
            //        MessageBox.Show("Please check null box or enter a valid date for end date", "Input error");
            //    else
            //    {
            //        newPackage.PkgStartDate = Convert.ToDateTime(maskedTxtStart.Text);
            //        newPackage.PkgEndDate = Convert.ToDateTime(maskedTxtEnd.Text);
            //    }

            //}
            ////if (maskedTxtStart.Text != null)
            ////    newPackage.PkgStartDate = Convert.ToDateTime(maskedTxtStart.Text);

            ////else
            ////newPackage.PkgStartDate = Convert.ToDateTime(maskedTxtStart.Text);

            ////End date
            ////if (maskedTxtEnd.Text != null)

            //////else
            ////newPackage.PkgEndDate = Convert.ToDateTime(maskedTxtEnd.Text);


            ////*****Prices***
            ////Base price
            //if (Validation.ValidNull(txtBasePrice))
            //{
            //    decimal basePrice = Convert.ToDecimal(txtBasePrice.Text);
            //    decimal commissionPrice = Convert.ToDecimal(txtCommision.Text);
            //    //Making sure base price is not lower than agency commission
            //    if (basePrice < commissionPrice)
            //        MessageBox.Show("Base price needs to be higher than commission price");
            //    else if ((Validation.ValidNeg(txtBasePrice)) && (Validation.ValidNull(txtBasePrice)))
            //        newPackage.PkgBasePrice = basePrice;
            //    else if (Validation.ValidNeg(txtCommision))
            //        newPackage.PkgAgencyCommission = commissionPrice;
            //}

            try
            {
                newPackage.PackgeId = PackageDB.AddPackage(newPackage);
                this.DialogResult = DialogResult.OK; // OK if Insert was successful
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding" + ex.Message, ex.GetType().ToString());
                this.DialogResult = DialogResult.Retry;
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
