using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class ChangeNameTransaction:
        ChangeEmployeeTransaction
    {
        private string newName;

        public ChangeNameTransaction(int id,string newName)
            :base(id)
        {
            this.newName = newName;
        }

        protected override void Change(Employee e)
        {
            e.Name = newName;
        }
    }
}
