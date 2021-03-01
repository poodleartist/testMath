
namespace MathWizzz
{
    partial class frmDrill
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelDrill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(87, 109);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(482, 30);
            this.txtQuestion.TabIndex = 0;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(87, 204);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(252, 28);
            this.txtAnswer.TabIndex = 1;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(87, 302);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(96, 45);
            this.btnSubmitAnswer.TabIndex = 2;
            this.btnSubmitAnswer.Text = "Submit";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(29, 114);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(30, 24);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Q:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "A:";
            // 
            // btnCancelDrill
            // 
            this.btnCancelDrill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDrill.Location = new System.Drawing.Point(323, 302);
            this.btnCancelDrill.Name = "btnCancelDrill";
            this.btnCancelDrill.Size = new System.Drawing.Size(131, 45);
            this.btnCancelDrill.TabIndex = 5;
            this.btnCancelDrill.Text = "Cancel Drill";
            this.btnCancelDrill.UseVisualStyleBackColor = true;
            this.btnCancelDrill.Click += new System.EventHandler(this.btnCancelDrill_Click);
            // 
            // frmDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnCancelDrill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnSubmitAnswer);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Name = "frmDrill";
            this.Text = "Drill";
            this.Load += new System.EventHandler(this.frmDrill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelDrill;
    }
}