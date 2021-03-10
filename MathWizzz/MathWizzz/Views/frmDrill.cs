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

        public frmDrill(Student drillStudent)
        {
            InitializeComponent();
            Student = drillStudent;
            Drill = new Drill(drillStudent);

            // generate first Question object.
            Drill.GetNextQuestion();

            txtQuestion.Text = Drill.Question.NewQuestion;

            txtAnswer.Select();
        }

        private void frmDrill_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayQuestion()
        {
            txtQuestion.Text = Drill.Question.NewQuestion;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            // Validate answer is in proper format
            try
            {
                
                int answer = int.Parse(txtAnswer.Text);
                bool isCorrect = Drill.CheckAnswer(answer);
                if (!isCorrect && Drill.NumberOfAttempts > 0)
                {
                    MessageBox.Show("Incorrect answer.\n\nTry again.", "Incorrect answer.");
                } else if (!isCorrect)
                {
                    MessageBox.Show($"Incorrect answer.\n\nThe correct answer is: {Drill.Question.Answer}", "Incorrect Answer");
                } else
                {
                    MessageBox.Show("Correct!", "Correct Answer");
                    txtAnswer.Text = "";
                    Drill.GetNextQuestion();
                    txtQuestion.Text = Drill.Question.NewQuestion;
                }
                
            } catch (FormatException)
            {
                MessageBox.Show("Please enter a number.", e.GetType().ToString());
            } catch (Exception f)
            {
                MessageBox.Show(f.Message, f.GetType().ToString());
            }
            // Compare user's answer with answer property of Question object

            // Display if answer is correct or not to user (Modal pop-up?)

            // If answer was correct or user is out of attempts, load new question.
            // Otherwise, clear Answer field and put cursor there.

        }

        private void btnCancelDrill_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
