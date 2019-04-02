﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace TP2_ASP.NET
{
    public partial class Menu : Form
    {
        public OracleConnection CurrentConn = new OracleConnection();
        private DataSet monDataSet = new DataSet();
        private OracleDataAdapter Adapter = new OracleDataAdapter();
        User Joueur1 = new User();
        User Joueur2 = new User();
        User Joueur3 = new User();
        User Joueur4 = new User();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
          
            try
            {
                string Dsource = "(DESCRIPTION="
                 + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                 + "(HOST=205.237.244.251)(PORT=1521)))"
                 + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id= bourgeoc" + ";Password=Bourg123";
                CurrentConn.ConnectionString = ChaineConnexion;
                CurrentConn.Open();
                MessageBox.Show(CurrentConn.State.ToString());
            }
            catch (Exception sqlConn)
            {
                MessageBox.Show(sqlConn.Message.ToString());
            }
            Start.Enabled = false;
            Joueur1Prenom.Clear();
            Joueur2Prenom.Clear();
            Joueur3Prenom.Clear();
            Joueur4Prenom.Clear();
         }

        private void Start_Click(object sender, EventArgs e)
        {
            Form1 Jeu = new Form1();
            Joueur1.Prenom = Joueur1Prenom.Text;
            Joueur1.Nom = Joueur1Nom.Text;
            Joueur1.Id = 1;
            Joueur2.Prenom = Joueur2Prenom.Text;
            Joueur2.Nom = Joueur2Nom.Text;
            Joueur1.Id = 2;
            if (!string.IsNullOrWhiteSpace(Joueur3Prenom.Text) && !string.IsNullOrWhiteSpace(Joueur3Nom.Text))
            {
                Joueur3.Prenom = Joueur3Prenom.Text;
                Joueur3.Nom = Joueur3Nom.Text;
                Joueur3.Id = 3;
            }
            if (!string.IsNullOrWhiteSpace(Joueur4Prenom.Text) && !string.IsNullOrWhiteSpace(Joueur4Nom.Text))
            {
                Joueur4.Prenom = Joueur4Prenom.Text;
                Joueur4.Nom = Joueur4Nom.Text;
                Joueur4.Id = 4;
            }
            Jeu.Joueur1 = Joueur1;
            Jeu.Joueur2 = Joueur2;
            Jeu.Joueur3 = Joueur3;
            Jeu.Joueur4 = Joueur4;
            AjouterJoueur(Joueur1, Joueur2, Joueur3, Joueur4);
            Jeu.ShowDialog();
        }

        private void Menu_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Joueur1Nom.Text) && !string.IsNullOrWhiteSpace(Joueur1Prenom.Text)
                && !string.IsNullOrWhiteSpace(Joueur2Nom.Text) && !string.IsNullOrWhiteSpace(Joueur2Prenom.Text))
                {
                Start.Enabled = true;
            }
            else
            {
                Start.Enabled = false;
            }
        }

        private void Menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Joueur1Nom.Text) && !string.IsNullOrWhiteSpace(Joueur1Prenom.Text)
                && !string.IsNullOrWhiteSpace(Joueur2Nom.Text) && !string.IsNullOrWhiteSpace(Joueur2Prenom.Text))
            {
                Start.Enabled = true;
            }
            else
            {
                Start.Enabled = false;
            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Admin dlg = new Admin();
            dlg.Conn = CurrentConn;

            DialogResult dlg_result = dlg.ShowDialog();

            if (dlg_result == DialogResult.OK)
            {

            }
        }

        private void AjouterJoueur(User Joueur1, User Joueur2, User Joueur3, User Joueur4)
        {
            int NombreJoueur = 2;
            if (Joueur3.Id != -1 && Joueur4.Id == -1) //3 Joueur
            {
                NombreJoueur = 3;
            }
            else if (Joueur3.Id != -1 && Joueur4.Id != -1) //4 Joueur
            {
                NombreJoueur = 4;
            }
            try
            {
                string SQLInsert = "insert into Player(Alias,Nom,Prenom)" +
                " values " + "('" + 1 + "','" + Joueur1Nom.Text + "','" + Joueur1Prenom.Text + "')";
                OracleCommand Insert = new OracleCommand(SQLInsert, CurrentConn);
                Insert.ExecuteNonQuery();
                string SQLInsert2 = "insert into Player(Alias,Nom,Prenom)" +
               " values " + "('" + 2 + "','" + Joueur2Nom.Text + "','" + Joueur2Prenom.Text + "')";
                OracleCommand Insert2 = new OracleCommand(SQLInsert2, CurrentConn);
                Insert2.ExecuteNonQuery();
                if (NombreJoueur >= 3)
                {
                    string SQLInsert3 = "insert into Player(Alias,Nom,Prenom)" +
               " values " + "('" + 3 + "','" + Joueur3Nom.Text + "','" + Joueur3Prenom.Text + "')";
                    OracleCommand Insert3 = new OracleCommand(SQLInsert3, CurrentConn);
                    Insert3.ExecuteNonQuery();
                }
                if(NombreJoueur == 4)
                {
                    string SQLInsert4 = "insert into Player(Alias,Nom,Prenom)" +
               " values " + "('" + 4 + "','" + Joueur4Nom.Text + "','" + Joueur4Prenom.Text + "')";
                    OracleCommand Insert4 = new OracleCommand(SQLInsert4, CurrentConn);
                    Insert4.ExecuteNonQuery();
                }

            }
            catch (Exception me)
            {
                MessageBox.Show(me.Message.ToString());
            }
        }
    }
}