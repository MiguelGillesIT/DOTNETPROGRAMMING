using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutClient ajoutClient = new FormAjoutClient();
            ajoutClient.Show();
            this.Hide();
        }

        private void listeDeClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeClients listeClient = new frmListeClients();
            listeClient.Show();
            this.Hide();
        }

        private void ajouterUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterFourn ajouterFournisseur = new frmAjouterFourn();
            ajouterFournisseur.Show();
            this.Hide();
        }

        private void listeDesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeFournisseurs listeFournisseurs = new FrmListeFournisseurs();
            listeFournisseurs.Show();
            this.Hide();
        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjouterProd ajouterProduit = new frmAjouterProd();
            ajouterProduit.Show();
            this.Hide();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListePro listeProduits = new frmListePro();
            listeProduits.Show();
            this.Hide();
        }

        private void rechercherUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFindProd trouverProduit = new frmFindProd();
            trouverProduit.Show();
            this.Hide();
        }

        private void créerUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjoutFacture AjoutFacture = new frmAjoutFacture();
            AjoutFacture.Show();
            this.Hide();
        }

        private void afficherUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void listeDesFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeFacture listeFacture = new frmListeFacture();
            listeFacture.Show();
            this.Hide();
        }



   
    }
}
