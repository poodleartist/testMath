using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWizzz
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Show Home page
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pwd = txtPassword.Text;

            //If a user is found from the student DB then the homepage will launch for the student.
            if (StudentDB.GetStudentInfo(username, pwd) != null)
            {
                this.Hide();
                frmHomePage HomePage = new frmHomePage();
                HomePage.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Incorrect password, or username. Please try again");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
