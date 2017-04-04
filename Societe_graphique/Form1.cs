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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Variables globales

        public struct Adresse
        {
            public int numero;
            public string rue;
            public string codePostale;
            public string ville;

        }
        public struct Societe
        {
            public string nom;
            public int effectif;
            public string statut;
            public Adresse AdrFact;
        }

        public static Societe[] t_clients;
        public static int nbSociete;
        
        #endregion


        #region Procédures évènementielles

        private void Form1_Load(object sender, EventArgs e)
        {
 
            creerDonnees();

            DvgSociete.Visible = false;
            
            
        }

        private void DvgSociete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnAffichage_Click(object sender, EventArgs e)
        {
            DvgSociete.Visible = true;
            BtnAffichage.Visible = false;
            for (int i = 0; i < nbSociete; i++)
            {
                //Insertion DataGridView
                string adresse;
                adresse = t_clients[i].AdrFact.numero + " " + t_clients[i].AdrFact.rue + " " +
                    t_clients[i].AdrFact.codePostale + " " + t_clients[i].AdrFact.ville;
                DvgSociete.Rows.Add(t_clients[i].nom, t_clients[i].effectif, t_clients[i].statut, adresse);

                //Statut des société
                //Ajoute dans la combobox les statut des sociétés qui n'ont pas encore été ajouté
                if (!(CbxStatut.Items.Contains(t_clients[i].statut)))
                {
                    CbxStatut.Items.Add(t_clients[i].statut);

                }
            }
           
            
        }

        private void BtnSociete_Click(object sender, EventArgs e)
        {
            int nbStatut = 0;
            int nbeffectif = 0;
            for (int i = 0; i < nbSociete; i++)
            {
                //Test si un element à été selectionner
                if (!CbxStatut.SelectedIndex.Equals(-1))
                {
                    //Verifie si le statut correspond à celui selectionné
                    if (t_clients[i].statut.Equals(CbxStatut.SelectedItem.ToString()))
                    {
                        nbStatut++;
                        nbeffectif = nbeffectif + t_clients[i].effectif;
                    }
                }
            }

            //Affichage dans un label le resultat
            lblstatut.Text = "Il y a " + nbStatut + " société de ce type pour un effectif total de " + nbeffectif;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ajout d'un nouveau client dans un nouveau formulaire
            Form2 FP = new Form2();
            FP.Show();
        }

        private void BtnActualiser_Click(object sender, EventArgs e)
        {
            //Vide l'affichage du DataGridView et remet toutes les données dedans
            DvgSociete.Rows.Clear();
            for (int i = 0; i < nbSociete; i++)
            {
                //Insertion DataGridView
                string adresse;
                adresse = t_clients[i].AdrFact.numero + " " + t_clients[i].AdrFact.rue + " " +
                    t_clients[i].AdrFact.codePostale + " " + t_clients[i].AdrFact.ville;
                DvgSociete.Rows.Add(t_clients[i].nom, t_clients[i].effectif, t_clients[i].statut, adresse);

                //Statut des société
                if (!(CbxStatut.Items.Contains(t_clients[i].statut)))
                {
                    CbxStatut.Items.Add(t_clients[i].statut);

                }
            }
        }

        #endregion


        #region Procédure et Fonctions utilisateurs
        
        public void creerDonnees()
        {
            t_clients = new Societe[50];
            nbSociete = 3;

            t_clients[0].nom = "ICOF";
            t_clients[0].effectif = 100;
            t_clients[0].statut = "LT";
            t_clients[0].AdrFact.numero = 8;
            t_clients[0].AdrFact.rue = "Avenue Debrousse";
            t_clients[0].AdrFact.codePostale = "69005";
            t_clients[0].AdrFact.ville = "LYON";

            t_clients[1].nom = "Edouard Heriot";
            t_clients[1].effectif = 500;
            t_clients[1].statut = "LG";
            t_clients[1].AdrFact.numero = 6;
            t_clients[1].AdrFact.rue = "Place Edgar Quinet";
            t_clients[1].AdrFact.codePostale = "69006";
            t_clients[1].AdrFact.ville = "LYON";

            t_clients[2].nom = "Martinière";
            t_clients[2].effectif = 1000;
            t_clients[2].statut = "LGT";
            t_clients[2].AdrFact.numero = 41;
            t_clients[2].AdrFact.rue = "Rue Antoine Lumière";
            t_clients[2].AdrFact.codePostale = "69008";
            t_clients[2].AdrFact.ville = "LYON";

        }

        #endregion
    }
}
