namespace MathWizzz
{
    partial class frmViewProgress
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
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtEnterStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(904, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(274, 46);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(774, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here\'s a listing of your accomplishments:";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(130, 147);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(203, 74);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Student Info";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtEnterStudentId
            // 
            this.txtEnterStudentId.Location = new System.Drawing.Point(164, 82);
            this.txtEnterStudentId.Name = "txtEnterStudentId";
            this.txtEnterStudentId.Size = new System.Drawing.Size(100, 38);
            this.txtEnterStudentId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "For Testing purposes, enter student ID";
            // 
            // frmViewProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 807);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterStudentId);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Name = "frmViewProgress";
            this.Text = "frmViewProgress";
            this.Load += new System.EventHandler(this.frmViewProgress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtEnterStudentId;
        private System.Windows.Forms.Label label2;
    }
}