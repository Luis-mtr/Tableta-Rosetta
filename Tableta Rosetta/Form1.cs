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
    public partial class btn_update : Form
    {
        Tableta_Rosetta.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        
        public btn_update()
        {
            InitializeComponent();
            Tableta_Rosetta.ServiceReference1.ArrayOfInt statisticsArray = service.GetQuestionStatistics();
            label1.Text = $"Sunt {statisticsArray[0]} întrebări\nGrupate in {statisticsArray[1]} Subiecte\nAu fost date {statisticsArray[2]} răspunsuri\nDin care {statisticsArray[3]*100/statisticsArray[2]}% corecte\nNivelul mediu de cunoștere a acestor întrebări este {statisticsArray[4]}%";
        }

        private void btn_addSubject_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btn_startTest_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tableta_Rosetta.ServiceReference1.ArrayOfInt statisticsArray = service.GetQuestionStatistics();
            label1.Text = $"Sunt {statisticsArray[0]} întrebări\nGrupate in {statisticsArray[1]} Subiecte\nAu fost date {statisticsArray[2]} răspunsuri\nDin care {statisticsArray[3] * 100 / statisticsArray[2]}% corecte\nNivelul mediu de cunoștere a acestor întrebări este {statisticsArray[4]}%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
