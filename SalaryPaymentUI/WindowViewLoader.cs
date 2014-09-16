using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryPaymentUI
{
    public class WindowViewLoader:ViewLoader
    {
        private Form lastLoaderView;
        public void LoadPaymentView()
        {
            PaymentWindow view = new PaymentWindow();
            PaymentPresenter present = new PaymentPresenter(this);

            view.Presnet = present;
            present.View = view;

            LoadView(view);
        }

        public void LoadAddEmployeeView(
            TransactionContainer transactionContainer)
        {
            AddEmployeeWindow view = new AddEmployeeWindow();
            AddEmployeePresenter present = new AddEmployeePresenter(
                view, transactionContainer);
            view.Presenter = present;
            LoadView(view);
        }

        public void LoadAddSalesReceiptView(
            TransactionContainer transactionContainer)
        {
            AddSalesReceiptWindow view = new AddSalesReceiptWindow();
            AddSalesReceiptPresenter presenter = new AddSalesReceiptPresenter(
                view, transactionContainer);
            view.Presenter = presenter;
            LoadView(view);
        }

        private void LoadView(Form view)
        {
            view.Show();
            lastLoaderView = view;
        }

        public Form LastLoaderView
        {
            get { return lastLoaderView; }
        }
    }
}
