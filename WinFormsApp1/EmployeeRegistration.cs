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

using WinFormsApp1;

namespace Employee
{
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection vcn = new SqlConnection();

            try
            {
                int eid = int.Parse(Eid.Text);
                string fname = Fname.Text;
                string lname = Lname.Text;
                int age = int.Parse(Age.Text);
                string email = Email.Text;
                long phoneNo = long.Parse(PhoneNo.Text);

                vcn.ConnectionString = "Data Source=DESKTOP-0KJOSO5;Initial Catalog=master;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "insert into [dbo].[employee_data] values(" + eid + "," + "'" + fname + "'" + "," + "'" + lname + "'" + "," + age + "," + "'" + email + "'" + "," + phoneNo + ")";

                cmd.CommandType = CommandType.Text;
                cmd.Connection = vcn;

                vcn.Open();
                int result = cmd.ExecuteNonQuery();
                MessageBox.Show(result.ToString() + "row affected");

                Hide();
                EmployeeDetails f2 = new EmployeeDetails();
                f2.Show();

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

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
            EmployeeDetails f2 = new EmployeeDetails();
            f2.Show();
        }
    }
}
