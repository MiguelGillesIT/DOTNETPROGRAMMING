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
    public partial class frmListeFacture : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet dset;

        public frmListeFacture()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Form1 mainInterface = new Form1();
            mainInterface.Show();
            this.Hide();
        }

        private void frmListeFacture_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DBStock;Integrated Security=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Facture";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Facture");
            dataGridView1.DataSource = dset.Tables[0];
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer cette facture?", "Supprimer une Facture", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "delete from Facture where CodeFacture=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression effectuée avec succes", "Suppression");
                    cmd = new SqlCommand();
                    cmd.CommandText = "select * from Facture";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd);
                    dset = new DataSet();
                    adap.Fill(dset, "Facture");
                    dataGridView1.DataSource = dset.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous enregistrer les modifications?", "Confirmer modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd.CommandText = "update Facture set Retenue = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "',Date = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "',CodeClient='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' where CodeFacture = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Modification effectuée avec succes", "Modification");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
