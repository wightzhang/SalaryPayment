﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public interface PaymentDatabase
    {
        void AddEmployee(Employee employee);
        Employee GetEmployee(int id);
        void DeleteEmployee(int id);
        void AddUnionMember(int id, Employee e);
        Employee GetUnionMember(int id);
        void RemoveUnionMember(int memberId);
        ArrayList GetAllEmployeeIds();
        IList GetAllEmployees();
    }
}
