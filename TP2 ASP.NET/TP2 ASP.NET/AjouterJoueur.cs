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
    public partial class AjouterJoueur : Form
    {
        public OracleConnection Conn = new OracleConnection();
        public AjouterJoueur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TB_Nom.Text) && !string.IsNullOrWhiteSpace(TB_Prenom.Text))
            {
                BTN_Ajouter.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TB_Nom.Text) && !string.IsNullOrWhiteSpace(TB_Prenom.Text))
            {
                BTN_Ajouter.Enabled = true;
            }
            else
            {
                BTN_Ajouter.Enabled = false;
            }
        }

        private void AjouterJoueur_Load(object sender, EventArgs e)
        {
            BTN_Ajouter.Enabled = false;
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
