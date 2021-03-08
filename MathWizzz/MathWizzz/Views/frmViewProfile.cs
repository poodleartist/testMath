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
                student = StudentDB.GetStudentById(studentID);

                txtFName.Text = student.firstName;
                txtLName.Text = student.lastName;
                txtSkillLevel.Text = student.studentLevel.ToString();
                txtClassID.Text = student.classID.ToString();
            
        }
    }
}
