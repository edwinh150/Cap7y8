using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap7y8
{
    public partial class Cap8e1Form : Form
    {
        public Cap8e1Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            string Cadena = CadenatextBox.Text;

            string[] Dividir = Cadena.Split(' ',',','.');
            foreach (string d in Dividir)
            {
                ResultadolistBox.Items.Add(d);
            }
            CadenatextBox.Text = "";
        }
    }
}
