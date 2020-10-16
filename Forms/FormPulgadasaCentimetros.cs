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
    public partial class FormPulgaCm : Form
    {
        Clases.ClassConversiones conversiones = new Clases.ClassConversiones();
        public FormPulgaCm()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPulgaCm_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double pulg;

            pulg = Convert.ToDouble(TxtPulg.Text);

            conversiones.converti(pulg);
        }
    }
}
