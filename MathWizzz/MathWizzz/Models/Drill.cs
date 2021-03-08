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
        public Question Question { get; set; }

        public Drill() { }


        public override Question GetNextQuestion()
        {
            // generate new Question
            Question = new Question();
            Question.GenerateQuestionAndAnswer();
            return Question;
        }

        public override bool CheckAnswer(int answer)
        {
            bool isCorrect = Question.CheckAnswer(answer);

            if (isCorrect)
            {
                NumberOfCorrectAnswers++;
            }

            NumberOfQuestions++;

            return isCorrect;
        }

        public override bool StoreActivity()
        {
            // Save completed Drill to the database. Auto-increment Activity ID in database.



            return true;
        }



        // public void SetNumberOfQuestions() { } ... Not sure if we want this here...
    }
}
