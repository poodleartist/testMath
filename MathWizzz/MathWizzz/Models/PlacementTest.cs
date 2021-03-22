using MathWizzz.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.Models
{
    public class PlacementTest : Activity
    {
        public int NumberOfAttempts { get; set; }
        public int DrillQuestionCount { get; set; }
        public Question Question { get; set; }
        public Student Student { get; set; }
        public SkillLevel Skill { get; set; }
        public int streak;
        public PlacementTest() { }

        public PlacementTest(Student student)
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
            }
            else
            {
                decimal percentScore = (NumberOfCorrectAnswers / NumberOfQuestions * 100);
                percentScore = Decimal.Round(percentScore, 0);
                throw new Exception("Drill is complete.\n\n" +
                    $"You got {NumberOfCorrectAnswers} out of {NumberOfQuestions} correct for a score of " +
                    $"{percentScore}%.");
            }
        }

        public override bool CheckAnswer(double studentAnswer)
        {
            bool isCorrect = Question.CheckAnswer(studentAnswer);

            if (isCorrect)
            {
                streak++;
                NumberOfCorrectAnswers++;

                //If the student get 3 right in a row then increase the skill level 
                //by 1 after that if they get 2 right consecutively increase skill level by 1
                if(streak >= 2)
                {
                    Student.studentLevel += 1;
                    Skill = SkillLevelDB.GetSkillLevel(Student.StudentLevel);
                    streak = 0;
                }


            }
            else
            {
                NumberOfAttempts--;

                //Reset streak if they get a question wrong.
                streak = 0;
            }

            NumberOfQuestions++;

            return isCorrect;
        }

        public override bool StoreActivity()
        {
            // Save completed Drill to the database. Auto-increment Activity ID in database.
            DrillDB.AddCompletedPlacement(this, Student);


            return true;
        }

    }
}
