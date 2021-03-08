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
    public partial class frmHomePage : Form
    {
        //Number of question selection.
        int[] numOfQuestion = { 5, 10, 15, 20 };

        //Load the number of selection to the combo box.
        public frmHomePage()
        {
            InitializeComponent();
            foreach (int i in numOfQuestion )
            cbxDrill.Items.Add(i);
        }

        //Pass the student object to the form and display the student info.
        public frmHomePage(Student student)
        {
            InitializeComponent();
            foreach (int i in numOfQuestion)
            cbxDrill.Items.Add(i);

            //lblWelcome.Text = student.FirstName + " " + student.LastName;
            lblWelcome.Text = "ABC" + " " + "CDE";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When the user make a number of question selection load the question and show the drill form.
        private void cbxDrill_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numQuestion = Int16.Parse(cbxDrill.Text);
            this.Hide();
            frmDrill DrillForm = new frmDrill();
            DrillForm.ShowDialog();

        }
    }
}
