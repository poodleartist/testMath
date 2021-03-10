using MathWizzz.DataAccess;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "\'Date/Time\\tTotal Questions\\tCorrect Answers\\tGrade Percent\\tSkill Level\\tActivit" +
                "y Type\'"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activityHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizzDataSet = new MathWizzz.DataAccess.MathWizzDataSet();
            this.activityHistoryTableAdapter = new MathWizzz.DataAccess.MathWizzDataSetTableAdapters.ActivityHistoryTableAdapter();
            this.tableAdapterManager = new MathWizzz.DataAccess.MathWizzDataSetTableAdapters.TableAdapterManager();
            this.lstViewHistory = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizzDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(276, 127);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(274, 46);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here\'s a listing of your accomplishments:";
            // 
            // activityHistoryBindingSource
            // 
            this.activityHistoryBindingSource.DataMember = "ActivityHistory";
            this.activityHistoryBindingSource.DataSource = this.mathWizzDataSet;
            // 
            // mathWizzDataSet
            // 
            this.mathWizzDataSet.DataSetName = "MathWizzDataSet";
            this.mathWizzDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // activityHistoryTableAdapter
            // 
            this.activityHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActivityHistoryTableAdapter = this.activityHistoryTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentInfoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MathWizzz.DataAccess.MathWizzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // lstViewHistory
            // 
            this.lstViewHistory.HideSelection = false;
            this.lstViewHistory.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstViewHistory.Location = new System.Drawing.Point(12, 256);
            this.lstViewHistory.Name = "lstViewHistory";
            this.lstViewHistory.Size = new System.Drawing.Size(1755, 595);
            this.lstViewHistory.TabIndex = 8;
            this.lstViewHistory.UseCompatibleStateImageBehavior = false;
            this.lstViewHistory.View = System.Windows.Forms.View.List;
            // 
            // frmViewProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1794, 895);
            this.Controls.Add(this.lstViewHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Name = "frmViewProgress";
            this.Text = "frmViewProgress";
            this.Load += new System.EventHandler(this.frmViewProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizzDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private MathWizzDataSet mathWizzDataSet;
        private System.Windows.Forms.BindingSource activityHistoryBindingSource;
        private DataAccess.MathWizzDataSetTableAdapters.ActivityHistoryTableAdapter activityHistoryTableAdapter;
        private DataAccess.MathWizzDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListView lstViewHistory;
    }
}