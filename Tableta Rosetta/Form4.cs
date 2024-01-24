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
    public partial class Form4 : Form
    {
        Tableta_Rosetta.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        private List<int> lastTwoQuestionIds = new List<int>();
        private string[] answers = new string[5];
        private ServiceReference1.WrongAnswersInfo wrongAnswers = new ServiceReference1.WrongAnswersInfo();
        string selectedAnswer = null;
        string rightAnswer = null;
        int questionId = 0;

        static void ShuffleArray<T>(T[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);

                // Swap array[i] and array[randomIndex]
                T temp = array[i];
                array[i] = array[randomIndex];
                array[randomIndex] = temp;
            }
        }

        public Form4()
        {
            InitializeComponent();
            LoadRandomQuestion();
        }

        private void LoadRandomQuestion()
        {
            Tableta_Rosetta.ServiceReference1.Question question = service.GetRandomQuestion();

            if (lastTwoQuestionIds.Contains(question.QuestionId))
            {
                LoadRandomQuestion();
            }
            else
            {
                label1.Text = question.QuestionText;
                lastTwoQuestionIds.Add(question.QuestionId);

                //Get right answer
                answers[0]=service.RightAnswer(question.QuestionId).AnswerText;
                rightAnswer = answers[0];
                questionId = question.QuestionId;

                //Get wrong answers
                wrongAnswers = service.GetRandomWrongAnswers(question.QuestionId);
                answers[1] = wrongAnswers.WrongAnswerText1;
                answers[2] = wrongAnswers.WrongAnswerText2;
                answers[3] = wrongAnswers.WrongAnswerText3;
                answers[4] = wrongAnswers.WrongAnswerText4;

                //Randomize answers order:
                ShuffleArray(answers);

                //Add text to radio buttons:
                radioButton1.Text = answers[0];
                radioButton2.Text = answers[1];
                radioButton3.Text = answers[2];
                radioButton4.Text = answers[3];
                radioButton5.Text = answers[4];

                if (lastTwoQuestionIds.Count > 2)
                {
                    lastTwoQuestionIds.RemoveAt(0);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.AnswerShown(wrongAnswers.WrongAnswerId1);
            service.AnswerShown(wrongAnswers.WrongAnswerId2);
            service.AnswerShown(wrongAnswers.WrongAnswerId3);
            service.AnswerShown(wrongAnswers.WrongAnswerId4);

            if (selectedAnswer == rightAnswer)
            {
                service.RightAnswerSubmited(questionId);
                MessageBox.Show("Corect!");
            }
            else
            {
                service.WrongAnswerSubmited(questionId);
                MessageBox.Show("Greșit!");
            }

            LoadRandomQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedAnswer = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedAnswer = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedAnswer = radioButton3.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selectedAnswer = radioButton4.Text;                ;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            selectedAnswer = radioButton5.Text;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
