namespace Projet4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LstG1 = new System.Windows.Forms.ListBox();
            this.LstD1 = new System.Windows.Forms.ListBox();
            this.BtnGD1 = new System.Windows.Forms.Button();
            this.BtnTGD1 = new System.Windows.Forms.Button();
            this.BtnDG1 = new System.Windows.Forms.Button();
            this.BtnTDG1 = new System.Windows.Forms.Button();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.BtnAjout1 = new System.Windows.Forms.Button();
            this.BtnVider1 = new System.Windows.Forms.Button();
            this.BtnSupp1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(25, 21);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(671, 495);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSupp1);
            this.tabPage1.Controls.Add(this.BtnVider1);
            this.tabPage1.Controls.Add(this.BtnAjout1);
            this.tabPage1.Controls.Add(this.TxtN);
            this.tabPage1.Controls.Add(this.BtnTDG1);
            this.tabPage1.Controls.Add(this.BtnDG1);
            this.tabPage1.Controls.Add(this.BtnTGD1);
            this.tabPage1.Controls.Add(this.BtnGD1);
            this.tabPage1.Controls.Add(this.LstD1);
            this.tabPage1.Controls.Add(this.LstG1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(663, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1 er cas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(378, 265);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "3 ème cas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(378, 265);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "2 ème cas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(378, 265);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4 ème cas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LstG1
            // 
            this.LstG1.FormattingEnabled = true;
            this.LstG1.Location = new System.Drawing.Point(69, 49);
            this.LstG1.Name = "LstG1";
            this.LstG1.Size = new System.Drawing.Size(218, 251);
            this.LstG1.TabIndex = 0;
            this.LstG1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LstD1
            // 
            this.LstD1.FormattingEnabled = true;
            this.LstD1.Location = new System.Drawing.Point(383, 49);
            this.LstD1.Name = "LstD1";
            this.LstD1.Size = new System.Drawing.Size(218, 251);
            this.LstD1.TabIndex = 1;
            // 
            // BtnGD1
            // 
            this.BtnGD1.Location = new System.Drawing.Point(308, 65);
            this.BtnGD1.Name = "BtnGD1";
            this.BtnGD1.Size = new System.Drawing.Size(56, 42);
            this.BtnGD1.TabIndex = 2;
            this.BtnGD1.Text = ">";
            this.BtnGD1.UseVisualStyleBackColor = true;
            this.BtnGD1.Click += new System.EventHandler(this.BtnGD1_Click);
            // 
            // BtnTGD1
            // 
            this.BtnTGD1.Location = new System.Drawing.Point(308, 127);
            this.BtnTGD1.Name = "BtnTGD1";
            this.BtnTGD1.Size = new System.Drawing.Size(56, 42);
            this.BtnTGD1.TabIndex = 3;
            this.BtnTGD1.Text = ">>";
            this.BtnTGD1.UseVisualStyleBackColor = true;
            this.BtnTGD1.Click += new System.EventHandler(this.BtnTGD1_Click);
            // 
            // BtnDG1
            // 
            this.BtnDG1.Location = new System.Drawing.Point(308, 191);
            this.BtnDG1.Name = "BtnDG1";
            this.BtnDG1.Size = new System.Drawing.Size(56, 42);
            this.BtnDG1.TabIndex = 4;
            this.BtnDG1.Text = "<";
            this.BtnDG1.UseVisualStyleBackColor = true;
            this.BtnDG1.Click += new System.EventHandler(this.BtnDG1_Click);
            // 
            // BtnTDG1
            // 
            this.BtnTDG1.Location = new System.Drawing.Point(308, 249);
            this.BtnTDG1.Name = "BtnTDG1";
            this.BtnTDG1.Size = new System.Drawing.Size(56, 42);
            this.BtnTDG1.TabIndex = 5;
            this.BtnTDG1.Text = "<<";
            this.BtnTDG1.UseVisualStyleBackColor = true;
            this.BtnTDG1.Click += new System.EventHandler(this.BtnTDG1_Click);
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(92, 326);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(85, 20);
            this.TxtN.TabIndex = 6;
            // 
            // BtnAjout1
            // 
            this.BtnAjout1.Location = new System.Drawing.Point(192, 324);
            this.BtnAjout1.Name = "BtnAjout1";
            this.BtnAjout1.Size = new System.Drawing.Size(83, 23);
            this.BtnAjout1.TabIndex = 7;
            this.BtnAjout1.Text = "Ajouter";
            this.BtnAjout1.UseVisualStyleBackColor = true;
            this.BtnAjout1.Click += new System.EventHandler(this.BtnAjout1_Click);
            // 
            // BtnVider1
            // 
            this.BtnVider1.Location = new System.Drawing.Point(192, 370);
            this.BtnVider1.Name = "BtnVider1";
            this.BtnVider1.Size = new System.Drawing.Size(83, 23);
            this.BtnVider1.TabIndex = 8;
            this.BtnVider1.Text = "Vider";
            this.BtnVider1.UseVisualStyleBackColor = true;
            this.BtnVider1.Click += new System.EventHandler(this.BtnVider1_Click);
            // 
            // BtnSupp1
            // 
            this.BtnSupp1.Location = new System.Drawing.Point(94, 370);
            this.BtnSupp1.Name = "BtnSupp1";
            this.BtnSupp1.Size = new System.Drawing.Size(83, 23);
            this.BtnSupp1.TabIndex = 9;
            this.BtnSupp1.Text = "Supprimer";
            this.BtnSupp1.UseVisualStyleBackColor = true;
            this.BtnSupp1.Click += new System.EventHandler(this.BtnSupp1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 528);
            this.Controls.Add(this.tabControl);
            this.Name = "Form2";
            this.Text = "Listes";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox LstD1;
        private System.Windows.Forms.ListBox LstG1;
        private System.Windows.Forms.Button BtnTDG1;
        private System.Windows.Forms.Button BtnDG1;
        private System.Windows.Forms.Button BtnTGD1;
        private System.Windows.Forms.Button BtnGD1;
        private System.Windows.Forms.Button BtnSupp1;
        private System.Windows.Forms.Button BtnVider1;
        private System.Windows.Forms.Button BtnAjout1;
        private System.Windows.Forms.TextBox TxtN;
    }
}