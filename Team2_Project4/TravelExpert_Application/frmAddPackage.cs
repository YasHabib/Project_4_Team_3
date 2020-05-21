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

        private void chkAddStart_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAddStart.Checked)
            //{
            //    maskedTxtStart.Enabled = false;
            //    newPackage.PkgStartDate = null;
            //}
            //else
            //   maskedTxtStart.Enabled = true;
        }


        private void chkAddEnd_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAddEnd.Checked)
            //{
            //    maskedTxtEnd.Enabled = false;
            //    newPackage.PkgEndDate = null;
            //}
            //else
            //    maskedTxtEnd.Enabled = true;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Validations
            //name
            if (Validation.ValidNull(txtName))
                newPackage.PkgName = txtName.Text;

            //description
            if (Validation.ValidNull(txtDesc))
                newPackage.PkgDesc = txtDesc.Text;

            //Start and End date

            if(Validation.ValidDate(txtStart, txtEnd))
            {
                //start
                if (txtStart.Text == "")
                    newPackage.PkgStartDate = null;
                else
                    newPackage.PkgStartDate = Convert.ToDateTime(txtStart.Text);

                //end
                if (txtEnd.Text == "")
                    newPackage.PkgEndDate = null;
                else
                    newPackage.PkgEndDate = Convert.ToDateTime(txtEnd.Text);
            }


            //if (txtStart.Text == "")
            //    newPackage.PkgStartDate = null;
            //else if (txtEnd.Text == "")
            //    newPackage.PkgEndDate = null;
            //else
            //{               
            //    DateTime startDate = Convert.ToDateTime(txtStart.Text);
            //    DateTime endDate = Convert.ToDateTime(txtEnd.Text);
            //    if (startDate < endDate)
            //        MessageBox.Show("Start date needs to be before end date");
            //    else
            //    {
            //        newPackage.PkgStartDate = startDate;
            //        newPackage.PkgEndDate = endDate;
            //    }
            //}



            //Prices
            if (txtBasePrice.Text == "")
                MessageBox.Show("Please enter a value for base price", "Input Error");
            else
            {
                decimal basePrice = Convert.ToDecimal(txtBasePrice.Text);
                decimal commissionPrice = Convert.ToDecimal(txtCommision.Text);
                if (basePrice < commissionPrice)
                    MessageBox.Show("Base price needs to be higher than commission price");
                else if (Validation.ValidNeg(txtBasePrice))
                    newPackage.PkgBasePrice = basePrice;
                else if (Validation.ValidNeg(txtCommision))
                    newPackage.PkgAgencyCommission = commissionPrice;
            }


            //if (((chkAddEnd.Checked == false) || (chkAddStart.Checked == false)) && ((maskedTxtStart.Text == null) || (maskedTxtEnd.Text == null)))
            //    MessageBox.Show("Please check null box or enter a valid date", "Input error");
            try
            {
                newPackage.PackgeId = PackageDB.AddPackage(newPackage);
                this.DialogResult = DialogResult.OK; // OK if Insert was successful
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
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
