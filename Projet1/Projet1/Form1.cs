using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class FrmCalculatrice : Form
    {
        public FrmCalculatrice()
        {
            InitializeComponent();
        }

        private void FrmCalculatrice_Load(object sender, EventArgs e)
        {

        }

        private void LblV1_Click(object sender, EventArgs e)
        {

        }

        private void LblV2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float s,x1,x2;
            if (float.TryParse(TxtV1.Text, out x1) && float.TryParse(TxtV2.Text, out x2))
            {
                s = x1 + x2;
                LblRes.Text = s.ToString();
            }else{
                MessageBox.Show("Il faut donner deux réels !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult x = MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void BtnFois_Click(object sender, EventArgs e)
        {
            float s, x1, x2;
            if (float.TryParse(TxtV1.Text, out x1) && float.TryParse(TxtV2.Text, out x2))
            {
                s = x1 * x2;
                LblRes.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Il faut donner deux réels !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult x = MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes){
                Application.Exit();
            }
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtV1.Text = "0";
            TxtV2.Text = "0";
            LblRes.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            float s, x1, x2;
            if (float.TryParse(TxtV1.Text, out x1) && float.TryParse(TxtV2.Text, out x2))
            {
                s = x1 - x2;
                LblRes.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Il faut donner deux réels !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult x = MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void BtnSur_Click(object sender, EventArgs e)
        {
            float s, x1, x2;
            if (float.TryParse(TxtV1.Text, out x1) && float.TryParse(TxtV2.Text, out x2))
            {
                s = x1 / x2;
                LblRes.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Il faut donner deux réels !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult x = MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            float s, x1, x2;
            if (float.TryParse(TxtV1.Text, out x1) && float.TryParse(TxtV2.Text, out x2))
            {
                s = x1 % x2;
                LblRes.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Il faut donner deux réels !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult x = MessageBox.Show("Voulez vous quitter ?", "Confirmation", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            frmAccueil acc = new frmAccueil();
            acc.Show();
            this.Close();
        }
    }
}
