using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tableta_Rosetta
{
    public partial class Form6 : Form
    {
        Tableta_Rosetta.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        private int questionId;
        private int answerId;
        private int subjectId;
        private string subject;
        private string answerText;
        private string questionText;
        private int countAsked;
        private int countRight;
        private double levelKnown;
        private string subjectText;

        public Form6(int questionId, int answerId, int subjectId, string questionText, string answerText, int countAsked, int countRight, double levelKnown, string subjectText)
        {
            InitializeComponent();
            LoadSubjects();

            this.questionId = questionId;
            this.answerId = answerId;
            this.subjectId = subjectId;
            this.answerText = answerText;
            this.countAsked = countAsked;
            this.countRight = countRight;
            this.levelKnown = levelKnown;
            this.questionText = questionText;
            this.subjectText = subjectText;

            int index = comboBox1.FindStringExact(subjectText);

            if (index != -1)
            {
                comboBox1.SelectedIndex = index;
            }

            textBox1.Text = questionText;
            textBox2.Text = answerText;
            textBox3.Text = countAsked.ToString();
            textBox4.Text = countRight.ToString();
            textBox5.Text = levelKnown.ToString();

            this.subjectText = subjectText;
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectId=(int)comboBox1.SelectedValue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            questionText = (string)textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            answerText= textBox2.Text;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            countAsked = Convert.ToInt32(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            countRight= Convert.ToInt32(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            levelKnown = Convert.ToDouble(textBox5.Text);
        }

        private void btn_submitUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateData(questionId, answerId, subjectId, questionText,answerText,countAsked,countRight,levelKnown);
                MessageBox.Show("Datele au fost actualizate.");
                this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_cancelUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
