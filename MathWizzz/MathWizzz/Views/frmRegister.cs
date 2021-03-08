using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathWizzz.Views
{
    public partial class frmRegister : Form
    {
        string[] arrary = { "Student", "Teacher" };
        public frmRegister()
        {
            InitializeComponent();
            cboRole.DataSource = arrary;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isInsert = true;
            //isInsert = StudentDB.AddUser("insert into Users values('" + txtUserID.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" +
            //    txtPassword.Text + "','" + cboRole.SelectedItem.ToString() + "')");
            if (isInsert == false)
            {
                MessageBox.Show("insert data error");
            }
        }
    }
}
