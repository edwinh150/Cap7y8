﻿using System;
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
    public partial class Cap8e5Form : Form
    {
        ArrayList Cadena;
        public Cap8e5Form()
        {
            InitializeComponent();
            Cadena = new ArrayList();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            Cadena.Add(Cadena1textBox.Text);
            Cadena.Add(Cadena2textBox.Text);

            Cadena.Sort();

            foreach (string cad in Cadena)
            {
                ResultadolistBox.Items.Add(cad);
            }

            Cadena1textBox.Text = "";
            Cadena2textBox.Text = "";
        }
    }
}
