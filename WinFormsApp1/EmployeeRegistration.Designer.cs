
namespace Employee
{
    partial class EmployeeRegistration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Agelbl = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Eid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Phonelbl);
            this.groupBox1.Controls.Add(this.Emaillbl);
            this.groupBox1.Controls.Add(this.Agelbl);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.EmployeeId);
            this.groupBox1.Controls.Add(this.PhoneNo);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.Lname);
            this.groupBox1.Controls.Add(this.Fname);
            this.groupBox1.Controls.Add(this.Eid);
            this.groupBox1.Location = new System.Drawing.Point(71, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Login";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(349, 251);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Location = new System.Drawing.Point(333, 184);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(60, 15);
            this.Phonelbl.TabIndex = 11;
            this.Phonelbl.Text = "Phone No";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Location = new System.Drawing.Point(80, 184);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(36, 15);
            this.Emaillbl.TabIndex = 10;
            this.Emaillbl.Text = "Email";
            // 
            // Agelbl
            // 
            this.Agelbl.AutoSize = true;
            this.Agelbl.Location = new System.Drawing.Point(364, 111);
            this.Agelbl.Name = "Agelbl";
            this.Agelbl.Size = new System.Drawing.Size(29, 15);
            this.Agelbl.TabIndex = 9;
            this.Agelbl.Text = "AGE";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(76, 111);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(63, 15);
            this.LastName.TabIndex = 8;
            this.LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(333, 39);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(64, 15);
            this.FirstName.TabIndex = 7;
            this.FirstName.Text = "First Name";
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(66, 39);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(73, 15);
            this.EmployeeId.TabIndex = 6;
            this.EmployeeId.Text = "Employee ID";
            // 
            // PhoneNo
            // 
            this.PhoneNo.Location = new System.Drawing.Point(403, 181);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(100, 23);
            this.PhoneNo.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(145, 181);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 23);
            this.Email.TabIndex = 4;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(403, 108);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 23);
            this.Age.TabIndex = 3;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(145, 108);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(100, 23);
            this.Lname.TabIndex = 2;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(403, 36);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(100, 23);
            this.Fname.TabIndex = 1;
            // 
            // Eid
            // 
            this.Eid.Location = new System.Drawing.Point(145, 36);
            this.Eid.Name = "Eid";
            this.Eid.Size = new System.Drawing.Size(100, 23);
            this.Eid.TabIndex = 0;
            // 
            // EmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeRegistration";
            this.Text = "Employee Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Agelbl;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.TextBox PhoneNo;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Eid;
    }
}