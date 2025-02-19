using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeEvaluaciones2700237
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            PromedioProgramacion objp = new PromedioProgramacion();

            objp.estudiante = txtEstudiante.Text;
            objp.evaluacion1 = int.Parse(txtEva1.Text);
            objp.evaluacion2 = int.Parse(txtEva2.Text);
            objp.evaluacion3 = int.Parse(txtEva3.Text);
            objp.actitudinal = int.Parse(txtActitudinal.Text);

            double promedio = objp.calculapromedio();
            string condicion = objp.determinaCondicion();

            ListViewItem fila = new ListViewItem(objp.estudiante);
            fila.SubItems.Add(objp.evaluacion1.ToString("0.00"));
            fila.SubItems.Add(objp.evaluacion2.ToString("0.00"));
            fila.SubItems.Add(objp.evaluacion3.ToString("0.00"));
            fila.SubItems.Add(objp.actitudinal.ToString("0.00"));
            fila.SubItems.Add(objp.calculapromedio().ToString("0.00"));
            fila.SubItems.Add(objp.determinaCondicion().ToString());
            lvEvaluaciones.Items.Add(fila);

            estadisticas();
        }
        double sumaPromedios()
        {
            double suma = 0;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {

                suma += double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text);
            }
            return suma;

        }
        double promedioMasAlto()
        {
            double mayor = 0;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                if (double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text) > mayor)
                {
                    mayor = double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text);
                }
            }
            return mayor;
        }
        double PromedioMasbajo()
        {
            double menor = int.MaxValue;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                if (double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text) < menor)
                {
                    menor = double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text);

                }
            }
            return menor;
        }
        int totalAprobados()
        {
            int cAprobados = 0;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                if (double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text) > 10)
                {
                    cAprobados++;
                }
            }
            return cAprobados;
        }
        int totalDesaprobados()
        {
            int cDesaprobados = 0;
            for (int i = 0; i < lvEvaluaciones.Items.Count; i++)
            {
                if (double.Parse(lvEvaluaciones.Items[i].SubItems[5].Text) <= 10)
                {
                    cDesaprobados++;
                }
            }
            return cDesaprobados;
        }
        void estadisticas()
        {
            lstR.Items.Clear();
            lstR.Items.Add("suma de promedios:" + sumaPromedios().ToString("0.00"));
            lstR.Items.Add("promedio mas alto:" + promedioMasAlto().ToString("0.00"));
            lstR.Items.Add("promedio mas bajo:" + PromedioMasbajo().ToString("0.00"));
            lstR.Items.Add("total de aprobados:" + totalAprobados().ToString("0.00"));
            lstR.Items.Add("total de desaprobados:" + totalDesaprobados().ToString("0.00"));
        }
    }
}
