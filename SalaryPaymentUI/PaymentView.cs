﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPaymentUI
{
    public interface PaymentView
    {
        string TransactionsText { set; }
        string EmployeesText { set; }
        PaymentPresenter Presenter { set; }
    }
}
