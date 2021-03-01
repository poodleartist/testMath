﻿using System;

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
            
            MinValue = min;
            MaxValue = max;
        }

        public void GenerateQuestionAndAnswer()
        {
            Random random = new Random();
            int firstOperand = random.Next()
        }
    }
}