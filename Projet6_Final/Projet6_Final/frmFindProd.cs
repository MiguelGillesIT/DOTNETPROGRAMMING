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
    public partial class frmFindProd : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;

        public frmFindProd()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Form1 mainInterface = new Form1();
            mainInterface.Show();
            this.Hide();
        }

        private void frmFindProd_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DBStock;Integrated Security=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Produit");
            dataGridView1.DataSource = dset.Tables[0];

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
                cmd = new SqlCommand();
                if (radioButton1.Checked)
                {
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn and CodeProduit like('" + textBox1.Text + "%')";
                }
                else if(radioButton2.Checked)
                {
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn=F.CodeFourn and NomProduit like('"+textBox1.Text+"%')";
                }
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset = new DataSet();
                adap.Fill(dset, "Produit");
                dataGridView1.DataSource = dset.Tables[0];
        }
    }
}
