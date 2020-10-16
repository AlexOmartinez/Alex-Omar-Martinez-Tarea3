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
    public partial class FormMillasaKm : Form
    {
        Clases.ClassConversiones conver = new Clases.ClassConversiones();
        public FormMillasaKm()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMillasaKm_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double m;

            m = Convert.ToDouble(TxtMillas.Text);

            conver.Conver(m);
        }
    }
}
