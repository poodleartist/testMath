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

            person = UserDB.GetUserByUserId(userId);
            //If a user is found from the student DB then the homepage will launch for the student.
            if (person != null)
            {
                if(person.userRole == "Student")
                {
                    Student stu = new Student();
                    stu = StudentDB.GetStudentById(userId);


                    //MessageBox.Show("person role:" + person.userRole);
                    this.Hide();
                    frmHomePage HomePage = new frmHomePage(stu);
                    HomePage.ShowDialog();
                    this.Show();
                }
                else if(person.userRole == "Teacher")
                {
                    //MessageBox.Show("person role:" + person.userRole);
                    this.Hide();
                    //frmHomePage HomePage = new frmHomePage(person);
                    //HomePage.ShowDialog();
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
            ////this.Show();

        }
    }
}
