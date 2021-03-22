using System;

namespace MathWizzz
{
    public class Question
    {
        //public SkillLevel SkillLevel { get; set; }
        public string NewQuestion { get; set; }
        public double Answer { get; set; }

        public Question() { }

        public Question(SkillLevel skillLevel)
        {
            GenerateQuestionAndAnswer(skillLevel);
        }

        public bool CheckAnswer(double studentAnswer)
        {
            if (Answer == studentAnswer)
                return true;
            else
                return false;
        }

        public void GenerateQuestionAndAnswer(SkillLevel skill)
        {
            Random random = new Random();
            double firstOperand = random.Next(skill.MinValue, skill.MaxValue);
            double secondOperand = random.Next(skill.MinValue, skill.MaxValue);
            string mathOperator = "";
            switch (skill.MathOperator)
            {
                case "+":
                    mathOperator = " + ";
                    Answer = firstOperand + secondOperand;
                    break;
                case "-":
                    mathOperator = " - ";
                    Answer = firstOperand - secondOperand;
                    break;
                case "*":
                    mathOperator = " * ";
                    Answer = firstOperand * secondOperand;
                    break;
                case "/":
                    mathOperator = " / ";
                    Answer = firstOperand / secondOperand;
                    Answer = Math.Round(Answer, 2);
                    break;
            }

            NewQuestion = firstOperand + " " + mathOperator + " " + secondOperand;
        }
    }
}