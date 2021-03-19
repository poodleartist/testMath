using MathWizzz.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWizzz
{
    public class Drill : Activity
    {
        public int NumberOfAttempts { get; set; }
        public int DrillQuestionCount { get; set; }
        public Question Question { get; set; }
        public Student Student { get; set; }
        public SkillLevel Skill { get; set; }

        public Drill() { }

        public Drill(Student student)
        {
            Student = student;
            Skill = SkillLevelDB.GetSkillLevel(Student.StudentLevel);
            NumberOfAttempts = 1; // student.DrillQuestionAttemps;
            // NumberOfQuestions = 
        }


        public override Question GetNextQuestion()
        {
            if (DrillQuestionCount > 0)
            {
                // generate new Question
                Question = new Question();
                Question.GenerateQuestionAndAnswer(Skill);
                NumberOfAttempts = 1; // Student.DrillQuestionAttempts;
                DrillQuestionCount--;
                return Question;
            } else
            {
                decimal percentScore = (NumberOfCorrectAnswers / NumberOfQuestions * 100);
                percentScore = Decimal.Round(percentScore, 0);
                throw new Exception("Drill is complete.\n\n" +
                    $"You got {NumberOfCorrectAnswers} out of {NumberOfQuestions} correct for a score of " +
                    $"{percentScore}%.");
            }
        }

        public override bool CheckAnswer(int studentAnswer)
        {
            bool isCorrect = Question.CheckAnswer(studentAnswer);

            if (isCorrect)
            {
                NumberOfCorrectAnswers++;
            } else
            {
                NumberOfAttempts--;
            }

            NumberOfQuestions++;

            return isCorrect;
        }

        public override bool StoreActivity()
        {
            // Save completed Drill to the database. Auto-increment Activity ID in database.
            DrillDB.AddCompletedDrill(this, Student);


            return true;
        }
    }
}
