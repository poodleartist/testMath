using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWizzz.Views
{
    public partial class frmRegister : Form
    {
        string[] arrary = { "Student", "Teacher" };
        public frmRegister()
        {
            InitializeComponent();
            cboRole.DataSource = arrary;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            bool isInsert = true;
            bool addToStudentInfo = false;

            Models.User user = new Models.User();
            user.UserName = txtUserName.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Password = txtPassword.Text;
            user.UserRole = cboRole.SelectedItem.ToString();

            if (String.IsNullOrWhiteSpace(user.UserName))
            {
                isValid = false;
            }
            if (String.IsNullOrWhiteSpace(user.FirstName))
            {
                isValid = false;
            }
            if (String.IsNullOrWhiteSpace(user.LastName))
            {
                isValid = false;
            }
            if (String.IsNullOrWhiteSpace(user.Password))
            {
                isValid = false;
            }
            if (String.IsNullOrWhiteSpace(user.UserRole))
            {
                isValid = false;
            }

            if (isValid == true)
            {
                isInsert = UserDB.AddUser("insert into Users values('" + txtUserName.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtPassword.Text + "','" + cboRole.SelectedItem.ToString() + "')");
                if (isInsert == false)
                {
                    MessageBox.Show("insert data error");
                }
                else
                {
                    Student student = new Student();
                    student = StudentDB.StudentLogin(user.UserName, user.Password);

                    if (student != null)
                    {
                        addToStudentInfo = StudentDB.AddToStudentInfo("INSERT INTO StudentInfo (StudentId) " +
                                                "VALUES ('" + student.UserId + "')");
                        frmHomePage HomePage = new frmHomePage(student.userId);
                        HomePage.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please try closing this page and signing in, if the issue persist please email us!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all of the fields provided.");
            }
        }
    }
}
