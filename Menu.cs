using Jeu_de_role.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Jeu_de_role
{
    public partial class Menu : Form
    {
        //Adresse du serveur
        private string server = Properties.Settings.Default.SERVER.ToString();

        //Joueur
        private int IdUtilisateur = 0;

        private Profil profil = new Profil();

        public Menu(int idUtilisateur)
        {
            InitializeComponent();
            IdUtilisateur = idUtilisateur;
        }






        /// <summary>
        /// Rafraichit les parties en cours de l'utilisateur.
        /// </summary>
        public void RefreshPartieList()
        {
            dgvParties.Rows.Clear();
            Task.Run(() =>
            {
                Task<List<PartieModel>> result = Requetes.GetParties(IdUtilisateur);
                this.Invoke(new MethodInvoker(delegate
                {
                    foreach (PartieModel p in result.Result)
                    {
                        AddRowToDgv(p.TITRE, p.DESCRIPTION_PARTIE);
                    }

                }));
            });

        }

        private void AddRowToDgv(string titre, string description)
        {
            DataGridViewRow row = (DataGridViewRow)dgvParties.Rows[0].Clone();
            row.Cells[0].Value = titre;
            row.Cells[1].Value = description;
            dgvParties.Rows.Add(row);
        }


        private void userInfoBtn_Click(object sender, EventArgs e)
        {
            profil.ShowDialog();
        }

        //Changement d'un fichier
        private void Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            using (StreamReader sr = new StreamReader(e.FullPath))
            {
                string line;
                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    // Ajoute dans la base de données les données de la ligne.
                    MessageBox.Show(line);
                }
            }
        }

        private void CreateGameBtn_Click(object sender, EventArgs e)
        {
            AjoutPartie ajoutPartie = new AjoutPartie(IdUtilisateur);
            ajoutPartie.ShowDialog();
            RefreshPartieList();
        }

        private void searchGameBtn_Click(object sender, EventArgs e)
        {
            string idPartieSearch = txtIdGame.Text;
            if (!String.IsNullOrEmpty(idPartieSearch))
            {
                Task.Run(() =>
                {
                    Task<string> result = Requetes.GetInfo(server + "/Partie/GetById?idPartie=" + idPartieSearch);
                    Task<string> resultTestPartie = Requetes.GetInfo(server + "/Partie/EstDansLaPartie?idPartie=" + idPartieSearch + "&idUtil=" + IdUtilisateur);
                    this.Invoke(new MethodInvoker(delegate
                    {
                        int isDansPartie = -1;
                        JObject json = JObject.Parse(result.Result);

                        if (json["Message"] == null)
                        {
                            if (Int32.TryParse(resultTestPartie.Result, out isDansPartie))
                            {
                                if(isDansPartie == 0)
                                {
                                    RejoindrePartie p = new RejoindrePartie(json, IdUtilisateur,this);
                                    this.Hide();
                                    p.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Vous avez déjà rejoint cette partie.");
                                }
                            }
                        }
                        else
                            MessageBox.Show("Aucune partie trouvée.");
                    }));
                });
            }
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            RefreshPartieList();
        }
    }
}
