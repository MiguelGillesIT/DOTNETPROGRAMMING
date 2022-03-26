namespace Projet2
{
    partial class FrmTables
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
            this.LblT = new System.Windows.Forms.Label();
            this.BtnEnreg = new System.Windows.Forms.Button();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnQ = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblSup = new System.Windows.Forms.Label();
            this.LblInf = new System.Windows.Forms.Label();
            this.LblEcart = new System.Windows.Forms.Label();
            this.LblMoy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblT);
            this.groupBox1.Controls.Add(this.BtnEnreg);
            this.groupBox1.Controls.Add(this.TxtN);
            this.groupBox1.Controls.Add(this.LblRes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enregistrement des Notes:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblT
            // 
            this.LblT.AutoSize = true;
            this.LblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblT.Location = new System.Drawing.Point(180, 85);
            this.LblT.Name = "LblT";
            this.LblT.Size = new System.Drawing.Size(71, 20);
            this.LblT.TabIndex = 3;
            this.LblT.Text = "1 | 3 | 5";
            // 
            // BtnEnreg
            // 
            this.BtnEnreg.Location = new System.Drawing.Point(283, 39);
            this.BtnEnreg.Name = "BtnEnreg";
            this.BtnEnreg.Size = new System.Drawing.Size(124, 26);
            this.BtnEnreg.TabIndex = 2;
            this.BtnEnreg.Text = "Enregistrer";
            this.BtnEnreg.UseVisualStyleBackColor = true;
            this.BtnEnreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(153, 39);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(55, 23);
            this.TxtN.TabIndex = 1;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(6, 42);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(141, 13);
            this.LblRes.TabIndex = 1;
            this.LblRes.Text = "Entrez la note de l\'éleve N° :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnQ);
            this.groupBox2.Controls.Add(this.BtnCalc);
            this.groupBox2.Controls.Add(this.LblSup);
            this.groupBox2.Controls.Add(this.LblInf);
            this.groupBox2.Controls.Add(this.LblEcart);
            this.groupBox2.Controls.Add(this.LblMoy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnQ
            // 
            this.BtnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQ.Location = new System.Drawing.Point(321, 100);
            this.BtnQ.Name = "BtnQ";
            this.BtnQ.Size = new System.Drawing.Size(86, 23);
            this.BtnQ.TabIndex = 9;
            this.BtnQ.Text = "Quitter";
            this.BtnQ.UseVisualStyleBackColor = true;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(321, 46);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(86, 23);
            this.BtnCalc.TabIndex = 8;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            // 
            // LblSup
            // 
            this.LblSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSup.ForeColor = System.Drawing.Color.Green;
            this.LblSup.Location = new System.Drawing.Point(197, 129);
            this.LblSup.Name = "LblSup";
            this.LblSup.Size = new System.Drawing.Size(87, 23);
            this.LblSup.TabIndex = 7;
            this.LblSup.Text = "3";
            this.LblSup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInf
            // 
            this.LblInf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInf.ForeColor = System.Drawing.Color.Red;
            this.LblInf.Location = new System.Drawing.Point(197, 94);
            this.LblInf.Name = "LblInf";
            this.LblInf.Size = new System.Drawing.Size(87, 23);
            this.LblInf.TabIndex = 6;
            this.LblInf.Text = "2";
            this.LblInf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEcart
            // 
            this.LblEcart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblEcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEcart.Location = new System.Drawing.Point(197, 62);
            this.LblEcart.Name = "LblEcart";
            this.LblEcart.Size = new System.Drawing.Size(87, 23);
            this.LblEcart.TabIndex = 5;
            this.LblEcart.Text = "10.193454";
            this.LblEcart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMoy
            // 
            this.LblMoy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoy.Location = new System.Drawing.Point(197, 30);
            this.LblMoy.Name = "LblMoy";
            this.LblMoy.Size = new System.Drawing.Size(87, 23);
            this.LblMoy.TabIndex = 4;
            this.LblMoy.Text = "11";
            this.LblMoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMoy.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre de Notes >= 10 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre de Notes < 10 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "L\'écart-type: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Moyenne de la classe : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTables";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnEnreg;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblMoy;
        private System.Windows.Forms.Button BtnQ;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label LblSup;
        private System.Windows.Forms.Label LblInf;
        private System.Windows.Forms.Label LblEcart;
    }
}