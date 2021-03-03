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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewProgress));
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtEnterStudentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activityHistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.activityHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mathWizzDataSet = new MathWizzz.MathWizzDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activityHistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activityHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradePercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByStudentIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentIdToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentIdToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByStudentIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.activityHistoryTableAdapter = new MathWizzz.MathWizzDataSetTableAdapters.ActivityHistoryTableAdapter();
            this.tableAdapterManager = new MathWizzz.MathWizzDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingNavigator)).BeginInit();
            this.activityHistoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizzDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryDataGridView)).BeginInit();
            this.fillByStudentIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(897, 120);
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
            this.btnLoadData.Location = new System.Drawing.Point(265, 207);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(203, 74);
            this.btnLoadData.TabIndex = 2;
            this.btnLoadData.Text = "Load Student Info";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtEnterStudentId
            // 
            this.txtEnterStudentId.Location = new System.Drawing.Point(188, 128);
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
            // activityHistoryBindingNavigator
            // 
            this.activityHistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.activityHistoryBindingNavigator.BindingSource = this.activityHistoryBindingSource;
            this.activityHistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.activityHistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.activityHistoryBindingNavigator.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.activityHistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.activityHistoryBindingNavigatorSaveItem});
            this.activityHistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.activityHistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.activityHistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.activityHistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.activityHistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.activityHistoryBindingNavigator.Name = "activityHistoryBindingNavigator";
            this.activityHistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.activityHistoryBindingNavigator.Size = new System.Drawing.Size(1465, 47);
            this.activityHistoryBindingNavigator.TabIndex = 5;
            this.activityHistoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 44);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 47);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(44, 44);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 47);
            // 
            // activityHistoryBindingNavigatorSaveItem
            // 
            this.activityHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.activityHistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("activityHistoryBindingNavigatorSaveItem.Image")));
            this.activityHistoryBindingNavigatorSaveItem.Name = "activityHistoryBindingNavigatorSaveItem";
            this.activityHistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(44, 44);
            this.activityHistoryBindingNavigatorSaveItem.Text = "Save Data";
            this.activityHistoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.activityHistoryBindingNavigatorSaveItem_Click);
            // 
            // activityHistoryDataGridView
            // 
            this.activityHistoryDataGridView.AllowUserToAddRows = false;
            this.activityHistoryDataGridView.AllowUserToDeleteRows = false;
            this.activityHistoryDataGridView.AutoGenerateColumns = false;
            this.activityHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.GradePercent,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.activityHistoryDataGridView.DataSource = this.activityHistoryBindingSource;
            this.activityHistoryDataGridView.Location = new System.Drawing.Point(40, 390);
            this.activityHistoryDataGridView.Name = "activityHistoryDataGridView";
            this.activityHistoryDataGridView.ReadOnly = true;
            this.activityHistoryDataGridView.RowTemplate.Height = 40;
            this.activityHistoryDataGridView.Size = new System.Drawing.Size(1394, 392);
            this.activityHistoryDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DateTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "DateTime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TotalQuestions";
            this.dataGridViewTextBoxColumn4.HeaderText = "TotalQuestions";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CorrectAnswers";
            this.dataGridViewTextBoxColumn5.HeaderText = "CorrectAnswers";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // GradePercent
            // 
            this.GradePercent.DataPropertyName = "CorrectAnswers/TotalQuestions";
            this.GradePercent.HeaderText = "GradePercent";
            this.GradePercent.Name = "GradePercent";
            this.GradePercent.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SkillLevel";
            this.dataGridViewTextBoxColumn6.HeaderText = "SkillLevel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ActivityType";
            this.dataGridViewTextBoxColumn7.HeaderText = "ActivityType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // fillByStudentIDToolStrip
            // 
            this.fillByStudentIDToolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.fillByStudentIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentIdToolStripLabel,
            this.studentIdToolStripTextBox,
            this.fillByStudentIDToolStripButton});
            this.fillByStudentIDToolStrip.Location = new System.Drawing.Point(0, 47);
            this.fillByStudentIDToolStrip.Name = "fillByStudentIDToolStrip";
            this.fillByStudentIDToolStrip.Size = new System.Drawing.Size(1465, 48);
            this.fillByStudentIDToolStrip.TabIndex = 7;
            this.fillByStudentIDToolStrip.Text = "fillByStudentIDToolStrip";
            // 
            // studentIdToolStripLabel
            // 
            this.studentIdToolStripLabel.Name = "studentIdToolStripLabel";
            this.studentIdToolStripLabel.Size = new System.Drawing.Size(154, 45);
            this.studentIdToolStripLabel.Text = "StudentId:";
            // 
            // studentIdToolStripTextBox
            // 
            this.studentIdToolStripTextBox.Name = "studentIdToolStripTextBox";
            this.studentIdToolStripTextBox.Size = new System.Drawing.Size(100, 48);
            // 
            // fillByStudentIDToolStripButton
            // 
            this.fillByStudentIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByStudentIDToolStripButton.Name = "fillByStudentIDToolStripButton";
            this.fillByStudentIDToolStripButton.Size = new System.Drawing.Size(222, 45);
            this.fillByStudentIDToolStripButton.Text = "FillByStudentID";
            this.fillByStudentIDToolStripButton.Click += new System.EventHandler(this.fillByStudentIDToolStripButton_Click);
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
            this.tableAdapterManager.UpdateOrder = MathWizzz.MathWizzDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // frmViewProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 807);
            this.Controls.Add(this.fillByStudentIDToolStrip);
            this.Controls.Add(this.activityHistoryDataGridView);
            this.Controls.Add(this.activityHistoryBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEnterStudentId);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Name = "frmViewProgress";
            this.Text = "frmViewProgress";
            this.Load += new System.EventHandler(this.frmViewProgress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingNavigator)).EndInit();
            this.activityHistoryBindingNavigator.ResumeLayout(false);
            this.activityHistoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mathWizzDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityHistoryDataGridView)).EndInit();
            this.fillByStudentIDToolStrip.ResumeLayout(false);
            this.fillByStudentIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtEnterStudentId;
        private System.Windows.Forms.Label label2;
        private MathWizzDataSet mathWizzDataSet;
        private System.Windows.Forms.BindingSource activityHistoryBindingSource;
        private MathWizzDataSetTableAdapters.ActivityHistoryTableAdapter activityHistoryTableAdapter;
        private MathWizzDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator activityHistoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton activityHistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView activityHistoryDataGridView;
        private System.Windows.Forms.ToolStrip fillByStudentIDToolStrip;
        private System.Windows.Forms.ToolStripLabel studentIdToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentIdToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByStudentIDToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradePercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}