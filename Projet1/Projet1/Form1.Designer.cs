namespace Projet1
{
    partial class FrmCalculatrice
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtV2 = new System.Windows.Forms.TextBox();
            this.TxtV1 = new System.Windows.Forms.TextBox();
            this.LblV1 = new System.Windows.Forms.Label();
            this.LblV2 = new System.Windows.Forms.Label();
            this.GrBCmd = new System.Windows.Forms.GroupBox();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnMoins = new System.Windows.Forms.Button();
            this.BtnFois = new System.Windows.Forms.Button();
            this.BtnSur = new System.Windows.Forms.Button();
            this.BtnMod = new System.Windows.Forms.Button();
            this.LblResultat = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnAccueil = new System.Windows.Forms.Button();
            this.GrBCmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtV2
            // 
            this.TxtV2.Location = new System.Drawing.Point(172, 105);
            this.TxtV2.Name = "TxtV2";
            this.TxtV2.Size = new System.Drawing.Size(143, 20);
            this.TxtV2.TabIndex = 1;
            this.TxtV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtV1
            // 
            this.TxtV1.Location = new System.Drawing.Point(172, 43);
            this.TxtV1.Name = "TxtV1";
            this.TxtV1.Size = new System.Drawing.Size(143, 20);
            this.TxtV1.TabIndex = 2;
            this.TxtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblV1
            // 
            this.LblV1.AutoSize = true;
            this.LblV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblV1.Location = new System.Drawing.Point(43, 44);
            this.LblV1.Name = "LblV1";
            this.LblV1.Size = new System.Drawing.Size(74, 17);
            this.LblV1.TabIndex = 3;
            this.LblV1.Text = "Valeur 1:";
            this.LblV1.Click += new System.EventHandler(this.LblV1_Click);
            // 
            // LblV2
            // 
            this.LblV2.AutoSize = true;
            this.LblV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblV2.Location = new System.Drawing.Point(43, 106);
            this.LblV2.Name = "LblV2";
            this.LblV2.Size = new System.Drawing.Size(74, 17);
            this.LblV2.TabIndex = 4;
            this.LblV2.Text = "Valeur 2:";
            this.LblV2.Click += new System.EventHandler(this.LblV2_Click);
            // 
            // GrBCmd
            // 
            this.GrBCmd.Controls.Add(this.BtnMod);
            this.GrBCmd.Controls.Add(this.BtnSur);
            this.GrBCmd.Controls.Add(this.BtnFois);
            this.GrBCmd.Controls.Add(this.BtnMoins);
            this.GrBCmd.Controls.Add(this.BtnPlus);
            this.GrBCmd.Location = new System.Drawing.Point(28, 159);
            this.GrBCmd.Name = "GrBCmd";
            this.GrBCmd.Size = new System.Drawing.Size(314, 81);
            this.GrBCmd.TabIndex = 5;
            this.GrBCmd.TabStop = false;
            this.GrBCmd.Text = "Commandes";
            // 
            // BtnPlus
            // 
            this.BtnPlus.Location = new System.Drawing.Point(18, 29);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(39, 37);
            this.BtnPlus.TabIndex = 6;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMoins
            // 
            this.BtnMoins.Location = new System.Drawing.Point(78, 29);
            this.BtnMoins.Name = "BtnMoins";
            this.BtnMoins.Size = new System.Drawing.Size(39, 37);
            this.BtnMoins.TabIndex = 7;
            this.BtnMoins.Text = "-";
            this.BtnMoins.UseVisualStyleBackColor = true;
            this.BtnMoins.Click += new System.EventHandler(this.BtnMoins_Click);
            // 
            // BtnFois
            // 
            this.BtnFois.Location = new System.Drawing.Point(135, 29);
            this.BtnFois.Name = "BtnFois";
            this.BtnFois.Size = new System.Drawing.Size(39, 37);
            this.BtnFois.TabIndex = 8;
            this.BtnFois.Text = "*";
            this.BtnFois.UseVisualStyleBackColor = true;
            this.BtnFois.Click += new System.EventHandler(this.BtnFois_Click);
            // 
            // BtnSur
            // 
            this.BtnSur.Location = new System.Drawing.Point(196, 29);
            this.BtnSur.Name = "BtnSur";
            this.BtnSur.Size = new System.Drawing.Size(39, 37);
            this.BtnSur.TabIndex = 9;
            this.BtnSur.Text = "/";
            this.BtnSur.UseVisualStyleBackColor = true;
            this.BtnSur.Click += new System.EventHandler(this.BtnSur_Click);
            // 
            // BtnMod
            // 
            this.BtnMod.Location = new System.Drawing.Point(258, 29);
            this.BtnMod.Name = "BtnMod";
            this.BtnMod.Size = new System.Drawing.Size(39, 37);
            this.BtnMod.TabIndex = 10;
            this.BtnMod.Text = "%";
            this.BtnMod.UseVisualStyleBackColor = true;
            this.BtnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // LblResultat
            // 
            this.LblResultat.AutoSize = true;
            this.LblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultat.Location = new System.Drawing.Point(43, 273);
            this.LblResultat.Name = "LblResultat";
            this.LblResultat.Size = new System.Drawing.Size(78, 17);
            this.LblResultat.TabIndex = 6;
            this.LblResultat.Text = "Resultat: ";
            // 
            // LblRes
            // 
            this.LblRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRes.Location = new System.Drawing.Point(169, 266);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(146, 27);
            this.LblRes.TabIndex = 7;
            this.LblRes.Text = "Resultat: ";
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.Yellow;
            this.BtnCE.Location = new System.Drawing.Point(46, 321);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(75, 23);
            this.BtnCE.TabIndex = 8;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.Color.Red;
            this.BtnQuitter.Location = new System.Drawing.Point(277, 321);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 9;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAccueil
            // 
            this.BtnAccueil.BackColor = System.Drawing.Color.Blue;
            this.BtnAccueil.Location = new System.Drawing.Point(163, 321);
            this.BtnAccueil.Name = "BtnAccueil";
            this.BtnAccueil.Size = new System.Drawing.Size(75, 23);
            this.BtnAccueil.TabIndex = 10;
            this.BtnAccueil.Text = "Accueil";
            this.BtnAccueil.UseVisualStyleBackColor = false;
            // 
            // FrmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 369);
            this.Controls.Add(this.BtnAccueil);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblResultat);
            this.Controls.Add(this.GrBCmd);
            this.Controls.Add(this.LblV2);
            this.Controls.Add(this.LblV1);
            this.Controls.Add(this.TxtV1);
            this.Controls.Add(this.TxtV2);
            this.Name = "FrmCalculatrice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.FrmCalculatrice_Load);
            this.GrBCmd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtV2;
        private System.Windows.Forms.TextBox TxtV1;
        private System.Windows.Forms.Label LblV1;
        private System.Windows.Forms.Label LblV2;
        private System.Windows.Forms.GroupBox GrBCmd;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnMod;
        private System.Windows.Forms.Button BtnSur;
        private System.Windows.Forms.Button BtnFois;
        private System.Windows.Forms.Button BtnMoins;
        private System.Windows.Forms.Label LblResultat;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnAccueil;

    }
}

