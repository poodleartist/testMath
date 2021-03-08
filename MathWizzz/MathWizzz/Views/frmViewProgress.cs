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
        public frmViewProgress(int studentID)
        {
            
            Student student = new Student();

            student = StudentDB.GetStudentById(studentID);
            this.student = student;
            InitializeComponent();
        }

        private void frmViewProgress_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathWizzDataSet.ActivityHistory' table. You can move, or remove it, as needed.
            this.activityHistoryTableAdapter.Fill(this.mathWizzDataSet.ActivityHistory);

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (txtEnterStudentId.Text != "")
            {
                //string studentId = Convert.ToInt32(txtEnterStudentId.Text);
                string studentId = txtEnterStudentId.Text;
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

        private void GetStudent(string studentId)
        {
            try
            {
                student = StudentDB.GetStudentById(int.Parse(studentId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void activityHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.activityHistoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mathWizzDataSet);

        }

        private void fillByStudentIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.activityHistoryTableAdapter.FillByStudentID(this.mathWizzDataSet.ActivityHistory, ((int)(System.Convert.ChangeType(studentIdToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
