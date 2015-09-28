using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Cap7y8
{

    public partial class Cap7e1Form : Form
    {
        ArrayList Promedio;
        int total;
        int Calificaciones;
        int mayor;
        int menor;
        int cant = 0;

        public Cap7e1Form()
        {
            InitializeComponent();
            Promedio = new ArrayList();
        }

        private void Cap7e1Form_Load(object sender, EventArgs e)
        {

        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {

            
            if (Calificaciones > 0)
            {
                foreach (int p in Promedio)
                {
                    total += p;
                    cant++;
                }

            }

            menor = 1000;

            foreach (int n in Promedio)
            {
                if (menor < n)
                {
                    menor = n;
                } 
            }

            mayor = 0;

            foreach (int n in Promedio)
            {
                if (mayor > n)
                {
                    mayor = n;
                }
            }

            ResultadolistBox.Items.Add("El promedio de el salon es: " + total / cant);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Calificaciones = Convert.ToInt32(CalificacionestextBox.Text);
            ResultadolistBox.Items.Add(Calificaciones);
            Promedio.Add(Calificaciones);
            CalificacionestextBox.Text = " ";
        }
    }
}
