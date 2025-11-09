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

            // Wire up event handlers for MenuStrip and ToolStrip
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

            // Programmatically build the ContextMenuStrip
            BuildContextMenu();
        }

        private void BuildContextMenu()
        {
            // Listes Menu
            ToolStripMenuItem listesContextMenuItem = new ToolStripMenuItem("Listes");
            ToolStripMenuItem deplacementContextMenuItem = new ToolStripMenuItem("Deplacement des données");
            deplacementContextMenuItem.Click += new System.EventHandler(this.deplacementMenuItem_Click);
            ToolStripMenuItem exitContextMenuItem = new ToolStripMenuItem("Exit");
            exitContextMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            listesContextMenuItem.DropDownItems.Add(deplacementContextMenuItem);
            listesContextMenuItem.DropDownItems.Add(new ToolStripSeparator());
            listesContextMenuItem.DropDownItems.Add(exitContextMenuItem);

            // Parametres Menu
            ToolStripMenuItem parametresContextMenuItem = new ToolStripMenuItem("Paramètres");
            ToolStripMenuItem afficherBarreContextMenuItem = new ToolStripMenuItem("Afficher Barre d'outils");
            afficherBarreContextMenuItem.Click += new System.EventHandler(this.afficherBarreMenuItem_Click);
            ToolStripMenuItem desactiverBarreContextMenuItem = new ToolStripMenuItem("Désactiver Barre D'outils");
            desactiverBarreContextMenuItem.Click += new System.EventHandler(this.desactiverBarreMenuItem_Click);
            ToolStripMenuItem afficherImageContextMenuItem = new ToolStripMenuItem("Afficher Image pour le Bureau");
            afficherImageContextMenuItem.Click += new System.EventHandler(this.afficherImageMenuItem_Click);
            ToolStripMenuItem changerCouleurContextMenuItem = new ToolStripMenuItem("Changer Couleur du Bureau");
            changerCouleurContextMenuItem.Click += new System.EventHandler(this.changerCouleurMenuItem_Click);
            parametresContextMenuItem.DropDownItems.Add(afficherBarreContextMenuItem);
            parametresContextMenuItem.DropDownItems.Add(desactiverBarreContextMenuItem);
            parametresContextMenuItem.DropDownItems.Add(new ToolStripSeparator());
            parametresContextMenuItem.DropDownItems.Add(afficherImageContextMenuItem);
            parametresContextMenuItem.DropDownItems.Add(changerCouleurContextMenuItem);

            // Aide Menu
            ToolStripMenuItem aideContextMenuItem = new ToolStripMenuItem("?");
            ToolStripMenuItem aideAideContextMenuItem = new ToolStripMenuItem("Aide");
            aideAideContextMenuItem.Click += new System.EventHandler(this.aideAideMenuItem_Click);
            ToolStripMenuItem aproposContextMenuItem = new ToolStripMenuItem("A propos de TP4");
            aproposContextMenuItem.Click += new System.EventHandler(this.aproposMenuItem_Click);
            aideContextMenuItem.DropDownItems.Add(aideAideContextMenuItem);
            aideContextMenuItem.DropDownItems.Add(aproposContextMenuItem);

            // Add all top-level menus to the ContextMenuStrip
            cmsMenuContextuel.Items.Add(listesContextMenuItem);
            cmsMenuContextuel.Items.Add(parametresContextMenuItem);
            cmsMenuContextuel.Items.Add(aideContextMenuItem);
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
