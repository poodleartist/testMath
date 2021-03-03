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
    public partial class frmViewProgress : Form
    {
        private Student student;
        public frmViewProgress()
        {
            InitializeComponent();
        }

        private void frmViewProgress_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (txtEnterStudentId.Text != "")
            {
                int studentId = Convert.ToInt32(txtEnterStudentId.Text);
                this.GetStudent(studentId);
                if (student == null)
                {
                    MessageBox.Show("No student found with that ID. "
                        + "Please try again.", "Student Not Found");
                }
                else
                {
                    lblName.Text = student.FirstName;
                }
            }
        }

        private void GetStudent(int studentId)
        {
            try
            {
                student = StudentDB.GetStudentById(studentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


    }
}
