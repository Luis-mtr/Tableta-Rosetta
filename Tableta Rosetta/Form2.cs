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
    public partial class Form2 : Form
    {
        Tableta_Rosetta.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_submitSubject_Click(object sender, EventArgs e)
        {
            string newSubject = textBox1.Text;

            try
            {
                service.AddSubject(newSubject);
                MessageBox.Show("Subiectul a fost adăugat cu succes!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Problemă tehnică! Vă rugăm reveniți mai târziu!"); MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelNewSubject_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
