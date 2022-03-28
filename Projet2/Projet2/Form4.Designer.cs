namespace Projet2
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.GrB1 = new System.Windows.Forms.GroupBox();
            this.LblNbJeux = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt14 = new System.Windows.Forms.TextBox();
            this.Txt13 = new System.Windows.Forms.TextBox();
            this.Txt12 = new System.Windows.Forms.TextBox();
            this.Txt11 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtP4 = new System.Windows.Forms.TextBox();
            this.TxtP3 = new System.Windows.Forms.TextBox();
            this.TxtP2 = new System.Windows.Forms.TextBox();
            this.TxtP1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GrB1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Caché";
            // 
            // GrB1
            // 
            this.GrB1.Controls.Add(this.LblNbJeux);
            this.GrB1.Controls.Add(this.button3);
            this.GrB1.Controls.Add(this.button2);
            this.GrB1.Controls.Add(this.groupBox2);
            this.GrB1.Controls.Add(this.button1);
            this.GrB1.Location = new System.Drawing.Point(26, 104);
            this.GrB1.Name = "GrB1";
            this.GrB1.Size = new System.Drawing.Size(594, 164);
            this.GrB1.TabIndex = 1;
            this.GrB1.TabStop = false;
            // 
            // LblNbJeux
            // 
            this.LblNbJeux.AutoSize = true;
            this.LblNbJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNbJeux.Location = new System.Drawing.Point(275, 130);
            this.LblNbJeux.Name = "LblNbJeux";
            this.LblNbJeux.Size = new System.Drawing.Size(19, 20);
            this.LblNbJeux.TabIndex = 4;
            this.LblNbJeux.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cacher";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Afficher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt14);
            this.groupBox2.Controls.Add(this.Txt13);
            this.groupBox2.Controls.Add(this.Txt12);
            this.groupBox2.Controls.Add(this.Txt11);
            this.groupBox2.Controls.Add(this.Txt1);
            this.groupBox2.Location = new System.Drawing.Point(129, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numéro à deviner";
            // 
            // Txt14
            // 
            this.Txt14.Location = new System.Drawing.Point(234, 38);
            this.Txt14.Name = "Txt14";
            this.Txt14.Size = new System.Drawing.Size(47, 20);
            this.Txt14.TabIndex = 7;
            // 
            // Txt13
            // 
            this.Txt13.Location = new System.Drawing.Point(167, 38);
            this.Txt13.Name = "Txt13";
            this.Txt13.Size = new System.Drawing.Size(47, 20);
            this.Txt13.TabIndex = 6;
            // 
            // Txt12
            // 
            this.Txt12.Location = new System.Drawing.Point(96, 36);
            this.Txt12.Name = "Txt12";
            this.Txt12.Size = new System.Drawing.Size(47, 20);
            this.Txt12.TabIndex = 5;
            // 
            // Txt11
            // 
            this.Txt11.Location = new System.Drawing.Point(29, 36);
            this.Txt11.Name = "Txt11";
            this.Txt11.Size = new System.Drawing.Size(47, 20);
            this.Txt11.TabIndex = 4;
            // 
            // Txt1
            // 
            this.Txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.Location = new System.Drawing.Point(29, 28);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(0, 0);
            this.Txt1.TabIndex = 0;
            this.Txt1.Text = "0";
            this.Txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Txt1.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nouvelle Partie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtP4);
            this.groupBox4.Controls.Add(this.TxtP3);
            this.groupBox4.Controls.Add(this.TxtP2);
            this.groupBox4.Controls.Add(this.TxtP1);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(155, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 81);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Votre proposition";
            // 
            // TxtP4
            // 
            this.TxtP4.Location = new System.Drawing.Point(234, 39);
            this.TxtP4.Name = "TxtP4";
            this.TxtP4.Size = new System.Drawing.Size(47, 20);
            this.TxtP4.TabIndex = 10;
            // 
            // TxtP3
            // 
            this.TxtP3.Location = new System.Drawing.Point(167, 38);
            this.TxtP3.Name = "TxtP3";
            this.TxtP3.Size = new System.Drawing.Size(47, 20);
            this.TxtP3.TabIndex = 9;
            // 
            // TxtP2
            // 
            this.TxtP2.Location = new System.Drawing.Point(96, 38);
            this.TxtP2.Name = "TxtP2";
            this.TxtP2.Size = new System.Drawing.Size(47, 20);
            this.TxtP2.TabIndex = 8;
            // 
            // TxtP1
            // 
            this.TxtP1.Location = new System.Drawing.Point(29, 38);
            this.TxtP1.Name = "TxtP1";
            this.TxtP1.Size = new System.Drawing.Size(47, 20);
            this.TxtP1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(333, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Vérifier";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 42);
            this.button5.TabIndex = 4;
            this.button5.Text = "Rejouer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(294, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 42);
            this.button6.TabIndex = 5;
            this.button6.Text = "Quitter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 439);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.GrB1);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "Jeux";
            this.GrB1.ResumeLayout(false);
            this.GrB1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrB1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label LblNbJeux;
        private System.Windows.Forms.TextBox Txt14;
        private System.Windows.Forms.TextBox Txt13;
        private System.Windows.Forms.TextBox Txt12;
        private System.Windows.Forms.TextBox Txt11;
        private System.Windows.Forms.TextBox TxtP4;
        private System.Windows.Forms.TextBox TxtP3;
        private System.Windows.Forms.TextBox TxtP2;
        private System.Windows.Forms.TextBox TxtP1;
        private System.Windows.Forms.Timer timer1;
    }
}