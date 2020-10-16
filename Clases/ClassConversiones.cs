using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_AlexOmarMartinez.Clases
{
    class ClassConversiones
    {
        public void Conversion(double m)
        {
            double res = m * 1609.34;
            MessageBox.Show(res.ToString());
        }

        public void Conver(double m)
        {
            double res = m * 1.60934;
            MessageBox.Show(res.ToString());
        }

        public void conv(double l)
        {
            double res = l * 0.041;
            MessageBox.Show(res.ToString());
        }

        public void convers(double l)
        {
            double res = l * 0.035;
            MessageBox.Show(res.ToString());
        }

        public void Convertir(double g)
        {
            double res = g * 3.78541;
            MessageBox.Show(res.ToString());
        }

        public void converti(double pulg)
        {
            double res = pulg * 2.54;
            MessageBox.Show(res.ToString());
        }
        public void ConvertirDM(int d)
        {
            int res = d * 1440;
            MessageBox.Show(res.ToString());
        }

        public void ConvertirLaO(double lb)
        {
            double res = lb * 16;
            MessageBox.Show(res.ToString());
        }

        public void ConvertirMaP(double m)
        {
            double res = m * 3.28;
            MessageBox.Show(res.ToString());
        }

        public void ConvertirSemaMin(double sem)
        {
            double res = sem * 10080;
            MessageBox.Show(res.ToString());
        }
    }
}
