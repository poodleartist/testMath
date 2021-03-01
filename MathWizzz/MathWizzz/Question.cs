using System;

namespace MathWizzz
{
    public class Question
    {
        public int SkillLevel { get; set; }
        public string NewQuestion { get; set; }
        public int Answer { get; set; }

        public Question(int skillLevel)
        {
            SkillLevel = skillLevel;
            GenerateQuestionAndAnswer();
        }

        private void GenerateQuestionAndAnswer()
        {
            Random random = new Random();
            int firstOperand = random.Next()
        }
    }
}