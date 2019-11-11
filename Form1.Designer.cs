namespace U3ExamEmpSys
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstBxFullTime = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxID = new System.Windows.Forms.TextBox();
            this.txtBxFName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.txtBxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxVac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxSick = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxInsure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtBxDateHired = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBxSsn = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxTaxRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.label13 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBxFullTime
            // 
            this.lstBxFullTime.FormattingEnabled = true;
            this.lstBxFullTime.Location = new System.Drawing.Point(142, 180);
            this.lstBxFullTime.Name = "lstBxFullTime";
            this.lstBxFullTime.Size = new System.Drawing.Size(210, 134);
            this.lstBxFullTime.TabIndex = 0;
            this.lstBxFullTime.SelectedIndexChanged += new System.EventHandler(this.lstBxFullTime_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(142, 330);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(210, 59);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(464, 95);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(95, 25);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Welcome";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EmployeeID";
            // 
            // txtBxID
            // 
            this.txtBxID.Location = new System.Drawing.Point(509, 167);
            this.txtBxID.Name = "txtBxID";
            this.txtBxID.Size = new System.Drawing.Size(100, 20);
            this.txtBxID.TabIndex = 4;
            // 
            // txtBxFName
            // 
            this.txtBxFName.Location = new System.Drawing.Point(509, 207);
            this.txtBxFName.Name = "txtBxFName";
            this.txtBxFName.Size = new System.Drawing.Size(100, 20);
            this.txtBxFName.TabIndex = 6;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(439, 210);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 13);
            this.FirstName.TabIndex = 5;
            this.FirstName.Text = "FirstName";
            // 
            // txtBxLName
            // 
            this.txtBxLName.Location = new System.Drawing.Point(509, 251);
            this.txtBxLName.Name = "txtBxLName";
            this.txtBxLName.Size = new System.Drawing.Size(100, 20);
            this.txtBxLName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "LastName";
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.Location = new System.Drawing.Point(509, 291);
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(100, 20);
            this.txtBxSalary.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salary";
            // 
            // txtBxVac
            // 
            this.txtBxVac.Location = new System.Drawing.Point(509, 333);
            this.txtBxVac.Name = "txtBxVac";
            this.txtBxVac.Size = new System.Drawing.Size(100, 20);
            this.txtBxVac.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "No. Of Vacation Days";
            // 
            // txtBxSick
            // 
            this.txtBxSick.Location = new System.Drawing.Point(509, 372);
            this.txtBxSick.Name = "txtBxSick";
            this.txtBxSick.Size = new System.Drawing.Size(100, 20);
            this.txtBxSick.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sick Days";
            // 
            // txtBxTax
            // 
            this.txtBxTax.AccessibleDescription = "True Or False";
            this.txtBxTax.Location = new System.Drawing.Point(509, 407);
            this.txtBxTax.Name = "txtBxTax";
            this.txtBxTax.Size = new System.Drawing.Size(100, 20);
            this.txtBxTax.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tax Exempt";
            // 
            // txtBxInsure
            // 
            this.txtBxInsure.Location = new System.Drawing.Point(509, 440);
            this.txtBxInsure.Name = "txtBxInsure";
            this.txtBxInsure.Size = new System.Drawing.Size(100, 20);
            this.txtBxInsure.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Insurance";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnUpdate,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(972, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "toolStripButton1";
            this.btnAdd.ToolTipText = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(574, 476);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(149, 40);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "Okay";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtBxDateHired
            // 
            this.txtBxDateHired.Location = new System.Drawing.Point(712, 167);
            this.txtBxDateHired.Name = "txtBxDateHired";
            this.txtBxDateHired.Size = new System.Drawing.Size(100, 20);
            this.txtBxDateHired.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Date Hired";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(654, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "SSN";
            // 
            // txtBxSsn
            // 
            this.txtBxSsn.Location = new System.Drawing.Point(712, 203);
            this.txtBxSsn.Name = "txtBxSsn";
            this.txtBxSsn.Size = new System.Drawing.Size(100, 20);
            this.txtBxSsn.TabIndex = 26;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(712, 247);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmail.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Email";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(712, 287);
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtBxPhone.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(645, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Phone";
            // 
            // txtBxTaxRate
            // 
            this.txtBxTaxRate.Location = new System.Drawing.Point(712, 332);
            this.txtBxTaxRate.Name = "txtBxTaxRate";
            this.txtBxTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtBxTaxRate.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(632, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Tax Rate";
            // 
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(23, 22);
            this.btnUpdate.Text = "toolStripButton1";
            this.btnUpdate.ToolTipText = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "toolStripButton1";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(313, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(396, 31);
            this.label13.TabIndex = 33;
            this.label13.Text = "Employee Management System\r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(972, 585);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBxTaxRate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBxSsn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBxDateHired);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtBxInsure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxSick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxVac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxFName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.txtBxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstBxFullTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxFullTime;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxID;
        private System.Windows.Forms.TextBox txtBxFName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox txtBxLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxVac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxSick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxInsure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtBxDateHired;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBxSsn;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBxPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxTaxRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Label label13;
    }
}

