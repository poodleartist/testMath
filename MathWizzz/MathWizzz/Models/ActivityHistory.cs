using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWizzz.Models
{
    public class ActivityHistory
    {
        public int NumberOfQuestions { get; set; }
        public int NumberOfCorrectAnswers { get; set; }
        public int SkillLevel { get; set; }
        public DateTime DateTime { get; set; }
        public string ActivityType { get; set; }
    }
}
