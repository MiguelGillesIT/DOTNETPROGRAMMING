using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAjout1_Click(object sender, EventArgs e)
        {
            if (TxtN.Text.Trim() != "")
            {
                LstG1.Items.Add(TxtN.Text);
                TxtN.Text = "";
                TxtN.Focus();

            }
            else
            {
                MessageBox.Show("Il faut saisir une valeur");
            }


        }

        private void BtnSupp1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
            {
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
            }
            else if (LstD1.SelectedIndex != -1)
            {
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Aucun élément n'est sélectionné");
            }
        }

        private void BtnVider1_Click(object sender, EventArgs e)
        {
            LstG1.Items.Clear();
            LstD1.Items.Clear();
        }

        private void BtnGD1_Click(object sender, EventArgs e)
        {
            if (LstG1.SelectedIndex != -1)
            {
                String item = LstG1.SelectedItem.ToString();
                LstG1.Items.RemoveAt(LstG1.SelectedIndex);
                LstD1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Aucun élément n'est sélectionné");
            }
        }

        private void BtnDG1_Click(object sender, EventArgs e)
        {
            if (LstD1.SelectedIndex != -1)
            {
                String item = LstD1.SelectedItem.ToString();
                LstD1.Items.RemoveAt(LstD1.SelectedIndex);
                LstG1.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Aucun élément n'est sélectionné");
            }
        }

        private void BtnTGD1_Click(object sender, EventArgs e)
        {
            String item;
            for (int i = 0; i < LstG1.Items.Count; i++)
            {
                item = LstG1.Items[i].ToString();
                LstD1.Items.Add(item);
            }
            LstG1.Items.Clear();
        }

        private void BtnTDG1_Click(object sender, EventArgs e)
        {
            String item;
            for (int i = 0; i < LstD1.Items.Count; i++)
            {
                item = LstD1.Items[i].ToString();
                LstG1.Items.Add(item);
            }
            LstD1.Items.Clear();
        }

        

        private void BtnAjout2_Click(object sender, EventArgs e)
        {
            if (TxtN2.Text.Trim() != "")
            {
                LstG2.Items.Add(TxtN2.Text);
                TxtN2.Text = "";
                TxtN2.Focus();

            }
            else
            {
                MessageBox.Show("Il faut saisir une valeur");
            }
        }

        private void BtnSupp2_Click(object sender, EventArgs e)
        {
            List<Object> coll1 = new List<Object>();
            List<Object> coll2 = new List<Object>();
            foreach (Object x in LstG2.SelectedItems)
            {
                coll1.Add(x);
            }
            foreach (Object y in coll1)
            {
                LstG2.Items.Remove(y);
            }

            foreach (Object x in LstD2.SelectedItems)
            {
                coll2.Add(x);
            }

            foreach (Object y in coll2)
            {
                LstD2.Items.Remove(y);
            }

        }

        private void BtnGD2_Click(object sender, EventArgs e)
        {
            List<Object> coll = new List<Object>();
            foreach (Object x in LstG2.SelectedItems)
            {
                coll.Add(x);
                LstD2.Items.Add(x);
            }
            foreach (Object y in coll)
                LstG2.Items.Remove(y);
        }

        private void BtnDG2_Click(object sender, EventArgs e)
        {
            List<Object> coll = new List<Object>();
            foreach (Object x in LstD2.SelectedItems)
            {
                coll.Add(x);
                LstG2.Items.Add(x);
            }
            foreach (Object y in coll)
            {
                LstD2.Items.Remove(y);
            }
        }

        private void BtnTGD2_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstG2.Items)
            {
                LstD2.Items.Add(x);
            }
            LstG2.Items.Clear();

        }

        private void BtnTDG2_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstD2.Items)
            {
                LstG2.Items.Add(x);
            }
            LstD2.Items.Clear();

        }

        private void BtnVider2_Click(object sender, EventArgs e)
        {
            LstG2.Items.Clear();
            LstD2.Items.Clear();
        }

       

        private void BtnAjout3_Click(object sender, EventArgs e)
        {
            if (TxtN3.Text.Trim() != "")
            {
                LstG3.Items.Add(TxtN3.Text);
                TxtN3.Text = "";
                TxtN3.Focus();

            }
            else
            {
                MessageBox.Show("Il faut saisir une valeur");
            }
        }

        private void BtnVider3_Click(object sender, EventArgs e)
        {
            LstG3.Items.Clear();
            LstD3.Items.Clear();
        }

        private void BtnGD3_Click(object sender, EventArgs e)
        {
            List<Object> coll = new List<Object>();
            foreach (Object x in LstG3.CheckedItems)
            {
                coll.Add(x);
                LstD3.Items.Add(x);
            }
            foreach (Object y in coll)
            {
                LstG3.Items.Remove(y);
            }
        }

        private void BtnTGD3_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstG3.Items)
            {
                LstD3.Items.Add(x);
            }
            LstG3.Items.Clear();
        }

        private void BtnDG3_Click(object sender, EventArgs e)
        {
            List<Object> coll = new List<Object>();
            foreach (Object x in LstD3.CheckedItems)
            {
                coll.Add(x);
                LstG3.Items.Add(x);
            }
            foreach (Object y in coll)
            {
                LstD3.Items.Remove(y);
            }
        }

        private void BtnTDG3_Click(object sender, EventArgs e)
        {
            foreach (Object x in LstD3.Items)
            {
                LstG3.Items.Add(x);
            }
            LstD3.Items.Clear();
        }

        private void BtnSupp3_Click(object sender, EventArgs e)
        {
            List<Object> coll1 = new List<Object>();
            List<Object> coll2 = new List<Object>();

            foreach (Object x in LstG3.CheckedItems)
            {
                coll1.Add(x);
            }
            foreach (Object y in coll1)
            {
                LstG3.Items.Remove(y);
            }

            foreach (Object x in LstD3.CheckedItems)
            {
                coll2.Add(x);
            }

            foreach (Object y in coll2)
            {
                LstD3.Items.Remove(y);
            }
        }

        private void LstG4_DragDrop(object sender, DragEventArgs e)
        {
            LstG4.Items.Add(LstD4.SelectedItem);
            LstD4.Items.Remove(LstD4.SelectedItem);
        }

        private void LstD4_DragDrop(object sender, DragEventArgs e)
        {
            LstD4.Items.Add(LstG4.SelectedItem);
            LstG4.Items.Remove(LstG4.SelectedItem);

        }

        private void LstG4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstD4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LstG4_MouseDown(object sender, MouseEventArgs e) {
            if (LstG4.SelectedIndex != -1){
                LstG4.DoDragDrop(LstG4.SelectedItem, DragDropEffects.Move);
            }
        }

        private void LstD4_MouseDown(object sender, MouseEventArgs e)
        {
            if (LstD4.SelectedIndex != -1)
            {
                LstD4.DoDragDrop(LstD4.SelectedItem, DragDropEffects.Move);
            }
        }

        private void BtnAjout4_Click(object sender, EventArgs e)
        {
            if (TxtN4.Text.Trim() != "")
            {
                LstG4.Items.Add(TxtN4.Text);
                TxtN4.Text = "";
                TxtN4.Focus();

            }
            else
            {
                MessageBox.Show("Il faut saisir une valeur");
            }
        }

        private void BtnVider4_Click(object sender, EventArgs e)
        {
            LstG4.Items.Clear();
            LstD4.Items.Clear();
        }

        private void BtnSupp4_Click(object sender, EventArgs e)
        {
            List<Object> coll1 = new List<Object>();
            List<Object> coll2 = new List<Object>();
            foreach (Object x in LstG4.SelectedItems)
            {
                coll1.Add(x);
            }
            foreach (Object y in coll1)
            {
                LstG4.Items.Remove(y);
            }

            foreach (Object x in LstD4.SelectedItems)
            {
                coll2.Add(x);
            }

            foreach (Object y in coll2)
            {
                LstD4.Items.Remove(y);
            }
        }

     }
}
