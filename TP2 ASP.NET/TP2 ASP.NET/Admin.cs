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
        private int NombreQuestionB = 21;
        private int NombreQuestionR = 21;
        private int NombreQuestionV = 21;
        private int NombreQuestionJ = 21;

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

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlcatego = "Select CodeCategorie from Catégorie where NomCategorie = '" + CB_Catégoire.GetItemText(CB_Catégoire.SelectedItem) + "'";
                OracleCommand Requetecatego = new OracleCommand(sqlcatego, Conn);
                OracleDataReader readercatego = Requetecatego.ExecuteReader();
                string catego = "";
                while (readercatego.Read())
                {
                    catego = readercatego.GetString(0);
                }
                catego = catego + (Question_LB.SelectedIndex + 1);
                string sqlDelete = "Delete from reponses where NumQuestion= '" + catego + "'";
                OracleCommand Requete2 = new OracleCommand(sqlDelete, Conn);
                Requete2.ExecuteNonQuery();
                string sqlDelete2 = "Delete from questions where NumQuestion= '" + catego + "'";
                OracleCommand Requete3 = new OracleCommand(sqlDelete2, Conn);
                Requete3.ExecuteNonQuery();
                MessageBox.Show("Question supprimé!");
                RemplirQuestion();
            }
            catch (Exception sqlConn)
            {
                MessageBox.Show(sqlConn.Message.ToString());
            }
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                char yes1 = 'N';
                char yes2 = 'N';
                char yes3 = 'N';
                char yes4 = 'N';
                if (checkBox1.Checked)
                {
                    yes1 = 'Y';
                }
                if (checkBox2.Checked)
                {
                    yes2 = 'Y';
                }
                if (checkBox3.Checked)
                {
                    yes3 = 'Y';
                }
                if (checkBox4.Checked)
                {
                    yes4 = 'Y';
                }
                string sqlSelect = "Select CodeCategorie from Catégorie where NomCategorie = '" + CB_Catégoire.GetItemText(CB_Catégoire.SelectedItem) + "'";
                OracleCommand Requete = new OracleCommand(sqlSelect, Conn);
                OracleDataReader reader = Requete.ExecuteReader();
                string catego = "";
                while (reader.Read())
                {
                    catego = reader.GetString(0);
                }
                //Numquestion
                if (catego == "B")
                {
                    catego = "B" + NombreQuestionB;
                    NombreQuestionB++;
                }
                if (catego == "V")
                {
                    catego = "V" + NombreQuestionV;
                    NombreQuestionV++;
                }
                if (catego == "R")
                {
                    catego = "R" + NombreQuestionR;
                    NombreQuestionR++;
                }
                if (catego == "J")
                {
                    catego = "J" + NombreQuestionJ;
                    NombreQuestionJ++;
                }
                string SQLInsert = "insert into questions (Numquestion,EnonceQuestion,Flag,CodeCategorie)" +
                " values " + "('" + catego + "','" + TXT_Question.Text + "','N', (Select CodeCategorie from Catégorie where NomCategorie = '" + CB_Catégoire.GetItemText(CB_Catégoire.SelectedItem) + "'))";
                OracleCommand Insert = new OracleCommand(SQLInsert, Conn);
                Insert.ExecuteNonQuery();

                //insertion réponse
                string Rep1 = catego + "A";
                string Rep2 = catego + "B";
                string Rep3 = catego + "C";
                string Rep4 = catego + "D";
                string SQLInsert2 = "insert into reponses (Numreponse,Description,EstBonne,Numquestion)" +
                " values " + "('" + Rep1 + "','" + Reponse1.Text + "','" + yes1 + "','" + catego + "')";
                OracleCommand Insert2 = new OracleCommand(SQLInsert2, Conn);
                Insert2.ExecuteNonQuery();
                string SQLInsert3 = "insert into reponses (Numreponse,Description,EstBonne,Numquestion)" +
                " values " + "('" + Rep2 + "','" + Reponse2.Text + "','" + yes2 + "','" + catego + "')";
                OracleCommand Insert3 = new OracleCommand(SQLInsert3, Conn);
                Insert3.ExecuteNonQuery();
                string SQLInsert4 = "insert into reponses (Numreponse,Description,EstBonne,Numquestion)" +
                " values " + "('" + Rep3 + "','" + Reponse3.Text + "','" + yes3 + "','" + catego + "')";
                OracleCommand Insert4 = new OracleCommand(SQLInsert4, Conn);
                Insert4.ExecuteNonQuery();
                string SQLInsert5 = "insert into reponses (Numreponse,Description,EstBonne,Numquestion)" +
                " values " + "('" + Rep4 + "','" + Reponse4.Text + "','" + yes4 + "','" + catego + "')";
                OracleCommand Insert5 = new OracleCommand(SQLInsert5, Conn);
                Insert5.ExecuteNonQuery();

                MessageBox.Show("Question ajoutee!");
                TXT_Question.Clear();
                Reponse1.Clear();
                Reponse2.Clear();
                Reponse3.Clear();
                RemplirQuestion();
                Reponse4.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

            }
            catch (Exception sqlConn)
            {
                MessageBox.Show(sqlConn.Message.ToString());
            }
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox3_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox3.Checked = true;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox4_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox4.Checked = true;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox1.Checked = false;
        }

        private void TXT_Question_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXT_Question.Text) && CB_Catégoire.GetItemText(CB_Catégoire.SelectedIndex) != "-1"
                && !string.IsNullOrWhiteSpace(Reponse1.Text) && !string.IsNullOrWhiteSpace(Reponse2.Text) && !string.IsNullOrWhiteSpace(Reponse3.Text)
                && !string.IsNullOrWhiteSpace(Reponse4.Text))
            {
                BTN_Ajouter.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }
        }

        private void TXT_Question_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TXT_Question.Text) && CB_Catégoire.GetItemText(CB_Catégoire.SelectedIndex) != "-1"
                && !string.IsNullOrWhiteSpace(Reponse1.Text) && !string.IsNullOrWhiteSpace(Reponse2.Text) && !string.IsNullOrWhiteSpace(Reponse3.Text)
                && !string.IsNullOrWhiteSpace(Reponse4.Text))
            {
                BTN_Ajouter.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }

        }
    }
}

