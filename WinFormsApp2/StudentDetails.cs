using Student;
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


namespace WinFormsApp2
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            SqlConnection vcn = new SqlConnection();
            try
            {

                vcn.ConnectionString = "Data Source=DESKTOP-0KJOSO5;Initial Catalog=master;Integrated Security=True";

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from [dbo].[student_data]";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = vcn;

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = cmd;
                da.Fill(ds);
                StudentData.DataSource = ds.Tables[0];



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

        private void Register_Click(object sender, EventArgs e)
        {
            StudentRegistration sr = new StudentRegistration();
            sr.Show();
            Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
