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
    public partial class VentanaPrincipalForm : Form
    {
        public VentanaPrincipalForm()
        {
            InitializeComponent();
        }

        private void capitulo6ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cap7e1Form Cap71 = new Cap7e1Form();

            Cap71.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cap7e2Form Cap72 = new Cap7e2Form();

            Cap72.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cap7e3Form Cap73 = new Cap7e3Form();

            Cap73.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Cap7e5Form Cap75 = new Cap7e5Form();

            Cap75.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Cap7e4Form Cap74 = new Cap7e4Form();

            Cap74.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Cap8e1Form Cap81 = new Cap8e1Form();

            Cap81.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Cap8e2Form Cap82 = new Cap8e2Form();

            Cap82.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Cap8e3Form Cap83 = new Cap8e3Form();

            Cap83.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Cap8e4Form Cap84 = new Cap8e4Form();

            Cap84.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Cap8e5Form Cap85 = new Cap8e5Form();

            Cap85.Show();
        }
    }
}
