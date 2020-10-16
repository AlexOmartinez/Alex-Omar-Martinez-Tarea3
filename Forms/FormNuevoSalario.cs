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
    public partial class FormNuevoSalario : Form
    {
        Clases.ClassCalculos calculos = new Clases.ClassCalculos();
        public FormNuevoSalario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormNuevoSalario_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double sala, ax;

            sala = Convert.ToDouble(TxtSalAc.Text);
            ax = Convert.ToDouble(TxtAum.Text);

            calculos.NuevoSal(sala, ax);
        }
    }
}
