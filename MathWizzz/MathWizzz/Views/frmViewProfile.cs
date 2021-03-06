﻿using System;
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
    public partial class frmViewProfile : Form
    {
        private Student student;
        public frmViewProfile()
        {
            InitializeComponent();
        }

        public frmViewProfile(int studentID)
        {

                InitializeComponent();
                student = StudentDB.GetStudentInfo(studentID);

                txtFName.Text = student.firstName;
                txtLName.Text = student.lastName;
                txtSkillLevel.Text = student.studentLevel.ToString();
                txtClassID.Text = student.classID.ToString();
            
        }

        private void btnChangePwd_Click(object sender, EventArgs e)
        {
            student = StudentDB.GetStudentInfo(student.UserId);
            if (student.Password == txtOldPwd.Text)
            {
                
                if(txtNewPwd.Text == txtNewConfirmPwd.Text)

                {
                    if(StudentDB.UpdatePassword(txtNewConfirmPwd.Text, student.UserId))
                    {
                        MessageBox.Show("Password has been successfully change");
                        txtOldPwd.Clear();
                        txtNewPwd.Clear();
                        txtNewConfirmPwd.Clear();
                        txtOldPwd.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Fail");
                    }
                }
            }
            else
            {
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
