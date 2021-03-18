using MathWizzz.DataAccess;
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
    public partial class frmDrill : Form
    {
        public Student Student { get; set; }
        public Drill Drill { get; set; }

        public frmDrill(Student drillStudent, int numQuestions)
        {
            InitializeComponent();
            Student = drillStudent;
            Drill = new Drill(drillStudent);
            Drill.DrillQuestionCount = numQuestions;

            // generate first Question object.
            Drill.GetNextQuestion();

            txtQuestion.Text = Drill.Question.NewQuestion;

            txtAnswer.Select();
        }

        private void frmDrill_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            try
            {

                int answer = int.Parse(txtAnswer.Text);
                bool isCorrect = Drill.CheckAnswer(answer);
                if (!isCorrect && Drill.NumberOfAttempts > 0)
                {
                    MessageBox.Show("Incorrect answer.\n\nTry again.", "Incorrect answer.");
                }
                else if (!isCorrect)
                {
                    if (Drill.NumberOfAttempts > 0)
                    {
                        MessageBox.Show("Incorrect, please try again.", "Incorrect Answer");

                    }
                    else
                    {
                        MessageBox.Show($"Incorrect answer.\n\nThe correct answer is: {Drill.Question.Answer}", "Incorrect Answer");
                        txtAnswer.Text = "";
                        Drill.GetNextQuestion();
                        txtQuestion.Text = Drill.Question.NewQuestion;
                    }

                }
                else
                {
                    MessageBox.Show("Correct!", "Correct Answer");
                    txtAnswer.Text = "";
                    Drill.GetNextQuestion();
                    txtQuestion.Text = Drill.Question.NewQuestion;
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
                //DrillDB.AddCompletedDrill(Drill, Student, ???);
                this.Hide();
                frmHomePage HomePage = new frmHomePage(Student.UserId);
                HomePage.ShowDialog();
            }
        }

        private void btnCancelDrill_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHomePage HomePage = new frmHomePage(Student.UserId);
            HomePage.ShowDialog();
        }


    }
}
