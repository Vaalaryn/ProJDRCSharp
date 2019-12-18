using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeu_de_role
{
    public partial class PartieMJ : Form
    {
        private string server = Properties.Settings.Default.SERVER.ToString();
        private string idPartie = "bEScFHceSkIgXs0R";
        private JObject jsonPartie;
        private DataGridViewRow rowClone;
        public PartieMJ()
        {
            InitializeComponent();
            jsonPartie = JObject.Parse(File.ReadAllText(@"\\10.176.131.132\Users\Elise\Documents\Watcher\Parties\" + idPartie + ".json"));
            rowClone = (DataGridViewRow) jListDtg.Rows[0].Clone();
            jListDtg.AllowUserToAddRows = false;

            RefreshListePerso();
        }

        public void EcrireLog(string log)
        {
            logTxtbx.Text += log;
        }



        /* ****************** Liste des perso **********************/
        public void RefreshListePerso()
        {
            JArray listeJoueur = (JArray)jsonPartie["joueur"];
            foreach (JObject joueurInfo in listeJoueur)
            {
                JObject perso = (JObject)joueurInfo["personnage"];
                AddRowToDgv(perso["NOM"].ToString(), perso["PRENOM"].ToString(), perso["ID_PERSO"].ToString());
            }
        }

        private void AddRowToDgv(string nom, string prenom,string idJoueur)
        {
            jListDtg.Rows.Clear();
            DataGridViewRow row = (DataGridViewRow)jListDtg.Rows[0].Clone();
            row.Cells[0].Value = nom;
            row.Cells[1].Value = prenom;
            row.Cells[3].Value = idJoueur;
            jListDtg.Rows.Add(row);
        }
        /* ****************** Liste des perso **********************/







        //Evénements 
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

        private void modifJBtn_Click(object sender, EventArgs e)
        {
            var modifJ = new modifJ();
            modifJ.Show(this);
        }

        private void eventBtn_Click(object sender, EventArgs e)
        {
            var evenement = new evenement(this);
            evenement.Show(this);
        }
        /// <summary>
        /// Changement des fichiers logs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WatcherLogs_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.FullPath.Split('\\').Last() == idPartie + ".json")
            {
                System.Diagnostics.Debug.WriteLine(e.FullPath);
            }
                
        }

        private void WatcherPartie_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.FullPath.Split('\\').Last() == idPartie + ".json")
            {
                jsonPartie = JObject.Parse(File.ReadAllText(e.FullPath));
            }
                
        }
    }
}
