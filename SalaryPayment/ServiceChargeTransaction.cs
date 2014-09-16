using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class ServiceChargeTransaction:Transaction
    {
        private readonly int memberId;
        private DateTime time;
        private double charge;

        public ServiceChargeTransaction(
            int memberId, DateTime time, double charge)
        {
            this.memberId = memberId;
            this.time = time;
            this.charge = charge;
        }

        public void Execute()
        {
            Employee e = PayrollDatabase.GetUnionMember(memberId);
        }
    }
}
