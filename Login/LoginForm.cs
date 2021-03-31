using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
using WinFormsApp2;
namespace Login
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails();
            ed.Show();
            Hide();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.Show();
            Hide();
        }
    }
}
