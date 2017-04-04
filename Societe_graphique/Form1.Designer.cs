namespace Societe_graphique
{
    partial class Form1
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
            this.DvgSociete = new System.Windows.Forms.DataGridView();
            this.BtnAffichage = new System.Windows.Forms.Button();
            this.BtnSociete = new System.Windows.Forms.Button();
            this.CbxStatut = new System.Windows.Forms.ComboBox();
            this.lblstatut = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnActualiser = new System.Windows.Forms.Button();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effectif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DvgSociete)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DvgSociete
            // 
            this.DvgSociete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgSociete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Effectif,
            this.Statut,
            this.adr});
            this.DvgSociete.Location = new System.Drawing.Point(12, 35);
            this.DvgSociete.Name = "DvgSociete";
            this.DvgSociete.Size = new System.Drawing.Size(543, 226);
            this.DvgSociete.TabIndex = 0;
            this.DvgSociete.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgSociete_CellContentClick);
            // 
            // BtnAffichage
            // 
            this.BtnAffichage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAffichage.Location = new System.Drawing.Point(287, 119);
            this.BtnAffichage.Name = "BtnAffichage";
            this.BtnAffichage.Size = new System.Drawing.Size(216, 119);
            this.BtnAffichage.TabIndex = 1;
            this.BtnAffichage.Text = "Afficher";
            this.BtnAffichage.UseVisualStyleBackColor = true;
            this.BtnAffichage.Click += new System.EventHandler(this.BtnAffichage_Click);
            // 
            // BtnSociete
            // 
            this.BtnSociete.Location = new System.Drawing.Point(183, 317);
            this.BtnSociete.Name = "BtnSociete";
            this.BtnSociete.Size = new System.Drawing.Size(118, 58);
            this.BtnSociete.TabIndex = 2;
            this.BtnSociete.Text = "Tri Société";
            this.BtnSociete.UseVisualStyleBackColor = true;
            this.BtnSociete.Click += new System.EventHandler(this.BtnSociete_Click);
            // 
            // CbxStatut
            // 
            this.CbxStatut.FormattingEnabled = true;
            this.CbxStatut.Location = new System.Drawing.Point(13, 333);
            this.CbxStatut.Name = "CbxStatut";
            this.CbxStatut.Size = new System.Drawing.Size(121, 21);
            this.CbxStatut.TabIndex = 3;
            // 
            // lblstatut
            // 
            this.lblstatut.AutoSize = true;
            this.lblstatut.Location = new System.Drawing.Point(364, 340);
            this.lblstatut.Name = "lblstatut";
            this.lblstatut.Size = new System.Drawing.Size(0, 13);
            this.lblstatut.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.nouveauClientToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // nouveauClientToolStripMenuItem
            // 
            this.nouveauClientToolStripMenuItem.Name = "nouveauClientToolStripMenuItem";
            this.nouveauClientToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.nouveauClientToolStripMenuItem.Text = "Nouveau Client";
            this.nouveauClientToolStripMenuItem.Click += new System.EventHandler(this.nouveauClientToolStripMenuItem_Click);
            // 
            // BtnActualiser
            // 
            this.BtnActualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualiser.Location = new System.Drawing.Point(606, 57);
            this.BtnActualiser.Name = "BtnActualiser";
            this.BtnActualiser.Size = new System.Drawing.Size(101, 56);
            this.BtnActualiser.TabIndex = 6;
            this.BtnActualiser.Text = "Actualiser";
            this.BtnActualiser.UseVisualStyleBackColor = true;
            this.BtnActualiser.Click += new System.EventHandler(this.BtnActualiser_Click);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Effectif
            // 
            this.Effectif.HeaderText = "Effectif";
            this.Effectif.Name = "Effectif";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.Name = "Statut";
            // 
            // adr
            // 
            this.adr.HeaderText = "Adresse";
            this.adr.Name = "adr";
            this.adr.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 387);
            this.Controls.Add(this.BtnActualiser);
            this.Controls.Add(this.lblstatut);
            this.Controls.Add(this.CbxStatut);
            this.Controls.Add(this.BtnSociete);
            this.Controls.Add(this.BtnAffichage);
            this.Controls.Add(this.DvgSociete);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Liste des clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgSociete)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgSociete;
        private System.Windows.Forms.Button BtnAffichage;
        private System.Windows.Forms.Button BtnSociete;
        private System.Windows.Forms.ComboBox CbxStatut;
        private System.Windows.Forms.Label lblstatut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauClientToolStripMenuItem;
        private System.Windows.Forms.Button BtnActualiser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effectif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn adr;
    }
}

