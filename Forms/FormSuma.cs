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
    public partial class FormSuma : Form
    {
        Clases.ClassCalculos cal = new Clases.ClassCalculos();
        public FormSuma()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSuma_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(TxtPrimerN.Text);
            b = Convert.ToInt32(TxtSegundoN.Text);
            c = Convert.ToInt32(TxtTercerN.Text);

            cal.Suma(a, b, c);
        }
    }
}
