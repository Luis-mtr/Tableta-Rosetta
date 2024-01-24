using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tableta_Rosetta.ServiceReference1;

namespace Tableta_Rosetta
{
    public partial class Form5 : Form
    {
        Tableta_Rosetta.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

        public Form5()
        {
            InitializeComponent();
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                Tableta_Rosetta.ServiceReference1.QuestionDataInfo[] questionDataList = service.GetQuestionData();

                dataGridView1.DataSource = questionDataList;
                //dataGridView1.Columns["QuestionId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                int questionId = (int)selectedRow.Cells["QuestionId"].Value;
                int answerId = (int)selectedRow.Cells["AnswerId"].Value;
                int subjectId = (int)selectedRow.Cells["SubjectId"].Value;
                string answerText = (string)selectedRow.Cells["AnswerText"].Value;
                string questionText = (string)selectedRow.Cells["QuestionText"].Value;
                string subjectText = (string)selectedRow.Cells["SubjectName"].Value;

                int countAsked = (int)selectedRow.Cells["CountAsked"].Value;
                int countRight = (int)selectedRow.Cells["CountRight"].Value;
                double levelKnown = (double)selectedRow.Cells["LevelKnown"].Value;

                Form6 form6 = new Form6(questionId, answerId, subjectId, questionText, answerText, countAsked, countRight, levelKnown, subjectText);
                form6.ShowDialog();
                this.Close();
            }
        }
    }
}
