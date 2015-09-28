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
    public partial class Cap7e4Form : Form
    {
        ArrayList Mes;
        int cuentas;

        public Cap7e4Form()
        {
            InitializeComponent();
            Mes = new ArrayList();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            cuentas = Convert.ToInt32(CuentastextBox.Text);
            Mes.Add(cuentas);
            MessageBox.Show("Guardado");
            CuentastextBox.Text = " ";
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            Mes.Sort();
            Mes.Reverse();

            ResultadolistBox.Items.Add("Las cuentas que se ordenaron cronologicamente son: ");
            foreach (int datos in Mes)
            {
                ResultadolistBox.Items.Add(datos);
            }
        }
    }
}
