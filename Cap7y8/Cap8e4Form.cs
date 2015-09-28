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
    public partial class Cap8e4Form : Form
    {
        public Cap8e4Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            double Numero1 = Convert.ToDouble(Numero1textBox.Text);
            double Numero2 = Convert.ToDouble(Numero2textBox.Text);

            double suma = Numero1 + Numero2;

            if (suma > 0)
            {
                ResultadotextBox.Text = suma.ToString();
            }
            else
            {
                ResultadotextBox.Text = " (" + suma.ToString() + ") ";
            }
            Numero1textBox.Text = " ";
            Numero2textBox.Text = " ";

        }
    }
}
