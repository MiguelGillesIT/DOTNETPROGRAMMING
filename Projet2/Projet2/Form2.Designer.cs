namespace Projet2
{
    partial class FrmFactoriel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblFactoriel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblFactoriel);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LblFactoriel
            // 
            this.LblFactoriel.AutoSize = true;
            this.LblFactoriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactoriel.Location = new System.Drawing.Point(114, 29);
            this.LblFactoriel.Name = "LblFactoriel";
            this.LblFactoriel.Size = new System.Drawing.Size(95, 25);
            this.LblFactoriel.TabIndex = 0;
            this.LblFactoriel.Text = "Factoriel";
            this.LblFactoriel.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblRes);
            this.groupBox2.Controls.Add(this.TxtN);
            this.groupBox2.Controls.Add(this.BtnCalc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // LblRes
            // 
            this.LblRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(9, 99);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(302, 27);
            this.LblRes.TabIndex = 3;
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRes.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(9, 56);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(200, 20);
            this.TxtN.TabIndex = 2;
            this.TxtN.TextChanged += new System.EventHandler(this.TxtN_TextChanged);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(236, 39);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 1;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donnez un entier positif: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnQuitter);
            this.groupBox3.Controls.Add(this.BtnBack);
            this.groupBox3.Location = new System.Drawing.Point(43, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Location = new System.Drawing.Point(207, 43);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitter.TabIndex = 1;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(47, 43);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmFactoriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 443);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFactoriel";
            this.Text = "Calcul Factoriel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblFactoriel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnBack;
    }
}