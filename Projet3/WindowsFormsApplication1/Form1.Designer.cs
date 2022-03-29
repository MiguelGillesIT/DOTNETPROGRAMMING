namespace WindowsFormsApplication1
{
    partial class CalculForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblHeure = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxtPrenom = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.TextBox();
            this.TxtCin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtTech = new System.Windows.Forms.TextBox();
            this.TxtLang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RdFem = new System.Windows.Forms.RadioButton();
            this.RdMas = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChkDip = new System.Windows.Forms.CheckBox();
            this.ChkMotiv = new System.Windows.Forms.CheckBox();
            this.ChkExper = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtChance = new System.Windows.Forms.TextBox();
            this.BtnChance = new System.Windows.Forms.Button();
            this.CmbAge = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnInit = new System.Windows.Forms.Button();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtScore = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lst1 = new System.Windows.Forms.ListBox();
            this.Lst2 = new System.Windows.Forms.ListBox();
            this.Lst3 = new System.Windows.Forms.ListBox();
            this.Lst4 = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcul de Score";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblHeure);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Location = new System.Drawing.Point(395, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // LblHeure
            // 
            this.LblHeure.AutoSize = true;
            this.LblHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeure.Location = new System.Drawing.Point(267, 26);
            this.LblHeure.Name = "LblHeure";
            this.LblHeure.Size = new System.Drawing.Size(61, 20);
            this.LblHeure.TabIndex = 1;
            this.LblHeure.Text = "Heure :";
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(38, 26);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(56, 20);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtNom);
            this.groupBox2.Controls.Add(this.TxtPrenom);
            this.groupBox2.Controls.Add(this.TxtTel);
            this.groupBox2.Controls.Add(this.TxtCin);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(70, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations";
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(522, 25);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(229, 23);
            this.TxtNom.TabIndex = 6;
            // 
            // TxtPrenom
            // 
            this.TxtPrenom.Location = new System.Drawing.Point(522, 61);
            this.TxtPrenom.Name = "TxtPrenom";
            this.TxtPrenom.Size = new System.Drawing.Size(229, 23);
            this.TxtPrenom.TabIndex = 7;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(121, 64);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(229, 23);
            this.TxtTel.TabIndex = 5;
            // 
            // TxtCin
            // 
            this.TxtCin.Location = new System.Drawing.Point(121, 28);
            this.TxtCin.MaxLength = 8;
            this.TxtCin.Name = "TxtCin";
            this.TxtCin.Size = new System.Drawing.Size(229, 23);
            this.TxtCin.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "CIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tél";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Prénom";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtTech);
            this.groupBox3.Controls.Add(this.TxtLang);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(70, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notes";
            // 
            // TxtTech
            // 
            this.TxtTech.Location = new System.Drawing.Point(118, 63);
            this.TxtTech.Name = "TxtTech";
            this.TxtTech.Size = new System.Drawing.Size(67, 23);
            this.TxtTech.TabIndex = 3;
            this.TxtTech.Text = "0";
            // 
            // TxtLang
            // 
            this.TxtLang.Location = new System.Drawing.Point(118, 29);
            this.TxtLang.Name = "TxtLang";
            this.TxtLang.Size = new System.Drawing.Size(67, 23);
            this.TxtLang.TabIndex = 2;
            this.TxtLang.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Technique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Langue";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RdFem);
            this.groupBox4.Controls.Add(this.RdMas);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(305, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexe";
            // 
            // RdFem
            // 
            this.RdFem.AutoSize = true;
            this.RdFem.Location = new System.Drawing.Point(45, 62);
            this.RdFem.Name = "RdFem";
            this.RdFem.Size = new System.Drawing.Size(75, 21);
            this.RdFem.TabIndex = 3;
            this.RdFem.TabStop = true;
            this.RdFem.Text = "Féminin";
            this.RdFem.UseVisualStyleBackColor = true;
            // 
            // RdMas
            // 
            this.RdMas.AutoSize = true;
            this.RdMas.Location = new System.Drawing.Point(45, 32);
            this.RdMas.Name = "RdMas";
            this.RdMas.Size = new System.Drawing.Size(81, 21);
            this.RdMas.TabIndex = 2;
            this.RdMas.TabStop = true;
            this.RdMas.Text = "Masculin";
            this.RdMas.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChkDip);
            this.groupBox5.Controls.Add(this.ChkMotiv);
            this.groupBox5.Controls.Add(this.ChkExper);
            this.groupBox5.Location = new System.Drawing.Point(70, 365);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(788, 83);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bonus";
            // 
            // ChkDip
            // 
            this.ChkDip.AutoSize = true;
            this.ChkDip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDip.Location = new System.Drawing.Point(580, 44);
            this.ChkDip.Name = "ChkDip";
            this.ChkDip.Size = new System.Drawing.Size(85, 21);
            this.ChkDip.TabIndex = 2;
            this.ChkDip.Text = "Diplomes";
            this.ChkDip.UseVisualStyleBackColor = true;
            // 
            // ChkMotiv
            // 
            this.ChkMotiv.AutoSize = true;
            this.ChkMotiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMotiv.Location = new System.Drawing.Point(347, 44);
            this.ChkMotiv.Name = "ChkMotiv";
            this.ChkMotiv.Size = new System.Drawing.Size(98, 21);
            this.ChkMotiv.TabIndex = 1;
            this.ChkMotiv.Text = "Motivations";
            this.ChkMotiv.UseVisualStyleBackColor = true;
            // 
            // ChkExper
            // 
            this.ChkExper.AutoSize = true;
            this.ChkExper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkExper.Location = new System.Drawing.Point(83, 44);
            this.ChkExper.Name = "ChkExper";
            this.ChkExper.Size = new System.Drawing.Size(198, 21);
            this.ChkExper.TabIndex = 0;
            this.ChkExper.Text = "Expérience Professionnelle";
            this.ChkExper.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Valeur de Chance";
            // 
            // TxtChance
            // 
            this.TxtChance.Location = new System.Drawing.Point(656, 309);
            this.TxtChance.Name = "TxtChance";
            this.TxtChance.ReadOnly = true;
            this.TxtChance.Size = new System.Drawing.Size(128, 23);
            this.TxtChance.TabIndex = 8;
            this.TxtChance.Text = "0";
            // 
            // BtnChance
            // 
            this.BtnChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChance.Location = new System.Drawing.Point(808, 309);
            this.BtnChance.Name = "BtnChance";
            this.BtnChance.Size = new System.Drawing.Size(88, 23);
            this.BtnChance.TabIndex = 9;
            this.BtnChance.Text = "Générer";
            this.BtnChance.UseVisualStyleBackColor = true;
            this.BtnChance.Click += new System.EventHandler(this.BtnChance_Click);
            // 
            // CmbAge
            // 
            this.CmbAge.FormattingEnabled = true;
            this.CmbAge.Items.AddRange(new object[] {
            "20-30",
            "30-40",
            "40 et plus"});
            this.CmbAge.Location = new System.Drawing.Point(656, 254);
            this.CmbAge.Name = "CmbAge";
            this.CmbAge.Size = new System.Drawing.Size(121, 24);
            this.CmbAge.TabIndex = 10;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnInit);
            this.groupBox6.Controls.Add(this.BtnCalc);
            this.groupBox6.Controls.Add(this.BtnAjout);
            this.groupBox6.Controls.Add(this.BtnQuit);
            this.groupBox6.Location = new System.Drawing.Point(70, 465);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(788, 76);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            // 
            // BtnInit
            // 
            this.BtnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInit.Location = new System.Drawing.Point(29, 31);
            this.BtnInit.Name = "BtnInit";
            this.BtnInit.Size = new System.Drawing.Size(164, 28);
            this.BtnInit.TabIndex = 3;
            this.BtnInit.Text = "Initialiser";
            this.BtnInit.UseVisualStyleBackColor = true;
            this.BtnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // BtnCalc
            // 
            this.BtnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalc.Location = new System.Drawing.Point(218, 31);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(164, 28);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnAjout
            // 
            this.BtnAjout.Enabled = false;
            this.BtnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjout.Location = new System.Drawing.Point(408, 31);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(164, 28);
            this.BtnAjout.TabIndex = 1;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuit.Location = new System.Drawing.Point(602, 31);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(164, 28);
            this.BtnQuit.TabIndex = 0;
            this.BtnQuit.Text = "Quitter";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(112, 611);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Score";
            // 
            // TxtScore
            // 
            this.TxtScore.Location = new System.Drawing.Point(99, 639);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.ReadOnly = true;
            this.TxtScore.Size = new System.Drawing.Size(100, 23);
            this.TxtScore.TabIndex = 13;
            // 
            // Lst1
            // 
            this.Lst1.FormattingEnabled = true;
            this.Lst1.ItemHeight = 16;
            this.Lst1.Location = new System.Drawing.Point(36, 39);
            this.Lst1.Name = "Lst1";
            this.Lst1.Size = new System.Drawing.Size(120, 116);
            this.Lst1.TabIndex = 14;
            // 
            // Lst2
            // 
            this.Lst2.FormattingEnabled = true;
            this.Lst2.ItemHeight = 16;
            this.Lst2.Location = new System.Drawing.Point(172, 39);
            this.Lst2.Name = "Lst2";
            this.Lst2.Size = new System.Drawing.Size(120, 116);
            this.Lst2.TabIndex = 15;
            // 
            // Lst3
            // 
            this.Lst3.FormattingEnabled = true;
            this.Lst3.ItemHeight = 16;
            this.Lst3.Location = new System.Drawing.Point(312, 39);
            this.Lst3.Name = "Lst3";
            this.Lst3.Size = new System.Drawing.Size(120, 116);
            this.Lst3.TabIndex = 16;
            // 
            // Lst4
            // 
            this.Lst4.FormattingEnabled = true;
            this.Lst4.ItemHeight = 16;
            this.Lst4.Location = new System.Drawing.Point(449, 39);
            this.Lst4.Name = "Lst4";
            this.Lst4.Size = new System.Drawing.Size(120, 116);
            this.Lst4.TabIndex = 17;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.Lst2);
            this.groupBox7.Controls.Add(this.Lst4);
            this.groupBox7.Controls.Add(this.Lst1);
            this.groupBox7.Controls.Add(this.Lst3);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(252, 568);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(600, 169);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Liste de personnes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(488, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "Score";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(353, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Prénom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "CIN";
            // 
            // CalculForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 749);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.CmbAge);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BtnChance);
            this.Controls.Add(this.TxtChance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculForm";
            this.Text = "Calcul de Score";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblHeure;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxtPrenom;
        private System.Windows.Forms.TextBox TxtTel;
        private System.Windows.Forms.TextBox TxtCin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtTech;
        private System.Windows.Forms.TextBox TxtLang;
        private System.Windows.Forms.RadioButton RdFem;
        private System.Windows.Forms.RadioButton RdMas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ChkDip;
        private System.Windows.Forms.CheckBox ChkMotiv;
        private System.Windows.Forms.CheckBox ChkExper;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtChance;
        private System.Windows.Forms.Button BtnChance;
        private System.Windows.Forms.ComboBox CmbAge;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnInit;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox Lst1;
        private System.Windows.Forms.ListBox Lst2;
        private System.Windows.Forms.ListBox Lst3;
        private System.Windows.Forms.ListBox Lst4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

