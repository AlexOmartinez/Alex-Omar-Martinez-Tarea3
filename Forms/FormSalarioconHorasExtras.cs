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
    public partial class FormSalHE : Form
    {
        Clases.ClassCalculos calculos = new Clases.ClassCalculos();
        public FormSalHE()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSalHE_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double dt, vd, he, vhe;

            dt = Convert.ToDouble(TxtDiasT.Text);
            vd = Convert.ToDouble(TxtValorDia.Text);
            he = Convert.ToDouble(TxtHE.Text);
            vhe = Convert.ToDouble(TxtVHE.Text);

            calculos.TotalPHE(dt, vd, he, vhe);
        }
    }
}
