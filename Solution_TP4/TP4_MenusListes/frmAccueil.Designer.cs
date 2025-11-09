namespace TP4_MenusListes
{
    partial class frmAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deplacementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherBarreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactiverBarreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.afficherImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerCouleurMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideAideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aproposMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBarreOutils = new System.Windows.Forms.ToolStrip();
            this.tsbListes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.cmsMenuContextuel = new System.Windows.Forms.ContextMenuStrip(this.components);
            // Re-create menu items for context menu
            this.deplacementContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip1.SuspendLayout();
            this.tsBarreOutils.SuspendLayout();
            this.cmsMenuContextuel.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listesToolStripMenuItem,
            this.parametresMenuItem,
            this.aideMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // listesToolStripMenuItem
            //
            this.listesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deplacementMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.listesToolStripMenuItem.Name = "listesToolStripMenuItem";
            this.listesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.listesToolStripMenuItem.Text = "Listes";
            //
            // deplacementMenuItem
            //
            this.deplacementMenuItem.Name = "deplacementMenuItem";
            this.deplacementMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deplacementMenuItem.Size = new System.Drawing.Size(239, 22);
            this.deplacementMenuItem.Text = "Deplacement des données";
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            //
            // exitMenuItem
            //
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitMenuItem.Size = new System.Drawing.Size(239, 22);
            this.exitMenuItem.Text = "Exit";
            //
            // parametresMenuItem
            //
            this.parametresMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherBarreMenuItem,
            this.desactiverBarreMenuItem,
            this.toolStripSeparator2,
            this.afficherImageMenuItem,
            this.changerCouleurMenuItem});
            this.parametresMenuItem.Name = "parametresMenuItem";
            this.parametresMenuItem.Size = new System.Drawing.Size(80, 20);
            this.parametresMenuItem.Text = "Paramètres";
            //
            // afficherBarreMenuItem
            //
            this.afficherBarreMenuItem.Checked = true;
            this.afficherBarreMenuItem.CheckOnClick = true;
            this.afficherBarreMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.afficherBarreMenuItem.Name = "afficherBarreMenuItem";
            this.afficherBarreMenuItem.Size = new System.Drawing.Size(224, 22);
            this.afficherBarreMenuItem.Text = "Afficher Barre d\'outils";
            //
            // desactiverBarreMenuItem
            //
            this.desactiverBarreMenuItem.CheckOnClick = true;
            this.desactiverBarreMenuItem.Name = "desactiverBarreMenuItem";
            this.desactiverBarreMenuItem.Size = new System.Drawing.Size(224, 22);
            this.desactiverBarreMenuItem.Text = "Désactiver Barre D\'outils";
            //
            // toolStripSeparator2
            //
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            //
            // afficherImageMenuItem
            //
            this.afficherImageMenuItem.Checked = true;
            this.afficherImageMenuItem.CheckOnClick = true;
            this.afficherImageMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.afficherImageMenuItem.Name = "afficherImageMenuItem";
            this.afficherImageMenuItem.Size = new System.Drawing.Size(224, 22);
            this.afficherImageMenuItem.Text = "Afficher Image pour le Bureau";
            //
            // changerCouleurMenuItem
            //
            this.changerCouleurMenuItem.Name = "changerCouleurMenuItem";
            this.changerCouleurMenuItem.Size = new System.Drawing.Size(224, 22);
            this.changerCouleurMenuItem.Text = "Changer Couleur du Bureau";
            //
            // aideMenuItem
            //
            this.aideMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideAideMenuItem,
            this.aproposMenuItem});
            this.aideMenuItem.Name = "aideMenuItem";
            this.aideMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aideMenuItem.Text = "?";
            //
            // aideAideMenuItem
            //
            this.aideAideMenuItem.Name = "aideAideMenuItem";
            this.aideAideMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aideAideMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aideAideMenuItem.Text = "Aide";
            //
            // aproposMenuItem
            //
            this.aproposMenuItem.Name = "aproposMenuItem";
            this.aproposMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aproposMenuItem.Size = new System.Drawing.Size(186, 22);
            this.aproposMenuItem.Text = "A propos de TP4";
            //
            // tsBarreOutils
            //
            this.tsBarreOutils.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbListes,
            this.toolStripSeparator3,
            this.tsbExit});
            this.tsBarreOutils.Location = new System.Drawing.Point(0, 24);
            this.tsBarreOutils.Name = "tsBarreOutils";
            this.tsBarreOutils.Size = new System.Drawing.Size(584, 25);
            this.tsBarreOutils.TabIndex = 1;
            this.tsBarreOutils.Text = "toolStrip1";
            //
            // tsbListes
            //
            this.tsbListes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbListes.Image = global::TP4_MenusListes.Properties.Resources.list_icon;
            this.tsbListes.Name = "tsbListes";
            this.tsbListes.Size = new System.Drawing.Size(23, 22);
            this.tsbListes.Text = "toolStripButton1";
            //
            // toolStripSeparator3
            //
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            //
            // tsbExit
            //
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::TP4_MenusListes.Properties.Resources.exit_icon;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(23, 22);
            this.tsbExit.Text = "toolStripButton2";
            //
            // cmsMenuContextuel
            //
            // This is a workaround for the designer. In a real scenario, you would copy the items.
            // Since I cannot use the designer, I am recreating the items manually.
            this.cmsMenuContextuel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                new System.Windows.Forms.ToolStripMenuItem("Listes", null, new System.Windows.Forms.ToolStripItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Deplacement des données", null, this.deplacementMenuItem_Click),
                    new System.Windows.Forms.ToolStripSeparator(),
                    new System.Windows.Forms.ToolStripMenuItem("Exit", null, this.exitMenuItem_Click)
                }),
                new System.Windows.Forms.ToolStripMenuItem("Paramètres", null, new System.Windows.Forms.ToolStripItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Afficher Barre d'outils", null, this.afficherBarreMenuItem_Click),
                    new System.Windows.Forms.ToolStripMenuItem("Désactiver Barre D'outils", null, this.desactiverBarreMenuItem_Click),
                    new System.Windows.Forms.ToolStripSeparator(),
                    new System.Windows.Forms.ToolStripMenuItem("Afficher Image pour le Bureau", null, this.afficherImageMenuItem_Click),
                    new System.Windows.Forms.ToolStripMenuItem("Changer Couleur du Bureau", null, this.changerCouleurMenuItem_Click)
                }),
                new System.Windows.Forms.ToolStripMenuItem("?", null, new System.Windows.Forms.ToolStripItem[] {
                    new System.Windows.Forms.ToolStripMenuItem("Aide", null, this.aideAideMenuItem_Click),
                    new System.Windows.Forms.ToolStripMenuItem("A propos de TP4", null, this.aproposMenuItem_Click)
                })
            });
            this.cmsMenuContextuel.Name = "cmsMenuContextuel";
            this.cmsMenuContextuel.Size = new System.Drawing.Size(153, 70);
            //
            // frmAccueil
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP4_MenusListes.Properties.Resources.background_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.ContextMenuStrip = this.cmsMenuContextuel;
            this.Controls.Add(this.tsBarreOutils);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsBarreOutils.ResumeLayout(false);
            this.tsBarreOutils.PerformLayout();
            this.cmsMenuContextuel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deplacementMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherBarreMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactiverBarreMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem afficherImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerCouleurMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideAideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aproposMenuItem;
        private System.Windows.Forms.ToolStrip tsBarreOutils;
        private System.Windows.Forms.ToolStripButton tsbListes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContextuel;
    }
}
