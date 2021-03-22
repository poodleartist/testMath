namespace MathWizzz
{
    partial class frmHomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReward = new System.Windows.Forms.Button();
            this.btnViewProgression = new System.Windows.Forms.Button();
            this.cboDrill = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(97, 109);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(142, 28);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnReward
            // 
            this.btnReward.Location = new System.Drawing.Point(97, 188);
            this.btnReward.Margin = new System.Windows.Forms.Padding(2);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(142, 28);
            this.btnReward.TabIndex = 3;
            this.btnReward.Text = "Reward Points";
            this.btnReward.UseVisualStyleBackColor = true;
            // 
            // btnViewProgression
            // 
            this.btnViewProgression.Location = new System.Drawing.Point(97, 228);
            this.btnViewProgression.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewProgression.Name = "btnViewProgression";
            this.btnViewProgression.Size = new System.Drawing.Size(142, 28);
            this.btnViewProgression.TabIndex = 4;
            this.btnViewProgression.Text = "View Progression";
            this.btnViewProgression.UseVisualStyleBackColor = true;
            this.btnViewProgression.Click += new System.EventHandler(this.btnViewProgression_Click);
            // 
            // cboDrill
            // 
            this.cboDrill.FormattingEnabled = true;
            this.cboDrill.Location = new System.Drawing.Point(97, 155);
            this.cboDrill.Margin = new System.Windows.Forms.Padding(2);
            this.cboDrill.Name = "cboDrill";
            this.cboDrill.Size = new System.Drawing.Size(145, 21);
            this.cboDrill.TabIndex = 5;
            this.cboDrill.Text = "Drills";
            this.cboDrill.SelectedIndexChanged += new System.EventHandler(this.cbxDrill_SelectedIndexChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(94, 83);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(35, 13);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "label1";
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.Location = new System.Drawing.Point(97, 269);
            this.btnTakeTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(142, 28);
            this.btnTakeTest.TabIndex = 7;
            this.btnTakeTest.Text = "Take Test";
            this.btnTakeTest.UseVisualStyleBackColor = true;
            this.btnTakeTest.Visible = false;
            this.btnTakeTest.Click += new System.EventHandler(this.btnTakeTest_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 370);
            this.Controls.Add(this.btnTakeTest);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.cboDrill);
            this.Controls.Add(this.btnViewProgression);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.Button btnViewProgression;
        private System.Windows.Forms.ComboBox cboDrill;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTakeTest;
    }
}