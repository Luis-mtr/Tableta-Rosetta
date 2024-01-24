namespace Tableta_Rosetta
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionDataInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnswerText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountAsked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelKnown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName,
            this.SubjectId,
            this.AnswerId,
            this.QuestionId,
            this.QuestionText,
            this.AnswerText,
            this.CountAsked,
            this.CountRight,
            this.LevelKnown});
            this.dataGridView1.DataSource = this.questionDataInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 321);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionDataInfoBindingSource
            // 
            this.questionDataInfoBindingSource.DataSource = typeof(Tableta_Rosetta.ServiceReference1.QuestionDataInfo);
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "SubjectName";
            this.SubjectName.Name = "SubjectName";
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "SubjectId";
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.Visible = false;
            // 
            // AnswerId
            // 
            this.AnswerId.DataPropertyName = "AnswerId";
            this.AnswerId.HeaderText = "AnswerId";
            this.AnswerId.Name = "AnswerId";
            this.AnswerId.Visible = false;
            // 
            // QuestionId
            // 
            this.QuestionId.DataPropertyName = "QuestionId";
            this.QuestionId.HeaderText = "QuestionId";
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.Visible = false;
            // 
            // QuestionText
            // 
            this.QuestionText.DataPropertyName = "QuestionText";
            this.QuestionText.HeaderText = "QuestionText";
            this.QuestionText.Name = "QuestionText";
            // 
            // AnswerText
            // 
            this.AnswerText.DataPropertyName = "AnswerText";
            this.AnswerText.HeaderText = "AnswerText";
            this.AnswerText.Name = "AnswerText";
            // 
            // CountAsked
            // 
            this.CountAsked.DataPropertyName = "CountAsked";
            this.CountAsked.HeaderText = "CountAsked";
            this.CountAsked.Name = "CountAsked";
            // 
            // CountRight
            // 
            this.CountRight.DataPropertyName = "CountRight";
            this.CountRight.HeaderText = "CountRight";
            this.CountRight.Name = "CountRight";
            // 
            // LevelKnown
            // 
            this.LevelKnown.DataPropertyName = "LevelKnown";
            this.LevelKnown.HeaderText = "LevelKnown";
            this.LevelKnown.Name = "LevelKnown";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Toate Întrebările";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionDataInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource questionDataInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnswerText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountAsked;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelKnown;
    }
}