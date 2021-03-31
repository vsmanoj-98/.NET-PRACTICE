using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace Student
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

            SqlConnection vcn = new SqlConnection();

            try
            {
                int eid = int.Parse(studentId.Text);
                string fname = firstName.Text;
                string lname = lastName.Text;
                int age = int.Parse(sage.Text);
                string email = Semail.Text;
                string branch = sbranch.Text;

                vcn.ConnectionString = "Data Source=DESKTOP-0KJOSO5;Initial Catalog=master;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "insert into [dbo].[student_data] values(" + eid + "," + "'" + fname + "'" + "," + "'" + lname + "'" + "," + age + "," + "'" + email + "'" + "," + "'" + branch + "'" + ")";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = vcn;

                vcn.Open();
                int result = cmd.ExecuteNonQuery();
                MessageBox.Show(result.ToString() + "row affected");

                Hide();
                StudentDetails sr = new StudentDetails();
                sr.Show();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (vcn.State == ConnectionState.Open)
                {
                    vcn.Close();
                }

            }
        }
/*
        private void cancel_Click(object sender, EventArgs e)
        {
            Hide();
            StudentDetails sr = new StudentDetails();
            sr.Show();
        }*/

        private void cancel_Click_1(object sender, EventArgs e)
        {
            Hide();
            StudentDetails sr = new StudentDetails();
            sr.Show();
        }
    }
}
    

