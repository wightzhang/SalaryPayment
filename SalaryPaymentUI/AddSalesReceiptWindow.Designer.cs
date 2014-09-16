namespace SalaryPaymentUI
{
    partial class AddSalesReceiptWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.SalesReceiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.Location = new System.Drawing.Point(56, 36);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Size = new System.Drawing.Size(119, 21);
            this.empIdTextBox.TabIndex = 0;
            this.empIdTextBox.TextChanged += new System.EventHandler(this.empIdTextBox_TextChanged);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(56, 73);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(119, 21);
            this.amountTextBox.TabIndex = 1;
            this.amountTextBox.TextChanged += new System.EventHandler(this.amountTextBox_TextChanged);
            // 
            // SalesReceiptDateTimePicker
            // 
            this.SalesReceiptDateTimePicker.Location = new System.Drawing.Point(56, 121);
            this.SalesReceiptDateTimePicker.Name = "SalesReceiptDateTimePicker";
            this.SalesReceiptDateTimePicker.Size = new System.Drawing.Size(119, 21);
            this.SalesReceiptDateTimePicker.TabIndex = 2;
            this.SalesReceiptDateTimePicker.ValueChanged += new System.EventHandler(this.SalesReceiptDateTimePicker_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(268, 106);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(80, 39);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // AddSalesReceiptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 192);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.SalesReceiptDateTimePicker);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.empIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddSalesReceiptWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSalesReceiptWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker SalesReceiptDateTimePicker;
        private System.Windows.Forms.Button submitButton;
    }
}