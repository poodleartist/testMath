using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.Models
{
    public class Test : Activity
    {
        public int TestQuestionCount { get; set; }
        public Question Question { get; set; }
        public Student Student { get; set; }
        public SkillLevel Skill { get; set; }


        public Test (Student student)
        {
            Student = student;
            Skill = SkillLevelDB.GetSkillLevel(Student.StudentLevel);
        }

        public override bool CheckAnswer(int studentAnswer)
        {
            bool isCorrect = Question.CheckAnswer(studentAnswer);

            if (isCorrect)
            {
                NumberOfCorrectAnswers++;
            }

            NumberOfQuestions++;

            return isCorrect;
        }

        public override Question GetNextQuestion()
        {
            if (TestQuestionCount > 0)
            {
                // generate new Question
                Question = new Question();
                Question.GenerateQuestionAndAnswer(Skill);
                //NumberOfAttempts = 1; // Student.DrillQuestionAttempts;
                TestQuestionCount--;
                return Question;
            }
            else
            {
                decimal percentScore = (NumberOfCorrectAnswers / NumberOfQuestions * 100);
                percentScore = Decimal.Round(percentScore, 0);
                throw new Exception("Test is complete.\n\n" +
                    $"You got {NumberOfCorrectAnswers} out of {NumberOfQuestions} correct for a score of " +
                    $"{percentScore}%.");
            }
        }

        public override bool StoreActivity()
        {
            // Save completed Test to the database. Auto-increment Activity ID in database.


            return true;
        }
    }
}
