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
    public partial class FormNTE : Form
    {
        Clases.ClassCalculos calculos = new Clases.ClassCalculos();
        public FormNTE()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double na, ne;

            na = Convert.ToDouble(TxtNotaA.Text);
            ne = Convert.ToDouble(TxtNotaE.Text);

            calculos.NotaTotal(na, ne);
        }

        private void FormNTE_Load(object sender, EventArgs e)
        {

        }
    }
}
