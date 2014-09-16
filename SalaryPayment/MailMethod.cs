using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class MailMethod:PaymentMethod
    {
        private readonly string address;

        public MailMethod(string address)
        {
            this.address = address;
        }

        public void Pay(Paycheck paycheck)
        {
            paycheck.SetField("Disposition", "Mail");
        }

        public string Address
        {
            get { return address; }
        }

        public override string ToString()
        {
            return string.Format("mail ({0})", address);
        }
    }
}
