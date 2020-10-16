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
    public partial class FormTotalP : Form
    {
        Clases.ClassCalculos calculos = new Clases.ClassCalculos();
        public FormTotalP()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormTotalP_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cant, prec;

            cant = Convert.ToDouble(TxtCant.Text);
            prec = Convert.ToDouble(TxtPrecio.Text);

            calculos.TotalP(cant, prec);
        }
    }
}
