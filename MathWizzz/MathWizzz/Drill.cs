using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Question question = new Question();
            question.GenerateQuestionAndAnswer();
            return question;
        }

        public override bool CheckAnswer(int answer)
        {
            bool isCorrect = Question.CheckAnswer(answer);
            return isCorrect;
        }

        public override bool StoreActivity()
        {
            // Save completed Drill to the database. Auto-increment Activity ID in database.
        }



        // public void SetNumberOfQuestions() { } ... Not sure if we want this here...
    }
}
