using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class HoldMethod:PaymentMethod
    {

        public void Pay(Paycheck paycheck)
        {
            paycheck.SetField("Disposition", "Hold");
        }

        public override string ToString()
        {
            return "Hold";
        }
    }
}
