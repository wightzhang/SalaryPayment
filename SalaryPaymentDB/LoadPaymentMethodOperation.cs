using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryPayment;

namespace SalaryPaymentDB
{
    public class LoadPaymentMethodOperation
    {
        private Employee employee;
        private string methodCode;
        private PaymentMethod method;

        public LoadPaymentMethodOperation(
            Employee employee, string methodCode)
        {
            this.employee = employee;
            this.methodCode = methodCode;
        }

        public void Execute()
        {
            if (methodCode == "hold")
                method = new HoldMethod();
        }

        public PaymentMethod Method
        {
            get { return method; }
        }
    }
}
