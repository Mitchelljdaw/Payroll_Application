using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_12
{
    public partial class FrmFluffElectronics : Form
    {
        const int THIRD = 2;//represents teh third element in the first element of an employee array of objects
        private Employee _employee;//reference to the employee class

        //will help know how many times we have gone through array. and how many employees there are in a file.
        private int index;

        //repsrents the name on employee
        private string employeeName;

        //represents the address of an employee
        private string employeeAddress;

        //represents the id of an emplyee
        private string employeeId;

        //double represting the number of hours an employee worked
        double hours;

        //double reresenting the hourly wage of an employee
        double wage;
        /// <summary>
        /// Main entry point into the program
        /// </summary>
        public FrmFluffElectronics()
        {

            InitializeComponent();
        }

        /// <summary>
        /// Constructor the initializes employee attributes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFluffElectronics_Load(object sender, EventArgs e)
        {
            index = 0;
            hours = 0;
            wage = 0;

            //initialize new class level reference to emplyoee class. with arguments 
            _employee = new Employee(employeeName, employeeId, employeeAddress, hours, wage);

            //make an array of objects from the file of employees
            _employee.MakeObjectArray();

            //display the first employee attributes in text boxes when program opens
            TxtId.Text = _employee.Employee_All[index, 0];
            TxtName.Text = _employee.Employee_All[index, 1];
            TxtAddress.Text = _employee.Employee_All[index, THIRD];
            TxtNetPay.Text = $"{_employee.CalcNetPay:c}";
        }

        /// <summary>
        /// Will show information about employee when pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            //Read through the array of objects and diplay each employee attribute in text boxes
            //until you read zero atrributes in the array
            if (_employee.Employee_All[index, 0] != null)
            {
                index++;//make a tally of how many employees 
                _employee.Help++;//helps get the corret net pay for employee
                TxtId.Text = _employee.Employee_All[index, 0];//display employee id
                TxtName.Text = _employee.Employee_All[index, 1];//display emplyee name 
                TxtAddress.Text = _employee.Employee_All[index, THIRD];//display employee's address
                TxtNetPay.Text = $"{_employee.CalcNetPay:c}";//display employee's pay
            }
            //once there are no longer employees in the array let the user now to exit program
            else
            {
                MessageBox.Show("That is all the current employees.\nPlease exit program now.");
            }
        }


        /// <summary>
        /// Exits porgram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuSubExt_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Shows a message box about the project 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuSubAbt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name:Mitchell Daw\nClass:CS 1400\nSection:002\nProject:12");
        }
    }
}
