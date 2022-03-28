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

    public partial class FrmTables : Form
    {
        const int n = 5;
        float[] T = new float[n];
        int i = 0;

        public FrmTables()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float val;
            if (float.TryParse(TxtN.Text, out val) && val >= 0)
            {
                LblRes.Text = "Entrez la note de l'élève N°: " + (i + 2).ToString();
                LblT.Text = LblT.Text + TxtN.Text + "|";
                T[i] = val;
                i++;
                TxtN.Text = "";
                TxtN.Focus();
                if (i == n)
                {
                    BtnCalc.Enabled = true;
                    BtnEnreg.Enabled = false;
                    TxtN.Enabled = false;
                    BtnCalc.Focus();
                }
            }
            else {
                MessageBox.Show("Il faut donner un réel positif !", "Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblRes_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double sum = 0.0, mean = 0.0, sqrSum = 0.0, stdDeviation = 0.0;
            int supToTen = 0, noSupToTen = 0;

            for (int i = 0; i < 5; i++) {
                if (T[i] <  10.0)
                {
                    noSupToTen += 1;
                }else{
                    supToTen += 1;
                }
                sum += T[i];
            }

            mean = sum / 5;

            for (int i = 0; i < 5; i++)
            {

                sqrSum += (T[i] - mean) * (T[i] - mean);
            }


            stdDeviation = Math.Sqrt(sqrSum);

            LblEcart.Text = stdDeviation.ToString();
            LblMoy.Text = mean.ToString();
            LblInf.Text = noSupToTen.ToString();
            LblSup.Text = supToTen.ToString();
            
        }
    }
}
