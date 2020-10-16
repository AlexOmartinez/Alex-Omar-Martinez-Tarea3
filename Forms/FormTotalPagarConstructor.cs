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
    public partial class FrmTPC : Form
    {
        Clases.ClassCalculos calculos = new Clases.ClassCalculos();
        public FrmTPC()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cmt, vmc;

            cmt = Convert.ToDouble(TxtCantMC.Text);
            vmc = Convert.ToDouble(TxtValMC.Text);

            calculos.TotalPConst(cmt, vmc);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
