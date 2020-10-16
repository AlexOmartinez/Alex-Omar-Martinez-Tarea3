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
    public partial class FormLempaDol : Form
    {
        Clases.ClassConversiones conversiones = new Clases.ClassConversiones();
        public FormLempaDol()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double l;

            l = Convert.ToDouble(TxtLempiras.Text);

            conversiones.conv(l);
        }
    }
}
