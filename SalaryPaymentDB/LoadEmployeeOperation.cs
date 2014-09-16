using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SalaryPayment;

namespace SalaryPaymentDB
{
    public class LoadEmployeeOperation
    {
        private int empId;
        private Employee employee;

        public LoadEmployeeOperation(int empId)
        {
            this.empId = empId;
        }

        public Employee Employee
        {
            get { return employee; }
        }

        public void Execute()
        {
            string sql = "select *  from Employee where EmpId = @EmpId";
            object[] par = { empId };
            DataRow row = 
                SqliteHelper.ExecuteDataSet(sql, par).Tables[0].Rows[0];

            CreateEmplyee(row);
            AddSchedule(row);
            AddPaymentMethod(row);

        }

        private void CreateEmplyee(DataRow row)
        {
            string name = row["Name"].ToString();
            string address = row["Address"].ToString();
            employee = new Employee(empId, name, address);
        }

        private void AddSchedule(DataRow row)
        {
            string scheduleType = row["ScheduleType"].ToString();
            if (scheduleType.Equals("weekly"))
                employee.Schedule = new WeeklySchedule();
            else if (scheduleType.Equals("biweekly"))
                employee.Schedule = new BiweeklySchedule();
            else if (scheduleType.Equals("monthly"))
                employee.Schedule = new MonthlySchedule();
        }

        void AddPaymentMethod(DataRow row)
        {
            string methodCode = row["PaymentMethodType"].ToString();
            LoadPaymentMethodOperation operation = 
                new LoadPaymentMethodOperation(employee, methodCode);

            operation.Execute();
            employee.Method = operation.Method;
        }

    }
}
