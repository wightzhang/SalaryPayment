namespace SalaryPaymentUI
{
    partial class AddEmployeeWindow
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
            this.empIdLabel = new System.Windows.Forms.Label();
            this.empIdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.commissionRadioButton = new System.Windows.Forms.RadioButton();
            this.salaryRadioButton = new System.Windows.Forms.RadioButton();
            this.commissiomTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.commissionRateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Location = new System.Drawing.Point(13, 47);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(35, 12);
            this.empIdLabel.TabIndex = 0;
            this.empIdLabel.Text = "empId";
            // 
            // empIdTextBox
            // 
            this.empIdTextBox.Location = new System.Drawing.Point(75, 47);
            this.empIdTextBox.Name = "empIdTextBox";
            this.empIdTextBox.Size = new System.Drawing.Size(100, 21);
            this.empIdTextBox.TabIndex = 1;
            this.empIdTextBox.TextChanged += new System.EventHandler(this.empIdTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(75, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 21);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "name";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(75, 159);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 21);
            this.addressTextBox.TabIndex = 5;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "address";
            // 
            // hourlyRadioButton
            // 
            this.hourlyRadioButton.AutoSize = true;
            this.hourlyRadioButton.Location = new System.Drawing.Point(243, 48);
            this.hourlyRadioButton.Name = "hourlyRadioButton";
            this.hourlyRadioButton.Size = new System.Drawing.Size(59, 16);
            this.hourlyRadioButton.TabIndex = 6;
            this.hourlyRadioButton.TabStop = true;
            this.hourlyRadioButton.Text = "Hourly";
            this.hourlyRadioButton.UseVisualStyleBackColor = true;
            this.hourlyRadioButton.CheckedChanged += new System.EventHandler(this.hourlyRadioButton_CheckedChanged);
            // 
            // commissionRadioButton
            // 
            this.commissionRadioButton.AutoSize = true;
            this.commissionRadioButton.Location = new System.Drawing.Point(243, 160);
            this.commissionRadioButton.Name = "commissionRadioButton";
            this.commissionRadioButton.Size = new System.Drawing.Size(83, 16);
            this.commissionRadioButton.TabIndex = 7;
            this.commissionRadioButton.TabStop = true;
            this.commissionRadioButton.Text = "Commission";
            this.commissionRadioButton.UseVisualStyleBackColor = true;
            this.commissionRadioButton.CheckedChanged += new System.EventHandler(this.commissionRadioButton_CheckedChanged);
            // 
            // salaryRadioButton
            // 
            this.salaryRadioButton.AutoSize = true;
            this.salaryRadioButton.Location = new System.Drawing.Point(243, 99);
            this.salaryRadioButton.Name = "salaryRadioButton";
            this.salaryRadioButton.Size = new System.Drawing.Size(59, 16);
            this.salaryRadioButton.TabIndex = 8;
            this.salaryRadioButton.TabStop = true;
            this.salaryRadioButton.Text = "Salary";
            this.salaryRadioButton.UseVisualStyleBackColor = true;
            this.salaryRadioButton.CheckedChanged += new System.EventHandler(this.salaryRadioButton_CheckedChanged);
            // 
            // commissiomTextBox
            // 
            this.commissiomTextBox.Enabled = false;
            this.commissiomTextBox.Location = new System.Drawing.Point(341, 194);
            this.commissiomTextBox.Name = "commissiomTextBox";
            this.commissiomTextBox.Size = new System.Drawing.Size(100, 21);
            this.commissiomTextBox.TabIndex = 11;
            this.commissiomTextBox.TextChanged += new System.EventHandler(this.commissiomTextBox_TextChanged);
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Enabled = false;
            this.salaryTextBox.Location = new System.Drawing.Point(341, 102);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 21);
            this.salaryTextBox.TabIndex = 10;
            this.salaryTextBox.TextChanged += new System.EventHandler(this.salaryTextBox_TextChanged);
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Enabled = false;
            this.hourlyRateTextBox.Location = new System.Drawing.Point(341, 42);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.hourlyRateTextBox.TabIndex = 9;
            this.hourlyRateTextBox.TextChanged += new System.EventHandler(this.hourlyRateTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(359, 244);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(82, 41);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // commissionRateTextBox
            // 
            this.commissionRateTextBox.Enabled = false;
            this.commissionRateTextBox.Location = new System.Drawing.Point(341, 160);
            this.commissionRateTextBox.Name = "commissionRateTextBox";
            this.commissionRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.commissionRateTextBox.TabIndex = 14;
            this.commissionRateTextBox.TextChanged += new System.EventHandler(this.commissionRateTextBox_TextChanged);
            // 
            // AddEmployeeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 317);
            this.Controls.Add(this.commissionRateTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.commissiomTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.hourlyRateTextBox);
            this.Controls.Add(this.salaryRadioButton);
            this.Controls.Add(this.commissionRadioButton);
            this.Controls.Add(this.hourlyRadioButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empIdTextBox);
            this.Controls.Add(this.empIdLabel);
            this.Name = "AddEmployeeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.TextBox empIdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton hourlyRadioButton;
        private System.Windows.Forms.RadioButton commissionRadioButton;
        private System.Windows.Forms.RadioButton salaryRadioButton;
        private System.Windows.Forms.TextBox commissiomTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox commissionRateTextBox;
    }
}