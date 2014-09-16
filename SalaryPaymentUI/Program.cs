using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalaryPaymentUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PaymentWindow window = new PaymentWindow();
            WindowViewLoader viewLoader = new WindowViewLoader();
            viewLoader.LoadPaymentView();
            Application.Run(viewLoader.LastLoaderView);
        }
    }
}
