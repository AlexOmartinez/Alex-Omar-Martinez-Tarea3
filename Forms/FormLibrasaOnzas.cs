﻿using System;
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
    public partial class FormLbsaOz : Form
    {
        Clases.ClassConversiones conversiones = new Clases.ClassConversiones();
        public FormLbsaOz()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLbsaOz_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double lb;

            lb = Convert.ToDouble(TxtLibras.Text);

            conversiones.ConvertirLaO(lb);
        }
    }
}
