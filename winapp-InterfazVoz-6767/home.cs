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
            labelTitle.Text = "Inicio";
        }
        private void buttonMoveImage_Click(object sender, EventArgs e)
        {
            panelmain.Visible = false;
            labelTitle.Text = "Mover imagen";

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
            panelmain.Visible = false;
            labelTitle.Text = "Paises y capitales";

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
            panelmain.Visible = false;
            labelTitle.Text = "Texto a voz";

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
            panelmain.Visible = false;
            labelTitle.Text = "Lineas y figuras";

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
            System.Diagnostics.Process.Start("https://github.com/atreyucam/InterfazVoz-winForm");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/atreyucam/InterfazVoz-winForm");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openHelpSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://muddy-triangle-e3b.notion.site/Documentaci-n-Comando-de-voz-b8758cb655144d7796e230aafb152420");
        }
    }
}
