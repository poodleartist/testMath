﻿using MathWizzz.DataAccess;
using MathWizzz.Views;
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

        private Student student;

        //Load the number of selection to the combo box.
        public frmHomePage()
        {
            InitializeComponent();
            
            foreach (int i in numOfQuestion )
            cboDrill.Items.Add(i);
        }

        //Pass the student object to the form and display the student info.
        public frmHomePage(int studentID)
        {
            Student student = new Student();

            student = StudentDB.GetStudentById(studentID);
            this.student = student;

            
            InitializeComponent();
            
            foreach (int i in numOfQuestion)
            cboDrill.Items.Add(i);

            lblWelcome.Text = student.FirstName + " " + student.LastName;
            
            //lblWelcome.Text = "ABC" + " " + "CDE";


        }

        public frmHomePage(Student student)
        {

            
            this.student = student;


            InitializeComponent();

            foreach (int i in numOfQuestion)
                cboDrill.Items.Add(i);

            lblWelcome.Text = student.FirstName + " " + student.LastName;

            //lblWelcome.Text = "ABC" + " " + "CDE";


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When the user make a number of question selection load the question and show the drill form.
        private void cbxDrill_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numQuestion = Int16.Parse(cboDrill.Text);            
            this.Hide();
            frmDrill DrillForm = new frmDrill(student, Convert.ToInt32(cboDrill.Text));
            DrillForm.ShowDialog();
            this.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProfile profileForm = new frmViewProfile(student.userId);
            profileForm.ShowDialog();
            this.Close();
        }

        private void btnViewProgression_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewProgress viewProgress = new frmViewProgress(student);
            viewProgress.ShowDialog();
            this.Show();
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {

        }
    }
}
