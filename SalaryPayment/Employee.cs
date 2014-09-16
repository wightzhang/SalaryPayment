using System;
using System.Text;

namespace SalaryPayment
{
    public class Employee
    {
        private readonly int empid;
        private string name;
        private string address;
        private PaymentClassification classification;
        private PaymentMethod method;
        private PaymentSchedule schedule;
        public Employee(int empid, string name, string address)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
        }

        public int EmpId { get { return empid; } }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public PaymentClassification Classfication
        {
            get { return classification; } 
            set { classification = value; }             
        }

        public PaymentSchedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
            
        }

        public PaymentMethod Method
        {
            get { return method; } 
            set { method = value; } 
        }

        public bool IsPayDate(DateTime payDate)
        {
            return schedule.IsPayday(payDate);
        }

        public void PayDay(Paycheck paycheck)
        {
            double grossPay = classification.CalculatePay(paycheck);

            paycheck.GrossPay = grossPay;
            method.Pay(paycheck);
        }

        public DateTime GetPayPeriodStartDate(DateTime payDate)
        {
            return schedule.GetPayPeriodStartDate(payDate);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Emp#: ").Append(empid).Append("   ");
            builder.Append(name).Append("   ");
            builder.Append(address).Append("   ");
            builder.Append("Paid ").Append(classification).Append(" ");
            builder.Append(schedule);
            builder.Append(" by ").Append(method);
            return builder.ToString();
        }
    }
}
