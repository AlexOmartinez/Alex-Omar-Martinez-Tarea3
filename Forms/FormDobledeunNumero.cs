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
    public partial class FormDobledeunNum : Form
    {
        Clases.ClassCalculos calculos = new Clases.ClassCalculos();
        public FormDobledeunNum()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDobledeunNum_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double n;

            n = Convert.ToDouble(TxtNumero.Text);

            calculos.DobledeunNumero(n);
        }
    }
}
