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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void BtnCalculatrice_Click(object sender, EventArgs e)
        {
            FrmCalculatrice c1 = new FrmCalculatrice();
            c1.Show();
            this.Hide();
        }

        private void BtnApropos_Click(object sender, EventArgs e)
        {
            frmApropos ap = new frmApropos();
            ap.ShowDialog();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
