using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP4_MenusListes
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();

            // Wire up event handlers
            this.deplacementMenuItem.Click += new System.EventHandler(this.deplacementMenuItem_Click);
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            this.tsbListes.Click += new System.EventHandler(this.tsbListes_Click);
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            this.afficherBarreMenuItem.Click += new System.EventHandler(this.afficherBarreMenuItem_Click);
            this.desactiverBarreMenuItem.Click += new System.EventHandler(this.desactiverBarreMenuItem_Click);
            this.afficherImageMenuItem.Click += new System.EventHandler(this.afficherImageMenuItem_Click);
            this.changerCouleurMenuItem.Click += new System.EventHandler(this.changerCouleurMenuItem_Click);
            this.aideAideMenuItem.Click += new System.EventHandler(this.aideAideMenuItem_Click);
            this.aproposMenuItem.Click += new System.EventHandler(this.aproposMenuItem_Click);

            // Context menu items
            this.deplacementContextMenuItem.Click += new System.EventHandler(this.deplacementMenuItem_Click);
            this.exitContextMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
        }

        private void deplacementMenuItem_Click(object sender, EventArgs e)
        {
            frmListes frm = new frmListes();
            frm.Show();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbListes_Click(object sender, EventArgs e)
        {
            deplacementMenuItem_Click(sender, e);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            exitMenuItem_Click(sender, e);
        }

        private void afficherBarreMenuItem_Click(object sender, EventArgs e)
        {
            tsBarreOutils.Visible = true;
            afficherBarreMenuItem.Checked = true;
            desactiverBarreMenuItem.Checked = false;
        }

        private void desactiverBarreMenuItem_Click(object sender, EventArgs e)
        {
            tsBarreOutils.Visible = false;
            desactiverBarreMenuItem.Checked = true;
            afficherBarreMenuItem.Checked = false;
        }

        private void afficherImageMenuItem_Click(object sender, EventArgs e)
        {
            if (afficherImageMenuItem.Checked)
            {
                this.BackgroundImage = Properties.Resources.background_image;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                changerCouleurMenuItem.Checked = false;
            }
            else
            {
                this.BackgroundImage = null;
            }
        }

        private void changerCouleurMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = null;
                this.BackColor = colorDialog1.Color;
                afficherImageMenuItem.Checked = false;
                changerCouleurMenuItem.Checked = true;
            }
        }

        private void aideAideMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ceci est l'aide du TP4.", "Aide", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aproposMenuItem_Click(object sender, EventArgs e)
        {
            frmApropos frm = new frmApropos();
            frm.ShowDialog();
        }
    }
}
