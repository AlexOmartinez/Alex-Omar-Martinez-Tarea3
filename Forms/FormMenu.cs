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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Forms.FormSuma suma = new Forms.FormSuma();
            suma.Show();
        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {
            Forms.FormPromedio promedio = new Forms.FormPromedio();
            promedio.Show();
        }

        private void BtnMillasaM_Click(object sender, EventArgs e)
        {
            Forms.FormMillasaMetros millasaMetros = new Forms.FormMillasaMetros();
            millasaMetros.Show();
        }

        private void BtnMillasaKm_Click(object sender, EventArgs e)
        {
            Forms.FormMillasaKm millasaKm = new Forms.FormMillasaKm();
            millasaKm.Show();
        }

        private void BtnLempaDol_Click(object sender, EventArgs e)
        {
            Forms.FormLempaDol lempaDol = new Forms.FormLempaDol();
            lempaDol.Show();
        }

        private void BtnTotalP_Click(object sender, EventArgs e)
        {
            Forms.FormTotalP totalP = new Forms.FormTotalP();
            totalP.Show();
        }

        private void BtnLemaEur_Click(object sender, EventArgs e)
        {
            Forms.FormLempaEur lempaEur = new Forms.FormLempaEur();
            lempaEur.Show();
        }

        private void BtnSalario_Click(object sender, EventArgs e)
        {
            Forms.FormSalario salario = new Forms.FormSalario();
            salario.Show();
        }

        private void BtnSalHE_Click(object sender, EventArgs e)
        {
            Forms.FormSalHE salHE = new Forms.FormSalHE();
            salHE.Show();
        }

        private void BtnGalaLts_Click(object sender, EventArgs e)
        {
            Forms.FormGalonesaLitros galonesaLitros = new Forms.FormGalonesaLitros();
            galonesaLitros.Show();
        }

        private void BtnPulgaCm_Click(object sender, EventArgs e)
        {
            Forms.FormPulgaCm pulgaCm = new Forms.FormPulgaCm();
            pulgaCm.Show();
        }

        private void BtnNSal_Click(object sender, EventArgs e)
        {
            Forms.FormNuevoSalario nuevoSalario = new Forms.FormNuevoSalario();
            nuevoSalario.Show();
        }

        private void BtnDiasaMinut_Click(object sender, EventArgs e)
        {
            Forms.FormDiasaMin diasaMin = new Forms.FormDiasaMin();
            diasaMin.Show();
        }

        private void BtnLbsaOz_Click(object sender, EventArgs e)
        {
            Forms.FormLbsaOz lbsaOz = new Forms.FormLbsaOz();
            lbsaOz.Show();
        }

        private void BtnEdadProm_Click(object sender, EventArgs e)
        {
            Forms.FormEdadProm edadProm = new Forms.FormEdadProm();
            edadProm.Show();
        }

        private void BtnCuadradoNum_Click(object sender, EventArgs e)
        {
            Forms.FormCuadradodeunNum cuadradodeunNum = new  Forms.FormCuadradodeunNum();
            cuadradodeunNum.Show();
        }

        private void BtnCuboNum_Click(object sender, EventArgs e)
        {
            Forms.FormCubodeunNum cubodeunNum = new Forms.FormCubodeunNum();
            cubodeunNum.Show();
        }

        private void BtnDobleNum_Click(object sender, EventArgs e)
        {
            Forms.FormDobledeunNum dobledeunNum = new Forms.FormDobledeunNum();
            dobledeunNum.Show();
        }

        private void BtnMtsaPies_Click(object sender, EventArgs e)
        {
            Forms.FormMetrosaPies metrosaPies = new Forms.FormMetrosaPies();
            metrosaPies.Show();
        }

        private void BtnTPC_Click(object sender, EventArgs e)
        {
            Forms.FrmTPC tPC = new Forms.FrmTPC();
            tPC.Show();
        }

        private void BtnNotaT_Click(object sender, EventArgs e)
        {
            Forms.FormNTE nTE = new Forms.FormNTE();
            nTE.Show();
        }

        private void BtnSemaMin_Click(object sender, EventArgs e)
        {
            Forms.FormSemaMin semaMin = new Forms.FormSemaMin();
            semaMin.Show();

        }
    }
}
