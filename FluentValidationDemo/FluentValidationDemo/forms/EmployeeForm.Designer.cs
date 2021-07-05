
namespace FluentValidationDemo.forms
{
    partial class EmployeeForm
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
            this.pnEmployee = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHiredDate = new System.Windows.Forms.DateTimePicker();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pnLocation = new System.Windows.Forms.Panel();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.pnJob = new System.Windows.Forms.Panel();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nupSalary = new System.Windows.Forms.NumericUpDown();
            this.pnEmployee.SuspendLayout();
            this.pnLocation.SuspendLayout();
            this.pnJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEmployee
            // 
            this.pnEmployee.Controls.Add(this.label5);
            this.pnEmployee.Controls.Add(this.label4);
            this.pnEmployee.Controls.Add(this.label3);
            this.pnEmployee.Controls.Add(this.label2);
            this.pnEmployee.Controls.Add(this.label1);
            this.pnEmployee.Controls.Add(this.dtpHiredDate);
            this.pnEmployee.Controls.Add(this.tbPhoneNumber);
            this.pnEmployee.Controls.Add(this.tbEmail);
            this.pnEmployee.Controls.Add(this.tbLastName);
            this.pnEmployee.Controls.Add(this.tbFirstName);
            this.pnEmployee.Location = new System.Drawing.Point(12, 81);
            this.pnEmployee.Name = "pnEmployee";
            this.pnEmployee.Size = new System.Drawing.Size(363, 189);
            this.pnEmployee.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hired Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // dtpHiredDate
            // 
            this.dtpHiredDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHiredDate.Location = new System.Drawing.Point(124, 141);
            this.dtpHiredDate.Name = "dtpHiredDate";
            this.dtpHiredDate.Size = new System.Drawing.Size(224, 26);
            this.dtpHiredDate.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.Location = new System.Drawing.Point(124, 110);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(224, 26);
            this.tbPhoneNumber.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(124, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(224, 26);
            this.tbEmail.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(124, 48);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(224, 26);
            this.tbLastName.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(124, 17);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(224, 26);
            this.tbFirstName.TabIndex = 0;
            // 
            // pnLocation
            // 
            this.pnLocation.Controls.Add(this.cboProvince);
            this.pnLocation.Controls.Add(this.tbAddress);
            this.pnLocation.Controls.Add(this.label8);
            this.pnLocation.Controls.Add(this.label7);
            this.pnLocation.Controls.Add(this.label6);
            this.pnLocation.Controls.Add(this.tbCity);
            this.pnLocation.Location = new System.Drawing.Point(12, 298);
            this.pnLocation.Name = "pnLocation";
            this.pnLocation.Size = new System.Drawing.Size(683, 124);
            this.pnLocation.TabIndex = 1;
            // 
            // cboProvince
            // 
            this.cboProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Ontario"});
            this.cboProvince.Location = new System.Drawing.Point(92, 26);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(191, 28);
            this.cboProvince.TabIndex = 7;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(92, 79);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(486, 26);
            this.tbAddress.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Province:";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(354, 28);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(224, 26);
            this.tbCity.TabIndex = 8;
            // 
            // pnJob
            // 
            this.pnJob.Controls.Add(this.nupSalary);
            this.pnJob.Controls.Add(this.cboTitle);
            this.pnJob.Controls.Add(this.label9);
            this.pnJob.Controls.Add(this.label10);
            this.pnJob.Location = new System.Drawing.Point(394, 104);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(301, 170);
            this.pnJob.TabIndex = 2;
            // 
            // cboTitle
            // 
            this.cboTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Intern",
            "Project Manager",
            "Software Engineer"});
            this.cboTitle.Location = new System.Drawing.Point(75, 21);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(214, 28);
            this.cboTitle.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Title:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Salary:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(252, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Insert Employee";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(366, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(12, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(12, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Location";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(394, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Job";
            // 
            // nupSalary
            // 
            this.nupSalary.DecimalPlaces = 2;
            this.nupSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSalary.Location = new System.Drawing.Point(75, 55);
            this.nupSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupSalary.Name = "nupSalary";
            this.nupSalary.Size = new System.Drawing.Size(214, 26);
            this.nupSalary.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 504);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnJob);
            this.Controls.Add(this.pnLocation);
            this.Controls.Add(this.pnEmployee);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.pnEmployee.ResumeLayout(false);
            this.pnEmployee.PerformLayout();
            this.pnLocation.ResumeLayout(false);
            this.pnLocation.PerformLayout();
            this.pnJob.ResumeLayout(false);
            this.pnJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHiredDate;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Panel pnLocation;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Panel pnJob;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nupSalary;
    }
}