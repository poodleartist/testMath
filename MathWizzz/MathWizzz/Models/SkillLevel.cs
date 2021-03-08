namespace MathWizzz
{
    public class SkillLevel
    {

        public int SkillLevelID { get; set; }
        public int NumberOfDigits { get; set; }
        public int NumberOfDecimalPlaces { get; set; }
        public string MathOperator { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }


        public SkillLevel()
        {

        }

        public SkillLevel(int skillLevelId)
        {

        }

    }
}