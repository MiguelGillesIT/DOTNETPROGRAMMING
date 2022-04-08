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
    public partial class Form2 : Form
    {
        // Création d'une table vide avec le nom Personne DataTable table = new DataTable("Personne");
        DataTable table = new DataTable("Personne");

        public Form2()
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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow dtr = table.NewRow(); 
            dtr[0] = TXTcin.Text;
            dtr[1] = TXTnom.Text; 
            dtr[2] = TXTprenom.Text; 
            dtr[3] = TXTville.Text; 
            dtr[4] = TXTtel.Text; 
            dtr[5] = TXTage.Text; 
            table.Rows.Add(dtr); 
            TXTcin.Text = ""; 
            TXTnom.Text = "";
            TXTprenom.Text = ""; 
            TXTville.Text = ""; 
            TXTtel.Text = ""; 
            TXTage.Text = ""; 
            TXTcin.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string ch; 
            int nb;
            nb = bindingSource1.Position;
            ch = "CIN = " + table.Rows[nb][0].ToString() + (char)10 + "Nom = " + table.Rows[nb][1].ToString() + (char)10 + "Prénom = " + table.Rows[nb][2].ToString() + (char)10 + "Ville = " + table.Rows[nb][3].ToString() + (char)10 +"Téléphone = " + table.Rows[nb][4].ToString() + (char)10 + "Age = " + table.Rows[nb][5].ToString();
            MessageBox.Show(ch,"Détails de la personne numéro " + nb.ToString());
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
