using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class CalculForm : Form
    {
        public CalculForm()
        {
            InitializeComponent();
            LblDate.Text = "Date : " + DateTime.Now.ToShortDateString();
            timer1.Start();
            LblHeure.Text = "Heure : " + DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnChance_Click(object sender, EventArgs e)
        {
            int x;
            Random alea = new Random();
            x = alea.Next(0, 16);
            TxtChance.Text = x.ToString();
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            TxtCin.Text = "";
            TxtTel.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtLang.Text = "0";
            TxtTech.Text = "0";
            TxtChance.Text = "0";
            RdMas.Checked = false;
            RdFem.Checked = false;
            ChkExper.Checked = false;
            ChkMotiv.Checked = false;
            ChkDip.Checked = false;
            CmbAge.SelectedIndex = -1;
            BtnAjout.Enabled = false;
        }

        private void TxtLang_Validating(object sender, CancelEventArgs e)
        {
            if (TxtLang.Text == "")
            {
            }
            else
            {
                MessageBox.Show("Il faut saisir un prix HT");
                e.Cancel = true;
                if (int.Parse(TxtLang.Text) >= 500)
                {
                    MessageBox.Show("Le prix HT doit être supérieure ou égal à 500");
                    TxtLang.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void TxtLang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0') || (e.KeyChar > '9')))
            {
                e.KeyChar = (char)0;
            }

        }

        private void TxtTech_Validating(object sender, CancelEventArgs e)
        {
            if (TxtLang.Text == "")
            {
                MessageBox.Show("Il faut saisir une TVA");
                e.Cancel = true;
            }
            else
            {

                if (int.Parse(TxtTech.Text) > 22 || int.Parse(TxtTech.Text) <  0)
                {
                    MessageBox.Show("La TVA doit être entre 0 et 22");
                    TxtTech.SelectAll();
                    e.Cancel = true;
                }
            }

        }

        private void TxtTech_KeyPress(object sender, KeyPressEventArgs e) {
            if (((e.KeyChar < '0') || (e.KeyChar > '9')))
            {
                e.KeyChar = (char)0;
            }

        }


        private void BtnAjout_Click(object sender, EventArgs e)
        {
            Lst1.Items.Add(TxtCin.Text);
            Lst2.Items.Add(TxtNom.Text);
            Lst3.Items.Add(TxtPrenom.Text);
            Lst4.Items.Add(TxtScore.Text);
            BtnAjout.Enabled = false;

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if ((TxtCin.Text == "") || (TxtTel.Text == "") || (TxtNom.Text == "") || (TxtPrenom.Text == "") || (TxtLang.Text == "") || (TxtTech.Text == "") || (TxtChance.Text == ""))
                {
                    MessageBox.Show("Il faut saisir toutes les informations !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int note = 0, note1, note2, sexe = 0, bonus = 0, age = 0, chance = 0, score = 0;

                if (int.TryParse(TxtLang.Text, out note1) && int.TryParse(TxtTech.Text, out note2))
                {
                    note = note1 + note2;
                }
                else
                {
                    MessageBox.Show("Montant ou TVA incorrecte !", "Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                
                if((RdMas.Checked == RdFem.Checked)){
                   MessageBox.Show("Choisissez un écran !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }else{
                        if(RdMas.Checked){
                            sexe = 200;
                        }else{
                            sexe = 310;
                        }
                }

                if(ChkExper.Checked){
                  bonus += 120 ;  
                }

                if(ChkMotiv.Checked){
                  bonus += 60 ;  
                }

                if(ChkDip.Checked){
                      bonus += 40 ;
                }

                chance = int.Parse(TxtChance.Text);
 
                score = note + sexe + bonus - chance;

                switch (CmbAge.SelectedIndex)
                {
                    case -1: score = Convert.ToInt32(score * 0.95); break;
                    case 0: score = Convert.ToInt32(score * 1.05); break;
                    case 1: score = Convert.ToInt32(score * 1.2); break;
                    case 2: score = Convert.ToInt32(score * 1.4); break;
                }

                TxtScore.Text = score.ToString();
                BtnAjout.Enabled = true;
        }

       

     

        

        

        
       

       

        
    }
}
