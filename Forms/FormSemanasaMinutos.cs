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
    public partial class FormSemaMin : Form
    {
        Clases.ClassConversiones conversiones = new Clases.ClassConversiones();
        public FormSemaMin()
        {
            InitializeComponent();
        }

        private void FormSemaMin_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double sem;

            sem = Convert.ToDouble(TxtSemanas.Text);

            conversiones.ConvertirSemaMin(sem);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
