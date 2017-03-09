using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proj_12
{
    class Employee
    {
        private const double STATE_TAX = .075; // Represents the state tax
        private const double FED_TAX = .20; // Represents the federal tax
        private const int SIZE = 10; //Represents the size of an array
        private const int OBJECT = 2;
        private const int MONEY = 3;

        //Represents the max amount of emplyees that will be in the company
        private const int MAX = 10;

        //repressents the number of attributes each employee will have
        private const int ATTRIBUTES = 5;

        //helps asign the hourly wage to the correect element in the employee arra of objects.
        private const int HOUR_WAGE = 4;
        
        //represents the over time hours
        private const int OVER_TIME = 40;

        // represents the number used to get time and a half for working more than 40 hours.
        private const double TIME_HALF = 1.50;


        private StreamReader _theEmployee;
        private string path;
        private string file;
        public int Help { get; set; }//Helps change the net pay.
        public string[,] Employee_All { get; set; }//Represetns an array of all the employees and thier information
        public string Employee_Id { get; set; }//represrents the if number for an employee
        public string Employee_Name { get; set; } // represents employee name
        public string Street_Address { get; set;} // Represrents street name of employee



        /// <summary>
        /// Default constructor for employee class.
        /// </summary>
        public Employee(string _employeeName, string _employeeId, string _employeeAddress, double _employeeHours, double _employeeHourWage)
        {
            Street_Address =_employeeAddress;
            Employee_Id = _employeeId;
            Employee_Name = _employeeName;
            Hours = _employeeHours;
            Hourly_Wage = _employeeHourWage;
            path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\";
            file = "Employee.txt";
            _theEmployee = new StreamReader(path + file);
        }

        /// <summary>
        /// Makes an array of object from reading an object
        /// </summary>
        /// <param name="objectArray"></param>
        /// <param name="file"></param>
        public void MakeObjectArray()
        {
            //Array that will hold the array of employee objects
            Employee_All = new string[MAX, ATTRIBUTES];
            int index = 0;
            //Will hold the data the is read from each line that is split from the file 
            string[] wages = new string[1];

            //will hold the lines read from the file
            string elements = "";

            //create a loop that will read thorugh a file to the end 
            do
            {
                //read thorugh the whole file and assign data to the employee array of objects
                for (int i = 0; i <= OBJECT; i++)
                {
                    elements = _theEmployee.ReadLine();

                    Employee_All[index, i] = elements;

                }
                
                // read through the data in the file and split the last line of the emplyoee data into the hourly wage and hours worked
                for (int i = MONEY; i < MONEY + 1; i++)
                {
                    elements = _theEmployee.ReadLine();
                    if (elements != null)
                    {
                        wages = elements.Split();
                        Employee_All[index, i] = wages[0];
                        Employee_All[index, i + 1] = wages[1];
                    }
                }
                index++;
            } while (elements != null);
        }

        /// <summary>
        /// Represents the hourly wage of an employee
        /// </summary>
        public double Hourly_Wage
        {
            get
            {
                //convert the the hourly wage into double so they can be used as such
                if(Employee_All[Help, HOUR_WAGE] != null)
                {
                    return double.Parse(Employee_All[Help, HOUR_WAGE]);
                }
                else
                {
                    return 0.00;
                }
            }
            set
            {

            }
        }

        /// <summary>
        /// Represents the hours worked by an employee
        /// </summary>
        public double Hours
        {
            get
            {
                //convert the the hours into double so they can be used as such
                if (Employee_All[Help, MONEY] != null)
                {
                    return double.Parse(Employee_All[Help, MONEY]);

                }
                else
                {
                    return 0.00;
                }
            }
            set
            {

            }
        }


        /// <summary>
        /// Calculates the net pay for an employee
        /// </summary>
        public double CalcNetPay
        {
            get
            {
                //Check to see if they worked over time
                if (Hourly_Wage <= OVER_TIME)
                {
                    return (Hours * Hourly_Wage) - (Hours * Hourly_Wage * (STATE_TAX + FED_TAX));
                }

                //if they have worked over time give them time and a half.
                else
                {
                    return ((Hourly_Wage * TIME_HALF) * Hours) - (((Hourly_Wage * TIME_HALF) * Hours) * (STATE_TAX + FED_TAX));
                }
            }
        }
    }
}
