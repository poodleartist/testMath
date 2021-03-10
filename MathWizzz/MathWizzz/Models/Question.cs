using System;

namespace MathWizzz
{
    public class Question
    {
        //public SkillLevel SkillLevel { get; set; }
        public string NewQuestion { get; set; }
        public int Answer { get; set; }

        public Question() { }

        public Question(SkillLevel skillLevel)
        {
            GenerateQuestionAndAnswer(skillLevel);
        }

        public bool CheckAnswer(int studentAnswer)
        {
            if (Answer == studentAnswer)
                return true;
            else
                return false;
        }

        public void GenerateQuestionAndAnswer(SkillLevel skill)
        {
            Random random = new Random();
            int firstOperand = random.Next(skill.MinValue, skill.MaxValue);
            int secondOperand = random.Next(skill.MinValue, skill.MaxValue);
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
                    break;
            }

            NewQuestion = firstOperand + " " + mathOperator + " " + secondOperand;
        }
    }
}