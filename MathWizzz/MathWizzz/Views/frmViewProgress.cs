using MathWizzz.Models;
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
            lblName.Text = student.firstName;
            var historyList = new List<ActivityHistory>();
            historyList = StudentDB.GetActivityHistory(Convert.ToInt32(student.userId));
            foreach (ActivityHistory history in historyList)
            {
                string singleLine = history.DateTime.ToString() + "\t     " + history.NumberOfQuestions
                    + "\t     " + history.NumberOfCorrectAnswers + "\t     " + (history.NumberOfCorrectAnswers/history.NumberOfQuestions*100).ToString()
                    + "\t     " + history.ActivityType;
                lstViewHistory.Items.Add(singleLine);
            }

        }

      

      

      
    }
}
