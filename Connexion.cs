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

        //Utilisateur
        private int IdUtilisateur = 0;

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
                string url = server + "/Utilisateur/Connexion?pseudo=" + pseudo + "&pass=" + pass;
                return await Requetes.GetInfo(url) == "true"? true : false;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Ouvre la fenetre menu
        /// </summary>
        public void OpenMenu()
        {
            if(IdUtilisateur != 0)
            {
                Menu menu = new Menu(IdUtilisateur);
                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Un problème de connexion est survenu.");
            }
            //On ferme la fenêtre de connexion.
            
        }

        public async Task<int> GetIdUtilisateur(string pseudo)
        {
            int IdUtilisateur = 0;
            try
            {
                string url = server + "/Utilisateur/GetByPseudo?pseudo=" + pseudo;
                string result = await Requetes.GetInfo(url);

                JObject json = JObject.Parse(result);
                IdUtilisateur = Convert.ToInt32(json["ID_UTIL"]);

                return IdUtilisateur;
            }
            catch
            {
                return 0;
            }
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
                Task<int> utilisateur = GetIdUtilisateur(login);
                if (result.Result)
                {
                    IdUtilisateur = utilisateur.Result;
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

        //private void Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine(e.FullPath + " Changed");
        //}
    }
}
