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
    //Author: Yasin Habib
    public partial class frmPackages : Form
    {
        const int UPDATE = 7; //Update button on column index 7
        List<Packages> packages;
        Packages oldPackage;
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            try
            {
                packages = PackageDB.GetAllPackages();
                grdPackages.DataSource = packages;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading packages: " + ex.Message,
                    ex.GetType().ToString());
            }
        }//End of form load

        private void grdPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UPDATE)
            {
                oldPackage = packages[e.RowIndex].PackageBackup();
                frmUpdate_Add update = new frmUpdate_Add();
                update.packageNow = packages[e.RowIndex];   // current package
                update.packageOld = oldPackage;             // older package (from frmPackage)
                DialogResult result = update.ShowDialog();
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid view
                    CurrencyManager cm = (CurrencyManager)grdPackages.BindingContext[packages];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    packages[e.RowIndex] = oldPackage; // revert to the old values
                }
            }


        }//End of Update click

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//End of frmPackage
}//End of namespace
