using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet5
{
    public partial class Form1 : Form
    {
        // Création d'une table vide avec le nom Personne DataTable table = new DataTable("Personne");
        DataTable table = new DataTable("Personne");

        public Form1()
        {
            InitializeComponent();
            // Création des colonnes pour la table 
            table.Columns.Add(new DataColumn("CIN", typeof(string))); 
            table.Columns.Add(new DataColumn("Nom", typeof(string))); 
            table.Columns.Add(new DataColumn("Prénom", typeof(string))); 
            table.Columns.Add(new DataColumn("Ville", typeof(string)));
            table.Columns.Add(new DataColumn("Telephone", typeof(string))); 
            table.Columns.Add(new DataColumn("Age", typeof(int)));
            // Configure la source de données avec le bindingSource 
            bindingSource1.DataSource = table;
            // Configure la navigation 
            bindingNavigator1.BindingSource = bindingSource1;
            // liéer le dataGridView avec la même source de données 
            dataGridView1.DataSource = bindingSource1;
        }

        private void nouveauCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void ouvrirCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fichiers XML (*.xml)|*.xml|Tous Les Fichiers (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
                table.ReadXml(@openFileDialog1.FileName); 
            }
        }

        private void enregistrerSousCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Fichiers XML (*.xml)|*.xml|Tous Les Fichiers (*.*)|*.*";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                table.WriteXml(@saveFileDialog1.FileName);
            }
        }

        private void quitterCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form3()).Show(); 
            this.Hide();
        }

       
    }
}
