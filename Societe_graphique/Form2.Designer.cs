namespace Societe_graphique
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
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbEffectif = new System.Windows.Forms.TextBox();
            this.txbStatut = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbRue = new System.Windows.Forms.TextBox();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.txbVille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(159, 23);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 20);
            this.txbNom.TabIndex = 0;
            // 
            // txbEffectif
            // 
            this.txbEffectif.Location = new System.Drawing.Point(159, 49);
            this.txbEffectif.Name = "txbEffectif";
            this.txbEffectif.Size = new System.Drawing.Size(100, 20);
            this.txbEffectif.TabIndex = 1;
            this.txbEffectif.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbStatut
            // 
            this.txbStatut.Location = new System.Drawing.Point(159, 75);
            this.txbStatut.Name = "txbStatut";
            this.txbStatut.Size = new System.Drawing.Size(100, 20);
            this.txbStatut.TabIndex = 2;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(159, 101);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 3;
            // 
            // txbRue
            // 
            this.txbRue.Location = new System.Drawing.Point(159, 127);
            this.txbRue.Name = "txbRue";
            this.txbRue.Size = new System.Drawing.Size(100, 20);
            this.txbRue.TabIndex = 4;
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(159, 153);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(100, 20);
            this.txbCP.TabIndex = 5;
            // 
            // txbVille
            // 
            this.txbVille.Location = new System.Drawing.Point(159, 179);
            this.txbVille.Name = "txbVille";
            this.txbVille.Size = new System.Drawing.Size(100, 20);
            this.txbVille.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Effectif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Statut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Code Postale";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ville";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(159, 229);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(100, 35);
            this.BtnAjouter.TabIndex = 14;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 312);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbVille);
            this.Controls.Add(this.txbCP);
            this.Controls.Add(this.txbRue);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbStatut);
            this.Controls.Add(this.txbEffectif);
            this.Controls.Add(this.txbNom);
            this.Name = "Form2";
            this.Text = "Saisie nouveau client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbEffectif;
        private System.Windows.Forms.TextBox txbStatut;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbRue;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.TextBox txbVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnAjouter;
    }
}