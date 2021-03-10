namespace MathWizzz.Views
{
    partial class frmViewProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpEditUser = new System.Windows.Forms.GroupBox();
            this.txtSkillLevel = new System.Windows.Forms.TextBox();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEditUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEditUser
            // 
            this.grpEditUser.Controls.Add(this.txtSkillLevel);
            this.grpEditUser.Controls.Add(this.txtClassID);
            this.grpEditUser.Controls.Add(this.txtLName);
            this.grpEditUser.Controls.Add(this.txtFName);
            this.grpEditUser.Controls.Add(this.label5);
            this.grpEditUser.Controls.Add(this.label4);
            this.grpEditUser.Controls.Add(this.label3);
            this.grpEditUser.Controls.Add(this.label2);
            this.grpEditUser.Controls.Add(this.label1);
            this.grpEditUser.Location = new System.Drawing.Point(12, 103);
            this.grpEditUser.Name = "grpEditUser";
            this.grpEditUser.Size = new System.Drawing.Size(501, 526);
            this.grpEditUser.TabIndex = 1;
            this.grpEditUser.TabStop = false;
            this.grpEditUser.Text = "User Profile";
            // 
            // txtSkillLevel
            // 
            this.txtSkillLevel.Location = new System.Drawing.Point(178, 208);
            this.txtSkillLevel.Name = "txtSkillLevel";
            this.txtSkillLevel.ReadOnly = true;
            this.txtSkillLevel.Size = new System.Drawing.Size(255, 38);
            this.txtSkillLevel.TabIndex = 8;
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(178, 260);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.ReadOnly = true;
            this.txtClassID.Size = new System.Drawing.Size(255, 38);
            this.txtClassID.TabIndex = 7;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(178, 147);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(255, 38);
            this.txtLName.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(178, 89);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(255, 38);
            this.txtFName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "ClassID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Skill Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // frmViewProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 822);
            this.Controls.Add(this.grpEditUser);
            this.Name = "frmViewProfile";
            this.Text = "Profile";
            this.grpEditUser.ResumeLayout(false);
            this.grpEditUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditUser;
        private System.Windows.Forms.TextBox txtSkillLevel;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}