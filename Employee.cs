using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3ExamEmpSys
{
    public abstract class Employee 
    {
        #region Private and Protected variable fields
        private int employeeId;
        private string firstName;
        private string lastName;
        private DateTime dateHired;
        private string ssn;
        private string email;
        private string phone;
        private decimal taxRate;
        #endregion

        #region Constructors
        protected Employee(string firstName, string lastName, DateTime dateHired,
            string ssn, string email, string phone, decimal taxRate, int employeeId)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateHired = dateHired;
            this.ssn = ssn;
            this.email = email;
            this.phone = phone;
            this.taxRate = taxRate;
            this.employeeId = employeeId;
        }
        /// <summary>
        /// emplty constructor
        /// </summary>
        public Employee()
        {

        }

        #endregion

        #region Public Getters and Setters
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateHired { get => dateHired; set => dateHired = value; }
        public string Ssn { get => ssn; set => ssn = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public decimal TaxRate { get => taxRate; set => taxRate = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        #endregion

        #region Abstract base class methods
        public override string ToString()
        {
            return base.ToString();
        }

        public virtual decimal calculateTaxes()
        {

            return 0.0m;
        }

        public virtual decimal calcTotalEarnings()
        {

            return 1.0m;
        }
        #endregion
    }
}
