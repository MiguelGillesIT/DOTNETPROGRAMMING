namespace Projet6
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDeClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fournisseursToolStripMenuItem,
            this.produitdToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 10, 2);
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.listeDeClientsToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnClientToolStripMenuItem.Image")));
            this.ajouterUnClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ajouterUnClientToolStripMenuItem.MergeIndex = 1;
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ajouterUnClientToolStripMenuItem.Text = " Ajouter un client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // listeDeClientsToolStripMenuItem
            // 
            this.listeDeClientsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeDeClientsToolStripMenuItem.Image")));
            this.listeDeClientsToolStripMenuItem.Name = "listeDeClientsToolStripMenuItem";
            this.listeDeClientsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.listeDeClientsToolStripMenuItem.Text = "Liste de clients";
            this.listeDeClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDeClientsToolStripMenuItem_Click);
            // 
            // fournisseursToolStripMenuItem
            // 
            this.fournisseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem,
            this.listeDesFournisseursToolStripMenuItem});
            this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            this.fournisseursToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fournisseursToolStripMenuItem.Text = "Fournisseurs";
            // 
            // ajouterUnFournisseurToolStripMenuItem
            // 
            this.ajouterUnFournisseurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnFournisseurToolStripMenuItem.Image")));
            this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
            this.ajouterUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUnFournisseurToolStripMenuItem.Text = "Ajouter un fournisseur";
            this.ajouterUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnFournisseurToolStripMenuItem_Click);
            // 
            // listeDesFournisseursToolStripMenuItem
            // 
            this.listeDesFournisseursToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeDesFournisseursToolStripMenuItem.Image")));
            this.listeDesFournisseursToolStripMenuItem.Name = "listeDesFournisseursToolStripMenuItem";
            this.listeDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesFournisseursToolStripMenuItem.Text = "Liste des fournisseurs";
            this.listeDesFournisseursToolStripMenuItem.Click += new System.EventHandler(this.listeDesFournisseursToolStripMenuItem_Click);
            // 
            // produitdToolStripMenuItem
            // 
            this.produitdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnProduitToolStripMenuItem,
            this.listeDesProduitsToolStripMenuItem,
            this.rechercherUnProduitToolStripMenuItem});
            this.produitdToolStripMenuItem.Name = "produitdToolStripMenuItem";
            this.produitdToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.produitdToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.produitdToolStripMenuItem.Text = "Produits";
            // 
            // ajouterUnProduitToolStripMenuItem
            // 
            this.ajouterUnProduitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajouterUnProduitToolStripMenuItem.Image")));
            this.ajouterUnProduitToolStripMenuItem.Name = "ajouterUnProduitToolStripMenuItem";
            this.ajouterUnProduitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUnProduitToolStripMenuItem.Text = "Ajouter un produit";
            this.ajouterUnProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProduitToolStripMenuItem_Click);
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeDesProduitsToolStripMenuItem.Image")));
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des produits";
            this.listeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProduitsToolStripMenuItem_Click);
            // 
            // rechercherUnProduitToolStripMenuItem
            // 
            this.rechercherUnProduitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rechercherUnProduitToolStripMenuItem.Image")));
            this.rechercherUnProduitToolStripMenuItem.Name = "rechercherUnProduitToolStripMenuItem";
            this.rechercherUnProduitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rechercherUnProduitToolStripMenuItem.Text = "Rechercher un produit";
            this.rechercherUnProduitToolStripMenuItem.Click += new System.EventHandler(this.rechercherUnProduitToolStripMenuItem_Click);
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUneFactureToolStripMenuItem,
            this.afficherUneFactureToolStripMenuItem,
            this.listeDesFacturesToolStripMenuItem});
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturesToolStripMenuItem.Text = "Factures";
            // 
            // créerUneFactureToolStripMenuItem
            // 
            this.créerUneFactureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("créerUneFactureToolStripMenuItem.Image")));
            this.créerUneFactureToolStripMenuItem.Name = "créerUneFactureToolStripMenuItem";
            this.créerUneFactureToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.créerUneFactureToolStripMenuItem.Text = "Créer une facture";
            this.créerUneFactureToolStripMenuItem.Click += new System.EventHandler(this.créerUneFactureToolStripMenuItem_Click);
            // 
            // afficherUneFactureToolStripMenuItem
            // 
            this.afficherUneFactureToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("afficherUneFactureToolStripMenuItem.Image")));
            this.afficherUneFactureToolStripMenuItem.Name = "afficherUneFactureToolStripMenuItem";
            this.afficherUneFactureToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.afficherUneFactureToolStripMenuItem.Text = "Afficher une facture";
            this.afficherUneFactureToolStripMenuItem.Click += new System.EventHandler(this.afficherUneFactureToolStripMenuItem_Click);
            // 
            // listeDesFacturesToolStripMenuItem
            // 
            this.listeDesFacturesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeDesFacturesToolStripMenuItem.Image")));
            this.listeDesFacturesToolStripMenuItem.Name = "listeDesFacturesToolStripMenuItem";
            this.listeDesFacturesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listeDesFacturesToolStripMenuItem.Text = "Liste des factures";
            this.listeDesFacturesToolStripMenuItem.Click += new System.EventHandler(this.listeDesFacturesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 476);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                       GESTION DU STOCK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDeClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

