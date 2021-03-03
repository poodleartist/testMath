using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWizzz
{
    public partial class frmDrill : Form
    {
        public Question Question { get; set; }
        public SkillLevel SkillLevel { get; set; }
        public int UserID { get; set; }

        public frmDrill()
        {
            InitializeComponent();
        }
        private void frmDrill_Load(object sender, EventArgs e)
        {
            // generate SkillLevel object
            SkillLevel skillLevel = new SkillLevel();
            

            // generate first Question object.
            Question = new Question(
                student.skillLevelID,
                skillLevel.NumberOfDigits,
                skillLevel.NumberOfDecimalPlaces,
                skillLevel.MinValue,
                skillLevel.MaxValue,
                skillLevel.MathOperator);
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            // Validate answer is in proper format

            // Compare user's answer with answer property of Question object

            // Display if answer is correct or not to user (Modal pop-up?)

            // If answer was correct or user is out of attempts, load new question.
            // Otherwise, clear Answer field and put cursor there.

        }

        private void btnCancelDrill_Click(object sender, EventArgs e)
        {

        }

        
    }
}
