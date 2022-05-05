using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace winapp_InterfazVoz_6767
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void buttonMoveImage_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0); 
            }
            Form window;
            window = new moverImagen();
            window.TopLevel = false;
            window.Dock = DockStyle.Fill;
            panelHome.Controls.Add(window);
            panelHome.Tag = window;
            window.Show();
        }

        private void buttonPaisCapital_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form window;
            window = new paisesCapitales();
            window.TopLevel = false;
            window.Dock = DockStyle.Fill;
            panelHome.Controls.Add(window);
            panelHome.Tag = window;
            window.Show();
        }

        public void buttonTextoVoz_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form window;
            window = new outputVoice();
            window.TopLevel = false;
            window.Dock = DockStyle.Fill;
            panelHome.Controls.Add(window);
            panelHome.Tag = window;
            window.Show();
        }

        private void buttonFormas_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form window;
            window = new lineasFiguras();
            window.TopLevel = false;
            window.Dock = DockStyle.Fill;
            panelHome.Controls.Add(window);
            panelHome.Tag = window;
            window.Show();
        }

        private void linkGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }
    }
}
