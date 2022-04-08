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
    public partial class Form3 : Form
    {
        // Création d'une liste de Personne 
        List<Personne> table=new List<Personne>();

        public Form3()
        {
            InitializeComponent();
            bindingSource1.DataSource = table; 
            bindingNavigator1.BindingSource = bindingSource1; 
            dataGridView1.DataSource = bindingSource1;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Personne p = new Personne(); 
            p.CIN = TXTcin.Text;
            p.Nom = TXTnom.Text; 
            p.Prenom = TXTprenom.Text; 
            p.Ville = TXTville.Text; 
            p.Tel = TXTtel.Text;
            p.Age = int.Parse(TXTage.Text); 
            table.Add(p); 
            bindingSource1.ResetBindings(true);
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
            string ch; int nb;
            nb = dataGridView1.CurrentRow.Index;
            Personne p = table[nb];
            ch = "CIN = " + p.CIN + (char)10 + "Nom = " + p.Nom + (char)10 + "Prénom = " + p.Prenom + (char)10 + "Ville = " + p.Ville + (char)10 + "Téléphone = " + p.Tel + (char)10 + "Age = " + p.Age.ToString(); 
            MessageBox.Show(ch, "Détails de la personne numéro " + nb.ToString());

        }

    }
}
