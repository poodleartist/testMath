using System;

namespace MathWizzz
{
    public class Question
    {
        public SkillLevel SkillLevel { get; set; }
        public string NewQuestion { get; set; }
        public int Answer { get; set; }

        public Question() { }

        public Question(SkillLevel skillLevel)
        {
            SkillLevel = skillLevel;
            GenerateQuestionAndAnswer();
        }

        public bool CheckAnswer(int newAnswer)
        {
            if (Answer == newAnswer)
                return true;
            else
                return false;
        }

        public void GenerateQuestionAndAnswer()
        {
            Random random = new Random();
            int firstOperand = random.Next(SkillLevel.MinValue, SkillLevel.MaxValue);
            int secondOperand = random.Next(SkillLevel.MinValue, SkillLevel.MaxValue);
            string mathOperator = "";
            switch (SkillLevel.MathOperator)
            {
                case "+":
                    mathOperator = " + ";
                    Answer = firstOperand + secondOperand;
                    break;
                case "S":
                    mathOperator = " - ";
                    Answer = firstOperand - secondOperand;
                    break;
                case "M":
                    mathOperator = " * ";
                    Answer = firstOperand * secondOperand;
                    break;
                case "D":
                    mathOperator = " / ";
                    Answer = firstOperand / secondOperand;
                    break;
            }

            NewQuestion = firstOperand + " " + mathOperator + " " + secondOperand;
        }
    }
}