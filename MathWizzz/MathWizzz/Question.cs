using System;

namespace MathWizzz
{
    public class Question
    {
        public int SkillLevel { get; set; }
        public string NewQuestion { get; set; }
        public int Answer { get; set; }
        public int NumberOfDigits { get; set; }
        public int NumberOfDecimalPlaces { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public string Operator { get; set; }

        public Question(int skillLevel, int digits, int decimals, int min, int max, string mathOperator)
        {
            SkillLevel = skillLevel;
            NumberOfDigits = digits;
            NumberOfDecimalPlaces = decimals;
            Operator = mathOperator;
            MinValue = min;
            MaxValue = max;
        }

        public void GenerateQuestionAndAnswer()
        {
            Random random = new Random();
            int firstOperand = random.Next(MinValue, MaxValue);
            int secondOperand = random.Next(MinValue, MaxValue);
            string mathOperator = "";
            switch (Operator)
            {
                case "A":
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

            NewQuestion = firstOperand + mathOperator + secondOperand;
        }
    }
}