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
    public partial class Admin : Form
    {
        public OracleConnection Conn = new OracleConnection();
        public Admin()
        {
            InitializeComponent();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            BTN_Ajouter.Enabled = false;
            BTN_Supprimer.Enabled = false;
            RemplirCatégorie();
            CB_Catégoire.SelectedIndex = 1;
            RemplirQuestion();
        }

        private void TXT_Question_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXT_Question.Text) && CB_Catégoire.GetItemText(CB_Catégoire.SelectedIndex) != "-1")
            {
                BTN_Ajouter.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }
        }

        private void TXT_Question_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXT_Question.Text) && CB_Catégoire.GetItemText(CB_Catégoire.SelectedIndex) != "-1")
            {
                BTN_Ajouter.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }
        }

        private void Question_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Question_LB.SelectedIndex == -1)
            {
                BTN_Supprimer.Enabled = false;
            }
            else
            {
                BTN_Supprimer.Enabled = true;
            }
        }

        private void RemplirCatégorie()
        {
            try
            {
                CB_Catégoire.Items.Clear();
                string sqlSelect = "Select NomCategorie from Catégorie";
                OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                OracleDataReader reader = Requete.ExecuteReader();

                while (reader.Read())
                {
                    CB_Catégoire.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception sqlerror)
            {
                MessageBox.Show(sqlerror.Message.ToString());
            }
        }

        private void RemplirQuestion()
        {
            try
            {
                Question_LB.Items.Clear();
                string sqlSelect = "Select CodeCategorie from Catégorie where NomCategorie = '" + CB_Catégoire.GetItemText(CB_Catégoire.SelectedItem) + "'";
                OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                OracleDataReader reader = Requete.ExecuteReader();
                string catego = "";
                while (reader.Read())
                {
                    catego = reader.GetString(0);
                }

                OracleCommand oraliste = new OracleCommand("TRIVIACROOK", Conn);
                oraliste.CommandText = "TRIVIACROOK.ChercherQuestion";
                oraliste.CommandType = CommandType.StoredProcedure;
                OracleParameter OrapamePhrase = new OracleParameter("Phrase",
                OracleDbType.RefCursor);
                OrapamePhrase.Direction = ParameterDirection.ReturnValue;
                oraliste.Parameters.Add(OrapamePhrase);
                OracleParameter OrapameCatego = new OracleParameter("pCode",
                OracleDbType.Char);
                OrapameCatego.Direction = ParameterDirection.Input;
                OrapameCatego.Value = catego;
                oraliste.Parameters.Add(OrapameCatego);
                OracleDataReader Oraread = oraliste.ExecuteReader();
                while (Oraread.Read())
                {
                    Question_LB.Items.Add(Oraread.GetString(0));
                    Question_LB.SelectedIndex = 0;
                }
            }
            catch (Exception sqlConn)
            {
                MessageBox.Show(sqlConn.Message.ToString());
            }
        }

        private void CB_Catégoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirQuestion();
        }
    }
}
