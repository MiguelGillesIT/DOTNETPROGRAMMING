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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFactoriel Factoriel = new FrmFactoriel();
            Factoriel.Show();
            this.Hide();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnJouer_Click(object sender, EventArgs e)
        {
            FormGame Game = new FormGame();
            Game.Show();
            this.Hide();
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            FrmTables Tables = new FrmTables();
            Tables.Show();
            this.Hide();
        }
    }
}
