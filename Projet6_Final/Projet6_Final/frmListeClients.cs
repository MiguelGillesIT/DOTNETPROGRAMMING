using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet6_Final
{
    public partial class frmListeClients : Form
    {
        public frmListeClients()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Form1 mainInterface = new Form1();
            mainInterface.Show();
            this.Hide();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBStockDataSet);

        }

        private void frmListeClients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dBStockDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.dBStockDataSet.Client);

        }
    }
}
