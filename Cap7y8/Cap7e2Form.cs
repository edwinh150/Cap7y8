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
    public partial class Cap7e2Form : Form
    {
        Hashtable Diccionario;
        string Nombre = "";
        String Definicion = "";

        public Cap7e2Form()
        {
            InitializeComponent();
            Diccionario = new Hashtable();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Nombre = NombretextBox.Text;
            Definicion = DefiniciontextBox.Text;
            Diccionario.Add(Nombre, Definicion);
            ResultadolistBox.Items.Add("Nombre: " + Nombre + " Definicion: " + Definicion);
            NombretextBox.Text = " ";
            DefiniciontextBox.Text = " ";
        }
    }
}
