﻿namespace Tableta_Rosetta
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_submitSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelNewSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_submitSubject
            // 
            this.btn_submitSubject.Location = new System.Drawing.Point(12, 65);
            this.btn_submitSubject.Name = "btn_submitSubject";
            this.btn_submitSubject.Size = new System.Drawing.Size(120, 23);
            this.btn_submitSubject.TabIndex = 1;
            this.btn_submitSubject.Text = "Confirm";
            this.btn_submitSubject.UseVisualStyleBackColor = true;
            this.btn_submitSubject.Click += new System.EventHandler(this.btn_submitSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subiect Nou";
            // 
            // btn_cancelNewSubject
            // 
            this.btn_cancelNewSubject.Location = new System.Drawing.Point(138, 65);
            this.btn_cancelNewSubject.Name = "btn_cancelNewSubject";
            this.btn_cancelNewSubject.Size = new System.Drawing.Size(120, 23);
            this.btn_cancelNewSubject.TabIndex = 3;
            this.btn_cancelNewSubject.Text = "Anulare";
            this.btn_cancelNewSubject.UseVisualStyleBackColor = true;
            this.btn_cancelNewSubject.Click += new System.EventHandler(this.btn_cancelNewSubject_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cancelNewSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_submitSubject);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Adăugați Subiect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_submitSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelNewSubject;
    }
}