using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class PartieMJ : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString();
        private string idPartie = "";
        public PartieMJ()
        {
            InitializeComponent();
        }
        public void ecrireLog(string log)
        {
            logTxtbx.Text += log;
        }

        private void déBtn_Click(object sender, EventArgs e)
        {
            var déPopUp = new déPopUp();
            déPopUp.Show(this);
        }

        private void jListDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Task.Run(() =>
            {
                Task<string> result = Requetes.GetInfo(server + "/Joueur/GetByPartie?idPartie=" + idPartie);
            });
        }

        private void PartieMJ_Load(object sender, EventArgs e)
        {
            
        }

        private void modifJBtn_Click(object sender, EventArgs e)
        {
            var modifJ = new modifJ();
            modifJ.Show(this);
        }

        private void listeJLbl_Click(object sender, EventArgs e)
        {

        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            var evenement = new Evenement(this);
            evenement.Show(this);
        }

        private void logTxtbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void changeMJBtn_Click(object sender, EventArgs e)
        {

        }

        private void modifInventBtn_Click(object sender, EventArgs e)
        {
            var modifInventaire = new ModifInventaire();
            modifInventaire.Show(this);
        }
    }
}
