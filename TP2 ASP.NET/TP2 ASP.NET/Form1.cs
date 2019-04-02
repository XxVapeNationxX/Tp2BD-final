using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace TP2_ASP.NET
{
    public partial class Form1 : Form
    {
        public OracleConnection Conn = new OracleConnection();

        public User Joueur1;
        public User Joueur2;
        public User Joueur3;
        public User Joueur4;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            QuestionChoisie.Text = "";
            BTN_Catégorie.Enabled = false;
            CatégorieChoisi.Enabled = false;
            Réponse1.Enabled = false;
            Réponse2.Enabled = false;
            Réponse3.Enabled = false;
            Réponse4.Enabled = false;
            User1.Text = Joueur1.Prenom;
            User2.Text = Joueur2.Prenom;
            if(Joueur3.Id != -1)
            {
                User3.Text = Joueur3.Prenom;
                if(Joueur4.Id != -1)
                {
                    User4.Text = Joueur4.Prenom;
                }
            }
            else
            {
                User3.Text = "";
                User4.Text = "";
            }
        }

        private void FinDeTour()
        {
            //Gérer la flèche
            if (Fleche1.Enabled == true)
            {
                Fleche1.Enabled = false;
                Fleche2.Enabled = true;
            }
            else if(Fleche2.Enabled == true)
            {
                Fleche2.Enabled = false;
                Fleche3.Enabled = true;
            }
            else if (Fleche3.Enabled == true)
            {
                Fleche3.Enabled = false;
                Fleche4.Enabled = true;
            }
            else if (Fleche4.Enabled == true)
            {
                Fleche4.Enabled = false;
                Fleche1.Enabled = true;
            }
            BTN_Question.Enabled = true;
        }

        private void ChangerCouleur(string Couleur)
        {
            if(Couleur == "blanc")
            {
                BTN_Couleur.BackColor = Color.White;
                Réponse1.Enabled = false;
                Réponse2.Enabled = false;
                Réponse3.Enabled = false;
                Réponse4.Enabled = false;
                CatégorieChoisi.Enabled = true;
                if (CatégorieChoisi.SelectedIndex > -1)
                {
                    BTN_Catégorie.Enabled = true;
                }
                else
                {
                    BTN_Catégorie.Enabled = false;
                }
            }
            else if(Couleur == "vert") //Sport
            {
                BTN_Couleur.BackColor = Color.Green;
            }
            else if (Couleur == "rouge") //art
            {
                BTN_Couleur.BackColor = Color.Red;
            }
            else if (Couleur == "bleu") //géo
            {
                BTN_Couleur.BackColor = Color.Blue;
            }
            else if (Couleur == "jaune") //histoire
            {
                BTN_Couleur.BackColor = Color.Yellow;
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            AjouterJoueur form = new AjouterJoueur();
            form.Show();
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            SupprimerJoueur form = new SupprimerJoueur();
            form.Show();
        }

        private void BTN_Question_Click(object sender, EventArgs e)
        {
            BTN_Question.Enabled = false;
            Réponse1.Enabled = true;
            Réponse2.Enabled = true;
            Réponse3.Enabled = true;
            Réponse4.Enabled = true;
            //Piger une question
            string Couleur = "blanc";
            ChangerCouleur(Couleur);
        }

        private void CatégorieChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CatégorieChoisi.SelectedIndex > -1)
            {
                BTN_Catégorie.Enabled = true;
            }
            else
            {
                BTN_Catégorie.Enabled = false;
            }
        }
    }
}
