using Jeu_de_role.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class Menu : Form
    {
        //Adresse du serveur
        private string server = Properties.Settings.Default.SERVER.ToString();
        DataGridViewRow row;

        //Joueur
        private int IdUtilisateur = 0;
        private Profil profil;

        public Menu(int idUtilisateur)
        {
            InitializeComponent();
            IdUtilisateur = idUtilisateur;
            row = (DataGridViewRow)dgvParties.Rows[0].Clone();
            dgvParties.AllowUserToAddRows = false;
            profil = new Profil(idUtilisateur);
        }






        /// <summary>
        /// Rafraichit les parties en cours de l'utilisateur.
        /// </summary>
        public void RefreshPartieList()
        {
            Task.Run(() =>
            {
                Task<List<PartieModel>> result = Requetes.GetParties(IdUtilisateur);
                result.Wait();
                this.Invoke(new MethodInvoker(delegate
                {
                    dgvParties.Rows.Clear();
                    foreach (PartieModel p in result.Result)
                    {
                        AddRowToDgv(p.TITRE, p.DESCRIPTION_PARTIE, p.ID_PARTIE,p.ISMJ,p.ID_JOUEUR);
                    }

                }));
            });

        }

        private void AddRowToDgv(string titre, string description, string idPartie,bool isMj,int idJoueur)
        {

            DataGridViewRow rowClone = (DataGridViewRow)row.Clone();
            rowClone.Cells[0].Value = titre;
            rowClone.Cells[1].Value = description;
            rowClone.Cells[2].Value = idPartie;
            rowClone.Cells[3].Value = isMj;
            rowClone.Cells[4].Value = idJoueur;
            dgvParties.Rows.Add(rowClone);
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
            AjoutPartie ajoutPartie = new AjoutPartie(IdUtilisateur,this);
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
                                if (isDansPartie == 0)
                                {
                                    RejoindrePartie p = new RejoindrePartie(json, IdUtilisateur, this);
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

        private void dgvParties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvParties.SelectedRows)
            {
                string id = dgvr.Cells["ID"].Value.ToString();
            
                if(Convert.ToBoolean(dgvr.Cells["isMj"].Value.ToString()))
                {
                    PartieMJ mj = new PartieMJ(id);
                    mj.Show();
                }
                else
                {
                    PartiePerso partiePerso = new PartiePerso(id, Convert.ToInt32(dgvr.Cells["idJoueur"].Value.ToString()));
                    partiePerso.Show();
                }    
                this.Close();
            }
        }
    }
}
