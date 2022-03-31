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
    public partial class FormGame : Form
    {
        List<TextBox> LTxtC = new List<TextBox>();
        List<TextBox> LTxtP = new List<TextBox>();
        int nbJeux = 0; bool animation = false;

        public FormGame()
        {
            InitializeComponent();
            int n1,n2,n3,n4;

            LblNbJeux.Text = nbJeux.ToString();

            Random random = new Random();

            n1 = random.Next(0, 10);
            Txt11.Text = n1.ToString();
            Txt11.ForeColor = Color.White;

            do
                n2 = random.Next(0, 10);
            while (n2 == n1);
            Txt12.Text = n2.ToString();
            Txt12.ForeColor = Color.White;

            do
                n3 = random.Next(0, 10);
            while (n3 == n2||n3==n1);
            Txt13.Text = n3.ToString();
            Txt13.ForeColor = Color.White;

            do
                n4 = random.Next(0, 10);
            while (n4 == n3 || n4 == n2 || n4==n1);
            Txt14.Text = n4.ToString();
            Txt14.ForeColor = Color.White;

            LTxtC.Add(Txt11);
            LTxtC.Add(Txt12);
            LTxtC.Add(Txt13);
            LTxtC.Add(Txt14);
            
            LTxtP.Add(TxtP1);
            LTxtP.Add(TxtP2);
            LTxtP.Add(TxtP3);
            LTxtP.Add(TxtP4);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtC[i].ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtC[i].ForeColor = Color.White;
            }
            
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White; LTxtP[i].Text = "";
            }
            LTxtP[0].Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j, correct = 0;
            for (i = 0; i < 4; i++){

                if (LTxtP[i].Text == LTxtC[i].Text)
                {
                    LTxtP[i].BackColor = Color.Lime;
                    correct++;
                }
                else
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (LTxtP[i].Text == LTxtC[j].Text)
                        {
                            LTxtP[i].BackColor = Color.Yellow;
                            break;
                        }
                    }
                }
            }
            if (correct == 4)
            {
                timer1.Start();
                for (i = 0; i < 4; i++){
                    LTxtC[i].ForeColor = Color.Black;
                }
                button4.Enabled = false;
            }
            else{
                nbJeux++;
                LblNbJeux.Text = (nbJeux + 1).ToString();
                if (nbJeux == 3)
                {
                    GrB1.Enabled = false;
                    for (i = 0; i < 4; i++) {
                        LTxtC[i].ForeColor = Color.Black; 
                    }
                    MessageBox.Show("Vous avez perdu", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, n4;

            Random random = new Random();

            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White;
                LTxtP[i].Text = "";
            }

            LTxtP[0].Focus();
            nbJeux = 0;
            LblNbJeux.Text = nbJeux.ToString();

            n1 = random.Next(0, 10);
            Txt11.Text = n1.ToString();
            Txt11.ForeColor = Color.White;

            do
                n2 = random.Next(0, 10);
            while (n2 == n1);
            Txt12.Text = n2.ToString();
            Txt12.ForeColor = Color.White;

            do
                n3 = random.Next(0, 10);
            while (n3 == n2 || n3 == n1);
            Txt13.Text = n3.ToString();
            Txt13.ForeColor = Color.White;

            do
                n4 = random.Next(0, 10);
            while (n4 == n3 || n4 == n2 || n4 == n1);
            Txt14.Text = n4.ToString();
            Txt14.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation == true)
            {
                for (int i = 0; i < 4; i++) LTxtC[i].BackColor = Color.Yellow;
                animation = false;
            }
            else
            {
                for (int i = 0; i < 4; i++) LTxtC[i].BackColor = Color.Red;
                animation = true;
            }
        }
    }
}
