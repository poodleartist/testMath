using MathWizzz.DataAccess;
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

namespace MathWizzz.Views
{
    public partial class frmPlacementTest : Form
    {
        public frmPlacementTest()
        {
            InitializeComponent();
        }

        public Student Student;
        public PlacementTest Placement { get; set; }

        public frmPlacementTest(Student drillStudent, int numQuestions)
        {            
            InitializeComponent();
            Student = drillStudent;
            Placement = new PlacementTest(drillStudent);
            Placement.DrillQuestionCount = numQuestions;

            // generate first Question object.
            Placement.GetNextQuestion();

            txtQuestion.Text = Placement.Question.NewQuestion;

            txtAnswer.Select();
        }

        private void frmDrill_Load(object sender, EventArgs e)
        {

        }




        private void btnSubmitAnswer_Click_1(object sender, EventArgs e)
        {
            try
            {

                int answer = int.Parse(txtAnswer.Text);
                bool isCorrect = Placement.CheckAnswer(answer);
                if (!isCorrect && Placement.NumberOfAttempts > 0)
                {
                    MessageBox.Show("Incorrect answer.\n\nTry again.", "Incorrect answer.");
                }
                else if (!isCorrect)
                {
                    if (Placement.NumberOfAttempts > 0)
                    {
                        MessageBox.Show("Incorrect, please try again.", "Incorrect Answer");

                    }
                    else
                    {
                        MessageBox.Show($"Incorrect answer.\n\nThe correct answer is: {Placement.Question.Answer}", "Incorrect Answer");
                        txtAnswer.Text = "";
                        Placement.GetNextQuestion();
                        txtQuestion.Text = Placement.Question.NewQuestion;
                    }

                }
                else
                {
                    MessageBox.Show("Correct!", "Correct Answer");
                    txtAnswer.Text = "";

                    Placement.GetNextQuestion();
                    txtQuestion.Text = Placement.Question.NewQuestion;
                    txtAnswer.Focus();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number.", e.GetType().ToString());
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
                // I am not understanding what the Activity History class is for, so I'm not sure how to call this method
                Student.StudentLevel = Placement.Student.StudentLevel;

                //Add student level. studentid, and class to the studentinfo class to store ActivityData
                StudentInfoDB.AddToStudentInfo(Student);
                DrillDB.AddCompletedPlacement(Placement, Student);
                MessageBox.Show("Congratulation you just finish your placement and currently at level " + Student.studentLevel);
                this.Hide();
                frmHomePage HomePage = new frmHomePage(Student);
                HomePage.ShowDialog();
            }
        }

        private void btnCancelDrill_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage HomePage = new frmHomePage(Student);
            HomePage.ShowDialog();
        }
    }
}
