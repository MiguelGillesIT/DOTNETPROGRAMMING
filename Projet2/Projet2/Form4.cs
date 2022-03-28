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

            Random random = new Random();

            n1 = random.Next(0, 10);
            Txt11.Text = n1.ToString();

            do
                n2 = random.Next(0, 10);
            while (n2 == n1);
            Txt12.Text = n2.ToString();

            do
                n3 = random.Next(0, 10);
            while (n3 == n2||n3==n1);
            Txt13.Text = n3.ToString();

            do
                n4 = random.Next(0, 10);
            while (n4 == n3 || n4 == n2 || n4==n1);
            Txt14.Text = n4.ToString();

            LTxtC.Add(Txt11);
            LTxtC.Add(Txt13);
            LTxtC.Add(Txt14);
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White;
                LTxtP[i].Text = "";
            }
            LTxtP[0].Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j, correct = 0;
            for (i = 0; i < 4; i++)
            {
                if (LTxtP[i].Text == LTxtC[i].Text)
                {
                }
                else
                    LTxtP[i].BackColor = Color.Lime;
                correct++;
                for (j = 0; j < 4; j++)
                {
                    if (LTxtP[i].Text == LTxtC[j].Text)
                    {
                        LTxtP[i].BackColor = Color.Yellow;
                        break;
                    }
                }
            }
            if (correct == 4)
            {
            }
            else
            {
                timer1.Start();
            }

            for (i = 0; i < 4; i++)
                LTxtC[i].ForeColor = Color.Black;
            {
                nbJeux++;
                LblNbJeux.Text = (nbJeux + 1).ToString();
                if (nbJeux == 3)
                {
                    GrB1.Enabled = false;
                    for (i = 0; i < 4; i++)
                        LTxtC[i].ForeColor = Color.Black;
                    MessageBox.Show("Vous avez perdu", "Game Over",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
