using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class ChangeAddressTransaction:
        ChangeEmployeeTransaction
    {
        private string newAddress;

        public ChangeAddressTransaction(int id, string newAddress)
            : base(id)
        {
            this.newAddress = newAddress;
        }

        protected override void Change(Employee e)
        {
            e.Address = newAddress;
        }
    }
}
