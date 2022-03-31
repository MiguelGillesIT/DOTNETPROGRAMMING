using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjout1_Click(object sender, EventArgs e)
        {
            if (TxtN.Text.Trim() != "")
            {
                LstG1.Items.Add(TxtN.Text);
                TxtN.Text = "";
                TxtN.Focus();

            }
            else {
                MessageBox.Show("Il faut saisir une valeur");
            }
            
            
        }

        private void BtnSupp1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1) {
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
            else if (LstD1.SelectedIndex != -1)
            {
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
            }
            else {
                MessageBox.Show("Aucun élément n'est sélectionné");
            }
        }

        private void BtnVider1_Click(object sender, EventArgs e)
        {
            LstG1.Items.Clear();
            LstD1.Items.Clear();
        }

        private void BtnGD1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
            {
                String item = LstG1.SelectedItem.ToString();
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
                LstD1.Items.Add(item);
            }else
            {
                MessageBox.Show("Aucun élément n'est sélectionné");
            }
        }

        private void BtnDG1_Click(object sender, EventArgs e)
        {
            if (LstD1.SelectedIndex != -1)
            {
                String item = LstD1.SelectedItem.ToString();
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
                LstG1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Aucun élément n'est sélectionné");
            }
        }

        private void BtnTGD1_Click(object sender, EventArgs e)
        {
            String item;
            for (int i = 0; i < LstG1.Items.Count; i++) {
                item = LstG1.Items[i].ToString();
                LstD1.Items.Add(item);
            }
            LstG1.Items.Clear();
        }

        private void BtnTDG1_Click(object sender, EventArgs e)
        {
            String item;
            for (int i = 0; i < LstD1.Items.Count; i++)
            {
                item = LstD1.Items[i].ToString();
                LstG1.Items.Add(item);
            }
            LstD1.Items.Clear();
        }
    }
}
