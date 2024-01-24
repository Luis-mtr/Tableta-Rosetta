using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tableta_Rosetta.ServiceReference1;

namespace Tableta_Rosetta
{
    public partial class Form3 : Form
    {
        Tableta_Rosetta.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        int addedQuestionID = -1;

        public Form3()
        {
            InitializeComponent();
            LoadSubjects();

        }


        
        private void LoadSubjects()
        {
            try 
            {    
                List<Tableta_Rosetta.ServiceReference1.SubjectInfo> subjects = service.GetSubjects().ToList();
                comboBox1.DataSource = subjects;
                comboBox1.DisplayMember = "SubjectName";
                comboBox1.ValueMember = "SubjectId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_AnswerInput.Text) && !string.IsNullOrEmpty(textBox_QuestionInput.Text))
            {
                int subjectId = (int)comboBox1.SelectedValue;
                try
                {
                    addedQuestionID = service.AddQuestion(textBox_QuestionInput.Text.ToString().Trim(), subjectId);
                    
                    try
                    {
                        service.AddAnswer(textBox_AnswerInput.Text.ToString().Trim(), addedQuestionID);
                        MessageBox.Show("Întrebare adăugată cu succes!");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
    }
}
