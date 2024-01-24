namespace Tableta_Rosetta
{
    partial class btn_update
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
            this.btn_addSubject = new System.Windows.Forms.Button();
            this.btn_addQuestion = new System.Windows.Forms.Button();
            this.btn_startTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addSubject
            // 
            this.btn_addSubject.Location = new System.Drawing.Point(45, 111);
            this.btn_addSubject.Name = "btn_addSubject";
            this.btn_addSubject.Size = new System.Drawing.Size(171, 63);
            this.btn_addSubject.TabIndex = 0;
            this.btn_addSubject.Text = "Adăugați Subiect";
            this.btn_addSubject.UseVisualStyleBackColor = true;
            this.btn_addSubject.Click += new System.EventHandler(this.btn_addSubject_Click);
            // 
            // btn_addQuestion
            // 
            this.btn_addQuestion.Location = new System.Drawing.Point(45, 180);
            this.btn_addQuestion.Name = "btn_addQuestion";
            this.btn_addQuestion.Size = new System.Drawing.Size(171, 63);
            this.btn_addQuestion.TabIndex = 1;
            this.btn_addQuestion.Text = "Adăugați Întrebare";
            this.btn_addQuestion.UseVisualStyleBackColor = true;
            this.btn_addQuestion.Click += new System.EventHandler(this.btn_addQuestion_Click);
            // 
            // btn_startTest
            // 
            this.btn_startTest.Location = new System.Drawing.Point(45, 249);
            this.btn_startTest.Name = "btn_startTest";
            this.btn_startTest.Size = new System.Drawing.Size(171, 63);
            this.btn_startTest.TabIndex = 2;
            this.btn_startTest.Text = "Începeți testarea";
            this.btn_startTest.UseVisualStyleBackColor = true;
            this.btn_startTest.Click += new System.EventHandler(this.btn_startTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Actualizți Datele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Toate Întrebările";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_startTest);
            this.Controls.Add(this.btn_addQuestion);
            this.Controls.Add(this.btn_addSubject);
            this.Name = "btn_update";
            this.Text = "Tableta Rosetta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addSubject;
        private System.Windows.Forms.Button btn_addQuestion;
        private System.Windows.Forms.Button btn_startTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

