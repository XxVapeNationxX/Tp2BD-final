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
        private DataSet DataSetQuestion = new DataSet();
        private char Categorie;
        private int JoueurEnJeu = 1;
        private int NbrJoueur = 2;
        static Random random = new Random();

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
            CatégorieChoisi.Enabled = false;
            Réponse1.Enabled = false;
            Réponse2.Enabled = false;
            Réponse3.Enabled = false;
            Réponse4.Enabled = false;
            Load_User();
        }

        private void FinDeTour()
        {
            if(NbrJoueur == 2)
            {
                if (Fleche1.Enabled == true)
                {
                    Fleche1.Enabled = false;
                    Fleche2.Enabled = true;
                    JoueurEnJeu = 2;
                }
                else
                {
                    Fleche1.Enabled = true;
                    Fleche2.Enabled = false;
                    JoueurEnJeu = 1;
                }
            }
            else if(NbrJoueur == 3)
            {
                if (Fleche1.Enabled == true)
                {
                    Fleche1.Enabled = false;
                    Fleche2.Enabled = true;
                    JoueurEnJeu = 2;
                }
                else if (Fleche2.Enabled == true)
                {
                    Fleche2.Enabled = false;
                    Fleche3.Enabled = true;
                    JoueurEnJeu = 3;
                }
                else if (Fleche3.Enabled == true)
                {
                    Fleche2.Enabled = false;
                    Fleche1.Enabled = true;
                    JoueurEnJeu = 1;
                }
            }
            else if(NbrJoueur == 4)
            {
                if (Fleche1.Enabled == true)
                {
                    Fleche1.Enabled = false;
                    Fleche2.Enabled = true;
                    JoueurEnJeu = 2;
                }
                else if (Fleche2.Enabled == true)
                {
                    Fleche2.Enabled = false;
                    Fleche3.Enabled = true;
                    JoueurEnJeu = 2;
                }
                else if (Fleche3.Enabled == true)
                {
                    Fleche3.Enabled = false;
                    Fleche4.Enabled = true;
                    JoueurEnJeu = 3;
                }
                else if (Fleche4.Enabled == true)
                {
                    Fleche4.Enabled = false;
                    Fleche1.Enabled = true;
                    JoueurEnJeu = 1;
                }
            }
           
            BTN_Question.Enabled = true;
        }

        private void ChangerCouleur()
        {

            int Number = random.Next(0, 5);

            if(Number == 0)
            {
                BTN_Couleur.BackColor = Color.White;
                Categorie = 'C';
            }
            else if(Number == 1) //Sport
            {
                BTN_Couleur.BackColor = Color.Green;
                Categorie = 'S';
            }
            else if (Number == 2) //art
            {
                BTN_Couleur.BackColor = Color.Red;
                Categorie = 'A';
            }
            else if (Number == 3) //géo
            {
                BTN_Couleur.BackColor = Color.Blue;
                Categorie = 'G';
            }
            else if (Number == 4) //histoire
            {
                BTN_Couleur.BackColor = Color.Yellow;
                Categorie = 'H';
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            AjouterJoueur form = new AjouterJoueur();
            form.joueur3 = Joueur3;
            form.joueur4 = Joueur4;
            DialogResult dlg_result = form.ShowDialog();
            form.Conn = Conn;

            if (dlg_result == DialogResult.OK)
            {
                Joueur3 = form.joueur3;
                Joueur4 = form.joueur4;
                Load_User();
            }

        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            SupprimerJoueur form = new SupprimerJoueur();
            form.Show();
            form.joueur1 = Joueur1;
            form.joueur2 = Joueur2;
            form.joueur3 = Joueur3;
            form.joueur4 = Joueur4;
            DialogResult dlg_result = form.ShowDialog();
            form.Conn = Conn;

            if (dlg_result == DialogResult.OK)
            {
                Joueur1 = form.joueur1;
                Joueur2 = form.joueur2;
                Joueur3 = form.joueur3;
                Joueur4 = form.joueur4;
                Load_User();
            }
        }

        private void BTN_Question_Click(object sender, EventArgs e)
        {
            ChangerCouleur();

            ChoixCategorie();

        }

        private void CatégorieChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // GEt la question
        }

        private void Load_User()
        {
            User1.Text = Joueur1.Prenom;
            User2.Text = Joueur2.Prenom;
            if (Joueur3.Id != -1)
            {
                NbrJoueur++;
                User3.Text = Joueur3.Prenom;
                if (Joueur4.Id != -1)
                {
                    NbrJoueur++;
                    User4.Text = Joueur4.Prenom;
                }
            }
            else
            {
                User3.Text = "";
                User4.Text = "";
            }
        }
        
        private void ChoixCategorie()
        {
            OracleCommand oraliste = new OracleCommand("TRIVIACROOK", Conn);
            oraliste.CommandText = "TRIVIACROOK.CHERCHERQUESTIONAleatoire";
            oraliste.CommandType = CommandType.StoredProcedure;
            OracleParameter OrapamePhrase = new OracleParameter("Phrase",
            OracleDbType.RefCursor);
            OrapamePhrase.Direction = ParameterDirection.ReturnValue;
            oraliste.Parameters.Add(OrapamePhrase);
            OracleParameter OrapameCatego = new OracleParameter("pCode",
            OracleDbType.Char);
            OrapameCatego.Direction = ParameterDirection.Input;
            OrapameCatego.Value = Categorie;
            oraliste.Parameters.Add(OrapameCatego);
            OracleDataReader Oraread = oraliste.ExecuteReader();
            while (Oraread.Read())
            {
                QuestionChoisie.Text = Oraread.GetString(0);
            } 

            if (Categorie == 'C')
            {
                try
                {
                    CatégorieChoisi.Items.Clear();
                    string sqlSelect = "Select NomCategorie from Catégorie";
                    OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                    OracleDataReader reader = Requete.ExecuteReader();

                    while (reader.Read())
                    {
                        CatégorieChoisi.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception sqlerror)
                {
                    MessageBox.Show(sqlerror.Message.ToString());
                }

                CatégorieChoisi.Enabled = true;
            }
            else if(Categorie == 'S')
            {
                CatégorieChoisi.Enabled = false;
                try
                {
                    CatégorieChoisi.Items.Clear();
                    string sqlSelect = "Select description from reponse where ";
                    OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                    OracleDataReader reader = Requete.ExecuteReader();

                    while (reader.Read())
                    {
                        CatégorieChoisi.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception sqlerror)
                {
                    MessageBox.Show(sqlerror.Message.ToString());
                }
            }
            else if (Categorie == 'A')
            {
                CatégorieChoisi.Enabled = false;
                try
                {
                    CatégorieChoisi.Items.Clear();
                    string sqlSelect = "Select NomCategorie from Catégorie";
                    OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                    OracleDataReader reader = Requete.ExecuteReader();

                    while (reader.Read())
                    {
                        CatégorieChoisi.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception sqlerror)
                {
                    MessageBox.Show(sqlerror.Message.ToString());
                }
            }
            else if (Categorie == 'G')
            {
                CatégorieChoisi.Enabled = false;
                try
                {
                    CatégorieChoisi.Items.Clear();
                    string sqlSelect = "Select NomCategorie from Catégorie";
                    OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                    OracleDataReader reader = Requete.ExecuteReader();

                    while (reader.Read())
                    {
                        CatégorieChoisi.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception sqlerror)
                {
                    MessageBox.Show(sqlerror.Message.ToString());
                }
            }
            else if (Categorie == 'H')
            {
                CatégorieChoisi.Enabled = false;
                try
                {
                    CatégorieChoisi.Items.Clear();
                    string sqlSelect = "Select NomCategorie from Catégorie";
                    OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                    OracleDataReader reader = Requete.ExecuteReader();

                    while (reader.Read())
                    {
                        CatégorieChoisi.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                catch (Exception sqlerror)
                {
                    MessageBox.Show(sqlerror.Message.ToString());
                }
            }
        }
        private void ValiderQuestion(String Reponse)
        {
            char Bonne;
            string sqlSelect = "Select EstBonne from Reponses where description = " + Reponse;
            OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
            OracleDataReader reader = Requete.ExecuteReader();

            Bonne = reader.GetChar(0);
            // ces quoi que ca retourne quand c'est bon?
            if(Bonne.ToString() == "Y")
            {
                if(JoueurEnJeu == 1)
                {
                    if (Categorie == 'S')
                    {
                        Sport1.Text = Sport1.Text.ToString() + 1;
                    }
                    else if (Categorie == 'A')
                    {
                        Art1.Text = Art1.Text.ToString() + 1;
                    }
                    else if (Categorie == 'G')
                    {
                        Géo1.Text = Géo1.Text.ToString() + 1;
                    }
                    else if (Categorie == 'H')
                    {
                        Histoire1.Text = Histoire1.Text.ToString() + 1;
                    }
                }
                else if(JoueurEnJeu == 2)
                {
                    if (Categorie == 'S')
                    {
                        Sport2.Text = Sport2.Text.ToString() + 1;
                    }
                    else if (Categorie == 'A')
                    {
                        Art2.Text = Art2.Text.ToString() + 1;
                    }
                    else if (Categorie == 'G')
                    {
                        Géo2.Text = Géo2.Text.ToString() + 1;
                    }
                    else if (Categorie == 'H')
                    {

                    }
                }
                else if (JoueurEnJeu == 3)
                {
                    if (Categorie == 'S')
                    {
                        Sport3.Text = Sport3.Text.ToString() + 1;
                    }
                    else if (Categorie == 'A')
                    {
                        Art3.Text = Art3.Text.ToString() + 1;
                    }
                    else if (Categorie == 'G')
                    {
                        Géo3.Text = Géo3.Text.ToString() + 1;
                    }
                    else if (Categorie == 'H')
                    {
                        Histoire3.Text = Histoire3.Text.ToString() + 1;
                    }
                }
                else if (JoueurEnJeu == 4)
                {
                    if (Categorie == 'S')
                    {
                        Sport4.Text = Sport4.Text.ToString() + 1;
                    }
                    else if (Categorie == 'A')
                    {
                        Art4.Text = Art4.Text.ToString() + 1;
                    }
                    else if (Categorie == 'G')
                    {
                        Géo4.Text = Géo4.Text.ToString() + 1;
                    }
                    else if (Categorie == 'H')
                    {
                        Histoire4.Text = Histoire4.Text.ToString() + 1;
                    }
                }
                else
                {
                    FinDeTour();
                    Réponse1.Text = "";
                    Réponse2.Text = "";
                    Réponse3.Text = "";
                    Réponse4.Text = "";
                    Réponse1.Enabled = false;
                    Réponse2.Enabled = false;
                    Réponse3.Enabled = false;
                    Réponse4.Enabled = false;
                }
                Réponse1.Text = "";
                Réponse2.Text = "";
                Réponse3.Text = "";
                Réponse4.Text = "";
                Réponse1.Enabled = false;
                Réponse2.Enabled = false;
                Réponse3.Enabled = false;
                Réponse4.Enabled = false;
            }
        }
    }
}
