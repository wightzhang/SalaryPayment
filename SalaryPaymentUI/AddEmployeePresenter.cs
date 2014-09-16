using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryPayment;

namespace SalaryPaymentUI
{
    public class AddEmployeePresenter
    {
        private readonly TransactionContainer transactionContainer;
        //private PayrollDatabase database;
        private readonly AddEmployeeView view;
        private int empId;
        private string name;
        private string address;
        private bool isHourly;
        private double hourlyRate;
        private bool isSalary;
        private double salary;
        private bool isCommission;
        private double commissionSalary;
        private double commission;

        public AddEmployeePresenter(AddEmployeeView view,
            TransactionContainer transactionContainer)
        {
            this.view = view;
            this.transactionContainer = transactionContainer;
            //this.database = database;
        }

        public int EmpId
        {
            get { return empId; }
            set
            {
                empId = value;
                UpdateView();
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                UpdateView();
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                UpdateView();
            }
        }

        public bool IsHourly
        {
            get { return isHourly; }
            set
            {
                isHourly = value;
                UpdateView();
            }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                hourlyRate = value;
                UpdateView();
            }
        }

        public bool IsSalary
        {
            get { return isSalary; }
            set
            {
                isSalary = value;
                UpdateView();
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                UpdateView();
            }
        }

        public bool IsCommission
        {
            get { return isCommission; }
            set
            {
                isCommission = value;
                UpdateView();
            }
        }

        public double CommissionSalary
        {
            get { return commissionSalary; }
            set
            {
                commissionSalary = value;
                UpdateView();
            }
        }

        public double Commission
        {
            get { return commission; }
            set
            {
                commission = value;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            view.SubmitEnable = AllInformtionIsCollected();
        }

        private bool AllInformtionIsCollected()
        {
            bool result = true;
            result &= empId > 0;
            result &= !string.IsNullOrEmpty(name);
            result &= !string.IsNullOrEmpty(address);
            result &= isHourly || isSalary || isCommission;
            if (isHourly)
                result &= hourlyRate > 0;
            else if (isSalary)
                result &= salary > 0;
            else if (isCommission)
            {
                result &= commission > 0;
                result &= commissionSalary > 0;
            }
            return result;
        }

        public TransactionContainer TransactionContainer
        {
            get { return transactionContainer; }
        }

        public virtual void AddEmployee()
        {
            transactionContainer.Add(CreateTransaction());
        }

        private Transaction CreateTransaction()
        {
            if (isHourly)
                return new AddHourlyEmployee(
                    empId, name, address, hourlyRate);
            else if (isSalary)
                return new AddSalariedEmployee(
                    empId, name, address, salary);
            else 
                return new AddCommissionedEmployee(
                    empId, name, address, commissionSalary, commission);
        }    
    }
}
