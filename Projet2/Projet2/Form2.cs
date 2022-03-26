using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2
{
    public partial class FrmFactoriel : Form
    {
        public FrmFactoriel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int s, fact = 1;
            if (int.TryParse(TxtN.Text, out s))
            {
                if (s < 0)
                {
                    MessageBox.Show("Entrez un entier positif!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (s == 0)
                {
                    LblRes.Text = "1";
                }
                else
                {
                    for (int i = 1; i <= s; i++) {
                        fact *= i;
                    }
                    LblRes.Text = fact.ToString();

                }

            }
            else {
                MessageBox.Show("Entrez un nombre entier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
