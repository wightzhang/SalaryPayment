using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class SalesReceiptTransaction:Transaction
    {
        private readonly DateTime date;
        private readonly double amount;
        private readonly int empId;

        public SalesReceiptTransaction(
            DateTime date, double amount, int empId)
        {
            this.date = date;
            this.amount = amount;
            this.empId = empId;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
            {
                CommissionClassification cc =
                    e.Classfication as CommissionClassification;
                if (cc != null)
                    cc.AddSalesReceipt(new SalesReceipt(date, amount));
                else
                    throw new Exception(
                        "Tried to add sales receipt to " +
                        "non-commissioned employee");
            }
            else
                throw new ApplicationException(
                    "No such employee.");
        }

        public override string ToString()
        {
            return String.Format("{0}  id:{1}   time:{2}   amount:{3}", 
                GetType().Name, empId, date.ToString("yyyy-MM-dd"), amount);
        }

    }
}
