
namespace Student
{
    partial class StudentRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbranch = new System.Windows.Forms.ComboBox();
            this.branch = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Semail = new System.Windows.Forms.TextBox();
            this.sage = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.studentId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbranch);
            this.panel1.Controls.Add(this.branch);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.lname);
            this.panel1.Controls.Add(this.fname);
            this.panel1.Controls.Add(this.sid);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.Semail);
            this.panel1.Controls.Add(this.sage);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.studentId);
            this.panel1.Location = new System.Drawing.Point(80, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 375);
            this.panel1.TabIndex = 1;
            // 
            // sbranch
            // 
            this.sbranch.FormattingEnabled = true;
            this.sbranch.Items.AddRange(new object[] {
            "E.E.E",
            "MECH",
            "CIVIL",
            "CSE",
            "ECE"});
            this.sbranch.Location = new System.Drawing.Point(419, 221);
            this.sbranch.Name = "sbranch";
            this.sbranch.Size = new System.Drawing.Size(105, 23);
            this.sbranch.TabIndex = 14;
            // 
            // branch
            // 
            this.branch.AutoSize = true;
            this.branch.Location = new System.Drawing.Point(362, 224);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(44, 15);
            this.branch.TabIndex = 13;
            this.branch.Text = "Branch";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(91, 224);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 12;
            this.Email.Text = "Email";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(362, 157);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(28, 15);
            this.Age.TabIndex = 11;
            this.Age.Text = "Age";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(91, 157);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(60, 15);
            this.lname.TabIndex = 10;
            this.lname.Text = "LastName";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(347, 86);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(59, 15);
            this.fname.TabIndex = 9;
            this.fname.Text = "Firstname";
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Location = new System.Drawing.Point(91, 86);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(58, 15);
            this.sid.TabIndex = 8;
            this.sid.Text = "StudentId";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(380, 289);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(265, 289);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 6;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Semail
            // 
            this.Semail.Location = new System.Drawing.Point(179, 221);
            this.Semail.Name = "Semail";
            this.Semail.Size = new System.Drawing.Size(100, 23);
            this.Semail.TabIndex = 4;
            // 
            // sage
            // 
            this.sage.Location = new System.Drawing.Point(419, 154);
            this.sage.Name = "sage";
            this.sage.Size = new System.Drawing.Size(100, 23);
            this.sage.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(179, 154);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 23);
            this.lastName.TabIndex = 2;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(419, 83);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 23);
            this.firstName.TabIndex = 1;
            // 
            // studentId
            // 
            this.studentId.Location = new System.Drawing.Point(179, 83);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(100, 23);
            this.studentId.TabIndex = 0;
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "StudentRegistration";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox sbranch;
        private System.Windows.Forms.Label branch;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox Semail;
        private System.Windows.Forms.TextBox sage;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox studentId;
    }
}