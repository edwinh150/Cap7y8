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
    public partial class Cap7e3Form : Form
    {
        Queue ClientesFila;
        string Cliente = "";
        string Atendido = "";

        public Cap7e3Form()
        {
            InitializeComponent();
            ClientesFila = new Queue();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cliente = LlegadatextBox.Text;
            ClientesFila.Enqueue(Cliente);
            ResultadolistBox.Items.Add(Cliente);
            LlegadatextBox.Text = " ";
        }

        private void Atenderbutton_Click(object sender, EventArgs e)
        {
            Atendido = (string)ClientesFila.Dequeue();

            MessageBox.Show("se acaba de atender a: " + Atendido);

            ResultadolistBox.Items.Add("Fila despues de Atender: ");
            foreach (string client in ClientesFila)
            {
                ResultadolistBox.Items.Add(client);
            }

        }
    }
}
