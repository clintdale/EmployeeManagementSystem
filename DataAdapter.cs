using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace U3ExamEmpSys
{
    class DataAdapter
    {
        /// <summary>
        /// class fields created
        /// </summary>
        private static SqlConnection oConn = new SqlConnection("YOUR SQL CONNECTION STRING HERE");
        private static SqlCommand dbCmd;
        private static string sql;
        private static SqlDataReader dbReader;
        private static FullTime aFulltime;



        /// <summary>
        /// Connect to the database
        /// </summary>
        public static void Connect()
        {
            try
            {
                oConn.Open();


            }
            catch (Exception exc)
            {

                Console.Error.WriteLine(exc.Message);
            }

        }

        /// <summary>
        /// Disconnect from the database
        /// </summary>
        public static void Disconnect()
        {
            try
            {
                oConn.Close();

            }
            catch (Exception exc)
            {
                Console.Error.WriteLine(exc.Message);
            }
            finally
            {
                oConn.Close();

            }
        }

        /// <summary>
        /// get all full time rows from database
        /// </summary>
        /// <returns>dbReader</returns>
        public static SqlDataReader getFullTime()
        {
            try
            {

                sql = "SELECT * FROM Employee JOIN FullTime ON Employee.EmployeeId = FullTime.EmployeeId"; // sql code

                // construct our command object
                dbCmd = new SqlCommand(sql, oConn); // pass sql command and database link as a parameter

                dbReader = dbCmd.ExecuteReader();




            }
            catch(Exception exc)
            {
                Console.Error.WriteLine(exc.Message);

            }


            return dbReader;
        }
        /// <summary>
        /// Get all full time employee and stores it into a instance passing the data unto a constructor on the full time employee
        /// Then the instance is added in to a Collection of ArrayList
        /// </summary>
        /// <returns>memarray</returns>

        public static ArrayList getAllFullTime()
        {
            Connect();

            dbReader = getFullTime();

            ArrayList memArray = new ArrayList();
            while (dbReader.Read())
            {
                //aFulltime = new FullTime(
                //    Convert.ToDecimal(dbReader["Salary"]),
                //    Convert.ToDouble(dbReader["NumOfVacationDays"]));
                //Convert.ToBoolean(dbReader["TaxExempt"]),
                //    Convert.ToBoolean(dbReader["HasInsurance"]));
                aFulltime = new FullTime(
                    dbReader["FirstName"].ToString(),
                    dbReader["LastName"].ToString(),
                    Convert.ToDateTime(dbReader["DateHired"]),
                    dbReader["SSN"].ToString(),
                    dbReader["Email"].ToString(),
                    dbReader["Phone"].ToString(),
                    Convert.ToDecimal(dbReader["TaxRate"]),
                    Convert.ToInt32(dbReader["EmployeeId"]),
                    Convert.ToDecimal(dbReader["Salary"]),
                    Convert.ToDouble(dbReader["NumOfVacationDays"]),
                    Convert.ToDouble(dbReader["SickDays"]),
                    Convert.ToBoolean(dbReader["TaxExempt"]),
                    Convert.ToBoolean(dbReader["HasInsurance"]));

                    
                memArray.Add(aFulltime); // the instance in to the ArrayList


            }
            Disconnect();
            return memArray;
        }



        /// <summary>
        /// Insert a Full time employee into both of the tables
        /// </summary>
        /// <param name="insFullTime"></param>
        public static void InsertFullTimeTable(FullTime insFullTime)
        {

            sql ="SET IDENTITY_INSERT Employee ON " + 
                "INSERT INTO Employee(EmployeeId, FirstName, LastName, DateHired, Ssn, Email, Phone, TaxRate)" +
                "VALUES('" +
                insFullTime.EmployeeId + "', '" +
                insFullTime.FirstName + "', '" +
                insFullTime.LastName + "', '" +
                insFullTime.DateHired + "', '" +
                insFullTime.Ssn + "', '" +
                insFullTime.Email + "', '" +
                insFullTime.Phone + "', '" +
                insFullTime.TaxRate + "');" +

                "SET IDENTITY_INSERT Employee OFF "+
                "INSERT INTO FullTime(EmployeeId,Salary, NumOfVacationDays, HasInsurance, TaxExempt, SickDays)" +
                "VALUES('" +
                insFullTime.EmployeeId + "', '" +
                insFullTime.Salary + "', '" +
                insFullTime.NumOfVacationDays + "', '" +
                insFullTime.HasInsurance + "', '" +
                insFullTime.IsTaxExempt + "', '" +
                insFullTime.SickDays + "');";

            Connect();

            SqlCommand cmdInsert = new SqlCommand(sql, oConn);
            ExeCommand(cmdInsert);

        }

        /// <summary>
        /// Updating Database row;
        /// </summary>
        /// <param name="updFullTime"></param>
        public static void UpdateFullTimeTable(FullTime updFullTime)
        {
            // set up an sql command to run in my sql
            sql = "UPDATE Employee SET " +
               
                "FirstName = '" + updFullTime.FirstName + "', " +
                "LastName  = '" + updFullTime.LastName + "', " +
                "DateHired  = '" + updFullTime.DateHired + "', " +
                "Ssn  = '" + updFullTime.Ssn + "', " +
                "Email  = '" + updFullTime.Email + "', " +
                "Phone = '" + updFullTime.Phone + "' " +
                "WHERE EmployeeId = @id " +
                "UPDATE FullTime SET " +
                
                "Salary= '" + updFullTime.Salary + "', " +
                "NumOfVacationDays= '" + updFullTime.NumOfVacationDays + "', " +
                "HasInsurance= '" + updFullTime.HasInsurance + "', " +
                "TaxExempt= '" + updFullTime.IsTaxExempt + "', " +
                "SickDays= '" + updFullTime.SickDays + "' " +
                "WHERE EmployeeId = @id; ";


            Connect();

            SqlCommand cmdUpdate = new SqlCommand(sql, oConn);
            cmdUpdate.Parameters.AddWithValue("@id", updFullTime.EmployeeId);
            ExeCommand(cmdUpdate);

        }

        /// <summary>
        /// Delete the full time employee dynamically
        /// </summary>
        /// <param name="delFullTime"></param>
        public static void DelFullTimeTable(FullTime delFullTime)
        {
            // set up an sql command to run in my sql
            sql = "DELETE Employee " +
                "WHERE EmployeeId = @id; ";


            Connect();

            SqlCommand cmdDelete = new SqlCommand(sql, oConn);
            cmdDelete.Parameters.AddWithValue("@id", aFulltime.EmployeeId); // deleting the employee using the employeeId dynamically make sure both tables are cascaded
            ExeCommand(cmdDelete);

        }

        /// <summary>
        /// execute command to the database
        /// </summary>
        /// <param name="theCmd"></param>
        public static void ExeCommand(SqlCommand theCmd)
        {
            try
            {
                theCmd.ExecuteNonQuery(); // ExecuteNonQuery it means it has to return results of rows

            }
            catch(Exception exc)
            {
                Console.Error.WriteLine(exc.Message);

            }
            finally
            {
                Disconnect();

            }
        }
    }
}
