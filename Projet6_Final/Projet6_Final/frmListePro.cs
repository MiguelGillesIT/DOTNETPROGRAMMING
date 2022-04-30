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
    public partial class frmListePro : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset, dset2;

        public frmListePro()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Form1 mainInterface = new Form1();
            mainInterface.Show();
            this.Hide();
        }

        private void frmListePro_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DBStock;Integrated Security=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            DataRow dr;
            dr = dset.Tables[0].NewRow();
            dr["NomPrenom"] = "Toute la liste";
            dset.Tables[0].Rows.Add(dr);
            cmbFourn.DataSource = dset.Tables[0];
            cmbFourn.DisplayMember = "NomPrenom";
            cmbFourn.ValueMember = "CodeFourn";
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset2 = new DataSet();
            adap.Fill(dset2, "Produit");
            dataGridView1.DataSource = dset2.Tables[0];
            cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce produit?", "Supprimer un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "delete from Produit where CodeProduit=" + dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression effectuée avec succes", "Suppression");
                    cmd = new SqlCommand();
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd); 
                    dset2 = new DataSet(); 
                    adap.Fill(dset2, "Produit");
                    dataGridView1.DataSource = dset2.Tables[0]; 
                    cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbFourn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            if (cmbFourn.SelectedIndex == cmbFourn.Items.Count - 1)
            {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn";

            }
            else
            {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn and P.CodeFourn=" + cmbFourn.SelectedValue;
            } 
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd); 
            dset2 = new DataSet(); 
            adap.Fill(dset2, "Produit");
            dataGridView1.DataSource = dset2.Tables[0];
        }

       
            private void BtnModify_Click(object sender, EventArgs e)
            {
                try
                {
                    if (MessageBox.Show("Voulez vous enregistrer les modifications?", "Confirmer modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cmd.CommandText = "update Produit set CodeFourn = '" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "',NomProduit = '" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "',PrixUnitaire='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "',QtEnStock='" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "'  where CodeProduit= " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
