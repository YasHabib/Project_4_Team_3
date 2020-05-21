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
        private void ckboxNullStart_CheckedChanged(object sender, EventArgs e)
        {
            //if(ckboxNullStart.Checked)
            //dateTimeStart.Enabled = false;
            //else
            //dateTimeStart.Enabled = true;
        }

        private void ckboxNullEnd_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckboxNullStart.Checked)
            //    dateTimeEnd.Enabled = false;
            //else
            //    dateTimeEnd.Enabled = true;
        }

        public frmUpdate_Add()
        {
            InitializeComponent();
        }
        //Shows all the data for selected package
        private void frmUpdate_Add_Load(object sender, EventArgs e)
        {
            //packagesBindingSource.Clear();
            packagesBindingSource.Add(packageNow);
        }

        //Start date
        private void dateTimeStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimeStart.CustomFormat = "dd/MM/yyyy";
            //if (dateTimeStart.Checked)
            //    dateTimeStart.Format = DateTimePickerFormat.Long;
            //else
            //{
            //    dateTimeStart.CustomFormat = " ";
            //    dateTimeStart.Format = DateTimePickerFormat.Custom;
            //}
        }
        private void dateTimeStart_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                dateTimeStart.CustomFormat = " ";
            }
        }

        // End date
        private void dateTimeEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimeEnd.CustomFormat = "dd/MM/yyyy";

            //if (dateTimeEnd.Checked)
            //    dateTimeEnd.Format = DateTimePickerFormat.Long;
            //else
            //{
            //    dateTimeEnd.CustomFormat = " ";
            //    dateTimeEnd.Format = DateTimePickerFormat.Custom;
            //}

        }
        private void dateTimeEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Back))
            {
                dateTimeEnd.CustomFormat = " ";
            }
        }
        //Saving and validation
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validation
            //Start date

            ////End date



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

        //Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }//end of Update
}//End of namespace
