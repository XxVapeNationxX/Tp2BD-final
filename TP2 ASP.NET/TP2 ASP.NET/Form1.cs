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

        int iS = 1;
        int iA = 1;
        int iG = 1;
        int iH = 1;
        int iS2 = 1;
        int iA2 = 1;
        int iG2 = 1;
        int iH2 = 1;
        int iS3 = 1;
        int iA3 = 1;
        int iG3 = 1;
        int iH3 = 1;
        int iS4 = 1;
        int iA4 = 1;
        int iG4 = 1;
        int iH4 = 1;

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
            if (NbrJoueur == 2)
            {
                if (Fleche1.Visible)
                {
                    Fleche1.Visible = false;
                    Fleche2.Visible = true;
                    JoueurEnJeu = 2;
                }
                else
                {
                    Fleche1.Visible = true;
                    Fleche2.Visible = false;
                    JoueurEnJeu = 1;
                }
            }
            else if (NbrJoueur == 3)
            {
                if (Fleche1.Visible)
                {
                    Fleche1.Visible = false;
                    Fleche2.Visible = true;
                    JoueurEnJeu = 2;
                }
                else if (Fleche2.Visible)
                {
                    Fleche2.Visible = false;
                    Fleche3.Visible = true;
                    JoueurEnJeu = 3;
                }
                else if (Fleche3.Visible)
                {
                    Fleche3.Visible = false;
                    Fleche1.Visible = true;
                    JoueurEnJeu = 1;
                }
            }
            else if (NbrJoueur == 4)
            {
                if (Fleche1.Visible == true)
                {
                    Fleche1.Visible = false;
                    Fleche2.Visible = true;
                    JoueurEnJeu = 2;
                }
                else if (Fleche2.Visible == true)
                {
                    Fleche2.Visible = false;
                    Fleche3.Visible = true;
                    JoueurEnJeu = 3;
                }
                else if (Fleche3.Visible == true)
                {
                    Fleche3.Visible = false;
                    Fleche4.Visible = true;
                    JoueurEnJeu = 4;
                }
                else if (Fleche4.Visible == true)
                {
                    Fleche4.Visible = false;
                    Fleche1.Visible = true;
                    JoueurEnJeu = 1;
                }
            }

            MessageBox.Show("Mauvaise réponse!");
            Réponse1.Text = "";
            Réponse2.Text = "";
            Réponse3.Text = "";
            Réponse4.Text = "";
            Réponse1.Enabled = false;
            Réponse2.Enabled = false;
            Réponse3.Enabled = false;
            Réponse4.Enabled = false;
            BTN_Question.Enabled = true;
        }

        private void ChangerCouleur()
        {

            int Number = random.Next(0, 5);

            if (Number == 0)
            {
                BTN_Couleur.BackColor = Color.White;
                Categorie = 'C';
            }
            else if (Number == 1) //Sport
            {
                BTN_Couleur.BackColor = Color.Green;
                Categorie = 'V';
            }
            else if (Number == 2) //art
            {
                BTN_Couleur.BackColor = Color.Red;
                Categorie = 'R';
            }
            else if (Number == 3) //géo
            {
                BTN_Couleur.BackColor = Color.Blue;
                Categorie = 'B';
            }
            else if (Number == 4) //histoire
            {
                BTN_Couleur.BackColor = Color.Yellow;
                Categorie = 'J';
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            AjouterJoueur form = new AjouterJoueur();
            form.Conn = Conn;
            form.joueur3 = Joueur3;
            form.joueur4 = Joueur4;
            form.Joueurenjeu = NbrJoueur;
            DialogResult dlg_result = form.ShowDialog();


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
            form.Conn = Conn;
            form.Show();
            form.joueur1 = Joueur1;
            form.joueur2 = Joueur2;
            form.joueur3 = Joueur3;
            form.joueur4 = Joueur4;
            DialogResult dlg_result = form.ShowDialog();


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
            if (CatégorieChoisi.Text.ToString() == "Histoire")
            {
                Categorie = 'J';
            }
            else if (CatégorieChoisi.Text.ToString() == "Sport")
            {
                Categorie = 'V';
            }
            else if (CatégorieChoisi.Text.ToString() == "Géographie")
            {
                Categorie = 'B';
            }
            else if (CatégorieChoisi.Text.ToString() == "Art et culture")
            {
                Categorie = 'R';
            }

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
            Load_Answer();

            CatégorieChoisi.Enabled = false;
        }

        private void Load_User()
        {
            NbrJoueur = 2;
            User1.Text = Joueur1.Prenom;
            User2.Text = Joueur2.Prenom;
            if (Joueur3.Prenom != null)
            {
                NbrJoueur++;
                User3.Text = Joueur3.Prenom;
                if (Joueur4.Prenom != null)
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

            if (Categorie == 'C')
            {
                QuestionChoisie.Text = "";
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
            else
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
                Load_Answer();

                if (Categorie == 'V')
                {
                    CatégorieChoisi.Text = "Sport";
                }
                else if (Categorie == 'B')
                {
                    CatégorieChoisi.Text = "Geographie";
                }
                else if (Categorie == 'J')
                {
                    CatégorieChoisi.Text = "Histoire";
                }
                else if (Categorie == 'R')
                {
                    CatégorieChoisi.Text = "Art et culture";
                }
            }
        }
        private void ValiderQuestion(String Reponse)
        {
            string Bonne = "" ;
            string sqlSelect = "Select EstBonne from Reponses where description ='" + Reponse + "'";
            OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
            OracleDataReader reader = Requete.ExecuteReader();
            while (reader.Read())
            {
                Bonne = reader.GetString(0);
            }
           

            if(Bonne == "Y")
            {
                if(JoueurEnJeu == 1)
                {
                    if (Categorie == 'V')
                    {
                        Sport1.Text = iS.ToString();
                        iS++;
                    }
                    else if (Categorie == 'R')
                    {
                        Art1.Text = iA.ToString();
                        iA++;
                    }
                    else if (Categorie == 'B')
                    {
                        Géo1.Text = iG.ToString();
                        iG++;
                    }
                    else if (Categorie == 'J')
                    {
                        Histoire1.Text = iH.ToString();
                        iH++;
                    }
                }
                else if(JoueurEnJeu == 2)
                {
                    if (Categorie == 'V')
                    {
                        Sport2.Text = iS2.ToString();
                        iS2++;
                    }
                    else if (Categorie == 'R')
                    {
                        Art2.Text = iA2.ToString();
                        iA2++;
                    }
                    else if (Categorie == 'B')
                    {
                        Géo2.Text = iG2.ToString();
                        iG2++;
                    }
                    else if (Categorie == 'J')
                    {
                        Histoire2.Text = iH2.ToString();
                        iH2++;
                    }
                }
                else if (JoueurEnJeu == 3)
                {
                    if (Categorie == 'V')
                    {
                        Sport3.Text = iS3.ToString();
                        iS3++;
                    }
                    else if (Categorie == 'R')
                    {
                        Art3.Text = iA3.ToString();
                        iA3++;
                    }
                    else if (Categorie == 'B')
                    {
                        Géo3.Text = iG3.ToString();
                        iG3++;
                    }
                    else if (Categorie == 'J')
                    {
                        Histoire3.Text = iH3.ToString();
                        iH3++;
                    }
                }
                else if (JoueurEnJeu == 4)
                {
                    if (Categorie == 'V')
                    {
                        Sport4.Text = iS4.ToString();
                        iS4++;
                    }
                    else if (Categorie == 'R')
                    {
                        Art4.Text = iA4.ToString();
                        iA4++;
                    }
                    else if (Categorie == 'B')
                    {
                        Géo4.Text = iG4.ToString();
                        iG4++;
                    }
                    else if (Categorie == 'J')
                    {
                        Histoire4.Text = iH3.ToString();
                        iH4++;
                    }
                }
                Réponse1.Text = "";
                Réponse2.Text = "";
                Réponse3.Text = "";
                Réponse4.Text = "";
                Réponse1.Enabled = false;
                Réponse2.Enabled = false;
                Réponse3.Enabled = false;
                Réponse4.Enabled = false;
                SiGagné(JoueurEnJeu);
            }
            else //mauvaise réponse
            {
                FinDeTour();
            }
        }

        private void Load_Answer()
        {
            Réponse1.Enabled = true;
            Réponse2.Enabled = true;
            Réponse3.Enabled = true;
            Réponse4.Enabled = true;
            string sqlSelect = "Select Numquestion from questions where EnonceQuestion = '" + QuestionChoisie.Text + "'";
            OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
            OracleDataReader reader = Requete.ExecuteReader();
            string Numquestion = "";
            while (reader.Read())
            { 
                Numquestion = reader.GetString(0);
            }

            string Rep1 = Numquestion.Substring(0, 3) + "A";
            string Rep2 = Numquestion.Substring(0, 3) + "B";
            string Rep3 = Numquestion.Substring(0, 3) + "C";
            string Rep4 = Numquestion.Substring(0, 3) + "D";
            string SQLInsert2 = "Select Description from reponses where Numreponse = '" + Rep1 + "'";
            OracleCommand Insert2 = new OracleCommand(SQLInsert2, Conn);
            OracleDataReader reader2 = Insert2.ExecuteReader();
            while (reader2.Read())
            {
                Réponse1.Text = reader2.GetString(0);
            }
            //
            string SQLInsert3 = "Select Description from reponses where Numreponse = '" + Rep2 + "'";
            OracleCommand Insert3 = new OracleCommand(SQLInsert3, Conn);
            OracleDataReader reader3 = Insert3.ExecuteReader();
            while (reader3.Read())
            {
                Réponse2.Text = reader3.GetString(0);
            }
            //
            string SQLInsert4 = "Select Description from reponses where Numreponse = '" + Rep3 + "'";
            OracleCommand Insert4 = new OracleCommand(SQLInsert4, Conn);
            OracleDataReader reader4 = Insert4.ExecuteReader();
            while (reader4.Read())
            {
                Réponse3.Text = reader4.GetString(0);
            }
            //
            string SQLInsert5 = "Select Description from reponses where Numreponse = '" + Rep4 + "'";
            OracleCommand Insert5 = new OracleCommand(SQLInsert5, Conn);
            OracleDataReader reader5 = Insert5.ExecuteReader();
            while (reader5.Read())
            {
                Réponse4.Text = reader5.GetString(0);
            }
        }

        private void SiGagné(int Joueurenjeu)
        {
            if(Joueurenjeu == 1)
            {
                if(iS > 5 && iG > 5 && iH > 5 && iA > 5)
                {
                    MessageBox.Show("Le joueur 1 a gagné!");
                    this.Close();
                }
            }
            else if (Joueurenjeu == 2)
            {
                if (iS2 > 5 && iG2 > 5 && iH2 > 5 && iA2 > 5)
                {
                    MessageBox.Show("Le joueur 2 a gagné!");
                    this.Close();
                }
            }
            else if(Joueurenjeu == 3)
            {
                if (iS3 > 5 && iG3 > 5 && iH3 > 5 && iA3 > 5)
                {
                    MessageBox.Show("Le joueur 3 a gagné!");
                    this.Close();
                }
            }
            else if (Joueurenjeu == 4)
            {
                if (iS4 > 5 && iG4 > 5 && iH4 > 5 && iA4 > 5)
                {
                    MessageBox.Show("Le joueur 4 a gagné!");
                    this.Close();
                }
            }
        }

        private void Réponse1_Click(object sender, EventArgs e)
        {
            ValiderQuestion(Réponse1.Text);
        }

        private void Réponse2_Click(object sender, EventArgs e)
        {
            ValiderQuestion(Réponse2.Text);
        }

        private void Réponse3_Click(object sender, EventArgs e)
        {
            ValiderQuestion(Réponse3.Text);
        }

        private void Réponse4_Click(object sender, EventArgs e)
        {
            ValiderQuestion(Réponse4.Text);
        }
    }
}
