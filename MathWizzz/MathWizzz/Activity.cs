using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz
{
    public abstract class Activity
    {
        public int ActivityID { get; set; }
        public int NumberOfQuestions { get; set; }
        public int NumberOfCorrectAnswers { get; set; }
       // public SkillLevel SkillLevel { get; set; }

        public abstract Question GetNextQuestion();

        public abstract bool CheckAnswer(int answer);
      //  public abstract bool StoreActivity();

    }
}
