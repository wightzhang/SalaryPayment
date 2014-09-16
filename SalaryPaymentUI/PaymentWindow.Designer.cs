namespace SalaryPaymentUI
{
    partial class PaymentWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.transcationsTextBox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.addSalesReceiptbutton = new System.Windows.Forms.Button();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(21, 12);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(88, 40);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "AddEmployee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // transcationsTextBox
            // 
            this.transcationsTextBox.Location = new System.Drawing.Point(21, 58);
            this.transcationsTextBox.Multiline = true;
            this.transcationsTextBox.Name = "transcationsTextBox";
            this.transcationsTextBox.Size = new System.Drawing.Size(404, 110);
            this.transcationsTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(21, 174);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(88, 41);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run Transaction";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(21, 221);
            this.employeeTextBox.Multiline = true;
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(404, 46);
            this.employeeTextBox.TabIndex = 3;
            // 
            // addSalesReceiptbutton
            // 
            this.addSalesReceiptbutton.Location = new System.Drawing.Point(124, 12);
            this.addSalesReceiptbutton.Name = "addSalesReceiptbutton";
            this.addSalesReceiptbutton.Size = new System.Drawing.Size(88, 40);
            this.addSalesReceiptbutton.TabIndex = 4;
            this.addSalesReceiptbutton.Text = "AddEmployee";
            this.addSalesReceiptbutton.UseVisualStyleBackColor = true;
            this.addSalesReceiptbutton.Click += new System.EventHandler(this.addSalesReceiptbutton_Click);
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.ItemHeight = 12;
            this.employeesListBox.Location = new System.Drawing.Point(21, 283);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(404, 100);
            this.employeesListBox.TabIndex = 5;
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 406);
            this.Controls.Add(this.employeesListBox);
            this.Controls.Add(this.addSalesReceiptbutton);
            this.Controls.Add(this.employeeTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.transcationsTextBox);
            this.Controls.Add(this.addEmployeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaymentWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalaryPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.TextBox transcationsTextBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.Button addSalesReceiptbutton;
        private System.Windows.Forms.ListBox employeesListBox;
    }
}

