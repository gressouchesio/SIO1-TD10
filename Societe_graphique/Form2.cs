using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Societe_graphique
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Form1.t_clients[Form1.nbSociete].nom = txbNom.Text;
            Form1.t_clients[Form1.nbSociete].effectif = Int32.Parse(txbEffectif.Text);
            Form1.t_clients[Form1.nbSociete].statut = txbStatut.Text;
            Form1.t_clients[Form1.nbSociete].AdrFact.numero = Int32.Parse(txbNumero.Text);
            Form1.t_clients[Form1.nbSociete].AdrFact.rue = txbRue.Text;
            Form1.t_clients[Form1.nbSociete].AdrFact.codePostale = txbCP.Text;
            Form1.t_clients[Form1.nbSociete].AdrFact.ville = txbVille.Text;
            Form1.nbSociete++;
            Form2.ActiveForm.Close();
        }
    }
}
