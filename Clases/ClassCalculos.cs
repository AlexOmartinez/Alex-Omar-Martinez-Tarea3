using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_AlexOmarMartinez.Clases
{
    class ClassCalculos
    {
        public void Suma(int a, int b, int c)
        {
            int res = a + b + c;
            MessageBox.Show(res.ToString());
        }

        public void Promedio(double c1, double c2, double c3, double c4)
        {
            double res = (c1 + c2 + c3 + c4) / 4;
            MessageBox.Show(res.ToString());
        }

        public void TotalP(double cant, double prec)
        {
            double res = cant * prec;
            MessageBox.Show(res.ToString());
        }

        public void Salario(double dt, double vd)
        {
            double res = dt * vd;
            MessageBox.Show(res.ToString());
        }

        public void TotalPHE(double dt,double vd,double he,double vhe)
        {
            double res = (dt * vd) + (he * vhe);
            MessageBox.Show(res.ToString());
        }

        public void NuevoSal(double sala, double ax)
        {
            double res = (sala * ax)+sala;
            MessageBox.Show(res.ToString());
        }

        public void CuadradodeunNumero(double n)
        {
            double res = n * n;
            MessageBox.Show(res.ToString());
        }

        public void CubodeunNumero(double n)
        {
            double res = n * n * n;
            MessageBox.Show(res.ToString());
        }

        public void DobledeunNumero(double n)
        {
            double res = n * 2;
            MessageBox.Show(res.ToString());
        }
        
        public void TotalPConst(double cmt,double vmc)
        {
            double res = cmt * vmc;
            MessageBox.Show(res.ToString());
        }

        public void NotaTotal(double na,double ne)
        {
            double res = na + ne;
            MessageBox.Show(res.ToString());
        }
    }
}
