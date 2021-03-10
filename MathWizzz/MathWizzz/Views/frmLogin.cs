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
            string userId = txtUsername.Text;
            string pwd = txtPassword.Text;
            Person person = new Person();

            person = StudentDB.StudentLogin(userId, pwd);
            //If a user is found from the student DB then the homepage will launch for the student.
            if (person != null)
            {
                if (person.userRole == "Student" || person.userRole == "student")
                {
                    //Student stu = new Student();
                    //stu = StudentDB.GetStudentById(int.Parse(userId));

                    //MessageBox.Show("person role:" + person.userRole);
                    this.Hide();
                    frmHomePage HomePage = new frmHomePage(int.Parse(person.userId));
                    HomePage.ShowDialog();
                    this.Show();
            }
            else if (person.userRole == "Teacher")
            {

                this.Hide();

                this.Show();
            }
        }
            else
            {
                MessageBox.Show("Incorrect password, or username. Please try again");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Views.frmRegister register = new Views.frmRegister();
            register.ShowDialog();
        }
    }
}
