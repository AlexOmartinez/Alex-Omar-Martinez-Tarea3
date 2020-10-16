using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_AlexOmarMartinez.Forms
{
    public partial class FormMillasaMetros : Form
    {
        Clases.ClassConversiones conver = new Clases.ClassConversiones();
        public FormMillasaMetros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double m;

            m = Convert.ToDouble(TxtMillas.Text);

            conver.Conversion(m);
        }

        private void FormMillasaMetros_Load(object sender, EventArgs e)
        {

        }

        private void TxtMillas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
