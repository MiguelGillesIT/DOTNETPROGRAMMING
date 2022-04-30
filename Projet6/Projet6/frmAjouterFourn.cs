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

namespace Projet6
{
    public partial class frmAjouterFourn : Form
    {
        SqlConnection cnx; 
        SqlCommand cmd; 
        SqlDataAdapter adap; 
        SqlCommandBuilder cb; 
        DataSet dset; 
        DataTable tab; 
        DataRow dtr;
        int indice;

        public frmAjouterFourn()
        {
            InitializeComponent();
           
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            txtCode.Text = ""; 
            txtNom.Text = ""; 
            txtAdr.Text = ""; 
            txtTel.Text = ""; 
            txtFax.Text = ""; 
            BTajout.Enabled = true;
        }

        private void BtnPrime_Click(object sender, EventArgs e)
        {
            indice = 0;
            txtCode.Text = (tab.Rows[0][0]).ToString(); 
            txtNom.Text = (tab.Rows[0][1]).ToString(); 
            txtAdr.Text = (tab.Rows[0][2]).ToString(); 
            txtTel.Text = (tab.Rows[0][3]).ToString(); 
            txtFax.Text = (tab.Rows[0][4]).ToString();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                txtCode.Text = (tab.Rows[indice][0]).ToString(); 
                txtNom.Text = (tab.Rows[indice][1]).ToString(); 
                txtAdr.Text = (tab.Rows[indice][2]).ToString(); 
                txtTel.Text = (tab.Rows[indice][3]).ToString(); 
                txtFax.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (indice < tab.Rows.Count - 1)
            {
                indice++;
                txtCode.Text = (tab.Rows[indice][0]).ToString(); 
                txtNom.Text = (tab.Rows[indice][1]).ToString(); 
                txtAdr.Text = (tab.Rows[indice][2]).ToString(); 
                txtTel.Text = (tab.Rows[indice][3]).ToString(); 
                txtFax.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            indice = tab.Rows.Count - 1;
            txtCode.Text = (tab.Rows[indice][0]).ToString(); 
            txtNom.Text = (tab.Rows[indice][1]).ToString(); 
            txtAdr.Text = (tab.Rows[indice][2]).ToString(); 
            txtTel.Text = (tab.Rows[indice][3]).ToString(); 
            txtFax.Text = (tab.Rows[indice][4]).ToString();
        }

        private void BTajout_Click(object sender, EventArgs e)
        {
            dtr = tab.NewRow(); 
            dtr[0] = txtCode.Text; 
            dtr[1] = txtNom.Text; 
            dtr[2] = txtAdr.Text; 
            dtr[3] = txtTel.Text; 
            dtr[4] = txtFax.Text;
            dset.Tables[0].Rows.Add(dtr); 
            tab = dset.Tables[0];
            indice = tab.Rows.Count - 1;
            MessageBox.Show("Fournisseur ajouté"); 
            BTajout.Enabled = false;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(adap); 
                adap.Update(dset, "Fournisseur"); 
                dset.Clear();
                adap.Fill(dset, "Fournisseur"); 
                tab = dset.Tables[0];
                MessageBox.Show("Données enregistrées dans la base");
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
                dset.Tables[0].Rows[indice][0] = txtCode.Text; 
                dset.Tables[0].Rows[indice][1] = txtNom.Text; 
                dset.Tables[0].Rows[indice][2] = txtAdr.Text; 
                dset.Tables[0].Rows[indice][3] = txtTel.Text; 
                dset.Tables[0].Rows[indice][4] = txtFax.Text; 
                tab = dset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                    if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur?", "Confirmer suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dset.Tables[0].Rows[indice].Delete(); 
                        dset.AcceptChanges();
                        indice--;
                        tab = dset.Tables[0];
                        if (indice < 0)
                        {
                            indice = 0;
                        } 
                        if (tab.Rows.Count != 0)
                        {
                            txtCode.Text = (tab.Rows[indice][0]).ToString(); 
                            txtNom.Text = (tab.Rows[indice][1]).ToString(); 
                            txtAdr.Text = (tab.Rows[indice][2]).ToString(); 
                            txtTel.Text = (tab.Rows[indice][3]).ToString(); 
                            txtFax.Text = (tab.Rows[indice][4]).ToString();
                        }
                        else
                        {
                            txtCode.Text = ""; 
                            txtNom.Text = ""; 
                            txtAdr.Text = ""; 
                            txtTel.Text = ""; 
                            txtFax.Text = "";
                        }
                        MessageBox.Show("Fournisseur Supprimé");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAjouterFourn_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
           // cnx.ConnectionString = "Data Source=(localdb)\v11.0;Initial Catalog=BDStock;Integrated Security=True";
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=BDStock;Integrated Security=True";
            cnx.Open();

            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;

            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            tab = dset.Tables[0];

            indice = 0;
            txtCode.Text = (tab.Rows[0][0]).ToString();
            txtNom.Text = (tab.Rows[0][1]).ToString();
            txtAdr.Text = (tab.Rows[0][2]).ToString();
            txtTel.Text = (tab.Rows[0][3]).ToString();
            txtFax.Text = (tab.Rows[0][4]).ToString();
            BTajout.Enabled = false;
        }

  

     
    }
}
