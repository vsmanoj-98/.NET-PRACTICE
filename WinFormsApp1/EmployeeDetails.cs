using Employee;
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

namespace WinFormsApp1
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            SqlConnection vcn = new SqlConnection();
            try
            {

                vcn.ConnectionString = "Data Source=DESKTOP-0KJOSO5;Initial Catalog=master;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from [dbo].[employee_data];";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = vcn;

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];



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

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeRegistration er = new EmployeeRegistration();
            er.Show();
            Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
