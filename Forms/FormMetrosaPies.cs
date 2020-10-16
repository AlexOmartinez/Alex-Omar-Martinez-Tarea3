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
    public partial class FormMetrosaPies : Form
    {
        Clases.ClassConversiones conversiones = new Clases.ClassConversiones();
        public FormMetrosaPies()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMetrosaPies_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            double m;

            m = Convert.ToDouble(TxtMetros.Text);

            conversiones.ConvertirMaP(m);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
