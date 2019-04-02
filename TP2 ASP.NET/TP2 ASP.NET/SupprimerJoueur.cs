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
        public SupprimerJoueur()
        {
            InitializeComponent();
        }

        private void SupprimerJoueur_Load(object sender, EventArgs e)
        {
            BTN_Supprimer.Enabled = false;
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
    }
}
