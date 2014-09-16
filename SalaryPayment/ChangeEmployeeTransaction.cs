using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public abstract class ChangeEmployeeTransaction:Transaction
    {
        private int empId;

        public ChangeEmployeeTransaction(int empId)
        {
            this.empId = empId;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
                Change(e);
            else
                throw new Exception("No Such Employee");
        }

        protected abstract void Change(Employee e);
    }
}
