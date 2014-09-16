using System;

namespace SalaryPayment
{
    public abstract class AddEmployeeTransaction:Transaction
    {
        private readonly int empid;
        private readonly string name;
        private readonly string address;

        protected AddEmployeeTransaction(
            int empid, string name, string address)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
        }

        public void Execute()
        {
            PaymentClassification pc = MakeClassfication();
            PaymentSchedule ps = MakeSchedule();
            PaymentMethod pm = new HoldMethod();
            Employee e = new Employee(empid, name, address) 
            {
                Classfication = pc, 
                Schedule = ps, 
                Method = pm
            };
            PayrollDatabase.AddEmployee_Static(e);
        }


        protected abstract PaymentClassification MakeClassfication();
        protected abstract PaymentSchedule MakeSchedule();

        public override string ToString()
        {
            return String.Format("{0}  id:{1}   name:{2}   address:{3}",
                GetType().Name, empid, name, address);
        }
    }
}
