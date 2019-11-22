using Jeu_de_role.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Connexion : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString().Replace("\"", "");

        public Connexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Vérifie que le couple login/mot de passe est correct en fonction de la réponse API.
        /// </summary>
        /// <param name="pseudo">Identifiant</param>
        /// <param name="pass">Mot de passe</param>
        /// <returns></returns>
        public bool AskConnexion(string pseudo, string pass)
        {
            try
            {
                /* On Interroge l'api, et on définit si la connexion est réussie ou non. */
                string jsonString = new WebClient().DownloadString(server + "/Utilisateur/Connexion?pseudo=" + pseudo + "&pass=" + pass).Replace("[", "").Replace("]", "");
                if (jsonString == "true")
                    return true;
                else
                    return false;
            }
            catch //Erreur -> on retourne faux
            {
                return false;
            }
        }
        /// <summary>
        /// Ouvre la fenetre menu
        /// </summary>
        public void OpenMenu()
        {
            /*TODO : Associer la fenêtre menu et l'ouvrir */


            this.Close(); //On ferme la fenêtre de connexion.
        }

        public void OpenInscription()
        {
            /*TODO : Ouvrir la fenêtre d'inscription en modal */
        }

        public void TryValidation()
        {
            string login = loginTxt.Text;
            string pass = passwordTxt.Text;

            //On vérifie le couple login/mot de passe
            if (AskConnexion(login, pass))
            {
                OpenMenu();
                MessageBox.Show("Vous êtes connecté.");
            }
            else
            {
                MessageBox.Show("Pseudo ou mot de passe incorrect.");
            }
        }

        /// <summary>
        /// Bouton connexion cliqué. On essaie de se connecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            TryValidation();
        }

        private void loginTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                TryValidation();
        }

        private void passwordTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                TryValidation();
        }

        private void inscriptionLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenInscription();
        }
    }
}
