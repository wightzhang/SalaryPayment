using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class Paycheck
    {
        private readonly DateTime payDate;
        private readonly DateTime startDate;
        private readonly Hashtable fields = new Hashtable();

        public Paycheck(DateTime startDate,DateTime payDate)
        {
            this.startDate = startDate;
            this.payDate = payDate;
        }

        public DateTime StartDate
        {
            get { return startDate; }
        }

        public DateTime PayDate
        {
            get { return payDate; }
        }

        public double GrossPay { get; set; }

        public void SetField(string fieldName, string value)
        {
            fields[fieldName] = value;
        }

        public string GetField(string fieldName)
        {
            return fields[fieldName] as string;
        }
    }
}
