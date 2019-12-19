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
        private JObject jsonPartie = new JObject();
        private JArray jsonLog = new JArray();
        private DataGridViewRow rowClone;
        public PartieMJ()
        {
            InitializeComponent();
            rowClone = (DataGridViewRow)jListDtg.Rows[0].Clone();
            jListDtg.AllowUserToAddRows = false;
        }

        public void InitJson()
        {
            string textLog = File.ReadAllText(@"\\10.176.131.132\Users\Elise\Documents\Watcher\Logs\" + idPartie + ".json");
            string textPartie = File.ReadAllText(@"\\10.176.131.132\Users\Elise\Documents\Watcher\Parties\" + idPartie + ".json");
            if (!String.IsNullOrEmpty(textPartie))
                jsonPartie = JObject.Parse(textPartie);
            if (!String.IsNullOrEmpty(textLog))
                jsonLog = JArray.Parse(textLog);

            if (jsonPartie.Count > 0)
                RefreshListePerso();
            if (jsonLog.Count > 0)
                RefreshLogs();
        }



        public void EcrireLog(string log)
        {
            logTxtbx.Text += log;
        }



        /* ****************** Liste des perso **********************/
        public void RefreshListePerso()
        {
            jListDtg.Rows.Clear();
            JArray listeJoueur;
            try
            {
                listeJoueur = (JArray)jsonPartie["joueur"];
            }
            catch
            {
                listeJoueur = new JArray();
            }
            foreach (JObject joueurInfo in listeJoueur)
            {
                JArray perso = JArray.Parse(joueurInfo["personnage"].ToString());
                if (perso.Count > 0)
                    AddRowToDgv(perso.First["NOM"].ToString(), perso.First["PRENOM"].ToString(), perso.First["ID_PERSO"].ToString());
            }
        }

        private void AddRowToDgv(string nom, string prenom, string idJoueur)
        {
            DataGridViewRow row = (DataGridViewRow)rowClone.Clone();
            row.Cells[0].Value = nom;
            row.Cells[1].Value = prenom;
            row.Cells[2].Value = idJoueur;
            jListDtg.Rows.Add(row);
        }
        /* ****************** Liste des perso **********************/

        /* ****************** Logs *********************************/
        public void RefreshLogs()
        {
            if (jsonLog.Count > 0)
                foreach (JObject json in jsonLog)
                {
                    logTxtbx.Text += json["MESSAGE"].ToString() + "\r\n";
                }

        }
        /* ****************** Logs *********************************/



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
            var evenement = new Evenement(this, idPartie);
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
                logTxtbx.Text = "";
                RefreshLogs();
            }

        }

        private void WatcherPartie_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        private void changeMJBtn_Click(object sender, EventArgs e)
        {

        }

        private void modifInventBtn_Click(object sender, EventArgs e)
        {
            var modifInventaire = new ModifInventaire();
            modifInventaire.Show(this);
        }

        private void modifInventBtn_Click(object sender, EventArgs e)
        {
            ModifInventaire modif = new ModifInventaire();
            modif.Show();
        }
    }
}
