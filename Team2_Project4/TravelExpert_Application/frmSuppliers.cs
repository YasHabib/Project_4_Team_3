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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private Suppliers supplier;

        private void btnGetSup_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupID) &&
                Validator.IsInt32(txtSupID))
            {
                int SupplierId = Convert.ToInt32(txtSupID.Text);
                this.GetSupplier(SupplierId);
                if (supplier == null) // no Supplier with this ID
                {
                    MessageBox.Show("No Supplier found with this ID. " +
                         "Please try again.", "Supplier Not Found");
                    this.ClearControls();
                }
                else // there is a possible Supplier ID to be displayed
                    this.DisplaySuppliers();
            }
        }

        private void DisplaySuppliers()
        {
            txtSupName.Text = supplier.SupName;
            //btnAdd.Enabled = true;
            btnModify.Enabled = true;
        }

        private void ClearControls()
        {
            txtSupID.Text = "";
            txtSupName.Text = "";
            //btnAdd.Enabled = false;
            btnModify.Enabled = false;
            txtSupID.Select();
        }

        private void GetSupplier(int supplierId)
        {
            try
            {
                supplier = SuppliersDB.GetSupplier(supplierId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifySupplier modifySupplierForm = new frmAddModifySupplier();
            modifySupplierForm.addSupplier = false; // it's Modify
            modifySupplierForm.supplier = supplier;
            DialogResult result = modifySupplierForm.ShowDialog(); //display 2nd form
            if (result == DialogResult.OK) // user clicked accept on second form
            {
                supplier = modifySupplierForm.supplier; // current supplier is now up
                this.DisplaySuppliers();
            }
            else if (result == DialogResult.Retry) // concurrent exception
            {
                this.GetSupplier(supplier.SupplierID); // got data from current
                if (supplier != null) // not available
                {
                    this.DisplaySuppliers();
                }
                else
                    this.ClearControls(); // none available
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifySupplier addSupplierForm = new frmAddModifySupplier();
            addSupplierForm.addSupplier = true; // need to add from main form
            DialogResult result = addSupplierForm.ShowDialog();
            if (result == DialogResult.OK) // when clicked
            {
                supplier = addSupplierForm.supplier;
                txtSupID.Text = supplier.SupplierID.ToString();
                this.DisplaySuppliers();
            }
        }

        //// access for main form
        //public bool addSupplier;

        //// Need for main form
        //public Suppliers suppliers;

        private void frmSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Also this.Close();
        }

       
    }
}
