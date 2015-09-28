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
    public partial class Cap8e3Form : Form
    {
        public Cap8e3Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            string formatoH = "";
            string formatoF = "";

            formatoH = String.Format("La hora es: {0:hh:m:ss tt}", DateTime.Now);
            formatoF = String.Format("La fecha es: {0:yyyy/d/MM}",DateTime.Now);

            FechalistBox.Items.Add(formatoH.ToString());
            FechalistBox.Items.Add(formatoF.ToString());

        }
    }
}
