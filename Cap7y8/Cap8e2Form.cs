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
    public partial class Cap8e2Form : Form
    {
        public Cap8e2Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            string Justificar = JustificartextBox.Text;
            string Res = "";

            if(IzradioButton.Checked)
            {
                Res = Justificar.PadLeft(10);
                ResultadolistBox.Items.Add(Res);
            }
            if(DereradioButton.Checked)
            {
                Res = Justificar.PadRight(10);
                ResultadolistBox.Items.Add(Res);
            }
            JustificartextBox.Text = " ";
        }
    }
}
