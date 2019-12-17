using Jeu_de_role.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Connexion : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString();
        private Inscription inscription = new Inscription();

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
        public async Task<bool> AskConnexion(string pseudo, string pass)
        {
            try
            {
                 string task = await Task.Run<string>(() =>
                {
                    string url = server + "/Utilisateur/Connexion";

                    Task<string> result = Requetes.PostInfo(url, new List<AttributeModel> {
                        new AttributeModel("pseudo",pseudo),
                        new AttributeModel("pass",pass)
                    });
                    return result;
                });


                /* On Interroge l'api, et on définit si la connexion est réussie ou non. */
                string jsonString = task;
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
            Menu menu = new Menu();
            menu.Show();

            this.Hide();
            //On ferme la fenêtre de connexion.
            
        }

        public void OpenInscription()
        {
            inscription.ShowDialog();
        }

        public void TryValidation()
        {
            string login = loginTxt.Text;
            string pass = passwordTxt.Text;

            //On vérifie le couple login/mot de passe
            Task.Run(() =>
            {
                Task<bool> result = AskConnexion(login, pass);

                if (result.Result)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        this.OpenMenu();
                    }));
                }
                else
                {
                    MessageBox.Show("Pseudo ou mot de passe incorrect.");
                }
            });
            
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
