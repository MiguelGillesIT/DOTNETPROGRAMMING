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
    public partial class frmAjoutFacture : Form
    {
        public frmAjoutFacture()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Form1 mainInterface = new Form1();
            mainInterface.Show();
            this.Hide();
        }
    }
}
