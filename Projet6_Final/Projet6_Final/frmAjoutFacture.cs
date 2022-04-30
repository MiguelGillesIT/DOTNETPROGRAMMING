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
    public partial class frmAjoutFacture : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        DataSet dset;

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

        private void frmAjoutFacture_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DBStock;Integrated Security=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Client";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Client");
            cmbClient.DataSource = dset.Tables[0];
            cmbClient.DisplayMember = "Nom";
            cmbClient.ValueMember = "CodeClient";
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment créer cette facture ?", "Création d'une facture", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    cmd.CommandText = "insert into Facture values ('" + txtCode.Text + "','" + cmbClient.SelectedValue.ToString() + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "','" + txtRetenue.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion effectuée avec succes", "Insertion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
