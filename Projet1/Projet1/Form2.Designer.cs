namespace Projet1
{
    partial class frmApropos
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
            this.LblApropos = new System.Windows.Forms.Label();
            this.LblCpRight = new System.Windows.Forms.Label();
            this.BtnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblApropos
            // 
            this.LblApropos.AutoSize = true;
            this.LblApropos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApropos.Location = new System.Drawing.Point(36, 46);
            this.LblApropos.Name = "LblApropos";
            this.LblApropos.Size = new System.Drawing.Size(295, 20);
            this.LblApropos.TabIndex = 0;
            this.LblApropos.Text = "Première application avec Visual C#";
            this.LblApropos.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCpRight
            // 
            this.LblCpRight.AutoSize = true;
            this.LblCpRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpRight.Location = new System.Drawing.Point(223, 100);
            this.LblCpRight.Name = "LblCpRight";
            this.LblCpRight.Size = new System.Drawing.Size(136, 13);
            this.LblCpRight.TabIndex = 1;
            this.LblCpRight.Text = "CopyRight DSI21 2014";
            // 
            // BtnOK
            // 
            this.BtnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOK.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnOK.Location = new System.Drawing.Point(157, 129);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 33);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmApropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 183);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.LblCpRight);
            this.Controls.Add(this.LblApropos);
            this.Name = "frmApropos";
            this.Text = "A propos";
            this.Load += new System.EventHandler(this.frmApropos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblApropos;
        private System.Windows.Forms.Label LblCpRight;
        private System.Windows.Forms.Button BtnOK;
    }
}