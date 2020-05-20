using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Project_4_Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_Application
{
    public partial class frmAddModifySupplier : Form
    {
        public frmAddModifySupplier()
        {
            InitializeComponent();
        }

        public bool addSupplier;
        public Suppliers supplier;

        private void frmAddModifySupplier_Load(object sender, EventArgs e)
        {
            if (addSupplier)
            {
                this.Text = "Add Supplier";
            }
            else
            {
                this.Text = "Modify Supplier";
                this.DisplaySuppliers();
            }
        }

        private void DisplaySuppliers()
        {
            txtSupName.Text = supplier.SupName;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtSupName))
            {
                if (addSupplier)
                {
                    supplier = new Suppliers();
                    supplier.SupName = txtSupName.Text;
                    try
                    {
                        supplier.SupplierID = SuppliersDB.AddSupplier(supplier);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Suppliers newSupplier = new Suppliers();
                    newSupplier.SupplierID = supplier.SupplierID;
                    supplier.SupName = txtSupName.Text;
                    try
                    {
                        if (!SuppliersDB.UpdateSuppliers(supplier, newSupplier))
                        {
                            MessageBox.Show("Another user has updated this", "Database error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            supplier = newSupplier;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
