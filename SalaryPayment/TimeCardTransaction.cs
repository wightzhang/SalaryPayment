using System;

namespace SalaryPayment
{
    public class TimeCardTransaction:Transaction
    {
        private readonly DateTime date;
        private readonly double hours;
        private readonly int empid;

        public TimeCardTransaction(
            DateTime date, double hours, int empid)
        {
            this.date = date;
            this.hours = hours;
            this.empid = empid;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empid);

            if (e != null)
            {
                HourlyClassification hc = e.Classfication as HourlyClassification;

                if (hc != null)
                {
                    hc.AddTimeCard(new TimeCard(date, hours));
                }
                else
                {
                    throw new Exception("non-hourly employee");
                }
            }
            else
                throw new Exception("No Such Employee");
        }
    }
}
