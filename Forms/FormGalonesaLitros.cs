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
    public partial class FormGalonesaLitros : Form
    {
        Clases.ClassConversiones conversiones = new Clases.ClassConversiones();
        public FormGalonesaLitros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGalonesaLitros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double g;
            g = Convert.ToDouble(TxtGalones.Text);

            conversiones.Convertir(g);
        }
    }
}
