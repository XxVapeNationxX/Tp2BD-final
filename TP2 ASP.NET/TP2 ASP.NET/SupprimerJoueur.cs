using System;
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
    public partial class SupprimerJoueur : Form
    {
        public OracleConnection Conn = new OracleConnection();
        int TotalJoueur = 0;
        public User joueur1;
        public User joueur2;
        public User joueur3;
        public User joueur4;

        public SupprimerJoueur()
        {
            InitializeComponent();
        }

        private void SupprimerJoueur_Load(object sender, EventArgs e)
        {
            BTN_Supprimer.Enabled = false;
            Load_Joueur();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                BTN_Supprimer.Enabled = false;
            }
            else
            {
                BTN_Supprimer.Enabled = true;
            }
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            if (TotalJoueur > 2)
            {
                string sqlDelete = "Delete from score where Alias = '" + (listBox1.SelectedIndex + 1) + "'";
                OracleCommand Requete = new OracleCommand(sqlDelete, Conn);
                Requete.ExecuteNonQuery();
                string sqlDelete2 = "Delete from Player where Alias= '" + (listBox1.SelectedIndex + 1) + "'";
                OracleCommand Requete2 = new OracleCommand(sqlDelete2, Conn);
                Requete2.ExecuteNonQuery();
                MessageBox.Show("Joueur supprimé!");
                Load_Joueur();
            }
            else
            {
                MessageBox.Show("Minimum de 2 joueurs!")
            }
        }

        private void Load_Joueur()
        {
            listBox1.Items.Clear();
            string sqlSelect = "Select Prenom from Player";
            OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
            OracleDataReader Oraread = Requete.ExecuteReader();
            while (Oraread.Read())
            {
                listBox1.Items.Add(Oraread.GetString(0));
                listBox1.SelectedIndex = 0;
            }
            for(int i = 0; i < listBox1.SelectedIndex; i++)
            {
                TotalJoueur++;
            }
        }
    }
}
