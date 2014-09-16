using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalaryPayment;
using System.Data.SQLite;

namespace SalaryPaymentDB
{
    public class SqlitePaymentDatabase:PaymentDatabase
    {
        public SqlitePaymentDatabase()
        {}

        public void AddEmployee(Employee employee)
        {
            SaveEmployeeOperation operation = 
                new SaveEmployeeOperation(employee);
            operation.Execute();
        }

        public Employee GetEmployee(int id)
        {
            string sql = "select *  from Employee where EmpId = @EmpId";
            object[] par = {id};
            DataSet ds = SqliteHelper.ExecuteDataSet(sql, par);
            DataRow row = ds.Tables[0].Rows[0];
            string name = ds.Tables[0].Rows[0]["Name"].ToString();
            string address = ds.Tables[0].Rows[0]["Address"].ToString();

            return new Employee(id, name, address);
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void AddUnionMember(int id, Employee e)
        {
            throw new NotImplementedException();
        }

        public Employee GetUnionMember(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveUnionMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public System.Collections.ArrayList GetAllEmployeeIds()
        {
            throw new NotImplementedException();
        }

        public System.Collections.IList GetAllEmployees()
        {
            throw new NotImplementedException();
        }

    }
}
