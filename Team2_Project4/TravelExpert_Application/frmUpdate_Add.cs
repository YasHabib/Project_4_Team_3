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
    public partial class frmUpdate_Add : Form
    {
        public Packages packageNow; //new updated package
        public Packages packageOld; //old package from frmPackages
        //List<Packages> pkg = new List<Packages>();

        public frmUpdate_Add()
        {
            InitializeComponent();
        }
        //Shows all the data for selected package
        private void frmUpdate_Add_Load(object sender, EventArgs e)
        {
            //packagesBindingSource.Clear();
            packagesBindingSource.Add(packageNow);
            Refresh();
        }
        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Saving and validation
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation

            bool success = PackageDB.UpdatePackage(packageOld, packageNow);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Retry;
            }
        }

        private void ckboxNullStart_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeStart.CustomFormat = "";
        }

        private void ckboxNullEnd_CheckedChanged(object sender, EventArgs e)
        {
            dateTimeEnd.CustomFormat = "";
        }
    }//end of Update
}//End of namespace
