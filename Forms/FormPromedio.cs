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
    public partial class FormPromedio : Form
    {
        Clases.ClassCalculos cal = new Clases.ClassCalculos();
        public FormPromedio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPromedio_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double c1, c2, c3, c4;

            c1 = Convert.ToDouble(TxtCalif1.Text);
            c2 = Convert.ToDouble(TxtCalif2.Text);
            c3 = Convert.ToDouble(TxtCalif3.Text);
            c4 = Convert.ToDouble(TxtCalif4.Text);

            cal.Promedio(c1,c2,c3,c4);
        }
    }
}
