namespace Projet2
{
    partial class FrmMenu
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
            this.BtnFactoriel = new System.Windows.Forms.Button();
            this.BtnTab = new System.Windows.Forms.Button();
            this.BtnJouer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFactoriel
            // 
            this.BtnFactoriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFactoriel.Location = new System.Drawing.Point(107, 42);
            this.BtnFactoriel.Name = "BtnFactoriel";
            this.BtnFactoriel.Size = new System.Drawing.Size(117, 39);
            this.BtnFactoriel.TabIndex = 0;
            this.BtnFactoriel.Text = "Calcul Factoriel";
            this.BtnFactoriel.UseVisualStyleBackColor = true;
            this.BtnFactoriel.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTab
            // 
            this.BtnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTab.Location = new System.Drawing.Point(107, 128);
            this.BtnTab.Name = "BtnTab";
            this.BtnTab.Size = new System.Drawing.Size(117, 39);
            this.BtnTab.TabIndex = 1;
            this.BtnTab.Text = "Les Tableaux";
            this.BtnTab.UseVisualStyleBackColor = true;
            this.BtnTab.Click += new System.EventHandler(this.BtnTab_Click);
            // 
            // BtnJouer
            // 
            this.BtnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJouer.Location = new System.Drawing.Point(107, 214);
            this.BtnJouer.Name = "BtnJouer";
            this.BtnJouer.Size = new System.Drawing.Size(117, 39);
            this.BtnJouer.TabIndex = 2;
            this.BtnJouer.Text = "Jouer";
            this.BtnJouer.UseVisualStyleBackColor = true;
            this.BtnJouer.Click += new System.EventHandler(this.BtnJouer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Location = new System.Drawing.Point(107, 300);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(117, 39);
            this.BtnQuitter.TabIndex = 3;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 368);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnJouer);
            this.Controls.Add(this.BtnTab);
            this.Controls.Add(this.BtnFactoriel);
            this.Name = "FrmMenu";
            this.Text = "TP 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFactoriel;
        private System.Windows.Forms.Button BtnTab;
        private System.Windows.Forms.Button BtnJouer;
        private System.Windows.Forms.Button BtnQuitter;
    }
}

