using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3ExamEmpSys
{
    /// <summary>
    /// Developer:  Clint Dale Tagbabucba
    /// Date:       11/9/2019
    /// Program:    Employee Management SYstem
    /// Purpose:    Create Read Update Delete full time employee data from the database server
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Declare class fields
        /// </summary>

        private FullTime aFullTime;
        private int selectedItem = -1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// when opening app disable textbox fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            EnableDisable(false);
        }

        /// <summary>
        /// set enable or disable buttons and textboxes
        /// </summary>
        /// <param name="val"></param>
        private void EnableDisable(bool val)
        {
            btnOk.Enabled = val;
            txtBxFName.Enabled = val;
            txtBxID.Enabled = val;
            txtBxLName.Enabled = val;
            txtBxSalary.Enabled = val;
            txtBxVac.Enabled = val;
            txtBxSick.Enabled = val;
            txtBxTax.Enabled = val;
            txtBxInsure.Enabled = val;
            txtBxDateHired.Enabled = val;
            txtBxSsn.Enabled = val;
            txtBxEmail.Enabled = val;
            txtBxPhone.Enabled = val;
            txtBxTaxRate.Enabled = val;
            
        }


        /// <summary>
        /// when button load clicked run loadItems method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            LoadItems(); // run load items
            lblMessage.Text = "Full Time Employees are Loaded";

        }

        /// <summary>
        /// load items in the text box
        /// </summary>
        public void LoadItems()
        {
            lstBxFullTime.Items.Clear();

            ArrayList fullTime = FullTime.getAllFullTime();

            foreach (FullTime aFullTime in fullTime)
            {
                this.lstBxFullTime.Items.Add(aFullTime);

            }
            
        }

        /// <summary>
        /// enable textbox fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnableDisable(true);
            ClearText();
            selectedItem = -1;

            txtBxID.Focus();


        }
        /// <summary>
        /// Clear text Boxes
        /// </summary>
        private void ClearText()
        {

            txtBxFName.Text = "";
            txtBxID.Text = "";
            txtBxLName.Text = "";
            txtBxSalary.Text = "";
            txtBxVac.Text = "";
            txtBxSick.Text = "";
            txtBxTax.Text = "";
            txtBxInsure.Text = "";
            txtBxDateHired.Text = "";
            txtBxSsn.Text = "";
            txtBxEmail.Text = "";
            txtBxPhone.Text = "";
            txtBxTaxRate.Text = "";
        }


        /// <summary>
        /// Add or update employee method when OK button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool hasIns = Convert.ToBoolean(txtBxInsure.Text);
            bool isTaxEx = Convert.ToBoolean(txtBxTax.Text);
            int ifHasIns = hasIns ? 1 : 0;
            int isTaxExempt = isTaxEx ? 1:0;

            if (selectedItem == -1) // if creating a new full time employee
            {
                aFullTime = new FullTime(txtBxFName.Text, txtBxLName.Text,
                    Convert.ToDateTime(txtBxDateHired.Text),
                    txtBxSsn.Text,
                    txtBxEmail.Text,
                    txtBxPhone.Text,
                    Convert.ToDecimal(txtBxTaxRate.Text),
                    Convert.ToInt32(txtBxID.Text),
                    Convert.ToDecimal(txtBxSalary.Text),
                    Convert.ToInt32(txtBxVac.Text),
                    Convert.ToInt32(txtBxSick.Text),
                    Convert.ToBoolean(ifHasIns),
                    Convert.ToBoolean(txtBxInsure.Text)
                    );

                aFullTime.InsertFullTime();
                lblMessage.Text = "Member Added";
                LoadItems();

            }
            else if(selectedItem >=0 )// if not, update the employee selected in the listbox 
            {
                aFullTime.FirstName = txtBxFName.Text;
                aFullTime.LastName = txtBxLName.Text;
                aFullTime.DateHired = Convert.ToDateTime(txtBxDateHired.Text);
                aFullTime.Ssn = txtBxSsn.Text;
                aFullTime.Email = txtBxEmail.Text;
                aFullTime.Phone = txtBxPhone.Text;
                aFullTime.TaxRate = Convert.ToDecimal(txtBxTaxRate.Text);
                aFullTime.Salary = Convert.ToDecimal(txtBxSalary.Text);
                aFullTime.NumOfVacationDays = Convert.ToInt32(txtBxVac.Text);
                aFullTime.SickDays = Convert.ToInt32(txtBxSick.Text);
                aFullTime.IsTaxExempt = Convert.ToBoolean(ifHasIns);
                aFullTime.HasInsurance = Convert.ToBoolean(ifHasIns);
                aFullTime.updateFullTime();
                lblMessage.Text = "Full Time Employee Updated";
                
            }
            else
            {

            }
            EnableDisable(false);
            ClearText();
            LoadItems();

        }

        /// <summary>
        /// populated text box fields upon selected item in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBxFullTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = lstBxFullTime.SelectedIndex;
            aFullTime = (FullTime)lstBxFullTime.Items[selectedItem]; // cast the items
            txtBxID.Text = aFullTime.EmployeeId.ToString();
            txtBxFName.Text = aFullTime.FirstName ;
            txtBxLName.Text = aFullTime.LastName;
            txtBxDateHired.Text = aFullTime.DateHired.ToString();
            txtBxSsn.Text = aFullTime.Ssn ;
            txtBxEmail.Text = aFullTime.Email;
            txtBxPhone.Text = aFullTime.Phone;
            txtBxTaxRate.Text = aFullTime.TaxRate.ToString();
            txtBxSalary.Text = aFullTime.Salary.ToString();
            txtBxVac.Text = aFullTime.NumOfVacationDays.ToString();
            txtBxSick.Text = aFullTime.SickDays.ToString();
            txtBxTax.Text = aFullTime.IsTaxExempt.ToString();
            txtBxInsure.Text = aFullTime.HasInsurance.ToString();
            

        }

        /// <summary>
        /// when update button clicked, enable textbox field exept employeeId textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableDisable(true);
            txtBxFName.Focus();
            txtBxID.Enabled = false;
        }

        /// <summary>
        /// when delete button is clicked, ask user if he's sure about deleting an employee
        /// if yes, run delFullTime() method from the fulltime class
        /// if no, then change lblMessage.Text = "Delete Cancelled", do nothing basically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedItem == -1)
            {
                lblMessage.Text = "Please select a member to delete"; // if nothing is selected

            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete an employee?",
                    "Employee Full Time List ", MessageBoxButtons.YesNo); //create a dialog box with yes or no button, title and a message
                if(result == DialogResult.Yes)
                {
                    aFullTime.DelFullTime(); // delete an employee
                    ClearText();
                    LoadItems();
                    lblMessage.Text = "Employee has been deleted";

                }
                else
                {
                    lblMessage.Text = "Delete cancelled";

                }
            }
        }
    }
}
