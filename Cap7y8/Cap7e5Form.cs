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
    public partial class Cap7e5Form : Form
    {
        public Hashtable Contactos;
        string nombre = "";
        string numero;
        int cant = 0;

        public Cap7e5Form()
        {
            InitializeComponent();
            Contactos = new Hashtable();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
      
        }

        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            nombre = NombretextBox.Text;
            numero = NumerotextBox.Text;

            NombretextBox.Text = " ";
            NumerotextBox.Text = " ";

            Contactos.Add(nombre, numero);
            MessageBox.Show("Guardado");
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            foreach (DictionaryEntry datos in Contactos)
            {

                ContactosdataGridView.Rows.Add(datos.Key, datos.Value);
            }
        }
    }
}
