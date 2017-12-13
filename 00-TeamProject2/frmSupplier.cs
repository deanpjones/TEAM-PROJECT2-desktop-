using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_TeamProject2
{
    //**********************************************************************
    //**********************************************************************

    //FORM (SUPPLIERS INFORMATION)
    //Author: Dean Jones
    //Date: Dec.27, 2016

    //**********************************************************************
    //**********************************************************************
    public partial class frmSupplier : Form
    {
        //VARIABLES
        List<djSupplier> mySupplierList = new List<djSupplier>();       //Supplier list

        /// <summary>
        /// FORM CONSTRUCTOR
        /// </summary>
        public frmSupplier()
        {
            InitializeComponent();
            CreateSupplierList();       //load suppliers to listbox           
        }

        /// <summary>
        /// FORM LOAD
        /// </summary>
        public void frmSupplier_Load(object sender, EventArgs e)
        {
            //disable REMOVE BUTTON
            btnRemoveSupplier.Visible = false;  //not required (cascade delete problem)

            lblInfo.Text = "";                                                                  //BLANK label on startup
            txtSupID.Select();                                                                  //need to select textbox first sometimes (when inside a group box?)
            txtSupID.Focus();                                                                   //focus on textbox
            radSortName.Checked = true;                                                         //default SORT BY to SupName
            lblInfo.Text = "Add a new supplier, edit an existing supplier, or remove a supplier from the list.";         //info display
            grpEditSupplier.Visible = false;                                                    //hide edit supplier window on load
        }

        /// <summary>
        /// DISPLAY SUPPLIERS IN THE LISTBOX
        /// </summary>
        private void CreateSupplierList()
        {
            // clears the contents of the listbox
            lstSuppliers.Items.Clear();  

            //get supplier info from database (as List<djSupplier>)
            mySupplierList = djSupplierDB.loadSuppliersInfo(grpSortBy.Tag.ToString());

            //add supplier info to listbox
            foreach (djSupplier sup in mySupplierList)
            {
                lstSuppliers.Items.Add(sup);
            }
        }

        /// <summary>
        /// ADD SUPPLIER TO DATABASE
        /// </summary>
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if(IsValidSupplierId() && IsValidSupplierName())
            {
                //add supplier (supplier name to UPPERCASE)
                djSupplierDB.addSupplier(Convert.ToInt32(txtSupID.Text), txtSupName.Text.ToUpper());

                //refresh listbox
                CreateSupplierList();       //load suppliers to listbox
                mySupplierList = djSupplierDB.loadSuppliersInfo(grpSortBy.Tag.ToString());
                lblInfo.Text = "The supplier list has been updated with the new supplier.";         //info display

                //clear boxes after adding
                txtSupID.Clear();
                txtSupName.Clear();
                txtSupID.Focus();           //focus on textbox
            }
        }

        /// <summary>
        /// REMOVE SUPPLIER INFO (sql DELETE)
        /// </summary>
        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            //confirm selection
            if (lstSuppliers.SelectedItem != null)
            {
                string mySelect = lstSuppliers.SelectedItem.ToString();             //get overall string
                string myId = mySelect.Substring(0, mySelect.IndexOf("\t"));        //parse string to get the 'Supplier Id'
                string myName = mySelect.Substring(mySelect.IndexOf("\t") + 1);     //parse string to get the 'Supplier Name'

                //confirmation message
                string myConfirmMessage = "Would you like to remove the selection from the database permanently?\n\n"
                        + "Supplier Id:\t" + myId + "\n"
                        + "Supplier Name:\t" + myName;

                //tests to see output
                //MessageBox.Show(mySelect);                                        
                //MessageBox.Show(myId);
                //MessageBox.Show(myName);
                //MessageBox.Show(lstSuppliers.SelectedItem.GetType().ToString());

                if (Validator.IsInteger(myId))
                {
                    // CONFIRMATION DIALOG (before deleting supplier)
                    DialogResult confirmDialog = MessageBox.Show(myConfirmMessage, "REMOVE SUPPLIER CONFIRMATION", MessageBoxButtons.OKCancel);
                    if (confirmDialog == DialogResult.OK)
                    {
                        //remove supplier
                        djSupplierDB.removeSupplier(Convert.ToInt32(myId));

                        //refresh listbox
                        CreateSupplierList();       //load suppliers to listbox
                        mySupplierList = djSupplierDB.loadSuppliersInfo(grpSortBy.Tag.ToString());
                        lblInfo.Text = "The supplier list has been updated with the supplier removed.";         //info display

                        //clear boxes after adding
                        txtSupID.Clear();
                        txtSupName.Clear();
                        txtSupID.Focus();           //focus on textbox
                    }
                    else if (confirmDialog == DialogResult.Cancel)
                    {
                        //Confirmation message
                        MessageBox.Show("The operation was cancelled.  The supplier was NOT REMOVED from the database.", "CANCELLED REMOVAL");
                    }
                }
            }
            else
            {
                MessageBox.Show("A supplier must be selected from the listbox before it can be removed.", "SELECTION ERROR");
            }
        }

        //************************************************************************************
        
        /// <summary>
        /// EDIT SUPPLIER INFO (sql UPDATE)
        /// </summary>
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            //confirm selection
            if (lstSuppliers.SelectedItem != null)
            {
                string mySelect = lstSuppliers.SelectedItem.ToString();             //get overall string
                string myId = mySelect.Substring(0, mySelect.IndexOf("\t"));        //parse string to get the 'Supplier Id'
                string myName = mySelect.Substring(mySelect.IndexOf("\t") + 1);     //parse string to get the 'Supplier Name'

                grpEditSupplier.Visible = true;                                     //show edit group               
                txtEditSupName.Focus();                                             //focus on name textbox
                lblInfo.Text = "Update the supplier information and click ok, or click cancel to exit without changes.";     //info display

                //load text from selection to edit textbox
                txtEditSupID.Text = myId;       
                txtEditSupName.Text = myName;
                txtEditSupName.Focus();             //put focus on edit supplier name

                //disable other fields until edit is over
                btnAddSupplier.Enabled = false;
                btnRemoveSupplier.Enabled = false;
                //re-enable buttons on OK or CANCEL
            }
            else
            {
                MessageBox.Show("A supplier must be selected from the listbox before it can be updated.", "SELECTION ERROR");
                //grpEditSupplier.Visible = false;                                    //hide edit group
            }
        }

        /// <summary>
        /// EDIT SUPPLIER INFO (OK BUTTON)
        /// </summary>
        private void btnEditSupplierOK_Click(object sender, EventArgs e)
        {
            updateSupplier();

            //re-enable buttons on OK or CANCEL
            btnAddSupplier.Enabled = true;
            btnRemoveSupplier.Enabled = true;           
        }

        /// <summary>
        /// EDIT SUPPLIER INFO (CANCEL BUTTON)
        /// </summary>
        private void btnEditSupplierCancel_Click(object sender, EventArgs e)
        {
            //Confirmation message
            MessageBox.Show("The operation was cancelled.  The supplier was NOT UPDATED in the database.", "CANCELLED UPDATE");

            //clear boxes after update
            txtEditSupID.Clear();
            txtEditSupName.Clear();
            grpEditSupplier.Visible = false;    //hide group edit supplier

            //clear boxes after update
            txtSupID.Clear();
            txtSupName.Clear();
            txtSupID.Focus();           //focus on textbox

            //Reset label
            lblInfo.Text = "Add a new supplier, edit an existing supplier, or remove a supplier from the list.";         //info display

            //re-enable buttons on OK or CANCEL
            btnAddSupplier.Enabled = true;
            btnRemoveSupplier.Enabled = true;
        }

        // UPDATE SUPPLIER METHOD
        private void updateSupplier()
        {
            //confirm selection
            if (lstSuppliers.SelectedItem != null)
            {
                string mySelect = lstSuppliers.SelectedItem.ToString();             //get overall string
                string myId = mySelect.Substring(0, mySelect.IndexOf("\t"));        //parse string to get the 'Supplier Id'
                string myName = mySelect.Substring(mySelect.IndexOf("\t") + 1);     //parse string to get the 'Supplier Name'

                //confirmation message
                string myConfirmMessage = "Would you like to update the selection in the database?\n\n"
                        + "Supplier Id:\t" + myId + "\n"
                        + "Supplier Name:\t" + myName;

                if (Validator.IsInteger(myId))
                {
                    // CONFIRMATION DIALOG (before deleting supplier)
                    DialogResult confirmDialog = MessageBox.Show(myConfirmMessage, "UPDATE SUPPLIER CONFIRMATION", MessageBoxButtons.OKCancel);
                    if (confirmDialog == DialogResult.OK)
                    {
                        //update supplier
                        //*****************************************************************************
                        djSupplierDB.editSupplier(Convert.ToInt32(myId), myName, txtEditSupName.Text);
                        //*****************************************************************************

                        //refresh listbox
                        CreateSupplierList();       //load suppliers to listbox
                        mySupplierList = djSupplierDB.loadSuppliersInfo(grpSortBy.Tag.ToString());
                        lblInfo.Text = "The supplier list has been updated with the changes.";         //info display

                        //clear boxes after update
                        txtEditSupID.Clear();
                        txtEditSupName.Clear();
                        grpEditSupplier.Visible = false;    //hide group edit supplier

                        //clear boxes after update
                        txtSupID.Clear();
                        txtSupName.Clear();
                        txtSupID.Focus();           //focus on textbox

                    }
                    else if (confirmDialog == DialogResult.Cancel)
                    {
                        //Confirmation message
                        MessageBox.Show("The operation was cancelled.  The supplier was NOT UPDATED in the database.", "CANCELLED UPDATE");
                    }
                }
            }
            else
            {
                MessageBox.Show("A supplier must be selected from the listbox before it can be removed.", "SELECTION ERROR");
            }
        }
        //************************************************************************************

        /// <summary>
        /// VALIDATE (SUPPLIER ID)(EDIT TEXTBOX) INFO
        /// </summary>
        /// <returns>True if valid</returns>
        private bool IsValidEditSupplierId()
        {
            return
                Validator.IsPresent(txtEditSupID) &&                        //make sure the Id textbox isn't blank
                Validator.IsInteger(txtEditSupID) &&                        //is an integer (test before if positive integer)
                Validator.IsPositiveInteger(txtEditSupID) &&                //make sure that the Id is a positive integer only
                Validator.IsIntegerWithinRange(txtEditSupID, 1, 50000);     //make sure supplier Id between (1 and 50,000) only
        }

        /// <summary>
        /// VALIDATE (SUPPLIER NAME)(EDIT TEXTBOX) INFO
        /// </summary>
        /// <returns>True if valid</returns>
        private bool IsValidEditSupplierName()
        {
            return
                Validator.IsPresent(txtEditSupName) &&                      //make sure the string textbox isn't blank
                Validator.IsStringWithinRange(txtEditSupName, 1, 255);      //make sure string fits the database requirements
        }

        /// <summary>
        /// VALIDATE (SUPPLIER ID) INFO
        /// </summary>
        /// <returns>True if valid</returns>
        private bool IsValidSupplierId()
        {
            return
                Validator.IsPresent(txtSupID) &&                        //make sure the Id textbox isn't blank
                Validator.IsInteger(txtSupID) &&                        //is an integer (test before if positive integer)
                Validator.IsPositiveInteger(txtSupID) &&                //make sure that the Id is a positive integer only
                Validator.IsIntegerWithinRange(txtSupID, 1, 50000);     //make sure supplier Id between (1 and 50,000) only
        }

        // VALIDATE (SUPPLIER ID) DUPLICATE ID (see djSupplierDatabase.addSupplier try-catch statement)

        /// <summary>
        /// VALIDATE (SUPPLIER NAME) INFO
        /// </summary>
        /// <returns>True if valid</returns>
        private bool IsValidSupplierName()
        {
            return
                Validator.IsPresent(txtSupName) &&                      //make sure the string textbox isn't blank
                Validator.IsStringWithinRange(txtSupName, 1, 255);      //make sure string fits the database requirements
        }

        /// <summary>
        /// SORT TAG EVENT (use TAG property on SORT BY group to pass to listbox)
        /// </summary>
        private void radSortID_CheckedChanged(object sender, EventArgs e)
        {
            grpSortBy.Tag = "SupplierId";
            //refresh listbox
            CreateSupplierList();       //load suppliers to listbox
            mySupplierList = djSupplierDB.loadSuppliersInfo(grpSortBy.Tag.ToString());    //load listbox
            lblInfo.Text = "The supplier list has been updated and sorted by 'Supplier Id'.";   //info display
        }
        
        /// <summary>
        /// SORT TAG EVENT (use TAG property on SORT BY group to pass to listbox)
        /// </summary>
        private void radSortName_CheckedChanged(object sender, EventArgs e)
        {
            grpSortBy.Tag = "SupName";
            //refresh listbox
            CreateSupplierList();       //load suppliers to listbox
            mySupplierList = djSupplierDB.loadSuppliersInfo(grpSortBy.Tag.ToString());    //load listbox
            lblInfo.Text = "The supplier list has been updated and sorted by 'Supplier Name'."; //info display
        }

        /// <summary>
        ///  UPDATE INFO TEXT IF RE-TYPING NEW SUPPLIER
        /// </summary>
        private void txtSupName_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "Enter a new 'Supplier Name' to be added.";                          //info display
        }

        /// <summary>
        /// UPDATE INFO TEXT IF RE-TYPING NEW SUPPLIER
        /// </summary>
        private void txtSupID_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "Enter a new 'Supplier Id' to be added.";                            //info display
        }

    }
}
