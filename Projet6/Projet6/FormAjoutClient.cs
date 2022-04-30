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
    public partial class FormAjoutClient : Form
    {
        public FormAjoutClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBStockDataSet);

        }

        private void FormAjoutClient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dBStockDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientTableAdapter.Fill(this.dBStockDataSet.Client);

        }
    }
}
