using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_Application
{
    //General validation class
    //Author: Yasin Habib
    public class Validation
    {
        //whole number
        public static bool ValidWhole(TextBox tbInput)
        {
            bool valid = true;
            int textValue;
            if (!Int32.TryParse(tbInput.Text, out textValue)) //Validating whole number
            {
                valid = false;
                MessageBox.Show("Need to be a whole number", "Input Error");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }//end of whole number

        //Non Negative
        public static bool ValidNeg(TextBox tbInput)
        {
            decimal tbData = Convert.ToDecimal(tbInput.Text);
            bool valid = true;
            if (tbData < 0)      //Validating a negative value
            {
                valid = false;
                MessageBox.Show("Please enter a positive value", "Input Error");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }//end of negative

        //No null
        public static bool ValidNull(TextBox tbInput)
        {
            bool valid = true;
            if (tbInput.Text == "") //Validating empty textbox
            {
                valid = false;
                MessageBox.Show("Description, Name and Base price fields can not be empty", "Input Error");
                tbInput.Focus();
            }
            return valid;
        }//End of null

        //No number(Only alphabets)
        public static bool ValidLetters(TextBox tbInput)
        {
            bool valid = true;
            if (!tbInput.Text.All(Char.IsLetter)) //Validating for letters
            {
                valid = false;
                MessageBox.Show("Name field accept letters only.", "Input Error");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }//End of letters only

        //Compare two datetime
        //public static bool ValidDateTime(DateTimePicker startDate, DateTimePicker endDate)
        //{
        //    bool valid = true;
        //    if (startDate < endDate)
        //    {
        //        valid = false;
        //        MessageBox.Show("Start date has to be before end date", "Input Error");
        //        tbInput.SelectAll();
        //        tbInput.Focus();
        //    }
        //    return valid;
        //}

        //Validating and comparing dates
        public static bool ValidDate(MaskedTextBox mkStart, MaskedTextBox mkEnd)
        {
            bool valid = true; // empty is valid
            DateTime startDate;
            if ((mkStart.Text != null) && (mkEnd.Text != null))
            {
                if (DateTime.TryParse(mkStart.Text, out startDate))
                {
                    DateTime start = Convert.ToDateTime(mkStart.Text);
                    DateTime end = Convert.ToDateTime(mkEnd.Text);

                    if (start < end)
                    {
                        valid = false;
                        MessageBox.Show("Base price needs to be higher than commission price","Input Error");
                    }
                }
                //else
                //{
                //    valid = false;
                //    MessageBox.Show("Please enter Date Ended in format MM/DD/YYYY", "Data Error");
                //}
            }
            else
            {
                valid = true;
                mkStart.Text = null;
                mkEnd.Text = null;
            }
            return valid;
        }

    }//End of validation
}//End of Namespace

