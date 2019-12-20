using Newtonsoft.Json.Linq;
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
    public partial class RejoindrePartie : Form
    {
        private JObject infoPartie;
        private int idUtil;
        private Menu menuForm;

        public void ChangerNomPerso(string nomPerso)
        {
            txtPersoName.Text = nomPerso;
            if(String.IsNullOrEmpty(nomPerso))
                btnRejoindre.Enabled = false;
            else
                btnRejoindre.Enabled = true;
            
        }


        public RejoindrePartie(JObject partie,int util, Menu menu)
        {
            InitializeComponent();
            infoPartie = partie;
            idUtil = util;

            txtTitre.Text = partie["TITRE"].ToString();
            txtDescription.Text = partie["DESCRIPTION_PARTIE"].ToString();
            menuForm = menu;
        }

        private void btnNewPerso_Click(object sender, EventArgs e)
        {
            CreationPerso cp = new CreationPerso(idUtil, infoPartie["ID_PARTIE"].ToString(),this);
            cp.ShowDialog();
        }

        private void btnRejoindre_Click(object sender, EventArgs e)
        {
            this.Close();
            menuForm.RefreshPartieList();
            menuForm.Show();
        }
    }
}
