namespace Projet1
{
    partial class frmAccueil
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
            this.LblAccueil = new System.Windows.Forms.Label();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnApropos = new System.Windows.Forms.Button();
            this.BtnCalculatrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAccueil
            // 
            this.LblAccueil.AutoSize = true;
            this.LblAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccueil.Location = new System.Drawing.Point(33, 29);
            this.LblAccueil.Name = "LblAccueil";
            this.LblAccueil.Size = new System.Drawing.Size(368, 17);
            this.LblAccueil.TabIndex = 0;
            this.LblAccueil.Text = "Cliquer sur le bouton correspondant à votre choix";
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(155, 165);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(106, 29);
            this.BtnQuitter.TabIndex = 3;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnApropos
            // 
            this.BtnApropos.Location = new System.Drawing.Point(155, 113);
            this.BtnApropos.Name = "BtnApropos";
            this.BtnApropos.Size = new System.Drawing.Size(106, 29);
            this.BtnApropos.TabIndex = 4;
            this.BtnApropos.Text = "Apropos";
            this.BtnApropos.UseVisualStyleBackColor = true;
            this.BtnApropos.Click += new System.EventHandler(this.BtnApropos_Click);
            // 
            // BtnCalculatrice
            // 
            this.BtnCalculatrice.Location = new System.Drawing.Point(155, 61);
            this.BtnCalculatrice.Name = "BtnCalculatrice";
            this.BtnCalculatrice.Size = new System.Drawing.Size(106, 29);
            this.BtnCalculatrice.TabIndex = 5;
            this.BtnCalculatrice.Text = "Calculatrice";
            this.BtnCalculatrice.UseVisualStyleBackColor = true;
            this.BtnCalculatrice.Click += new System.EventHandler(this.BtnCalculatrice_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 212);
            this.Controls.Add(this.BtnCalculatrice);
            this.Controls.Add(this.BtnApropos);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.LblAccueil);
            this.Name = "frmAccueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAccueil;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnApropos;
        private System.Windows.Forms.Button BtnCalculatrice;
    }
}