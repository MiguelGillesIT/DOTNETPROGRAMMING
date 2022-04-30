using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet6_Final
{
    public partial class FrmListeFournisseurs : Form
    {
        SqlConnection cnx; 
        SqlCommand cmd; 
        SqlDataAdapter adap; 
        SqlCommandBuilder cb; 
        DataSet dset;

        public FrmListeFournisseurs()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Form1 mainInterface = new Form1();
            mainInterface.Show();
            this.Hide();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                    if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur?", "Confirmer suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       
                        int i = dataGridView1.CurrentRow.Index; 
                        dset.Tables[0].Rows[i].Delete();
                        cb = new SqlCommandBuilder(adap); 
                        adap.Update(dset, "Fournisseur");
                   
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous enregistrer les modifications?", "Confirmer modification", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Fournisseur");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fournisseurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fournisseurBindingSource.EndEdit();
            this.fournisseurTableAdapter.Update(this.dBStockDataSet1);

        }

        private void FrmListeFournisseurs_Load_1(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DBStock;Integrated Security=True";
            cnx.Open();
            cmd = new SqlCommand(); cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            dataGridView1.DataSource = dset.Tables[0];

        }

      



       
    }
}
