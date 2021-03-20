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
                isInsert = UserDB.AddUser("insert into Users values('" + txtUserName.Text + "','" + txtPassword.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cboRole.SelectedItem.ToString() + "')");
                if (isInsert == false)
                {
                    MessageBox.Show("insert data error");
                }
                else
                {
                    //After inserting the new user create a student and get that student info and store it in student
                    //Set the skill to 1 and default number of question to 20 so that student can take a placement test - Tai

                    Student student = new Student();
                    student = StudentDB.StudentLogin(txtUserName.Text, txtPassword.Text);
                    student.StudentLevel = 1;
                    student.classID = Convert.ToInt16(txtClassroom.Text);
                    int numQuestion = 10;
                    frmPlacementTest placement = new frmPlacementTest(student, numQuestion);
                    placement.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Please fill out all of the fields provided.");
            }
        }
    }
}
