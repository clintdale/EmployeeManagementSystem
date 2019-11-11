using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace U3ExamEmpSys 
{
    class FullTime : Employee
    {
        #region Private Class Fields
        private decimal salary;
        private double numOfVacationDays;
        private double sickDays;
        private bool isTaxExempt;
        private bool hasInsurance;
        #endregion end of Private Class Fields
        #region Constructors
        public FullTime(string firstName, string lastName, DateTime dateHired, string ssn, string email,
        string phone, decimal taxRate, int employeeId,
        decimal salary, double numOfVacationDays, double sickDays,
        bool isTaxExempt, bool hasInsurance)
        : base(firstName, lastName, dateHired, ssn, email, phone, taxRate, employeeId)
        {
            this.salary = salary;
            this.numOfVacationDays = numOfVacationDays;
            this.sickDays = sickDays;
            this.isTaxExempt = isTaxExempt;
            this.hasInsurance = hasInsurance;
        }
        /// <summary>
        /// No-Args Constructor
        /// </summary>
        public FullTime()
        {

        }
        #endregion End of Constructors




        #region Getters and setters
        public decimal Salary { get => salary; set => salary = value; }
        public double NumOfVacationDays { get => numOfVacationDays; set => numOfVacationDays = value; }
        public double SickDays { get => sickDays; set => sickDays = value; }
        public bool IsTaxExempt { get => isTaxExempt; set => isTaxExempt = value; }
        public bool HasInsurance { get => hasInsurance; set => hasInsurance = value; }
        #endregion End of getters and setters





        #region Class methods | override methods | DML methods
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override decimal calculateTaxes()
        {
            return base.calculateTaxes();
        }

        public override decimal calcTotalEarnings()
        {
            return base.calcTotalEarnings();
        }

        public static ArrayList getAllFullTime()
        {
            return DataAdapter.getAllFullTime();

        }


        public void InsertFullTime()
        {
            DataAdapter.InsertFullTimeTable(this);

        }

        public void DelFullTime()
        {
            DataAdapter.DelFullTimeTable(this);

        }
        public void updateFullTime()
        {
            DataAdapter.UpdateFullTimeTable(this);

        }
        #endregion End Methods

    }
}
